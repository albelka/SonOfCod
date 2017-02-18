# Son of Cod

#### Son of Cod is designed to emulate a seafood company website with authenication. 2.17.17

#### By **Anne Belka**

## Description
This project was generated in VisualStudio utilizing code-first development and migrations with Entity Framework. Son of Cod is an exercise in C# ASP.Net core. It includes full CRUD functionality for authentication and utilizes xunit testing.

## Setup/Installation Requirements

Clone this repository: https://github.com/albelka/SonOfCod
 and open it in Visual Studio.

* _In SSMS :_
```
open SonOfCod.sql
add these lines to the top of the query
CREATE DATABASE SonOfCod
GO 
```

In VisualStudio right click on SonOfCod in the Solution Explorer and select **Build**

Then in the command prompt write:
```
> dotnet ef database update
```

Now run Son of Cod in Visual Studio to view it in any modern browser.

**For full access login as "Anne" with password "3"**

## Technologies Used
* C#
* VisualStudio
* ASP.Net
* Entity Framework
* Identity
* xunit

### License

GPL

Copyright (c) 2017 **_Anne Belka_**