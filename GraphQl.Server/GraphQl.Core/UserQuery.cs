using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.Server.Repository;
using GraphQL.Types;

namespace GraphQl.Server.GraphQl.Core
{
    public class UserQuery : ObjectGraphType
    {
        public UserQuery(UsersRepository usersRepository)
        {
            Name = "UsersQuery";
            Field<UserType>("user",
                arguments: new QueryArguments(
                    new QueryArgument<IntGraphType> {Name = "userId", Description = "The ID of the User."}),
                resolve: context =>
                {
                    var userId = context.Arguments["userId"];
                    return usersRepository.GetUserbyId(Convert.ToInt32(userId));
                });
        }
    }
}
