FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
RUN dotnet tool install --global dotnet-ef
COPY ["cbtest/cbtest.csproj", "cbtest/cbtest.csproj"]
COPY ["cbtesttest/cbtesttest.csproj", "cbtesttest/cbtesttest.csproj"]
#WORKDIR /cbtest
#RUN dotnet clean "cbtest.csproj"
#RUN dotnet restore "cbtest.csproj"
COPY . .
RUN dotnet build "cbtest.sln" -c Debug -o /app/build

WORKDIR "/cbtest"
FROM build AS publish
RUN dotnet publish "cbtest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "cbtest.dll"]