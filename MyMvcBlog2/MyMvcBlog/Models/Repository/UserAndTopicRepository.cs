using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models.Repository
{
    public class UserAndTopicRepository
    {
        MvcContext _mvcContext;

        public UserAndTopicRepository(MvcContext context)
        {
            this._mvcContext = context;
        }

        public bool Add(List<UserAndTopic> userAndTopics)
        {
            // AddRange Diğer koleksiyon tabanlı nesneleri ya da dizileri ArrayList içerisine aktarır.
            _mvcContext.UserAndTopics.AddRange(userAndTopics);
            return _mvcContext.SaveChanges() > 0;
        }

        public bool Delete(List<UserAndTopic> userAndTopics)
        {
            _mvcContext.UserAndTopics.RemoveRange(userAndTopics);
            return _mvcContext.SaveChanges() > 0;
        }

        public bool Add(UserAndTopic userAndTopic)
        {
            _mvcContext.UserAndTopics.Add(userAndTopic);
            return _mvcContext.SaveChanges() > 0;
        }

        public bool Delete(UserAndTopic userAndTopic)
        {
            _mvcContext.UserAndTopics.Remove(userAndTopic);
            return _mvcContext.SaveChanges() > 0;
        }


        //userlarımın Konuları
       public List<User>UsersFollowTopic(Topic topic)
        {
            var list = _mvcContext.UserAndTopics.Include(a => a.Topic).Where(a => a.TopicId == topic.TopicId);
            List<User> users = new List<User>();
            foreach (var item in list)
            {
                users.Add(item.User);
            }
            return users;
        }



        // konularımın userları
        public List<Topic>TopicFolowUser(User user)
        {
            var list = _mvcContext.UserAndTopics.Include(a => a.User).Where(a => a.UserId == user.UserId);
            List<Topic> topics = new List<Topic>();
            foreach (var item in list)
            {
                topics.Add(item.Topic);
            }
            return topics;  
        }

        

        

    }
}
