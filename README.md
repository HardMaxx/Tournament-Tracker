# Tournament Tracker
> 
> 

## Table of Contents
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Screenshots](#screenshots)
* [Setup](#setup)
* [Project Status](#project-status)
* [Room for Improvement](#room-for-improvement)
* [Acknowledgements](#acknowledgements)


## Technologies Used
- The tool is written in C # in Visual Studio 2019 on .NET Core 3.1 on Windows 10 - windows form aplications.

## Features
List the ready features here:
- Alert emailing to teams
- sql and text database

## Screenshots
![dashboard](./ss/dashboard.png)
![tournamentviewer](./ss/tournamentviewer.png)
![createtournament](./ss/createtournament.png)
![createteam](./ss/createteam.png)
![createprize](./ss/createprize.png)
<!-- If you have screenshots you'd like to share, include them here. -->

## Setup
To use this on your computer u have to change in App.config: localization to your database or a filepath, if u save data to text file.

Text File

` <appSettings>
    <add key="filePath" value="your localisation"/>
  </appSettings> `
  
  or
  
 Database
 
 ` <connectionStrings>
    <add name="Tournaments" connectionString="Server= your server name ;Database=Tournaments;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
  </connectionStrings> `
  
 to send emails
 
 ` <appSettings> <add key="senderEmail" value="yourEmaill"/>
    <add key="senderDisplayName" value="YourName"/>  </appSettings>  `

## Project Status
Project is: no longer being worked on.

## Acknowledgements
- This project was based on [this tutorial](https://www.youtube.com/watch?v=wfWxdh-_k_4).


## Room for Improvement

Room for improvement:
- error handling to all forms
- option that a winning team with a lower score, for example Golf 
