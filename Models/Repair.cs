using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnico.Enums;

namespace Tecnico.Models;

public record Repair(
    DateTime Date,
    TypeOfRepair TypeOfRepair,
    string Description,
    string Address,
    decimal Cost,
    StatusOfRepair status,
    Owner Owner
    );

