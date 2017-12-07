using AjaxForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxForm.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        
        public PartialViewResult Test()
        {
            List<TestViewModel> modelList = new List<TestViewModel>();

            string letters = "ABCDEFGHIJKLMNOPQRSTUVXYZabcdefghijklmnopqrstuvxyz0123456789!#%&/()=?@£$€{[]}\\";

            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                string name = "";

                for (int u = 0; u < 10; u++)
                {
                    name += letters.Substring(rand.Next(78), 1);
                }

                TestViewModel temp = new TestViewModel() { ID = i, Name = name };

                modelList.Add(temp);
            }

            return PartialView(modelList);
        }
    }
}