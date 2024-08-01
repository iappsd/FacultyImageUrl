# Faculty Management API

This is a simple .NET Core 8 API for managing faculty members, including setting a default image URL if the image URL is invalid or missing.

## Features

- Retrieve a list of faculty members
- Automatically set a default image URL if the provided image URL is invalid or missing

## Technologies and Libraries Used

- [.NET Core 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Entity Framework Core SQLite](https://docs.microsoft.com/en-us/ef/core/providers/sqlite/?tabs=dotnet-core-cli)
- [AutoMapper](https://automapper.org/)
- [AutoMapper.Extensions.Microsoft.DependencyInjection](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/)
- [HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient)
- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)

## Getting Started

### Prerequisites

- [.NET Core 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Installation

1. Clone the repository
   ```sh
   git clone https://github.com/iappsd/FacultyImageUrl.git
