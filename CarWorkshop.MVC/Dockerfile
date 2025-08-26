# syntax=docker/dockerfile:1.7

# ==============================
# BUILD STAGE
# ==============================
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build   
# ✅ SDK 7.0, bo projekt net7.0
WORKDIR /src

# kopiujemy csproj-y
COPY CarWorkshop.Application/*.csproj CarWorkshop.Application/
COPY CarWorkshop.Domain/*.csproj CarWorkshop.Domain/
COPY CarWorkshop.Infrastructure/*.csproj CarWorkshop.Infrastructure/
COPY CarWorkshop.MVC/*.csproj CarWorkshop.MVC/

RUN dotnet restore CarWorkshop.MVC/CarWorkshop.MVC.csproj

# kopiujemy resztę
COPY . .

WORKDIR /src/CarWorkshop.MVC
RUN dotnet publish -c Release -o /app

# ==============================
# RUNTIME STAGE
# ==============================
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime   
# ✅ runtime 7.0, spójne z projektem
WORKDIR /app
COPY --from=build /app .
ENV ASPNETCORE_URLS=http://+:8080
EXPOSE 8080
ENTRYPOINT ["dotnet", "CarWorkshop.MVC.dll"]
