

CREATE DATABASE PetNest;

USE PetNest

DROP TABLE IF EXISTS UserProfile

CREATE TABLE UserProfile(
UserId INT NOT NULL,
firstName VARCHAR(30) NOT NULL,
lastName VARCHAR(30) NOT NULL,
UserAge INT,
UserGender char(20),
AboutMe VARCHAR(200),
PictureURL VARCHAR(50),
MaxDistance INTEGER,
LocationID VARCHAR(70)
PRIMARY KEY(UserID));

---------------------------------------------

DROP TABLE IF EXISTS Animals

CREATE TABLE Animals(
AnimalID INT NOT NULL,
AnimalName VARCHAR(20),
AnimalAge INT,
AnimalType VARCHAR(20),
AnimalBreed VARCHAR(30),
AnimalSex VARCHAR(10),
AnimalWeight INT,
IsSpayedOrNeutered VARCHAR(3),
VaccinationUpToDate VARCHAR(20),
AnimalAboutMe VARCHAR(200),
OwnerID VARCHAR(20),
FOREIGN KEY(OwnerID) REFERENCES UserProfile(UserID));

---------------------------------------------

DROP TABLE IF EXISTS Locations

CREATE TABLE Locations(
LocationID INT,
LocationName VARCHAR(128),
Address1 VARCHAR(20),
Address2 VARCHAR(20),
City VARCHAR(10),
ST char(2),
PRIMARY KEY(LocationID));

--------------------------------------------

DROP TABLE IF EXISTS Favorites

CREATE TABLE Favorites(
UserID INT,
AnimalID INT,
FavoriteID INT,
FOREIGN KEY(UserID) REFERENCES UserProfile(UserID));

-------------------------------------------

DROP TABLE IF EXISTS MessageSystem

CREATE TABLE MessageSystem(
MessageID VARCHAR(70),
Recipient CHAR(70),
MessageBody VARCHAR(500),
MessageTimeStamp TIMESTAMP,
ReportUser_UserID VARCHAR(70),
PRIMARY KEY(MessageID));

------------------------------------------

DROP TABLE IF EXISTS ReportUsers

CREATE TABLE ReportUsers(
UserID VARCHAR(70),
ReportID INT,
ReasonID VARCHAR(70),
ReportResolved char(3));

------------------------------------------

DROP TABLE IF EXISTS Shelters

CREATE TABLE Shelters(
ShelterName VARCHAR(30),
ShelterDescription VARCHAR(200),
ShelterPhone INT,
ShelterID INT,
PRIMARY KEY(ShelterID));

------------------------------------------

DROP TABLE IF EXISTS AnimalLocator

CREATE TABLE AnimalLocator(
AnimalID INT,
LocationID INT,
DateTime INT,
FOREIGN KEY(AnimalID) REFERENCES Animals(AnimalID),
FOREIGN KEY(LocationID) REFERENCES Locations(LocationID));