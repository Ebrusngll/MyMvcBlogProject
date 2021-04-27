using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMvcBlog.Models;
using MyMvcBlog.Models.Repository;

namespace MyMvcBlog.Controllers
{
    public class LoginController : Controller
    {
        private readonly MvcContext _context;
        UserRepository userRepository;

        public LoginController(MvcContext context)
        {
            _context = context;
            userRepository = new UserRepository(context);
        }








        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(User user)
        {
            var value = _context.Users.FirstOrDefault(x => x.Mail == user.Mail);
            string mail = value.Mail;

            if (value != null)
            {
                AddCookie(value.Mail);
                return RedirectToAction("Getmailname", "Login", new { mail });
            }
            ViewBag.NotRegister = "COULD NOT FOUND NOW¿¿¿";

            return View();
        }

        public IActionResult Getmailname(string mail)
        {
            //session yaz
            //HttpContext.Session.SetString("Kullanıcı", userName);
            //Cookie yaz


            if (!HttpContext.Request.Cookies.ContainsKey("MailName")
                || HttpContext.Request.Cookies["MailName"] == "")
            {
                HttpContext.Response.Cookies.Append("MailName", mail);

            }


            return RedirectToAction("Index");

        }


        // GET: Login/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Login/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (userRepository.UserIsRegister(user.Mail) == false) 
            {
                if (ModelState.IsValid)
                {
                    
                    try
                    {
                        userRepository.AddUser(user);
                        SendActivaitonMail(user.UserId);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    
                    return RedirectToAction("Confirmation");
                }
                return View(user);
            }
            else
            {
                return RedirectToAction("UserErrorPage");
            }
                
        }
        public ActionResult UserErrorPage()
        {
            return View();
        }

        private void SendActivaitonMail(int userId)
        {
            User user = new User();
            user = userRepository.GetUserById(userId);
            string control = user.UserId.ToString();
            string url = string.Format("{0}://{1}", HttpContext.Request.Scheme, HttpContext.Request.Host) + "/Login/Verify?Id=" + control;
            // localhost Yazar.              // Portu Yazar.
            // Kişiye göndericeğim mesajı oluşturuyorum.
            string message = string.Format("Almost done... Please click to link\n");
            message += url;
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("clients885@gmail.com");

            mail.To.Add(user.Mail);
            mail.Subject = "Deneme";
            mail.Body = message;
            smtpServer.Port = 587;
            smtpServer.Credentials = new NetworkCredential("clients885@gmail.com", "deneme12");
            smtpServer.EnableSsl = true;
            smtpServer.Send(mail);
        }

        public ActionResult Verify(string Id)
        {
            User user = userRepository.GetUserById(int.Parse(Id));
            userRepository.ActivateUser(user);
            userRepository.UpdateUser(user);
            return RedirectToAction("Success");
        }

        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Confirmation()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult MemberPage()  // üyemin sfsı
        {
            return View();
        }


        public ActionResult ErrorPage()
        {
            return View();
        }

        //private void AddCookie(string login)
        //{
        //    Response.Cookies.Append("Mail", login);
        //}  
        private void AddCookie(string login)
        {
            if (Request.Cookies["EMail"] == null)
            {
                HttpContext.Response.Cookies.Append("EMail", login);
            }
        }
        private void DeleteCookie()
        {
            Response.Cookies.Delete("EMail");
        }


        [HttpGet]
        public ActionResult Logout()
        {
            DeleteCookie();
            return RedirectToAction("Index", "HomePageViewModel");
        }

        public ActionResult UserControl(string login)
        {
            if (userRepository.IsUserActive(login))
            {
                AddCookie(login);
                return RedirectToAction("NewMemberPage","HomePageViewModel");
            }
            return RedirectToAction("ErrorPage");
        }
      
        // GET: Login/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Login/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,FullName,UserName,Photo,Mail,Description,Url,UserRole,IsActive")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Login/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        public ActionResult Makale()
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}
