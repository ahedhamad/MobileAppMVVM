# Mobile Application Model and View Classes

This repository contains multiple classes forming the model and view components of a mobile application.

## Model Classes

### AdminUser
- Attributes:
  - `Id`: Integer representing the user's ID.
  - `Name`: String representing the user's name.
  - `Age`: Integer representing the user's age.
  - `staffUsers`: List of StaffUser instances associated with the AdminUser.

### StaffUser
- Attributes:
  - `Id`: Integer representing the staff user's ID.
  - `Name`: String representing the staff user's name.
  - `Age`: Integer representing the staff user's age.
  - `role`: Enum defining the roles for the staff user.

### User
- Attributes:
  - `Id`: Integer representing the user's ID.
  - `Name`: String representing the user's name.
  - `Age`: Integer representing the user's age.

## ModelView Classes

### MViewAdminUser
- Functionality:
  - Manages AdminUser instances.
  - Handles addition, removal, and updates of AdminUser instances.
  - Contains delegates for various operations.

### MViewStaffUser
- Functionality:
  - Manages StaffUser instances.
  - Handles addition, removal, and updates of StaffUser instances.
  - Contains delegates for various operations.

### MViewUser
- Functionality:
  - Manages User instances.
  - Handles addition, removal, and updates of User instances.
  - Contains delegates for various operations.

## View Classes

### ViewAdminUser
- Functionality:
  - Main entry point for managing AdminUser views.
  - Handles addition, deletion, and update events for AdminUser instances.
  - Contains delegate methods to update views accordingly.

### ViewStaffUser
- Functionality:
  - Main entry point for managing StaffUser views.
  - Handles addition, deletion, and update events for StaffUser instances.
  - Contains delegate methods to update views accordingly.

### ViewUser
- Functionality:
  - Main entry point for managing User views.
  - Handles addition, deletion, and update events for User instances.
  - Contains delegate methods to update views accordingly.

## Purpose
The code in this repository demonstrates the structure of model and view classes for managing different types of users within a mobile application. Each class encapsulates specific attributes and functionalities related to user management.

## Additional Notes
- The classes provided offer basic functionalities for user management and require further implementation and integration for a complete mobile application.
- For detailed usage instructions, refer to the individual class descriptions and their functionalities.
