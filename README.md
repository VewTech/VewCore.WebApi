# VewCore.WebApi

VewCore.WebApi is a .NET Class Library used for creating ASP.NET Web Apis.

## Features

Features for VewCore.WebApi include:

- [x] **CRUD Controller Generic Class**: Generic class that extends the Controller ASP.NET class with default CRUD operation methods using EntityFrameworkCore.

- [x] **WebApi Helper Generic Class**: Provides wrapper methods around the CRUD endpoints a CrudController exposes.

## Installation

You can install the package by running the `dotnet add` command

```Shell
dotnet add ./MyProjectRoute package VewTech.VewCore.WebApi
```

You can also add a reference to the package in your .csproj file:

```XML
<ItemGroup>
    <PackageReference Include="VewTech.VewCore.WebApi" Version="X.X.X" />
</ItemGroup>
```

## Usage

Read the repository wiki for details about usage and classes.

## Contributions

All contributions are welcome. Please, open an issue or make a pull request if you wish to contribute to the project.

## Tech Stack

This is the tech stack used by the app:
- .NET 8.0
- C#
- EntityFrameworkCore

## Code Conventions

This project follows the official Microsoft code conventions for C#. See:

https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions

## License

VewCore.WebApi is licensed under the standard MIT license.