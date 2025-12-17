# Projects and dependencies analysis

This document provides a comprehensive overview of the projects and their dependencies in the context of upgrading to .NETCoreApp,Version=v10.0.

## Table of Contents

- [Executive Summary](#executive-Summary)
  - [Highlevel Metrics](#highlevel-metrics)
  - [Projects Compatibility](#projects-compatibility)
  - [Package Compatibility](#package-compatibility)
  - [API Compatibility](#api-compatibility)
- [Aggregate NuGet packages details](#aggregate-nuget-packages-details)
- [Top API Migration Challenges](#top-api-migration-challenges)
  - [Technologies and Features](#technologies-and-features)
  - [Most Frequent API Issues](#most-frequent-api-issues)
- [Projects Relationship Graph](#projects-relationship-graph)
- [Project Details](#project-details)

  - [Projeto.ConsoleApp\Projeto.ConsoleApp.csproj](#projetoconsoleappprojetoconsoleappcsproj)
  - [Projeto.LogicaNegocio\Projeto.LogicaNegocio.csproj](#projetologicanegocioprojetologicanegociocsproj)
  - [Projeto.Tests\Projeto.Tests.csproj](#projetotestsprojetotestscsproj)


## Executive Summary

### Highlevel Metrics

| Metric | Count | Status |
| :--- | :---: | :--- |
| Total Projects | 3 | All require upgrade |
| Total NuGet Packages | 4 | All compatible |
| Total Code Files | 3 |  |
| Total Code Files with Incidents | 3 |  |
| Total Lines of Code | 72 |  |
| Total Number of Issues | 3 |  |
| Estimated LOC to modify | 0+ | at least 0,0% of codebase |

### Projects Compatibility

| Project | Target Framework | Difficulty | Package Issues | API Issues | Est. LOC Impact | Description |
| :--- | :---: | :---: | :---: | :---: | :---: | :--- |
| [Projeto.ConsoleApp\Projeto.ConsoleApp.csproj](#projetoconsoleappprojetoconsoleappcsproj) | net5.0 | 🟢 Low | 0 | 0 |  | DotNetCoreApp, Sdk Style = True |
| [Projeto.LogicaNegocio\Projeto.LogicaNegocio.csproj](#projetologicanegocioprojetologicanegociocsproj) | net5.0 | 🟢 Low | 0 | 0 |  | ClassLibrary, Sdk Style = True |
| [Projeto.Tests\Projeto.Tests.csproj](#projetotestsprojetotestscsproj) | net5.0 | 🟢 Low | 0 | 0 |  | DotNetCoreApp, Sdk Style = True |

### Package Compatibility

| Status | Count | Percentage |
| :--- | :---: | :---: |
| ✅ Compatible | 4 | 100,0% |
| ⚠️ Incompatible | 0 | 0,0% |
| 🔄 Upgrade Recommended | 0 | 0,0% |
| ***Total NuGet Packages*** | ***4*** | ***100%*** |

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 27 |  |
| ***Total APIs Analyzed*** | ***27*** |  |

## Aggregate NuGet packages details

| Package | Current Version | Suggested Version | Projects | Description |
| :--- | :---: | :---: | :--- | :--- |
| coverlet.collector | 3.0.2 |  | [Projeto.Tests.csproj](#projetotestsprojetotestscsproj) | ✅Compatible |
| Microsoft.NET.Test.Sdk | 16.9.4 |  | [Projeto.Tests.csproj](#projetotestsprojetotestscsproj) | ✅Compatible |
| MSTest.TestAdapter | 2.2.3 |  | [Projeto.Tests.csproj](#projetotestsprojetotestscsproj) | ✅Compatible |
| MSTest.TestFramework | 2.2.3 |  | [Projeto.Tests.csproj](#projetotestsprojetotestscsproj) | ✅Compatible |

## Top API Migration Challenges

### Technologies and Features

| Technology | Issues | Percentage | Migration Path |
| :--- | :---: | :---: | :--- |

### Most Frequent API Issues

| API | Count | Percentage | Category |
| :--- | :---: | :---: | :--- |

## Projects Relationship Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart LR
    P1["<b>📦&nbsp;Projeto.ConsoleApp.csproj</b><br/><small>net5.0</small>"]
    P2["<b>📦&nbsp;Projeto.LogicaNegocio.csproj</b><br/><small>net5.0</small>"]
    P3["<b>📦&nbsp;Projeto.Tests.csproj</b><br/><small>net5.0</small>"]
    P1 --> P2
    P3 --> P2
    click P1 "#projetoconsoleappprojetoconsoleappcsproj"
    click P2 "#projetologicanegocioprojetologicanegociocsproj"
    click P3 "#projetotestsprojetotestscsproj"

```

## Project Details

<a id="projetoconsoleappprojetoconsoleappcsproj"></a>
### Projeto.ConsoleApp\Projeto.ConsoleApp.csproj

#### Project Info

- **Current Target Framework:** net5.0
- **Proposed Target Framework:** net10.0
- **SDK-style**: True
- **Project Kind:** DotNetCoreApp
- **Dependencies**: 1
- **Dependants**: 0
- **Number of Files**: 1
- **Number of Files with Incidents**: 1
- **Lines of Code**: 12
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["Projeto.ConsoleApp.csproj"]
        MAIN["<b>📦&nbsp;Projeto.ConsoleApp.csproj</b><br/><small>net5.0</small>"]
        click MAIN "#projetoconsoleappprojetoconsoleappcsproj"
    end
    subgraph downstream["Dependencies (1"]
        P2["<b>📦&nbsp;Projeto.LogicaNegocio.csproj</b><br/><small>net5.0</small>"]
        click P2 "#projetologicanegocioprojetologicanegociocsproj"
    end
    MAIN --> P2

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 4 |  |
| ***Total APIs Analyzed*** | ***4*** |  |

<a id="projetologicanegocioprojetologicanegociocsproj"></a>
### Projeto.LogicaNegocio\Projeto.LogicaNegocio.csproj

#### Project Info

- **Current Target Framework:** net5.0
- **Proposed Target Framework:** net10.0
- **SDK-style**: True
- **Project Kind:** ClassLibrary
- **Dependencies**: 0
- **Dependants**: 2
- **Number of Files**: 1
- **Number of Files with Incidents**: 1
- **Lines of Code**: 15
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph upstream["Dependants (2)"]
        P1["<b>📦&nbsp;Projeto.ConsoleApp.csproj</b><br/><small>net5.0</small>"]
        P3["<b>📦&nbsp;Projeto.Tests.csproj</b><br/><small>net5.0</small>"]
        click P1 "#projetoconsoleappprojetoconsoleappcsproj"
        click P3 "#projetotestsprojetotestscsproj"
    end
    subgraph current["Projeto.LogicaNegocio.csproj"]
        MAIN["<b>📦&nbsp;Projeto.LogicaNegocio.csproj</b><br/><small>net5.0</small>"]
        click MAIN "#projetologicanegocioprojetologicanegociocsproj"
    end
    P1 --> MAIN
    P3 --> MAIN

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 6 |  |
| ***Total APIs Analyzed*** | ***6*** |  |

<a id="projetotestsprojetotestscsproj"></a>
### Projeto.Tests\Projeto.Tests.csproj

#### Project Info

- **Current Target Framework:** net5.0
- **Proposed Target Framework:** net10.0
- **SDK-style**: True
- **Project Kind:** DotNetCoreApp
- **Dependencies**: 1
- **Dependants**: 0
- **Number of Files**: 4
- **Number of Files with Incidents**: 1
- **Lines of Code**: 45
- **Estimated LOC to modify**: 0+ (at least 0,0% of the project)

#### Dependency Graph

Legend:
📦 SDK-style project
⚙️ Classic project

```mermaid
flowchart TB
    subgraph current["Projeto.Tests.csproj"]
        MAIN["<b>📦&nbsp;Projeto.Tests.csproj</b><br/><small>net5.0</small>"]
        click MAIN "#projetotestsprojetotestscsproj"
    end
    subgraph downstream["Dependencies (1"]
        P2["<b>📦&nbsp;Projeto.LogicaNegocio.csproj</b><br/><small>net5.0</small>"]
        click P2 "#projetologicanegocioprojetologicanegociocsproj"
    end
    MAIN --> P2

```

### API Compatibility

| Category | Count | Impact |
| :--- | :---: | :--- |
| 🔴 Binary Incompatible | 0 | High - Require code changes |
| 🟡 Source Incompatible | 0 | Medium - Needs re-compilation and potential conflicting API error fixing |
| 🔵 Behavioral change | 0 | Low - Behavioral changes that may require testing at runtime |
| ✅ Compatible | 17 |  |
| ***Total APIs Analyzed*** | ***17*** |  |

