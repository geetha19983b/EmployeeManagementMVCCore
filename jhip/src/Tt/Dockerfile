FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build
WORKDIR /app
COPY ["src/JHipsterNet/JHipsterNet.csproj", "src/JHipsterNet/"]
COPY ["src/Tt/Tt.csproj", "src/Tt/"]
RUN dotnet restore "src/Tt/Tt.csproj"
COPY . ./
WORKDIR /app/src/Tt
RUN apt-get update -yq && apt-get install -yq curl
RUN curl -sL https://deb.nodesource.com/setup_10.x | bash - && \
    apt-get update && \
    apt-get install -yq nodejs && \
    rm -rf /var/lib/apt/lists/*
RUN npm install
RUN rm -rf wwwroot && \
    dotnet publish "Tt.csproj" -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2 AS runtime
WORKDIR /app
EXPOSE 80
COPY --from=build /app/out .
ENTRYPOINT ["dotnet", "tt.dll"]
