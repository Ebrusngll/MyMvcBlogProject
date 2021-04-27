using Microsoft.EntityFrameworkCore;
using MyMvcBlog.Models.DtoTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcBlog.Models.Repository
{
    public class ArticleRepository
    {
        User user = new User();
        MvcContext _mvcContext;
        public ArticleRepository(MvcContext context)
        {
            this._mvcContext = context;
        }

        public List<Article> MostReadArticles()
        {
            return GetAllArticle().OrderByDescending(a => a.ReadingCount).ToList();
        }
        public List<Article> OrderByCreatedDate()
        {
            return GetAllArticle().OrderByDescending(a => a.DateOfWriting).ToList();
        }

        public User GetUser(string usermail)
        {
            var user = _mvcContext.Users.Where(a => a.Mail == usermail).FirstOrDefault();
            return user;

        }

        public List<Article>MostReadTopArticles(int sumArticle)
        {
            return MostReadArticles().Take(sumArticle).ToList();
        }



        public bool ReadingCount(Article article)
        {
            Article readenArticle = GetArticleId(article.ArticleId);
            readenArticle.ReadingCount++;
            return _mvcContext.SaveChanges() > 0; 
        }

        public List<Article> GetOrderByArticle() // son yazılana göre sıralama
        {
            return _mvcContext.Articles.OrderByDescending(a => a.DateOfWriting).ToList();
        }


        //Tüm makaleleri getirme
        public List<Article> GetAllArticle()
        {
            return _mvcContext.Set<Article>().ToList();
        }

        //public bool AddArticle(Article article)//Makale ekleme
        //{
        //    if(article.Title == null && article.Content == null)
        //    _mvcContext.Articles.Add(article);                  
        //    return _mvcContext.SaveChanges() > 0;
        //}


        public bool AddArticle(Article article)
        {
            article.ReadingCount = 0;
            article.DateOfWriting = DateTime.Now;
            article.ReadingTime = CalculateReadingTime(article.Content);
            _mvcContext.Articles.Add(article);
            return _mvcContext.SaveChanges() > 0;
        }






        public Article GetArticleId(int Id) // Makaleyi Id ye göre getir.
        {
            return _mvcContext.Articles.SingleOrDefault(a => a.ArticleId == Id);
        }



        public bool DeleteArticle(Article article) // seçilen Makaleyi Id ye göre sildir.
        {
            if (user.UserRole == Enum.UserRole.Member)
            {
                Article selected = GetArticleId(article.ArticleId);
                _mvcContext.Articles.Remove(selected);
            }
            return _mvcContext.SaveChanges() > 0;
        }





        public bool UpdateArticle(Article article)
        {
            if (user.UserRole == Enum.UserRole.Member)
            {
                Article selected = GetArticleId(article.ArticleId);
                selected.Content = article.Content;
                selected.Title = article.Title;
            }
            return _mvcContext.SaveChanges() > 0;
        } // Makale güncelle





        //kişinin makalelerini getirir.
        //public List<Article> UserOfArticle(User user)
        //{
        //    //var list = _mvcContext.UserAndArticles.Where(u => u.UserId == user.UserId);
        //    //var liste = _mvcContext.Articles.Join(list, a => a.ArticleId, l => l.ArticleId, (a, l) => new { a, l }).Select(z => new Article { ArticleId = z.a.ArticleId, Content = z.a.Content, DateOfWriting = z.a.DateOfWriting, Title = z.a.Title });

        //    return liste.ToList();

        //}


        public List<DtoMainPage> dtoMainPages()
        {
            var list = _mvcContext.ArticleAndTopics;
            var liste = _mvcContext.Articles.Join(list, a => a.ArticleId, l => l.ArticleId, (a, l) => new { a, l }).Select(z => new DtoMainPage { DateOfWriting = z.a.DateOfWriting, Title = z.a.Title });
            
            
            return liste.ToList();

        }


        public int CalculateReadingTime(string content)//Dünyada dakikada ortalama 300 kelime okunuyor. Ortalamaya göre okunma süresini hesapla.
        {
            char[] seperator = { };

            int wordsCount = content.Split(seperator, StringSplitOptions.RemoveEmptyEntries).Length;

            if (wordsCount < 300)
            {
                return 1;
            }

            return wordsCount / 300;
        }
    }
}
