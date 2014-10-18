## Contents
- [Design Issues](#design-issues)
- [Detailed Design Information](#detailed-design-information)
- [Trace of Requirement to Design](#trace-of-requirement-to-design) 




---------------------------


## Design Issues
- **Reliability**
  - By opting to use the .NET framework and Visual Studio, many utilities and reliable class libraries are available for our disposal instead of requiring a reimplementation.
  - The .NET Framework supplied calendar class (`System.Globalization.Calendar`) handles serialization of Date/Time formats.  Therefore, if there is an error in the date/time being displayed it is without a doubt an error in the logic, not in the serialization of the data.
  - The system clock determines the date and time exposed to our application through the operating system.  Unless the computer is connected to the internet, it can be the case that the system clock is inaccurate,  resulting in our system being inaccurate as well.  These types of reliability issues are cannot be controlled within our system, therefore we assume that there is no error with the system clock.
  - Data Integrity in our application, will be the responsibility of the MySQL Database Management System which we will plan to implement in our framework to provide the database to store our model data in order to implement Model-View-Controller architectural pattern.  We risk compromising the reliability of our application by implementing third party software, but since MySQL is assumed to be reliable and consider the scope of our application, we believe that the risk is not substantial and worth taking. 
  
- **Portability**
  - Portability across all available operating systems is not a critical requirement of our application.  Our highest priority target platform is is Microsoft Windows (only 7, 8, and 8.1) and then below that Mac OS X.  This decision was made to reduce the risk of compatibility-issues causing unforeseen/difficult-to-trace errors that will delay the progress of our agile development cycle.
  - Portability is a almost always a requirement for most software applications.  The decision to limit our range of device/software compatibility was made due to our initiative to begin the next cycle of our agile process life-cycle
  
- **Maintainability**
	* The Model-View-Controller's Architecture inherently simplifies the task of identifying where faults (defect) to errors in our system are.  
	* Because Agile Model is being used, if errors are not discovered through testing, customer feedback can supply useful information regarding faults in the system.  Once the presence of a fault has been verified, the fix to the fault will be applied on the next iteration of the lifecycle process.
- **Performance**
	* Initially in our development process, the system's performance isn't high priority and our system is deemed optimal as long as our application is usable and functional.  
	
- **Database Integrity**
	* Database Integrity is manage by the Database Management System (in our case MySQL).  In the context of our application, database integrity will assume to be preserved by the DBMS automatically.




--------------------



## Detailed Design Information
* Login/Registration (System Perspective) Activity Diagram
* Create/Edit Profile Sequence Diagram
* Class Diagram
	* Objects
		* User
			* Attribs: 
				* Name
				* Age
				* Sex
				* Height
				* Body Weight
				* Body Fat %
				* etc.
	* Models
		* Workouts
	* Views
		* Login 
		* Register
		* Create Profile
		* Edit Profile
		* Month View 
		* Week View  (w/ week schedule if any, otherwise suggestions)
		* Day View (w/ schedule if exists otherwise suggestions)
		* Browse Suggestion 
	* Controller
		* AccountController
			* Manages Login/Registration and Profile Creation/Editing and rendering views (Login, Register, Create Profile, Edit Profile) by calling DBMS interface functions
		* CalendarController
			* Manages retrieving calendar data from model to put into Calendar's "Month View", "Week View", "Day View"
		* SuggestionController
			* Generates Suggestions for workouts based on user's history/rating or present user predefined set of available workouts to schedule or participate in.

	* Feature Requirements
		* View/Rate Suggestion Service 
		* Intuitive User-Interface
		* Documentation Storage
		* Accessibility Feature
		* Notification Feature





--------------------



## Trace of Requirement to Design

- **Functional Requirements**
	* User is should be able to create their profile
	* User should be able to edit their profile
	* The user shall be able to view and modify their calendar. Including the ability to add events, edit events, delete events, and insert any suggestions.
	* The user shall be able to look at the suggestions the system produces, rate them, and insert them into their calendar.

- **Interface Requirements**
	* The user shall have a specific interface for the user to easily go to their profile, calendar, and suggestions, and make changes as they see fit

- **Physical Environment Requirements**
	* The user shall be able to access their software from a modern PC with either the Windows 7 or 8 Operating system, or the current Mac OS.
- **Users and Human Factor Requirements**
	* The system shall require its users to have only the documentation that comes with the application.
	* The system shall provide its users special accommodations such as larger font sizes and a neutral color scheme for those that are color blind.
	* The system shall maintain its own independent copy of the database and the software so that no private information between other users is jeopardized
	
- **Documentation Requirements**
	* User shall have access to documentation through the application
	* User is assumed to have a skill level of novice with minimal computer experience
	
- **Data Requirements**
	* The system shall retain all data of the user's profile for personalization of notifications and specializing the suggestions
	* The system shall retain all ratings of the suggestions made by the user and data taken from the events created by the user, to personalization of notifications and specializing the suggestions
	
- **Resource Requirement**
	* Software Engineers to maintain the system
	* System will utilize C#, .Net, and Mysql
	* The system shall be independent from other systems so information is accessible only from the user who produced the information
	* The system shall backup its data once every 5 minutes the application is running in case of the computer or application shutting down inadvertently
	
- **Quality Assurance Requirements**
	* The system will be available 100% of the time so long as the user's PC and/or files remain original and operational.
	* The system shall be reliable to notify the user 99.99% of the time of their upcoming events on time
	* The system shall receive updates to upkeep and improve the quality of the suggestions and the application itself
