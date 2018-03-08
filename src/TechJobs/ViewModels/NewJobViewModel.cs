using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Data;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class NewJobViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Employer")]
        public int EmployerID { get; set; }
      

        // TODO #3 - Included other fields needed to create a job,
        // with correct validation attributes and display names.

        [Required]
        [Display(Name = "Employer")]
        public List<SelectListItem> Employers { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Location")]
        public List<SelectListItem> Locations { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Core Competency")]
        public List<SelectListItem> CoreCompetencies { get; set; } = new List<SelectListItem>();

        [Required]
        [Display(Name = "Position Type")]
        public List<SelectListItem> PositionTypes { get; set; } = new List<SelectListItem>();

        public NewJobViewModel()
        {

            JobData jobData = JobData.GetInstance();

            foreach (Employer field in jobData.Employers.ToList())
            {
                Employers.Add(new SelectListItem {
                    Value = field.ID.ToString(),
                    Text = field.Value
                });
            }

            // TODO #4 - populate the other List<SelectListItem> 
            // collections needed in the view

        }
    }
}
