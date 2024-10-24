using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnico.Enums;

namespace Tecnico.Models;

public class Item
{
    public long ID { get; set; }
    public string Address { get; set; }
    public int YearOfConstruction { get; set; }
    public Owner Owner { get; set; }
    public TypeOfItem TypeOfItem { get; set; }
}