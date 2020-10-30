# __ParksApi__

#### __An API for states and national parks. October 30, 2020__

#### By _**Emme Buentiempo**_

## Description

This application was created as an Epicodus assignment, with the intent to have it serve as a demonstration of knowledge after the program's 13th week. For the time being this README will serve as a checklist to demonstrate the satisfaction of all project requirements and objectives. 

## Project requirements:

For your final C#/.NET code review, you’ll build one of the three APIs below:

Parks Lookup: Create an API for state and national parks. The API will list state and national parks.
You have the freedom to build out your APIs as you wish. At the very least, your API should include the following:

  * Full CRUD functionality. [Incomplete]
  * Further exploration of one of the following objectives: authentication, versioning, pagination, Swagger documentation, or CORS. [Incomplete]
  * Complete documentation of API endpoints and the further exploration you did. [Incomplete]

## Project Objectives:

  * Application includes CRUD functionality and successfully returns responses to API calls. [Incomplete]
  * Application includes at least one of the further exploration objectives: authentication, versioning, pagination, Swagger documentation, or CORS. [Incomplete]
  * Application is well-documented, including specific documentation on further exploration. [Incomplete]
  * Commit history clearly shows eight hours of work. [Incomplete]

## Specs

  1.[X] Full CRUD for NationalParks 
    * Create: [Works]
    * Read: [Works]
    * Update: [Works]
    * Destroy: [Untested]
  
  2.[] Full CRUD for StateParks 
    * Create: [Works]
    * Read: [Works]
    * Update: [Untested]
    * Destroy: [Untested]
  
  3.[X] Full CRUD for States
    * Create: [Works]
    * Read: [Works]
    * Update: [Works]
    * Destroy: [Works]
  
  4.[] Authentication
    * Functionality: [Works]
    * Documentation: [Incomplete]

  5.[] Swagger Documentation
    * Functionality: [Works]
    * Documentation: [Incomplete]

## Setup/Installation Requirements

* First, recreate the database schema by connecting to a local instance within MySql Workbench (instal information can be found here if you have not already done so https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)

* Then, to run the application:
* _open terminal_
* _type "cd desktop", then press enter_
* _type "git clone https://github.com/3emme/ParksApi", then press enter_
* _locate and open directory on desktop named "ParksApi" with your console of choice_
* _If necessary, update the appsettings.json file with your personal mysql username/password:_
  * {"ConnectionStrings": {"DefaultConnection": "Server=localhost;Port=3306;database=parks_apo;uid={YOUR USERNAME};pwd={YOUR PASSWORD}"}
* _(in console) locate and move to the directory inside called ParksApi_
* _(in console) run $dotnet restore_
* _(in console) run $dotnet build_
* _(in console) run $dotnet ef database update_
* _(in console) run $dotnet run_

## Support and contact details

_Please do not hesitate to contact me at emmettbuentiempo@gmail.com should you have any questions regarding this project_

## Technologies Used

* _C#_

### License

Copyright (c) 2020 **_Emme Buentiempo_**
This software is licensed under the MIT license.