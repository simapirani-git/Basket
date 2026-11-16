# Basket - .NET Web API

## Introduction

Basket is an ASP.NET Core Web API developed as part of a Multi-Repository architecture.

The project demonstrates how an independent .NET application can consume reusable components distributed through a NuGet package hosted in Azure DevOps Artifacts.

Basket uses the Shared library to demonstrate centralized code reuse and package dependency management across independent repositories.

## Project Architecture

Basket is one of three independent application repositories in this project:

| Repository | Responsibility |
|---|---|
| Shared | Reusable .NET Class Library |
| Basket | Basket Web API |
| Identity | Identity Web API |
| Order | Order Web API |

Each application has its own solution, source code, Git repository, and CI/CD pipeline.

## Technologies Used

- C#
- .NET 10
- ASP.NET Core Web API
- NuGet Package Management
- Azure DevOps Artifacts
- Azure DevOps Classic Pipelines
- Git and GitHub

## Repository Structure

```text
Basket/
│
├── src/
│   └── Basket/
│       ├── Controllers/
│       ├── Properties/
│       ├── Basket.csproj
│       ├── Basket.http
│       ├── Program.cs
│       ├── WeatherForecast.cs
│       ├── appsettings.json
│       └── appsettings.Development.json
│
├── .gitignore
├── NuGet.Config
├── README.md
└── basket.slnx
```

## Shared NuGet Package Integration

Basket consumes the Shared library as a NuGet dependency.

Package reference:

```xml
<PackageReference Include="Shared" Version="1.0.0" />
```

The package is published to the Azure DevOps Artifacts feed named `Shared-Feed`.

This approach allows Basket to consume reusable functionality without directly referencing another repository's source code.

## Build and Run

Restore dependencies:

```bash
dotnet restore basket.slnx
```

Build the solution:

```bash
dotnet build basket.slnx
```

Run the application:

```bash
dotnet run --project src/Basket/Basket.csproj
```

## CI/CD Pipeline

The Basket repository is integrated with Azure DevOps Classic Pipelines.

The pipeline includes the following stages:

1. NuGet Restore
2. Build
3. Test
4. Pack
5. Push NuGet Package (where applicable)
6. Publish Build Artifact

The pipeline automates application validation and build artifact generation.

## Project Objectives

- Implement independent repository management.
- Consume reusable NuGet packages.
- Integrate Azure DevOps Artifacts with .NET applications.
- Implement automated CI/CD workflows.
- Demonstrate dependency management across multiple repositories.
- Maintain independent application lifecycle and version control.

---

**Note:** This is a personal learning and demonstration project using sample configurations and data.
