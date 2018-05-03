using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.Server.Model;

namespace GraphQl.Server.Repository
{
    public class UsersRepository
    {
        private readonly List<User> _users = new List<User>();
        private readonly List<Post> _posts = new List<Post>();
        

        public UsersRepository()
        {
            var bob = new User { UserId = 1, Name = "Bob", EmailId = "bob@gmail.com", Picture = @"bob.png", About = "Geek and Coder" };
            var sandy = new User { UserId = 2, Name = "Sandy", EmailId = "sandy@gmail.com", Picture = @"sandy.png", About = "Nerd" };

            var follower1 = new User { UserId = 3, Name = "follower1", EmailId = "follower1@gmail.com", Picture = @"follower1.png", About = "Geek and Coder" };
            var follower2 = new User { UserId = 4, Name = "follower2", EmailId = "follower2@gmail.com", Picture = @"follower2.png", About = "Geek and Coder" };

            _users.Add(bob);
            _users.Add(sandy);
            _users.Add(follower1);
            _users.Add(follower2);

            //_posts
            var allposts = new List<Post>
            {
                new Post {PostId = 1, UserId = 1, Title = "Bob's first post", Description = "Test Desc"},
                new Post {PostId = 2, UserId = 1, Title = "Bob's Second post", Description = "Test Desc"},
                new Post {PostId = 3, UserId = 2, Title = "Sandy's Second post", Description = "Test Desc tes"},
                new Post {PostId = 4, UserId = 2, Title = "Sandy's Second post", Description = "Test Desc"}
            };
            _posts.AddRange(allposts);
        }

        public User GetUserbyId(int userId)
        {
            return _users.FirstOrDefault(x => x.UserId == userId);
        }

        public Post GetPostbyId(int postId)
        {
            return _posts.FirstOrDefault(x => x.PostId == postId);
        }

        public IList<Post> GetPostsByUserId(int userId)
        {
            return _posts.Where(x => x.UserId == userId).ToList();
        }

        public IList<User> GetFollowersbyUserId(int userId)
        {
            return userId == 1 ? 
                _users.Where(_ => _.UserId == 3 || _.UserId == 4).ToList() 
                : new List<User>();
        }

    }
}
