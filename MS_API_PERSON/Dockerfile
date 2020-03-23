FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["MS_API_PERSON.csproj", ""]
RUN dotnet restore "./MS_API_PERSON.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "MS_API_PERSON.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "MS_API_PERSON.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "MS_API_PERSON.dll"]