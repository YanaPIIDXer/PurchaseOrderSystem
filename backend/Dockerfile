FROM --platform=linux/x86_64 mcr.microsoft.com/dotnet/sdk:3.1-alpine

RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"

WORKDIR /app

ADD ./PurchaseOrderSystem/*.csproj /app
RUN dotnet restore

ADD ./PurchaseOrderSystem /app

EXPOSE 3002
CMD ["dotnet", "watch", "run"]
