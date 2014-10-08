using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;
using System.Text;
namespace Week6CodeChallenge1.Controllers
{
    

    public class ContactController : Controller
    {
        Models.spTylerEntities db = new Models.spTylerEntities();
        //
        // GET: /Contact/
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.ContactMe());
        }

        [HttpPost]
        public ActionResult Index(Models.ContactMe contactForm)
        {
            //sending an email
            //STEP 1: add using System.Net.mail
            //STEP 2: create a new message            from                         too
            MailMessage message = new MailMessage("theDarkSide@seedpaths.com", "tyler.w.annis@gmail.com");
            //STEP 3: set the subject
            message.Subject = "Contact Request from " + contactForm.First_Name;
            //STEP 4: construct the body with a string builder
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("You have a new contact request");
            sb.AppendLine("Name: " + contactForm.First_Name + " " + contactForm.Last_Name);
            sb.AppendLine("Email: " + contactForm.Email);
            sb.AppendLine("Message: " + contactForm.Comment);
            sb.AppendLine("I love you,");
            sb.AppendLine("The Voices in you head");
            //STEP 5: add the body to the string
            message.Body = sb.ToString();

            //STEP 6: declare the SMTP client
            SmtpClient client = new SmtpClient("mail.dustinkraft.com", 587);

            client.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");
            //STEP 7: send the message
            client.Send(message);
            //done
            //redirect
            return PartialView("Thanks");
        }
      

    }
}
