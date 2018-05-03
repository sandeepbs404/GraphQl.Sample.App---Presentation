using System.Collections.Generic;

namespace GraphQl.Server.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Picture { get; set; }
        public string About { get; set; }
        public IList<User> Followers { get; set; }
        public IList<Post> Posts { get; set; }

        public User()
        {
            Followers = new List<User>();
            Posts = new List<Post>();
        }
    }
}
