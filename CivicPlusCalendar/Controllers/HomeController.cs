using CivicPlusCalendar.Models;
using CivicPlusCalendar.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;

namespace CivicPlusCalendar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IAuthenticationService _authenticationService;
        private readonly IEventService _eventService;

        public HomeController(
            ILogger<HomeController> logger, 
            IConfiguration configuration, 
            IAuthenticationService authenticationService,
            IEventService eventService)
        {
            _logger = logger;
            _configuration = configuration;
            _authenticationService = authenticationService;
            _eventService = eventService;

        }

        public IActionResult Index()
        {
            var eventList = _eventService.GetEvents().Result;


            return View(eventList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddEvent(EventViewModel eventModel, string message = "")
        {
            ViewBag.Message = message;
            return View();
        }

        public IActionResult PostEvent(EventViewModel eventModel)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                var startDate = DateTime.Parse(eventModel.StartDate);
                var endDate = DateTime.Parse(eventModel.EndDate);
                if (DateTime.Compare(startDate, endDate) > 0)
                    message = "Error(s) on event submit: The end date must be greater or equal than the start date!";
                else
                {
                    _eventService.PostEvent(eventModel);
                    message = "Success!";
                }
            }
            else
            {
                message = "Error(s) on event submit: ";
                ModelState.Values.ToList().ForEach(value => {
                    if (value.ValidationState != ModelValidationState.Valid)
                    {
                        value.Errors.ToList().ForEach(error => {
                                message += $"{error.ErrorMessage} ";
                        });
                    }
                });
            }

            return RedirectToAction("AddEvent", new { eventModel, message });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
