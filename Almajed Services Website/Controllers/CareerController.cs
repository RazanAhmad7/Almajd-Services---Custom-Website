using Almajed_Services_Website.Models;
using Microsoft.AspNetCore.Mvc;

namespace Almajed_Services_Website.Controllers
{
    public class CareerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> SubmitApplication(JobRequests model)
        //{
        //    if (model.ResumeFile == null || model.ResumeFile.Length == 0)
        //    {
        //        ModelState.AddModelError("ResumeFile", "Please upload your resume.");
        //        return View(model); // return to the view if invalid
        //    }

        //    // Validate file type
        //    var allowedTypes = new[] { ".pdf", ".doc", ".docx" };
        //    var extension = Path.GetExtension(model.ResumeFile.FileName).ToLower();

        //    if (!allowedTypes.Contains(extension))
        //    {
        //        ModelState.AddModelError("ResumeFile", "Only PDF, DOC, or DOCX files are allowed.");
        //        return View(model);
        //    }

        //    // Optional: save the file
        //    var filePath = Path.Combine("wwwroot/uploads", model.ResumeFile.FileName);
        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        await model.ResumeFile.CopyToAsync(stream);
        //    }

        //    // You can also save model data to the database here

        //    return RedirectToAction("Success"); // Or wherever you want to go
        //}

    }
}
