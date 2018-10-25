using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using LayoutEditor.Models;
using LayoutEditor.Utilities;

namespace LayoutEditor.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public IActionResult Index()
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            string physicalPath = webRootPath + "//data.json";
            using (FileStream fs = new FileStream(physicalPath, FileMode.Open))
            {
                fs.Seek(0,SeekOrigin.Begin);
                byte[] buff = new byte[fs.Length];
                int s = fs.Read(buff, 0, buff.Length);

                if (s > 0)
                {
                    IndexViewModel ivm = new IndexViewModel(Encoding.UTF8.GetString(buff), webRootPath);
                    return View(ivm);
                }
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            
        }
    }
}
