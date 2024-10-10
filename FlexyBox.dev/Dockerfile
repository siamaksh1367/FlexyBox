FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src

COPY FlexyBox.dev/FlexyBox.dev.csproj FlexyBox.dev/
COPY FlexyBox.dal/FlexyBox.dal.csproj FlexyBox.dal/
COPY . . 

RUN dotnet restore FlexyBox.dev/FlexyBox.dev.csproj

RUN dotnet tool install --global dotnet-ef

ENV PATH="$PATH:/root/.dotnet/tools"

ENTRYPOINT ["bash"]
