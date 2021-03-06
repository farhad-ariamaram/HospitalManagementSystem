![.net](https://img.shields.io/badge/.NETFramework-4.7.2-blue.svg)
[![License](https://img.shields.io/badge/License-Apache%202.0-orange.svg)](https://opensource.org/licenses/Apache-2.0)


## Overview
- Hospital Management System desktop application
- C# .NET
- Three tier architecture 
- Micosoft SQL Server CE (Compact)
- DevComponents DotNetBar


## Requirements

- .NET Framework 4.7.2

- Microsoft SQL Server Compact 4.0

## Build
- Remember to copy all entity framework DLLs and XMLs from Data Layer to Presentation Layer output after build.

## Architecture

```
|__HospitalManagementSystem
  |
  |__ClassLiberty
  |         |_____DAL
  |         |_____BLL
  |__UI
  |
  |__Database
```
## Database configuration
```XML
  <connectionStrings>
    <add name="Entities" connectionString="metadata=res://*/HospitalDBModel.csdl|res://*/HospitalDBModel.ssdl|res://*/HospitalDBModel.msl;provider=System.Data.SqlServerCe.4.0;provider connection string=&quot;Data Source=|DataDirectory|\HospitalDB.sdf&quot;" providerName="System.Data.EntityClient" />
  </connectionStrings>
```
## Screenshot
- Application
  
  ![application.png](images/application.png)
  
- Class Diagram
  
  ![application.png](images/Class_Diagram.png)
  
- DataBase Model
  
  ![application.png](images/Database_Model.png)

## License

- Apache 2.0



