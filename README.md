# Lab11-MyFirstMVC_App

## Person of the year
This is a ASP.NET Core MVC web application. Using a csv file of all the “Time” Persons of the year from 1927 - 2016, Created is
a web app that will allow a user to put in a span of 2 different years, and a list of all the winners will be returned.

## What is being implemented
This web app was created from an empty Web App template, with all controllers and views manually created. Created with only 1 controller. 
The home controller, with 3 actions (2 Index, and 1 Results) utilizing HTTPGET and HTTPPOST Upon posting back to the server, the Results action to redirect to the results view occurs.
The Views folder contains the home page and search results and a form tag is what accepts user input.

A model class named TimePerson contains properties for the time person of the year. This is the Model that takes information from a csv file. It also contains the methods to convert this file 
into usable objects that were created through using lists. On the controller side, this is where the HTTP GET and POST happen on click of submit button. This causes a redirect to the results action
and calls on TimePerson, which is a class to get all of the data from the csv file and filter it based on user input.

## (Visuals)


