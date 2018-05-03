using GraphQl.Server.Model;
using GraphQL.Types;

namespace GraphQl.Server.GraphQl.Core
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Name = "Post";
            Description = "User Post";
            Field(_ => _.UserId).Description("User Id of the Post");
            Field(_ => _.PostId).Description("Post Id of the Post");
            Field(_ => _.Title).Description("Title Id of the Post");
            Field(_ => _.Description);
        }
    }
}
