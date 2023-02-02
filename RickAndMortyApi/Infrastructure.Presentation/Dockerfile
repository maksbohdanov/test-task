FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Infrastructure.Presentation/Infrastructure.Presentation.csproj", "Infrastructure.Presentation/"]
COPY ["Core.Services.Abstractions/Core.Services.Abstractions.csproj", "Core.Services.Abstractions/"]
COPY ["Core.Contracts/Core.Contracts.csproj", "Core.Contracts/"]
COPY ["Core.Domain/Core.Domain.csproj", "Core.Domain/"]
COPY ["Core.Services/Core.Services.csproj", "Core.Services/"]
COPY ["Infrastructure.Clients/Infrastructure.Clients.csproj", "Infrastructure.Clients/"]
RUN dotnet restore "Infrastructure.Presentation/Infrastructure.Presentation.csproj"
COPY . .
WORKDIR "/src/Infrastructure.Presentation"
RUN dotnet build "Infrastructure.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Infrastructure.Presentation.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Infrastructure.Presentation.dll"]