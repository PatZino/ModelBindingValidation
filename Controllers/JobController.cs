using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBindingValidationS.Models;

namespace ModelBindingValidationS.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(JobApplication jobApplication)
        {

            #region Validation errors
            //if (string.IsNullOrEmpty(jobApplication.Name))
            //    ModelState.AddModelError(nameof(jobApplication.Name), "Please enter your name");
            //else if (jobApplication.Name == "Osama Bin Laden")
            //    ModelState.AddModelError("", "You cannot apply for the Job");

            //if (jobApplication.DOB == Convert.ToDateTime("01-01-0001 00:00:00"))
            //    ModelState.AddModelError(nameof(jobApplication.DOB), "Please enter your Date of Birth");
            //else if (jobApplication.DOB > DateTime.Now)
            //    ModelState.AddModelError(nameof(jobApplication.DOB), "Date of Birth cannot be in the future");
            //else if (jobApplication.DOB < new DateTime(1980, 1, 1))
            //    ModelState.AddModelError(nameof(jobApplication.DOB), "Date of Birth should not be before 1980");

            //if (string.IsNullOrEmpty(jobApplication.Sex))
            //    ModelState.AddModelError(nameof(jobApplication.Sex), "Please select your sex");

            //if (jobApplication.Experience.ToString() == "Select")
            //    ModelState.AddModelError(nameof(jobApplication.Experience), "Please select your experience");

            //if (!jobApplication.TermsAccepted)
            //    ModelState.AddModelError(nameof(jobApplication.TermsAccepted), "You must accept the Terms");
            #endregion

            if (jobApplication.Name == "Osama Bin Laden")
                ModelState.AddModelError(nameof(jobApplication.Name), "You cannot apply for the Job");

            if (jobApplication.DOB > DateTime.Now)
                ModelState.AddModelError(nameof(jobApplication.DOB), "Date of Birth cannot be in the future");
            else if (jobApplication.DOB < new DateTime(1980, 1, 1))
                ModelState.AddModelError(nameof(jobApplication.DOB), "Date of Birth should not be before 1980");

            if (ModelState.IsValid)
                return View("Accepted", jobApplication);
            else
                return View();
        }
    }
}