using Technico;
using Technico.Controllers;
using Technico.Enums;
using Technico.Services;
using Technico.Models;
using Technico.Repositories;
using Microsoft.EntityFrameworkCore;



AppDbContext appDbContext = new();
OwnerRepository ownerRepository = new OwnerRepository(appDbContext);




ItemRepository itemRepository = new ItemRepository(appDbContext);
ItemService itemService = new ItemService(itemRepository);

IRepairRepository repairRepository = new RepairRepository(appDbContext);
RepairService repairService = new RepairService(repairRepository);
OwnerService ownerService = new OwnerService(ownerRepository, itemService);
OwnerController ownerController = new OwnerController(ownerService);


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

////ownerController.create(
////    owner
////);

ownerService.UpdateOwner("432432", name: "Ben",surname:"lll",newVAT:"432432"); 
//var fake_owner = ownerService.GetOwnerByVAT(owner.VAT);

//var item = new Item
//{
//    Address = fake_owner.Address,
//    E9 = 5555,
//    TypeOfItem = TypeOfItem.Detached,
//    YearOfConstruction = 2010,
//};

//itemService.create(item);

//var fake_item = itemService.getItemByE9(5555);

//var repair = new Repair
//{
//    Date = DateTime.Now,
//    TypeOfRepair = TypeOfRepair.Painting,
//    Description = "Pumb",
//    Address = "Chania",
//    Cost = 100m,
//    Status = StatusOfRepair.Pending,
//    Item = fake_item,
//};
//repairService.createRepair(repair);
//ownerController.display();

////itemService.create(item);
////ownerController.display();
