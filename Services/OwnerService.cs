using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnico.Models;
using System.Linq;
using Tecnico.Repositories;
namespace Tecnico.Services;

public class OwnerService
{
    private readonly IOwnerRepository _ownerRepository;
     
    public OwnerService(IOwnerRepository ownerRepository)
    {
        _ownerRepository = ownerRepository;
    }


    //todo: Create Method
    public void createOwner(Owner owner)
    {
        _ownerRepository.InsertOwner(owner);
    }
    public bool deleteOwner(int id)
    {
      return  _ownerRepository.Delete(id);
    }

    public List<Owner> get_owners()
    {
        return _ownerRepository.GetOwners().ToList();
    }

    public Owner findOwnerById(int id)
    {
        return _ownerRepository.GetOwnerByID(id); 
        
    }

}

