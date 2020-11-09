# __ParksApi__

#### __An API for states and national parks. October 30, 2020__

#### By _**Emme Buentiempo**_

## Description

This application was created as an Epicodus assignment, with the intent to have it serve as a demonstration of knowledge after the program's 13th week. For the time being this README will serve as a checklist to demonstrate the satisfaction of all project requirements and objectives. 

## Project requirements:

For your final C#/.NET code review, you’ll build one of the three APIs below:

Parks Lookup: Create an API for state and national parks. The API will list state and national parks.
You have the freedom to build out your APIs as you wish. At the very least, your API should include the following:

  * Full CRUD functionality. [Complete]
  * Further exploration of one of the following objectives: authentication, versioning, pagination, Swagger documentation, or CORS. [Complete]
  * Complete documentation of API endpoints and the further exploration you did. [Complete]

## Project Objectives:

  * Application includes CRUD functionality and successfully returns responses to API calls. [Complete]
  * Application includes at least one of the further exploration objectives: authentication, versioning, pagination, Swagger documentation, or CORS. [Complete]
  * Application is well-documented, including specific documentation on further exploration. [Complete]
  * Commit history clearly shows eight hours of work. [Complete]

## Specs

  1.[X] Full CRUD for NationalParks 
    * Create: [Works]
    * Read: [Works]
    * Update: [Works]
    * Destroy: [Works]
  
  2.[] Full CRUD for StateParks 
    * Create: [Works]
    * Read: [Works]
    * Update: [Works]
    * Destroy: [Works]
  
  3.[X] Full CRUD for States
    * Create: [Works]
    * Read: [Works]
    * Update: [Works]
    * Destroy: [Works]
  
  4.[] Authentication
    * Functionality: [Works]
    * Documentation: [Complete]

## Setup/Installation Requirements

* First, recreate the database schema by connecting to a local instance within MySql Workbench (instal information can be found here if you have not already done so https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)

* Then, to run the application:
* _open terminal_
* _type "cd desktop", then press enter_
* _type "git clone https://github.com/3emme/ParksApi", then press enter_
* _locate and open directory on desktop named "ParksApi" with your console of choice_
* _If necessary, update the appsettings.json file with your personal mysql username/password:_
  * {"ConnectionStrings": {"DefaultConnection": "Server=localhost;Port=3306;database=parks_api;uid={YOUR USERNAME};pwd={YOUR PASSWORD}"}
* _(in console) locate and move to the directory inside called ParksApi_
* _(in console) run $dotnet restore_
* _(in console) run $dotnet build_
* _(in console) run $dotnet ef database update_
* _(in console) run $dotnet run_

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.
* Open Postman and create a POST request using the URL: `http://localhost:4000/api/users/authenticate`
* Add the following query to the request as raw data in the Body tab:
```
{
    "UserName": "test",
    "Password": "test"
}
```
* The token will be generated in the response. Copy and paste it as the Token paramenter in the Authorization tab.

#### Example Query
```
https://localhost:4000/api/nationalparks/?name=crater
```

..........................................................................................

### Endpoints
Base URL: `https://localhost:4000`

#### HTTP Request Structure
```
GET /api/{component}
POST /api/{component}
GET /api/{component}/{id}
PUT /api/{component}/{id}
DELETE /api/{component}/{id}
```

#### Example Query
```
https://localhost:5000/api/nationalparks/1
```

#### Sample JSON Response
```
{
    "NationalParkId": 1,
    "NationalParkName": "Crater Lake National Park",
    "NationalParkDescription": "Crater Lake is a crater lake in south-central Oregon in the western United States",
    "NationalParkLocation": "South-Central Oregon",
}
```

..........................................................................................

### National Parks
Access information on National Parks of the United States.

#### HTTP Request
```
GET /api/nationalparks
POST /api/nationalparks
GET /api/nationalparks/{id}
PUT /api/nationalparks/{id}
DELETE /api/nationalparks/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.

#### Example Query
```
https://localhost:4000/api/beverage/?name=crater
```

#### Sample JSON Response
```
{
    "NationalParkId": 1,
    "NationalParkName": "Crater Lake National Park",
    "NationalParkDescription": "Crater Lake is a crater lake in south-central Oregon in the western United States.",
    "NationalParkLocation: "South-central Oregon"
}
```
..........................................................................................

### State Parks
Access information on State Parks of the United States.

#### HTTP Request
```
GET /api/stateparks
POST /api/stateparks
GET /api/stateparks/{id}
PUT /api/stateparks/{id}
DELETE /api/stateparks/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.

#### Example Query
```
https://localhost:4000/api/beverage/?name=bates
```

#### Sample JSON Response
```
{
    "StateParkId": 3,
    "StateParkName": "Bates State Park",
    "StateParkDescription": "Bates State Park was once the site of a thriving lumber mill and an adjacent company town set in a lush valley in the Blue Mountains. The mill closed in the mid-1970s. Families--and in some instances their houses--moved to nearby Prairie City and John Day. The mill buildings and town were dismantled; the land sat empty for more than 35 years.",
    "StateParkLocation: "Oregon"
}
```

..........................................................................................

## Support and contact details

_Please do not hesitate to contact me at emmettbuentiempo@gmail.com should you have any questions regarding this project_

## Technologies Used

* _C#_

### License

Copyright (c) 2020 **_Emme Buentiempo_**
This software is licensed under the MIT license.