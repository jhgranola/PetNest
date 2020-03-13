# PetNest
Repository for my course project during MSSA.

PetNest is a developing web application designed to be a one stop shop for everyone interested in having pets. The first versions will only pertain to those wishing to become owners of a new pet from shelters in their area. Designed like current dating apps, PetNest is a new fun and exciting way to find you, or your family's new best friend who's waiting for you at a shelter nearby. This applications initial launch is meant to give users the opportinity to view pets within parameters they set via filters (such as dog, cat, etc. and even breed). This is also a way for shelters to gain publicity so that they can give more opportunity to the animals they may be housing. Users will be able to get detailed information about the pets they are looking at such as age, certain medical history, and even behaviour if the shelters input that information so that the viewers have a better idea as to if their home is a good fit for the animals. If users are unsure, they can always contact the shelter through the app, or of course save the animal under as a favorite and address it at a later time.

-----
 
## Table Of Contents

- [1. User Stories](#user-stories)
- [2. Use-Cases](#use-cases)
- [3. Requirements](#requirements)
- [4. Requirements Table](#requirements-table)
- [5. Test Table](#test-table)

-----

## User stories, use-cases, and requirements for PetNest Application.

### User Stories



As an animal shelter vendor I want to be able to populate the animals from my shelter onto an app so that  I have more coverage and the animals will find homes faster.

As a user I want a space where I can see all animals in shelters nearby in one collection so that I have easier access to the inventory and have an easier way to adopt.

As a user, I want to be able to favorite animals I want to potentially adopt so they are bookmarked.

As a user, I want to be able to filter out animals/breeds I do not desire to adopt.

As a vendor, I want to be able to prescreen potential clients prior to adoption

As a vendor, I want to be able to track the number of people viewing the animals in my shelter so I can prioritize preparing them for adoption

As a vendor, I want to make consumers aware of what the animals preferences and behaviors are


### Use-Cases



Given user action, when they click an animal photo, its profile will load

Given user action, when they first login to the website, they will be directed to logon or create an account

Given user action, the available animals will be shown according to their filters

Given user action, the contact information will be displayed for the shelter

Given user action, when they click the heart, the animal will be favorited and saved to a favorites folder

Given user action, an animal will be removed once it is listed as adopted

Given user action, clicking to upload images will display desktop folders so that images may be selected

Given user action, when they click the ‘X’ on an animal, it will no longer be shown to them unless retrieved from a “passed” tab

Given user action, when they favorite an animal, the shelter will be notified


### Requirements



1a – User will create an account

1b – User will have to verify their account via email

1c – User will have to login, using email and password

1d – User will specify initial filters (they may be changed at any time)

1e – User will be directed to browsing pages

2a – System will provide the page

2b – System will provide UI

2c – System will provide site navigation

2d – System will allow chat functions between shelters and interested buyers

3a – Software will verify login credentials

3b – Software will post profile information to database

3c – Software will post and remove animals as they become available or adopted from shelters

3d – Software will make sure users favorites are saved in database

3e – Software will contain profanity filters

3f – Software will ensure vendors are verified legally (if applicable)


### Requirements Table



This table will organize requirements and keepy track of whats been implemented, and tested, as well as establish the type of test method associated with each requirement.

Req ID | Requirement Description | Test ID | Test Method | Implemented | Tested
--- | --- | --- | --- | --- | ---
1a | User will create an account | T-1 | Demonstration | No | No
1b | User will have to verify their account via email | T-2 | Inspection | No | No
1c | User will have to login using email and password | T-3 | Demonstration | No | No
1d | User will specify initial filters | T-4 | Analysis | No | No
1e | User will be directed to browsing pages | T-5 | Test | No | No
2a | System will provide the page  | T-6 | Inspection | No | No
2b | System will provide UI | T-7 | Test | No | No
2c | System will provide site navigation | T-8 | Demonstration | No | No
2d | System will allow chat functions between shelters and interested buyers | T-9 | Demonstration | No | No
3a | Software will verify login credentials | T-10 | Analysis | No | No
3b | Software will post profile information to database | T-11 | Analysis | No | No
3c | Software will post and remove animals as they become available or adopted from shelters | T-12 | Test | No | No
3d | Software will make sure users favorites are saved in database | T-13 | Analysis | No | No
3e | Software will contain profanity filters | T-14 | Test | No | No
3f | Software will ensure vendors are verified legally (if applicable) | T-15 | Analysis | No | No


### Test Table



Test ID | Req ID | Test Procedure | Status | Last Update (time) | Version
--- | --- | --- | --- | --- | ---
1a | T-1 | Click sign up button displayed on home page. Promt user to select vendor or consumer. All requried fields should be displayed and annotate required fields using * | Not Tested | N/A | 0.0.0
1b | T-2 | Once user submits sign-up, promt user to verify via email. Ensure email is sent to user, and profile data is stored in database | Not Tested | N/A | 0.0.0
1c | T-3 | Prompt users to enter email and password on homepage in order to log in | Not Tested | N/A | 0.0.0
1d | T-4 | Specify a set of filters and ensure correct data is displayed | Not Tested | N/A | 0.0.0
1e | T-5 | Verify user is directed to browsing pages once initial filters are set as well as every time after they login thereafter | Not Tested | N/A | 0.0.0
2a | T-6 | Visually inspect all views | Not Tested | N/A | 0.0.0
2b | T-7 | Use and ensure all user interfaces perform as intended | Not Tested | N/A | 0.0.0
2c | T-8 | Click on all navigation components and ensure they render the correct view i.e. account settings returns the account settings view | Not Tested | N/A | 0.0.0
2d | T-9 | Create two user accounts and attempt to chat between a vendor account and user account | Not Tested | N/A | 0.0.0
3a | T-10 | Enter credentials to and click login if correct log in success and display intended view. Supply faulty credentials to display correct errors | Not Tested | N/A | 0.0.0
3b | T-11 | Analyze database to ensure correct profile information is being stored | Not Tested | N/A | 0.0.0
3c | T-12 | Create test animal. Confirm animal as sold and ensure database reflects | Not Tested | N/A | 0.0.0
3d | T-13 | Using test profile, favorite an animal. Analyze database to ensure animal is added to favorites under the users profile | Not Tested | N/A | 0.0.0
3e | T-14 | Insert profanity into profile descrptions and messages. Ensure user is prompted to retype their statement. | Not Tested | N/A | 0.0.0
3f | T-15 | With vendor account, ensure documentation based on location is required for verification | Not Tested | N/A | 0.0.0
