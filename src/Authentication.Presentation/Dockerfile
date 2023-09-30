FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/Authentication.Presentation/Authentication.Presentation.csproj", "src/Authentication.Presentation/"]
COPY ["src/Authentication.Application/Authentication.Application.csproj", "src/Authentication.Application/"]
COPY ["src/Authentication.Domain/Authentication.Domain.csproj", "src/Authentication.Domain/"]
COPY ["src/Authentication.Infrastructure/Authentication.Infrastructure.csproj", "src/Authentication.Infrastructure/"]
RUN dotnet restore "src/Authentication.Presentation/Authentication.Presentation.csproj"
COPY . .
WORKDIR "/src/src/Authentication.Presentation"
RUN dotnet build "Authentication.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Authentication.Presentation.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Authentication.Presentation.dll"]
