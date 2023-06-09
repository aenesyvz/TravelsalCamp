﻿using Business.Abstract;
using Entities.Concretes;
using Entities.DTOs.ContactDTOs;
using Microsoft.AspNetCore.Mvc;

namespace TravelsalCamp.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.Add(
                        new ContactUs()
                        {
                            MessageBody = model.MessageBody,
                            Mail = model.Mail,
                            MessageStatus = true,
                            Name = model.Name,
                            Subject = model.Subject,
                            MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                        }
                );

                return RedirectToAction("Index", "Default");
            }
            return View(model);
        }
    }
}
