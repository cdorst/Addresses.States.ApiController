# Addresses.States.ApiController

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-states-apicontroller.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/addresses-states-apicontroller)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.States.ApiController.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Addresses.States.ApiController)

## Description

ASP.NET Core web API controller for State entities

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Addresses.States.DatabaseContext](https://github.com/CDorst/Addresses.States.DatabaseContext) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/addresses-states-databasecontext.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/addresses-states-databasecontext) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Addresses.States.DatabaseContext.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Addresses.States.DatabaseContext)
[CDorst.DevOps.Code.DataAccess.Metapackages.ApiControllers](https://github.com/CDorst/DevOps.Code.DataAccess.Metapackages.ApiControllers) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-dataaccess-metapackages-apicontrollers.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-dataaccess-metapackages-apicontrollers) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.DataAccess.Metapackages.ApiControllers.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.DataAccess.Metapackages.ApiControllers)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Addresses.States.ApiController](https://www.nuget.org/packages/CDorst.Addresses.States.ApiController)

## Version

1.0.5

## Metaproject

Addresses.States.ApiController is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

