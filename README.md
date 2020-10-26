# Effective tables project

## Project info

- Patterns and architecture
     - Basic Domain driven design
     - CQRS
 
 ## Setup
 - Set environment variable for connection string but change user and password
    - ```EFFECTIVE_TABLES_CONNECTION_WIN="DefaultConnection": "Data Source=(localdb)//[YOUR_USER];Password=[YOUR_PASSWORD];Initial Catalog=EffectiveTables;Integrated Security=True"```
    - ```EFFECTIVE_TABLES_CONNECTION_UNIX="Server=localhost;Database=EffectiveTables;User Id=[YOUR_USER];Password=[YOUR_PASSWORD];Integrated Security=True```

    - ```export $EFFECTIVE_TABLES_CONNECTION_WIN```
    - ```export $EFFECTIVE_TABLES_CONNECTION_UNIX```