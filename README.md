#AddressBook API
#Description
An API for managing an address book, supporting CRUD operations (Create, Read, Update, Delete). It uses AutoMapper for seamless object mapping and is fully integrated with ASP.NET Core Dependency Injection.

#Features
Manage contacts with CRUD functionality.
AutoMapper for efficient object transformation between models and DTOs.
Dependency Injection for better modularity and testability.
Endpoints
Method	Endpoint	Description
GET	/Contacts/AllContacts	Get all contacts.
GET	/Contacts/ContactById/{id}	Get a contact by ID.
POST	/Contacts/CreateContact	Create a new contact.
PUT	/Contacts/UpdateContact	Update a contact.
DELETE	/Contacts/DeleteContact/{id}	Delete a contact.
#How to Use
Configure AutoMapper in Program.cs.
Inject the IContactService in controllers for handling business logic.
Test endpoints using Swagger or Postman.
#Technologies
ASP.NET Core
AutoMapper
C#
