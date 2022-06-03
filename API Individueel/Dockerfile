#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["API Individueel/API Individueel.csproj", "API Individueel/"]
COPY ["Abstraction Layer/Abstraction Layer.csproj", "Abstraction Layer/"]
COPY ["DTO Layer/DTO Layer.csproj", "DTO Layer/"]
COPY ["DAL/DAL Layer.csproj", "DAL/"]
RUN dotnet restore "API Individueel/API Individueel.csproj"
COPY . .
WORKDIR "/src/API Individueel"
RUN dotnet build "API Individueel.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API Individueel.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API Individueel.dll"]