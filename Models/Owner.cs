using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnico.Enums;

namespace Tecnico.Models;

public record Owner(

     int VAT,
     int ID,
     string Name,
     string Surname,
     string Address,
     int Phone,
     string Email,
     string Password,
     Users TypeOfUser
);
