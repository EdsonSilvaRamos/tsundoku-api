# Acesse https://aka.ms/customizecontainer para saber como personalizar seu contêiner de depuração e como o Visual Studio usa este Dockerfile para criar suas imagens para uma depuração mais rápida.


# Esta fase é usada para compilar o projeto de serviço
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY ["/TsundokuTraducoes/TsundokuTraducoes.Api.csproj", "TsundokuTraducoes/"]
COPY ["/TsundokuTraducoes.Data/TsundokuTraducoes.Data.csproj", "TsundokuTraducoes.Data/"]
COPY ["/TsundokuTraducoes.Domain/TsundokuTraducoes.Domain.csproj", "TsundokuTraducoes.Domain/"]
COPY ["/TsundokuTraducoes.Entities/TsundokuTraducoes.Entities.csproj", "TsundokuTraducoes.Entities/"]
COPY ["/TsundokuTraducoes.Helpers/TsundokuTraducoes.Helpers.csproj", "TsundokuTraducoes.Helpers/"]
COPY ["/TsundokuTraducoes.Services/TsundokuTraducoes.Services.csproj", "TsundokuTraducoes.Services/"]
# COPY ["/TsundokuTraducoes.Entities.Tests/TsundokuTraducoes.Entities.Tests.csproj", "TsundokuTraducoes.Entities.Tests/"]
# COPY ["/TsundokuTraducoes.Integration.Tests/TsundokuTraducoes.Integration.Tests.csproj", "TsundokuTraducoes.Integration.Tests/"]

RUN dotnet restore "./TsundokuTraducoes/TsundokuTraducoes.Api.csproj"

COPY . ./

RUN dotnet publish "./TsundokuTraducoes/TsundokuTraducoes.Api.csproj" -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

RUN mkdir -p /app/certificados
COPY TsundokuTraducoes.Helpers/Certifidos/aspnetapp.pfx /app/certificados

ENTRYPOINT [ "dotnet", "TsundokuTraducoes.Api.dll" ]