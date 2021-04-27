using Microsoft.EntityFrameworkCore;
using MyMvcBlog.Models.DtoTables;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyMvcBlog.Models.Repository
{
    public class UserRepository
    {
        User user = new User();
        MvcContext _mvcContext;
        public UserRepository(MvcContext context)
        {
           this._mvcContext = context;
        }


        //public List<UserAndArticle> GetUserArticle(int id)  //kullanıcının kendine ait makaleleri  --- kim biliyor kullanıcı biliyor o yüzden user reposunda.
        //{


        //    return _mvcContext.UserAndArticles.Include(a => a.UserId == id).Include(a => a.Article).ToList();

        //}

        public bool IsUserActive(string mail)
        {
            if(_mvcContext.Users.Where(a=>a.Mail==mail && a.IsActive).FirstOrDefault() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UnActiveUser(User user)
        {
            User unActiveUser = GetUserById(user.UserId);
            unActiveUser.IsActive = false;
            return _mvcContext.SaveChanges() > 0;
        }  //Unaactivate yapmak için

        public bool ActivateUser(User user)  // Activate yapmak için
        {
            User activateUser = GetUserById(user.UserId);
            activateUser.IsActive = true;
            return _mvcContext.SaveChanges() > 0;
        }

        public User GetUserById(int id)  //user ID ti getirme
        {
            return _mvcContext.Users.SingleOrDefault(u => u.UserId == id);
        }

        public bool UserIsRegister(string mail)
        {
            if(_mvcContext.Users.Where(a=>a.Mail== mail).FirstOrDefault() != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddUser(User user) // user ekleme
        {
            string userName = CreateNewUserName(user.Mail);
            user.FullName = userName;
            user.UserName = userName;
            user.Url = "https://medium.com/" + user;
            user.IsActive = false;
            user.UserRole = Enum.UserRole.Member;
            IsValidEmail(user.Mail);
            _mvcContext.Users.Add(user);
            return _mvcContext.SaveChanges() > 0;
        }

        private string CreateNewUserName(string createUserName) // mailden isim getirme
        {
            string userName = "";
            for (int i = 0; i < createUserName.Length; i++)
            {
                if (createUserName[i] != '@')
                {
                    userName += createUserName[i].ToString();
                }
                else
                {
                    break;
                }
            }
            return userName;
        }

        public bool UpdateUser(User user)  // user güncelleme
        {
            User updateUser = GetUserById(user.UserId);
            string userName = CreateNewUserName(user.UserName);
            updateUser.Description = user.Description;
            updateUser.IsActive = user.IsActive;
            updateUser.Photo = user.Photo;
            updateUser.Mail = user.Mail;
            updateUser.Url = "https://medium.com/" + userName;
            updateUser.UserName = user.UserName;
            return _mvcContext.SaveChanges() > 0;
        }

        public bool Delete(User user)  // user silme
        {
            _mvcContext.Users.Remove(GetUserById(user.UserId));
            return _mvcContext.SaveChanges() > 0;
        }

        public List<User> AllUsers()  // tüm userları getir.
        {
            return _mvcContext.Set<User>().ToList();
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {             
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
                    string domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }


        // SORRRRRRRRRRRRR

        // kullanıcının takip ettiği konularla ilgili makaleler

        //public List<DtoUserFollowArticleAndTopic> dtoUserFollowArticleAndTopics(int id)
        //{
        //    List<int> topicId = _mvcContext.UserAndTopics.Include(a => a.User).Include(a => a.Topic).Where(a => a.User.UserId == id).Select(a => a.Topic.TopicId).ToList();  // userlarımın topicleri 

        //    List<ArticleAndTopic> makalelerveKonulari = _mvcContext.ArticleAndTopics.Include(a => a.Article).ToList();

        //    List<DtoUserFollowArticleAndTopic> sonuc = new List<DtoUserFollowArticleAndTopic>();

        //    foreach (var item in makalelerveKonulari)
        //    {
        //        foreach (int item2 in topicId)
        //        {
        //            if (item.TopicId == item2)
        //            {
        //                item.Topic.TopicId = item2;

        //                sonuc.ToList();
        //            }

        //        }
        //    }
        //}

    }
}
