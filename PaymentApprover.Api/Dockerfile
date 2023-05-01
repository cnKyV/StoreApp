FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DataApprover/DataApprover.csproj", "DataApprover/"]
RUN dotnet restore "DataApprover/DataApprover.csproj"
COPY . .
WORKDIR "/src/DataApprover"
RUN dotnet build "DataApprover.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DataApprover.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DataApprover.dll"]
