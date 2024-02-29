# Time Tracker Console Application

Author - Asfaq Moideen Askar, Solin 2024 B2.

### Initial Design of the product
 As per the customer requirement provided, The Initial design of the product proposed to the customer comprehending all requirements.

### Overview
The Time Tracker Conosle Appilacation, Complete assistance for your personal and proffesional Time Management.
- With highly interactive Command Line User Interface 
- Showing Insights, Setting remainders also exporting your data.
- Prone to errors and user account controls. 

### Context 

As growning in a fast developing world, Time management is a main thing to concern for one's personal growth.
This project is taken to develop a verstile application with lot of features and tools.

### Low Level Design

The Appliction to be developed in the basis of MCV Archeitecture for long term support and Maintenance

#### Layers

- Models 
	- User 
	- Tasks
	- Connecing to Storage elements
	
- Controller
	- UserController - (Core Functionalities given by customer)
	- TaskController

- Service 
	- All suppporting methods of both controllers
	- Log file creation and management
	- Insights and Reports
	- Input Validations

- Views
	- The User interfaces
	- Input and Output Methods

#### Uint Testing

- Creating unit tests for Controller, Service layer functionalities. 

#### Storage 
- The user details will be stored in seperate file which have User Attributes with Log file location
- A new log file will created for new user who are added, That contains the User's task Attributes


