using AspCoreGraphQL.Contracts;

public class OwnerRepository:IOwnerRepository
{
    private readonly ApplicationContext _context;

    public OwnerRepository(ApplicationContext context)
    {
        _context=context;
    }
}