# GymProject

## Make Migration

- `dotnet ef migrations add <migration_name> --project API/`
- `dotnet ef database update --project API/`

## Run API

Make Sure To Run Migration Only First Time Before Running API

- `dotnet run watch --project API/`
