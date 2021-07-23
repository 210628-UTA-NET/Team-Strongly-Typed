using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MemeTown.Models;

namespace MemeTown.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Random rnd = new Random();
            int dice = rnd.Next(16);
            string link = "nothing";


            switch (dice)
            {
                case 0:
                    link = "https://www.youtube.com/watch?v=efI4u-54xcQ&ab_channel=DumbestofAllWorlds";
                    break;
                case 1:
                    link = "https://youtu.be/ZUIObCgsfWA";
                    break;
                case 2:
                    link = "https://youtu.be/ZADIyAmQTWg";
                    break;
                case 3:
                    link = "https://youtu.be/TiC8pig6PGE";
                    break;
                case 4:
                    link = "https://youtu.be/ULtHWsLSbSM";
                    break;
                case 5:
                    link = "https://youtu.be/QZShA_a-5r8";
                    break;
                case 6:
                    link = "https://youtu.be/IPNrjRariow";
                    break;
                case 7:
                    link = "https://youtu.be/u1hnBv12-uk";
                    break;
                case 8:
                    link =  "https://youtu.be/C3XQuF21fto";
                    break;
                case 9:
                    link = "https://youtu.be/JSKpsKMTxA8";
                    break;
                case 10:
                    link = "https://youtu.be/hV5G_gwBUXY";
                    break;
                case 11:
                    link = "https://youtu.be/DPEvF8l9LDM";
                    break;
                case 12:
                    link = "https://youtu.be/tRI_Y0UHSeI";
                    break;
                case 13:
                    link = "https://youtu.be/KmBQxtYoiU8";
                    break;
                case 14:   
                    link = "https://youtu.be/UlmXn7Fy4C4";
                    break;
                case 15:
                    link = "https://www.youtube.com/watch?v=3yHL-bb0Z8k&ab_channel=Turbo";
                    break;
                default:
                    link = "https://www.youtube.com/watch?v=o-YBDTqX_ZU";
                    break;


            }
            ViewData["MemeLink"] = link;
            dice = rnd.Next(16);
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
        
    }
}
