using System.Collections.Generic;
using System.Linq;
using AspCoreGraphQL.Contracts;

public class OwnerRepository:IOwnerRepository
{
    private readonly ApplicationContext _context;

    public OwnerRepository(ApplicationContext context)
    {
        _context=context;
    }

    public IEnumerable<Owner> GetAll() => _context.Owners.ToList();
}