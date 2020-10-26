# Effective tables project

## Project info

- Patterns and architecture
     - Basic Domain driven design
     - CQRS
 
## Setup
- In ```server/EffectiveTables/DataAccess/Configuration/``` create .env file and paste content below just change user and password values
    - ##### Windows
        - ```Data Source=(localdb)//[YOUR_USER];Password=[YOUR_PASSWORD];Initial Catalog=EffectiveTables;Integrated Security=True"```
    - ##### Linux
        - ```Server=localhost;Database=EffectiveTables;User Id=[YOUR_USER];Password=[YOUR_PASSWORD];Integrated Security=True"```
        - If you get ```Cannot authenticate using Kerberos.``` error try deleting ```Integrated Security=True``` and add ```Trusted_Connection=False``` but this is not recomended.


- After setting environment variables
    - Run ```dotnet build``` in /server directory to make sure that everything works as intended 