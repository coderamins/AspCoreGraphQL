using System.Collections.Generic;

namespace AspCoreGraphQL.Contracts
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> GetAll();
    }
}