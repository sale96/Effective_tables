echo "What is your database user: "
read USER

echo "What is your database user password: "
read PASS

FILE="./server/EffectiveTables/EffectiveTables.Api/appsettings.json"

echo "Creating appsettings.json file."
touch $FILE

echo "Writing to a file."

cat > $FILE <<- EOM
    {
      "Logging": {
        "LogLevel": {
          "Default": "Information",
          "Microsoft": "Warning",
          "Microsoft.Hosting.Lifetime": "Information"
        }
      },
      "ConnectionStrings": {
        "DefaultConnection": "Data Source=(localdb)\\\\$USER;Password=$PASS;Initial Catalog=EffectiveTables;Integrated Security=True"
      },
      "AllowedHosts": "*"
    }
EOM

echo "Successfully created appsetting.json file."