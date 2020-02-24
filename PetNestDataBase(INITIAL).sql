

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
IsVendor char(3),
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
GoodInHomeWith VARCHAR(50),
AnimalAboutMe VARCHAR(200));

---------------------------------------------

DROP TABLE IF EXISTS Locations

CREATE TABLE Locations(
LocationID VARCHAR(70),
GPS FLOAT(32),
LocationName VARCHAR(128),
PRIMARY KEY(LocationID));

--------------------------------------------

DROP TABLE IF EXISTS Likes

CREATE TABLE Likes(
UserID INT,
AnimalID INT,
FavoriteID INT);

-------------------------------------------

DROP TABLE IF EXISTS MessageSystem

CREATE TABLE MessageSystem(
MessageID VARCHAR(70),
Recipient CHAR(70),
MessageBody VARCHAR(500),
MessageTimeStamp TIMESTAMP,
ReportUser VARCHAR(70),
PRIMARY KEY(MessageID));

------------------------------------------

DROP TABLE IF EXISTS ReportUsers

CREATE TABLE ReportUsers(
USERID VARCHAR(70),
ReasonID VARCHAR(70));

