using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Services;

namespace Technico.Controllers;

 public class RepairController
{
   private readonly  IRepairService repairService;

    public RepairController(IRepairService repairService)
    {
        this.repairService = repairService;
    }
}
