# VersionDemo

## compile & run
dotnet build
dotnet run --project ./Odata6Demo/VersionDemo.csproj --urls=http://localhost:5001/
##

## Swagger
http://localhost:5001/swagger/index.html
##

## endpoint v1
## data contract ThermostatV1
https://localhost:5001/api/v1/Devices
##

## endpoint v2 
## data contract ThermostatV2 
## with extra property [wireless], but still compatible JSON Deserialize <ThermostatV1>
https://localhost:5001/api/v2/Devices
##

## endpoint v3
## return 400 with error message UnsupportedApiVersion The HTTP resource that matches the request URI 'https://localhost:7039/api/v3/Devices' does not support the API version '3'."
https://localhost:5001/api/v3/Devices
##