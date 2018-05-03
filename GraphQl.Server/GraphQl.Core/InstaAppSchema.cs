using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;

namespace GraphQl.Server.GraphQl.Core
{
    public class InstaAppSchema : Schema
    {
        public InstaAppSchema(UserQuery query, IDependencyResolver dependencyResolver)
        {
            Query = query;
            DependencyResolver = dependencyResolver;
        }
    }
}
