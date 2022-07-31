# _Salon Management_

#### By _**Patty Otero**_

#### _A practice website for C# salon management-- this application allows salon management to manage a database of stylists and clients._

## Technologies Used

* _C#_
* _.NET_
* ASP.NETCore 
* _CSS_
* _HTML_
* _Entity_
* _MySQL Workbench_

## Description

_A c# website where you can manage stylists and clients for a salon. You can add stylists to the database and add clients assigned to stylists. The database utilizes a one-to-many model; assigning one stylist to many clients._

## Setup/Installation Requirements

* Clone this repository to your desktop
* Open your terminal and navigate to the top of this directory
* enter the commands $ dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0 AND
$ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
* Open MySqlWorkbench and import the database patty_otero from this repository into your worbench
* create a file called appsettings.json within the HairSalon folder
* add the following text to the file inserting your own DATABASE NAME, USER ID, and PASSWORD: {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE NAME HERE];uid=[USER ID HERE];pwd=[PASSWORD HERE];"
  }
}
* in the terminal enter the command: $dotnet build
* To run the application in the terminal navigate to the top of the HairSalon folder and enter: >dotnet run
* Use the localhost url with your web-browser to view the site

## Known Bugs

* _none_

## License

_MIT_

Copyright (c) _2022_ _Patty Otero_