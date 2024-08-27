# Stardew Valley Community Center Tracker

![Stardew Valler Community Center Tracker Home Page](https://github.com/user-attachments/assets/d75087b7-4223-4e64-aa55-c946832fcfc1)

## Description
This was a class group project to demonstrate understanding of .NET and CRUD functionality. This app is a WindowsForms app that uses C# and code first migrations along side EF Core. This app allows a user to create a Farm. In the app, you will be able to select a Farm and keep track of each Iitem required to finish a [Community Center Bundle](https://stardewvalleywiki.com/Bundles). ![Screenshot 2024-08-27 101216]

![Items being tracked in the Bundles](https://github.com/user-attachments/assets/c346fbdb-829c-427d-8a4a-a58545196056)

## Getting Started

### Prerequisites
To run this app you will need:
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
- [.NET major version 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Step 1
To run the app, you will have to clone the app onto your machine. For a detailed explanation on cloning, 
[click here](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository).

### Step 2
You will need to restore the NuGet Packages before you can create the database or run the app. Do do this, you will need to right click on your solution in the Solution Explorer and click on Restore NuGet 
Packages. 

![Restore Packages Demo](https://github.com/user-attachments/assets/80a86058-c743-495e-99c7-51c0c9fa6f62)


### Step 3
Next, you will need to create the database. In order to add the database, in Visual Studio 2022 you will have to go to the View menu and under other windows select Package Manager Console. You will then 
have to type in command ```Update-Database``` and hit enter. This command will apply all migrations, and create the tables nessecary to run the app. 

![Update Database Demo](https://github.com/user-attachments/assets/78562f5a-5226-47f4-bec8-ac5953c27302)

### Step 4
You're done! After Step 3, you can run the app. 
