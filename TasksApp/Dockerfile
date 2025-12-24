# ================================
# 1️. Build Stage
# ================================
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /app

# Copy csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy everything else
COPY . ./

# Build and publish
RUN dotnet publish -c Release -o /app/publish /p:UseAppHost=false


# ================================
# 2️. Runtime Stage (Small & Secure)
# ================================
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS runtime
WORKDIR /app

# Create non-root user (security best practice)
USER app

# Copy published output
COPY --from=build /app/publish .

# Expose HTTP port
EXPOSE 8080

# ASP.NET Core URLs
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

HEALTHCHECK --interval=30s --timeout=5s --start-period=10s CMD curl -f http://localhost:8080 || exit 1

# Start app
ENTRYPOINT ["dotnet", "TasksApp.dll"]
