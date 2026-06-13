FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# copy csproj files first 
COPY TaskManagement.Api/TaskManagement.Api.csproj TaskManagement.Api/
COPY TaskManagement.Application/TaskManagement.Application.csproj TaskManagement.Application/
COPY TaskManagement.Domain/TaskManagement.Domain.csproj TaskManagement.Domain/
COPY TaskManagement.Infrastructure/TaskManagement.Infrastructure.csproj TaskManagement.Infrastructure/

# restore solution
RUN dotnet restore TaskManagement.Api/TaskManagement.Api.csproj

# copy everything
COPY . .

RUN dotnet publish TaskManagement.Api/TaskManagement.Api.csproj -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
EXPOSE 8080

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TaskManagement.Api.dll"]