using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UrlControlProject.Models;

namespace UrlControlProject.Controllers
{
    public class HomeController : Controller
    {
        UrlControlDbContext _UrlControlDbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UrlControlDbContext UrlControlDbContext)
        {
            _logger = logger;
            _UrlControlDbContext = UrlControlDbContext;
        }

        long z = 0;

        

        public async Task<IActionResult> Index()
        {
                var count = _UrlControlDbContext.UrlControl.Count();
                List<string> urls = new List<string>();
                List<string> urlNames = new List<string>();
                var url = _UrlControlDbContext.UrlControl.FirstOrDefault().Url;
                urls.Add(url);
                for (int i = 1; i < count; i++)
                {
                    var url2 = _UrlControlDbContext.UrlControl.Skip(i).FirstOrDefault().Url;
                    urls.Add(url2);
                }

                var urlName = _UrlControlDbContext.UrlControl.FirstOrDefault().UrlName;
                urlNames.Add(urlName);
                for (int i = 1; i < count; i++)
                {
                    var urlName2 = _UrlControlDbContext.UrlControl.Skip(i).FirstOrDefault().UrlName;
                    urlNames.Add(urlName2);
                }

                var httpClient = HttpClientFactory.Create();
                List<string> statusCodes = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(urls[i]);
                    //var content = httpResponseMessage.Content;
                    var statusCode = (int)httpResponseMessage.StatusCode;
                    statusCodes.Add(Convert.ToString(statusCode));
                }

                int j = 0;

                ViewData["UrlName"] = urlNames[j];
                ViewData["Url"] = urls[j];
                ViewData["StatusCode"] = statusCodes[j];

                j++;

                ViewData["UrlName2"] = urlNames[j];
                ViewData["Url2"] = urls[j];
                ViewData["StatusCode2"] = statusCodes[j];

                j++;

                ViewData["UrlName3"] = urlNames[j];
                ViewData["Url3"] = urls[j];
                ViewData["StatusCode3"] = statusCodes[j];

                j++;

                ViewData["UrlName4"] = urlNames[j];
                ViewData["Url4"] = urls[j];
                ViewData["StatusCode4"] = statusCodes[j];

                j++;

                ViewData["UrlName5"] = urlNames[j];
                ViewData["Url5"] = urls[j];
                ViewData["StatusCode5"] = statusCodes[j];

                j++;

                ViewData["UrlName6"] = urlNames[j];
                ViewData["Url6"] = urls[j];
                ViewData["StatusCode6"] = statusCodes[j];

                j++;

                ViewData["UrlName7"] = urlNames[j];
                ViewData["Url7"] = urls[j];
                ViewData["StatusCode7"] = statusCodes[j];

                j++;

                ViewData["UrlName8"] = urlNames[j];
                ViewData["Url8"] = urls[j];
                ViewData["StatusCode8"] = statusCodes[j];

                j++;

                ViewData["UrlName9"] = urlNames[j];
                ViewData["Url9"] = urls[j];
                ViewData["StatusCode9"] = statusCodes[j];

                j++;

                ViewData["UrlName10"] = urlNames[j];
                ViewData["Url10"] = urls[j];
                ViewData["StatusCode10"] = statusCodes[j];

                j++;

                ViewData["UrlName11"] = urlNames[j];
                ViewData["Url11"] = urls[j];
                ViewData["StatusCode11"] = statusCodes[j];

                j++;

                ViewData["UrlName12"] = urlNames[j];
                ViewData["Url12"] = urls[j];
                ViewData["StatusCode12"] = statusCodes[j];

                j++;

                ViewData["UrlName13"] = urlNames[j];
                ViewData["Url13"] = urls[j];
                ViewData["StatusCode13"] = statusCodes[j];

                j++;

                ViewData["UrlName14"] = urlNames[j];
                ViewData["Url14"] = urls[j];
                ViewData["StatusCode14"] = statusCodes[j];

                j++;

                ViewData["UrlName15"] = urlNames[j];
                ViewData["Url15"] = urls[j];
                ViewData["StatusCode15"] = statusCodes[j];

