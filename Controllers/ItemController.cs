using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Services;

namespace Technico.Controllers;

public class ItemController
{
    private readonly ItemService itemService;
    public ItemController(ItemService itemService)
    {
       this.itemService = itemService;
    }
}
