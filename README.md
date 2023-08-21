# VersionDemo

## dotnet compile
dotnet build

## dotnet run on localhost
dotnet run --project ./Odata6Demo/VersionDemo.csproj --urls=http://localhost:5001/
##

## Swagger
http://localhost:5001/swagger/index.html
##

## endpoint v1
## data contract ThermostatV1
http://localhost:5001/api/v1/Devices
##

## endpoint v2 
## data contract ThermostatV2 
## extra property [wireless] 
## compatible with JsonSerializer.Deserialize [ThermostatV1]
http://localhost:5001/api/v2/Devices
##

## endpoint v3
## return http 400 with error message UnsupportedApiVersion The HTTP resource that matches the request URI 'http://localhost:5001/api/v3/Devices' does not support the API version '3'."
http://localhost:5001/api/v3/Devices
##