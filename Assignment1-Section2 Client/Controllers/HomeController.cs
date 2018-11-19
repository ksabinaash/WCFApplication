using Assignment1_Section2_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace WCFClient.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult JobOpenings()
        {
            Assignment1_Section2_Client.JobService.JobServiceClient client = new Assignment1_Section2_Client.JobService.JobServiceClient("BasicHttpBinding_IJobService");
            List<JobOpenings> openings = new List<JobOpenings>();
            var response = client.OpeningJobs();
            foreach (var item in response)
            {
                JobOpenings opening = new JobOpenings();
                opening.opening = item.Value;
                opening.role = item.Key;
                openings.Add(opening);
            }
            return View(openings);
        }

        public ActionResult JobOpeningsByRole(string role)
        {
            Assignment1_Section2_Client.JobService.JobServiceClient client = new Assignment1_Section2_Client.JobService.JobServiceClient("BasicHttpBinding_IJobService");
            JobOpenings openings = new JobOpenings();
            openings.role = role;
            openings.opening = client.OpeningJobsByRole(role);
            return View(openings);
        }
    }
}