using GraphQl.Server.Model;
using GraphQl.Server.Repository;
using GraphQL.Language.AST;
using GraphQL.Types;

namespace GraphQl.Server.GraphQl.Core
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType(UsersRepository usersRepository)
        {
            Name = "User";
            Field(_ => _.UserId).Description("User Id of User");
            Field(_ => _.Name).Description("Name Id of User");
            Field(_ => _.EmailId).Description("EmailId Id of User");
            Field(_ => _.About).Description("About Id of User");
            Field(_ => _.Picture).Description("Picture Id of User");
            Field<ListGraphType<PostType>>("posts",
                resolve: context => usersRepository.GetPostsByUserId(context.Source.UserId));
            Field<ListGraphType<UserType>>("followers",
                resolve: context => usersRepository.GetFollowersbyUserId(context.Source.UserId));
        }
    }
}
