using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MyMvcBlog.Models.Repository
{
    public class TopicRepository
    {
        User user = new User();
        MvcContext _mvcContext;
        public TopicRepository(MvcContext context)
        {
            this._mvcContext = context;
        }

        public bool AddTopic(Topic topic)
        {
            if (user.UserRole == Enum.UserRole.Member)
            {
                _mvcContext.Topics.Add(topic);
            }
            return _mvcContext.SaveChanges() > 0;
        }

        public List<Topic> GetAllTopic()
        {
            return _mvcContext.Set<Topic>().ToList();

        }
        

        public Topic GetTopicId(int id)  // id ye göre getir.
        {
            return _mvcContext.Topics.SingleOrDefault(t => t.TopicId == id);
        }

        public bool DeleteTopic(Topic topic)
        {
            if (user.UserRole == Enum.UserRole.Member)
            {
                Topic selected = GetTopicId(topic.TopicId);
                _mvcContext.Topics.Remove(selected);
            }
            return _mvcContext.SaveChanges() > 0;
        }

        public bool UpdateTopic(Topic topic)
        {
            if (user.UserRole == Enum.UserRole.Member)
            {
                Topic selected = GetTopicId(topic.TopicId);
                selected.Title = topic.Title;
                selected.Photo = topic.Photo;
            }
            return _mvcContext.SaveChanges() > 0;
        }
    }
}
