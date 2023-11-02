#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Homework_6_1/Homework_6_1.csproj", "Homework_6_1/"]
RUN dotnet restore "Homework_6_1/Homework_6_1.csproj"
COPY . .
WORKDIR "/src/Homework_6_1"
RUN dotnet build "Homework_6_1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Homework_6_1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Homework_6_1.dll"]