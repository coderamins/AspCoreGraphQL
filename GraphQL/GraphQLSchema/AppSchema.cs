using GraphQL.Types;
using System;

public class AppSchema : Schema
{
    public AppSchema(IServiceProvider resolver)
        : base(resolver)
    {
        //Query = resolver.<AppQuery>();
    }
}