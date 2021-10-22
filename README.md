# Pierre's Bakery 2.0

#### This web application demonstrates a many-to-many database for managing and displaying information about a bakery, using authentication and authorization.

#### By Connor Hansen

## Technologies Used

* C#
* .NET
* Razor
* HTML
* MySQL
* Linq
* Entity Framework

## Description

_This is an MVC web application for a bakery owner to track flavors and treats for users. A user's treats and flavors may be seen and edited by other authorized users. Treats and flavors maintain a many-to-many relationship. A treat can have many flavors, and a flavor can have many treats. All types of users may view the entire list of treats and flavors authenticated users have created, but the relationships may only be viewed by authenticated users._

## Setup/Installation Requirements

- _To clone and run from [GitHub Repo](https://github.com/chansen1395/Factory.Solution):_

- _Use a program such as VSCode to view, run, and test the program._
  
- _Database Setup:_

- Create a file named "appsettings.json" in the Factory directory
  * add the following code to the appsettings.json file:

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-NAME-HERE];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
  * replace [YOUR-NAME-HERE] with the desired database name
  * replace [YOUR-USERNAME-HERE] with your unique MySql username
  * replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command "$ mySql -u[YOUR-USERNAME-HERE] -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Build the required database:
  - $ dotnet ef migrations add Initial
  - $ dotnet ef database update


- _In order to set up the project environment, in bash at a
 folder of your choice, type the following:_
    1. **$ git clone https://github.com/chansen1395/Factory.Solution.git**
    2. **$ code .**
    3. **$ cd YourFolder.Solution/Factory**
    4. **Install packages if not already installed:**
    ```
      $ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
      $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
      $ dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
      $ dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0
      $ dotnet tool install --global dotnet-ef
    ```
    5. **Build out your database Migrations with the following:**
    ```
      $ dotnet ef migrations add Initial
      $ dotnet ef database update
    ```
    6. **$ dotnet restore**<br>

- **Database Schema**

| engineers   | machines     | engineermachine   |
| ----------- | ------------ | ----------------- |
| EngineerId  | MachineId    | EngineerMachineId |
| Name        | Name         | MachineId         |
| RepairMade  | SerialNumber | EngineerId        |
|             | Operational  |                   |
- _In order to run the program, follow along with the previous steps. After step 4, navigate to the Factory directory:_
```
    1. $ cd ..Factory
    2. $ dotnet watch run
    3. _Navigate to http://localhost:5000/ in your browser.
```

## Known Bugs

* _No Known Bugs._

## License

{Let me know if you run into any issues or have questions, ideas or concerns. I encourage you to contact me or make a contribution to the code.}

## Contact Information

- Connor Hansen: _{<chansen13@georgefox.edu>}_
- _{[GitHub Repo - main](https://github.com/chansen1395/Factory.Solution)}_