                j++;

                ViewData["UrlName16"] = urlNames[j];
                ViewData["Url16"] = urls[j];
                ViewData["StatusCode16"] = statusCodes[j];

                j++;

                ViewData["UrlName14"] = urlNames[j];
                ViewData["Url14"] = urls[j];
                ViewData["StatusCode14"] = statusCodes[j];

                j++;

                ViewData["UrlName15"] = urlNames[j];
                ViewData["Url15"] = urls[j];
                ViewData["StatusCode15"] = statusCodes[j];

                j++;

                ViewData["UrlName16"] = urlNames[j];
                ViewData["Url16"] = urls[j];
                ViewData["StatusCode16"] = statusCodes[j];

                j++;

                ViewData["UrlName17"] = urlNames[j];
                ViewData["Url17"] = urls[j];
                ViewData["StatusCode17"] = statusCodes[j];

                j++;

                ViewData["UrlName18"] = urlNames[j];
                ViewData["Url18"] = urls[j];
                ViewData["StatusCode18"] = statusCodes[j];

                j++;

                ViewData["UrlName19"] = urlNames[j];
                ViewData["Url19"] = urls[j];
                ViewData["StatusCode19"] = statusCodes[j];

                j++;

                ViewData["UrlName20"] = urlNames[j];
                ViewData["Url20"] = urls[j];
                ViewData["StatusCode20"] = statusCodes[j];

                j++;

                ViewData["UrlName21"] = urlNames[j];
                ViewData["Url21"] = urls[j];
                ViewData["StatusCode21"] = statusCodes[j];

                j++;

                ViewData["UrlName22"] = urlNames[j];
                ViewData["Url22"] = urls[j];
                ViewData["StatusCode22"] = statusCodes[j];

                j++;

                ViewData["UrlName23"] = urlNames[j];
                ViewData["Url23"] = urls[j];
                ViewData["StatusCode23"] = statusCodes[j];

                j++;

                ViewData["UrlName24"] = urlNames[j];
                ViewData["Url24"] = urls[j];
                ViewData["StatusCode24"] = statusCodes[j];

                j++;

                ViewData["UrlName25"] = urlNames[j];
                ViewData["Url25"] = urls[j];
                ViewData["StatusCode25"] = statusCodes[j];

                j++;

                ViewData["UrlName26"] = urlNames[j];
                ViewData["Url26"] = urls[j];
                ViewData["StatusCode26"] = statusCodes[j]; j++;

                ViewData["UrlName27"] = urlNames[j];
                ViewData["Url27"] = urls[j];
                ViewData["StatusCode27"] = statusCodes[j];

                j++;

                ViewData["UrlName28"] = urlNames[j];
                ViewData["Url28"] = urls[j];
                ViewData["StatusCode28"] = statusCodes[j];

                j++;

                ViewData["UrlName29"] = urlNames[j];
                ViewData["Url29"] = urls[j];
                ViewData["StatusCode29"] = statusCodes[j];

                j++;

                ViewData["UrlName30"] = urlNames[j];
                ViewData["Url30"] = urls[j];
                ViewData["StatusCode30"] = statusCodes[j];

                j++;

                ViewData["UrlName31"] = urlNames[j];
                ViewData["Url31"] = urls[j];
                ViewData["StatusCode31"] = statusCodes[j];

                j++;

                ViewData["UrlName32"] = urlNames[j];
                ViewData["Url32"] = urls[j];
                ViewData["StatusCode32"] = statusCodes[j];

                j++;

                ViewData["UrlName33"] = urlNames[j];
                ViewData["Url33"] = urls[j];
                ViewData["StatusCode33"] = statusCodes[j];

                j++;

                ViewData["UrlName34"] = urlNames[j];
                ViewData["Url34"] = urls[j];
                ViewData["StatusCode34"] = statusCodes[j];

                j++;

                ViewData["UrlName35"] = urlNames[j];
                ViewData["Url35"] = urls[j];
                ViewData["StatusCode35"] = statusCodes[j]; j++;

