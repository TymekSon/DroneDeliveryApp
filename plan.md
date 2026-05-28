**App main goals** 

    - provide a system that manages package transport via drones
    - allows users to track their order status
    - allows admins to add/delete new drones and landing spots, change status


**Data the app must store**

    - landing spots
    - drones
    - users
    - admins
    - packages
    - orders


**API the app must have**

    User:
        - login/register
        - make/cancel order
        - check status

    Admin:
        - add/delete drone
        - add/delete landing spot
        - update values/status 


**Schema of Classes(simpified)**

    User:
        -id
        -name
        -email
        -adress
        -passwordHash
        -List<Role>

    Role:
        -id
        -name
        -List<Permission>

    Permission:
        -id
        -name
        -description

    Order:
        -id
        -user.id
        -date
        -status
        -List<Package>

    Package:
        -id
        -size
        -weight
        -Order.id
    
    Drone:
        -id
        -model
        -user.id <- technician who maintains the drone
        -LandingSpot.id <- drone's base
        -status
        -fleet

    Model:
        -id
        -name
        -weight
        -dimensions
        -max_payload
    
    Landing_Spot:
        -id
        -n_of_spots
        -latitude
        -longitute
        -status
        -group

    Fleet:
        -id
        -name
        -List<Drone>
    
    Group:
        -id
        -name
        -List<Landing_Spot>


**Data Base Schema**

    Users: <id, name, email, address, password_hash, role.id>
    Roles: <id, name>
    Permissions: <id, name, description>
    Role_permissions: <role.id, permission.id>
    User_Roles: <user.id, role.id>

    Orders: <id, user.id, confirmation_date, completion_date, status>
    Packages: <id, order.id, size, weight>

    Drones: <id, Model.id, user.id, Landing_Spot.id, status>
    Fleets: <id, name>
    Fleet_Drone: <Fleet.id, Drone.id>
    Models: <id, name, weight, dimensions, max_payload>

    Landing_Spots: <id, n_of_spots, latitude, longitude, status>
    Groups: <id, name>
    Group_Landing_Spot: <Group.id, Landing_Spot.id>


**App structure**

    DroneDeliveryApp/                  ← nazwa folderu i solution
    ├── DroneDeliveryApp/              ← folder projektu (.csproj)
    │   ├── Program.cs
    │   ├── appsettings.json
    │   ├── appsettings.Development.json
    │   │
    │   ├── Controllers/               ← API Controllers
    │   ├── DTOs/                      ← Data Transfer Objects
    │   │   ├── Requests/
    │   │   └── Responses/
    │   │
    │   ├── Models/                    ← Encje domenowe (dawniej "Classes/")
    │   │   ├── Entities/              ← User, Order, Drone, etc.
    │   │   ├── ValueObjects/          ← opcjonalnie (np. Address, Coordinates)
    │   │   └── Enums/
    │   │
    │   ├── Data/                      ← Warstwa danych
    │   │   ├── ApplicationDbContext.cs
    │   │   ├── Configurations/        ← IEntityTypeConfiguration<T>
    │   │   ├── Repositories/          ← (opcjonalnie na początku)
    │   │   └── Migrations/
    │   │
    │   ├── Services/                  ← Logika biznesowa
    │   │   ├── Interfaces/
    │   │   └── Implementations/
    │   │
    │   ├── Common/                    ← rzeczy wspólne
    │   │   ├── Exceptions/
    │   │   ├── Extensions/
    │   │   └── Helpers/
    │   │
    │   ├── Utils/                     ← skrypty, seedery, etc.
    │   └── Tests/                     ← (możesz na razie zostawić na zewnątrz)
    │
    ├── DroneDeliveryApp.Tests/        ← osobny projekt testowy (opcjonalnie później)
    ├── .gitignore
    ├── README.md
    └── DroneDeliveryApp.sln