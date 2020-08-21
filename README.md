# :paw_prints: _Animal Shelter_

#### _C#/.Net SQL API Bulding Exercise for Epicodus, 08/21/2020_

#### :pencil_2: By _**Beverly Potts**_

## :gem: Description

_Demonstrates API building process by creating two databases, one for dogs and one for cats, seeding the data and providing routes To create, read, update and delete entries._

## :cat: Cat Http Request
```
GET /api/cats
POST /api/cats
GET /api/cats/{id}
PUT /api/cats/{id}
DELETE /api/cats/{id}
GET /api/cats/random (Return random cat object)
```

## :cat: Pagination
```
GET /api/cats/page/?pageNumber=1&pageSize=2
```

## :cat: Cat Path Parameters

| Parameter  |   Type   |  Default |  Required  | Description |
|------|:------:|:------:|:------:|-------------:|
|name|string|none|false|Return matches by name.|
|color|string|none|false|Return matches by color.|
|breed|string|none|false|Return matches by breed.|
|age|int|none|false|Return matches by age.|
|gender|string|none|false|Return matches by gender.|

## :dart: Example Query
```
http://localhost:5000/api/cats/?gender=male&color=black
```

## :dart: Sample JSON Response
```
 {
        "catId": 2,
        "name": "Jasper",
        "color": "Black",
        "breed": "Domestic Mediumhair",
        "age": 3,
        "gender": "Male"
    },
    {
        "catId": 10,
        "name": "Jiji",
        "color": "Black",
        "breed": "Domestic Shorthair",
        "age": 5,
        "gender": "Male"
    }
```

## :dog: Dog Http Request
```
GET /api/dogs
POST /api/dogs
GET /api/dogs/{id}
PUT /api/dogs/{id}
DELETE /api/dogs/{id}
GET /ap/dogs/random (return random dog object)
```

## :dog: Pagination
```
GET /api/dogs/page/?pageNumber=1&pageSize=2
```

## :dog: Dog Path Parameters

| Parameter  |   Type   |  Default |  Required  | Description |
|------|:------:|:------:|:------:|-------------:|
|name|string|none|false|Return matches by name.|
|color|string|none|false|Return matches by color.|
|breed|string|none|false|Return matches by breed.|
|age|int|none|false|Return matches by age.|
|gender|string|none|false|Return matches by gender.|

## :dart: Example Query
```
http://localhost:5000/api/dogs/?age=6
```

## :dart: Sample JSON Response
```
{
  "dogId": 6,
  "name": "Fido",
  "color": "Tawny",
  "breed": "Wolfhound",
  "age": 6,
  "gender": "Female"
}
```

## :clipboard: Setup/Installation Requirements


  1. Follow this [link to the project repository](https://github.com/BAPotts/AnimalShelter.Solution.git) on GitHub. 
  2. Click on the "Clone or download" button to copy the project link.     
  3. If you are comfortable with the command line, you can copy the project link and clone it through your command line with the command `git clone`. Otherwise, I recommend choosing "**Download ZIP**".     
  4. Once the ZIP file has finished downloading, you can right click on the file to view the zip folder in your downloads.     
  5. Right click on the project ZIP folder that you have just downloaded and choose the option "**Copy To...**", then choose the location where you would like to save this folder.      
  6. Navigate to the final location where you have chosen to save the project folder.      
  7. To view the code itself, right click, choose "open with..." and open using a text editor such as VS Code or Atom, etc.
  8. Open the terminal inside of your text editor.
  9. From inside of the AnimalShelter directory, type the command `dotnet restore` into your terminal and hit enter. You should see object files appear. They should be greyed out.

## :card_index: Database Population
To populate a database:
1. Delete the migrations folder.
2. Navigate to AnimalShelter folder.
3. Run `dotnet ef migrations add Initial` in the terminal.
4. Then run `dotnet ef database update`.

## :bug: Known Bugs

There are no known bugs at this time.

## :raising_hand: Support and Contact Details

Feedback is greatly appreciated! Contact BAPotts on GitHub with any questions or comments.

## :computer: Technologies Used

* C# 
* EntityFrameworkCore
* .NET-Core 2.2
* Visual Studio Code
* Git Version Control 
* GitHub
* Sql Workbench 8.0

### :scroll: License

*This project is licensed under the MIT license.*

Copyright (c) 2020 **_{Beverly Potts}_**