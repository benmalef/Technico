﻿using Technico;
using Technico.Controllers;
using Technico.Enums;
using Technico.Services;
using Technico.Models;
using Technico.Repositories;
using Microsoft.EntityFrameworkCore;




AppDbContext appDbContext = new();

// DI
// Item
ItemRepository itemRepository = new ItemRepository(appDbContext);
ItemService itemService = new ItemService(itemRepository);
// Repair
IRepairRepository repairRepository = new RepairRepository(appDbContext);
RepairService repairService = new RepairService(repairRepository);
//Owner
OwnerRepository ownerRepository = new OwnerRepository(appDbContext);
OwnerService ownerService = new OwnerService(ownerRepository, itemService);
OwnerController ownerController = new OwnerController(ownerService);


//------Create/Read Operation----------
// Create an owner
var owner = new Owner
{
    VAT = "1133",
    Name = "Takis",
    Surname = "Smith",
    Address = "",
    Phone = 234567801,
    Email = "jane.smith@example.com",
    Password = "pass234",
    TypeOfUser = Users.Simple
};

// Insert the owner to the database
var owner1 = ownerService.CreateOwner(owner);

// Find the owner by VAT that the item belongs 
owner = ownerService.GetOwnerByVAT(owner.VAT);

// Create an item 
var item = new Item
{
    Owner = owner,
    Address = owner?.Address,
    E9 = 12345,
    TypeOfItem = TypeOfItem.Detached,
    YearOfConstruction = 2010,
};

//Insert the item to the database
itemService.CreateItem(item);

//Find the item that the repair belongs 
item = itemService.GetItemByE9(12345);

//Create a repair 
var repair = new Repair
{
    Date = DateTime.Now,
    TypeOfRepair = TypeOfRepair.Painting,
    Description = "Pumb",
    Address = "Chania",
    Cost = 100m,
    Status = StatusOfRepair.Pending,
    Item = item,
};

//Insert the repair to the database
repairService.CreateRepair(repair);

//------Display the owner's details, items, repairs --------

//Display  the owner's details, you should provide the owner VAT
ownerService.GetOwnerByVAT("1133");

//Display all the owner's items
var ownerItems = ownerService.GetOwnerItemsByVAT("1133");

//Display all the owner's repairs 
var ownerRepairs = ownerService.GetOwnerRepairsByVAT("1133");


//------Update Operation----------

//Update the owner details. 
//Update the onwer name and email
ownerService.UpdateOwner("1133", name: "George");


//Update the item details
//Update the item(E9:12345) year of construction
itemService.UpdateItemByE9(12345, yearOfConstruction: 1010);

//Update the repair details
//We should find the repair id. 
var repairs = itemService.GetItemByE9(12345)?.Repairs;
//Update the first repair status of the list
repairService.UpdateRepair(repairs[0].Id, status: StatusOfRepair.Complete);

//------Delete Operation---------- please uncomment to test it 
//Delete an owner
//ownerService.DeleteOwnerByVAT("1133");

////Delete a repair 
//repairService.DeleteRepairById(repairs[0].Id);



