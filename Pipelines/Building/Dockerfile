FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY ./DockerContent .
EXPOSE 80
ENTRYPOINT ["dotnet", "HelmAksKubernetesProc.dll"]