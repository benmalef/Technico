using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Enums;

namespace Technico.Models;

public class Repair
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public TypeOfRepair TypeOfRepair { get; set; }
    public string? Description { get; set; }
    public string? Address { get; set; }
    [Precision(8, 2)]
    public decimal Cost { get; set; }
    public StatusOfRepair Status { get; set; }

    public  Item? Item { get; set; }

}

