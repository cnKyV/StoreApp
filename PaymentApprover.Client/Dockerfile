FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PaymentApprover.Client/PaymentApprover.Client.csproj", "PaymentApprover.Client/"]
RUN dotnet restore "PaymentApprover.Client/PaymentApprover.Client.csproj"
COPY . .
WORKDIR "/src/PaymentApprover.Client"
RUN dotnet build "PaymentApprover.Client.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PaymentApprover.Client.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PaymentApprover.Client.dll"]
