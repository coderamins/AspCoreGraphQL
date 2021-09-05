using AspCoreGraphQL.Contracts;

public class AccountRepository:IAccountRepository
{
    private readonly ApplicationContext _context;

    public AccountRepository(ApplicationContext context)
    {
        _context=context;
    }
}