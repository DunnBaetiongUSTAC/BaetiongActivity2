using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaetiongActivity2.Controllers
{
    public class BaetiongController : Controller
    {
        // GET: Baetiong
        public string MySelf()
        {
            return "My Name Is Dunn Lester, I am 20 Years Old and im am enrolled as a BSIT Student";
        }
        public string date(int mm, int dd, int yyyy)
        {
            return "Today is " + mm + " " + dd + " " + yyyy;
        }
        public string me(string name, int age)
        {
            return "I am " + name + ". " + "I am " + age + " years old";
        }
    }
}