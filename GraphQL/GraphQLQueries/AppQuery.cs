using AspCoreGraphQL.Contracts;
using GraphQL.Types;

public class AppQuery:ObjectGraphType
{
    public AppQuery(IOwnerRepository repository)
    {
        Field<ListGraphType<OwnerType>>(
            "owners",
            resolve:context=>repository.GetAll()
        );
    }
}