using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnico.Enums;

namespace Tecnico.Models;

public class Repair
{
    public DateTime Date { get; set; }
    public TypeOfRepair TypeOfRepair { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public decimal Cost { get; set; }
    public StatusOfRepair Status { get; set; }
    public Owner Owner { get; set; }
}

