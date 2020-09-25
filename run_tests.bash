#!/bin/bash

rm -f appsettings.Development.json
echo '{
  "ConnectionStrings": {
    "DefaultConnection": "Server=db;Port=5432;Database=agreements_database;User Id=postgres;"
  }
}' >> appsettings.Development.json

echo "running migrations"
cd /cbtest


/root/.dotnet/tools/dotnet-ef database update

cd /cbtesttest
dotnet test

exit $?

