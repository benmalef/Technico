using System.Net;
using System.Numerics;
using System.Xml.Linq;
using Tecnico;
using Tecnico.Enums;
using Tecnico.Models;
using Tecnico.Repositories;
using Tecnico.Services;


AppDbContext appDbContext =  new();
OwnerRepository ownerRepository = new OwnerRepository(appDbContext);
OwnerService ownerService = new OwnerService(ownerRepository);
OwnerController ownerController = new OwnerController(ownerService);


//new  { VAT = 123456, ID = 1, Name = "John", Surname = "Doe", Address = "123 Main St", Phone = 1234567890, Email = "john.doe@example.com", Password = "pass123", TypeOfUser = Users.Admin },
//            new User { VAT = 234567, ID = 2, Name = "Jane", Surname = "Smith", Address = "456 Elm St", Phone = 2345678901, Email = "jane.smith@example.com", Password = "pass234", TypeOfUser = Users.Simple },
//            new User { VAT = 345678, ID = 3, Name = "Alice", Surname = "Johnson", Address = "789 Maple St", Phone = 3456789012, Email = "alice.johnson@example.com", Password = "pass345", TypeOfUser = Users.Admin },
//            new User { VAT = 456789, ID = 4, Name = "Bob", Surname = "Williams", Address = "101 Oak St", Phone = 4567890123, Email = "bob.williams@example.com", Password = "pass456", TypeOfUser = Users.Simple },
//            new User { VAT = 567890, ID = 5, Name = "Charlie", Surname = "Brown", Address = "202 Pine St", Phone = 5678901234, Email = "charlie.brown@example.com", Password = "pass567", TypeOfUser = Users.Simple },
//            new User { VAT = 678901, ID = 6, Name = "David", Surname = "Miller", Address = "303 Cedar St", Phone = 6789012345, Email = "david.miller@example.com", Password = "pass678", TypeOfUser = Users.Admin },
//            new User { VAT = 789012, ID = 7, Name = "Eve", Surname = "Davis", Address = "404 Birch St", Phone = 7890123456, Email = "eve.davis@example.com", Password = "pass789", TypeOfUser = Users.Simple },
//            new User { VAT = 890123, ID = 8, Name = "Frank", Surname = "Garcia", Address = "505 Cherry St", Phone = 8901234567, Email = "frank.garcia@example.com", Password = "pass890", TypeOfUser = Users.Admin },
//            new User { VAT = 901234, ID = 9, Name = "Grace", Surname = "Martinez", Address = "606 Willow St", Phone = 9012345678, Email = "grace.martinez@example.com", Password = "pass901", TypeOfUser = Users.Simple },
//            new User { VAT = 123456, ID = 10, Name = "Hank", Surname = "Lopez", Address = "707 Poplar St", Phone = 1234567891, Email = "hank.lopez@example.com", Password = "pass012", TypeOfUser = Users.Admin }

var ben = new Owner
(
    11,
     1,
     "John",
     "Doe",
     "123 Main St",
     1234567890,
     "john.doe@example.com",
     "pass123",
     Users.Admin
);
ownerController.create(
    ben
);
ownerController.create(
    ben
);
ownerController.create(
    ben
);
ownerController.create(
    ben
);

ownerController.display();