                ViewData["UrlName36"] = urlNames[j];
                ViewData["Url36"] = urls[j];
                ViewData["StatusCode36"] = statusCodes[j];

                j++;

                ViewData["UrlName37"] = urlNames[j];
                ViewData["Url37"] = urls[j];
                ViewData["StatusCode37"] = statusCodes[j];

                j++;

                ViewData["UrlName38"] = urlNames[j];
                ViewData["Url38"] = urls[j];
                ViewData["StatusCode38"] = statusCodes[j];

                j++;

                ViewData["UrlName39"] = urlNames[j];
                ViewData["Url39"] = urls[j];
                ViewData["StatusCode39"] = statusCodes[j];

                j++;

                ViewData["UrlName40"] = urlNames[j];
                ViewData["Url40"] = urls[j];
                ViewData["StatusCode40"] = statusCodes[j];

                j++;

                ViewData["UrlName41"] = urlNames[j];
                ViewData["Url41"] = urls[j];
                ViewData["StatusCode41"] = statusCodes[j];

                j++;

                ViewData["UrlName42"] = urlNames[j];
                ViewData["Url42"] = urls[j];
                ViewData["StatusCode42"] = statusCodes[j];

                j++;

                ViewData["UrlName43"] = urlNames[j];
                ViewData["Url43"] = urls[j];
                ViewData["StatusCode43"] = statusCodes[j];

                j++;

                ViewData["UrlName44"] = urlNames[j];
                ViewData["Url44"] = urls[j];
                ViewData["StatusCode44"] = statusCodes[j];

                j++;

                ViewData["UrlName45"] = urlNames[j];
                ViewData["Url45"] = urls[j];
                ViewData["StatusCode45"] = statusCodes[j];

                j++;

                ViewData["UrlName46"] = urlNames[j];
                ViewData["Url46"] = urls[j];
                ViewData["StatusCode46"] = statusCodes[j];

                j++;

                ViewData["UrlName47"] = urlNames[j];
                ViewData["Url47"] = urls[j];
                ViewData["StatusCode47"] = statusCodes[j];

                j++;

                ViewData["UrlName48"] = urlNames[j];
                ViewData["Url48"] = urls[j];
                ViewData["StatusCode48"] = statusCodes[j];

                j++;

                ViewData["UrlName49"] = urlNames[j];
                ViewData["Url49"] = urls[j];
                ViewData["StatusCode49"] = statusCodes[j];

                j++;

                ViewData["UrlName50"] = urlNames[j];
                ViewData["Url50"] = urls[j];
                ViewData["StatusCode50"] = statusCodes[j];

                j++;

                ViewData["UrlName51"] = urlNames[j];
                ViewData["Url51"] = urls[j];
                ViewData["StatusCode51"] = statusCodes[j];

                j++;

                ViewData["UrlName52"] = urlNames[j];
                ViewData["Url52"] = urls[j];
                ViewData["StatusCode52"] = statusCodes[j];

                j++;

                ViewData["UrlName53"] = urlNames[j];
                ViewData["Url53"] = urls[j];
                ViewData["StatusCode53"] = statusCodes[j];

                j++;

                ViewData["UrlName54"] = urlNames[j];
                ViewData["Url54"] = urls[j];
                ViewData["StatusCode54"] = statusCodes[j];

                j++;

                ViewData["UrlName55"] = urlNames[j];
                ViewData["Url55"] = urls[j];
                ViewData["StatusCode55"] = statusCodes[j];



                //j++;

                //ViewData["UrlName56"] = urlNames[j];
                //ViewData["Url56"] = urls[j];
                //ViewData["StatusCode56"] = statusCodes[j];

                //j++;

                //ViewData["UrlName57"] = urlNames[j];
                //ViewData["Url57"] = urls[j];
                //ViewData["StatusCode57"] = statusCodes[j];

                //j++;

                //ViewData["UrlName58"] = urlNames[j];
                //ViewData["Url58"] = urls[j];
                //ViewData["StatusCode58"] = statusCodes[j];




            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
