using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using StudentFeedbackWithAuth.Models;
using StudentFeedbackWithAuth.ViewModels;

namespace StudentFeedbackWithAuth.Controllers
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
            string requestUrl = "https://opinionated-quotes-api.gigalixirapp.com/v1/quotes?tags=science";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(requestUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            var content = readStream.ReadToEnd();
            var contentJson = JsonConvert.DeserializeObject<dynamic>(content);
            var quotes = contentJson.quotes[0];

            response.Close();
            readStream.Close();

            QuoteOfTheDayViewModel quote = new QuoteOfTheDayViewModel()
            {
                Quote = quotes.quote,
                Author = quotes.author
            };

            return View(quote);
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
