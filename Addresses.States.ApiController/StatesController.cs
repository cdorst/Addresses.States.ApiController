// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Addresses.States.DatabaseContext;
using DevOps.Code.DataAccess.Interfaces.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Addresses.States.ApiController
{
    /// <summary>ASP.NET Core web API controller for State entities</summary>
    [ApiController]
    [Route("api/[controller]")]
    public class StatesController : ControllerBase
    {
        /// <summary>Represents the application events logger</summary>
        private readonly ILogger<StatesController> _logger;

        /// <summary>Represents repository of State entity data</summary>
        private readonly IRepository<StateDbContext, State, int> _repository;

        /// <summary>Constructs an API controller for State entities using the given repository service</summary>
        public StatesController(ILogger<StatesController> logger, IRepository<StateDbContext, State, int> repository)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        /// <summary>Handles HTTP GET requests to access State resources at the given ID</summary>
        [HttpGet("{id}")]
        public async Task<ActionResult<State>> Get(int id)
        {
            if (id < 1) return NotFound();
            var resource = await _repository.FindAsync(id);
            if (resource == null) return NotFound();
            return resource;
        }

        /// <summary>Handles HTTP HEAD requests to access State resources at the given ID</summary>
        [HttpHead("{id}")]
        public ActionResult<State> Head(int id) => null;

        /// <summary>Handles HTTP POST requests to save State resources</summary>
        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<ActionResult<State>> Post(State resource)
        {
            var saved = await _repository.AddAsync(resource);
            return CreatedAtAction(nameof(Get), new { id = saved.GetKey() }, saved);
        }
    }
}
