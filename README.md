# Tournament Tracker
> 
> 

## Table of Contents
* [Technologies Used](#technologies-used)
* [Setup](#setup)
* [Project Status](#project-status)
* [Acknowledgements](#acknowledgements)


## Technologies Used
- The tool is written in C # in Visual Studio 2019 on .NET Framework on Windows 10 - windows form aplications.

## Setup
To use this on your computer u have to change in App.config: localization to your database or a filepath, if u save data to text file.

` <appSettings>
    <add key="filePath" value="your localisation"/>
  </appSettings> `
  
  
  or
  
  
 ` <connectionStrings>
    <add name="Tournaments" connectionString="Server= your server name ;Database=Tournaments;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
  </connectionStrings> `
  

## Project Status
Project is: _in progress_. 

## Acknowledgements
- This project was based on [this tutorial](https://www.youtube.com/watch?v=wfWxdh-_k_4).
