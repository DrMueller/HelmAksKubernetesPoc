# FROM mcr.microsoft.com/dotnet/sdk:6.0
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY ./DockerContent .
EXPOSE 80
ENTRYPOINT ["dotnet", "WebApplication1.dll"]