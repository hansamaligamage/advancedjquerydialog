using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jqueryconfirmdialog.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace jqueryconfirmdialog.Controllers
{
    public class HomeController : Controller
    {

        private List<Module> modules = new List<Module>() { new Module {Id = 1, Title = "Frontiers of Physics", Level = "Beginner", Lecturer = "Simon De Silva" },
                new Module { Id = 2, Title = "Quantum Physics", Level = "Beginner", Lecturer = "Simon De Silva" },
                new Module { Id = 3, Title = "Mathematics for Physicists", Level = "Advanced", Lecturer = "Ryan Perera" } };
        List<Resource> imageUrls = new List<Resource>() { new Resource { Id = 1, Url = "http://physicslocker.com/physicslocker/images/physics.jpg" },
            new Resource { Id = 2, Url = "http://physics.uconn.edu/wp-content/uploads/sites/1363/2015/08/physics.png" },
            new Resource { Id = 3, Url = "http://www.aplusphysics.com/assets/images/slide05.png" } };
        List<Resource> videoUrls = new List<Resource>() { new Resource { Id = 1, Url = "https://www.youtube.com/embed/DxQK1WDYI_k" },
            new Resource { Id = 2, Url = "https://www.youtube.com/embed/4xSPlQUejd8" } };

        // GET: /<controller>/
        [Route("/")]
        public IActionResult Index()
        {
            Course course = new Course() { Id = 1, CourseTitle = "Physics", Modules = modules, CourseImageUrls = imageUrls, CourseVideoUrls = videoUrls };
            return View(course);
        }

        public IActionResult RemoveModule(int id)
        {
            Module module = modules.Find(p => p.Id == id);
            if(module != null)
                modules.Remove(module);
            Course course = new Course() { Id = 1, CourseTitle = "Physics", Modules = modules, CourseImageUrls = imageUrls, CourseVideoUrls = videoUrls };
            return View("Index", course);
        }

        public IActionResult RemoveResource(int id, int type)
        {
            if (type == 2) //image
            {
                Resource resource = imageUrls.Find(p => p.Id == id);
                if (resource != null)
                    imageUrls.Remove(resource);
            }
            else if (type == 3) //videos
            {
                Resource resource = videoUrls.Find(p => p.Id == id);
                if (resource != null)
                    videoUrls.Remove(resource);
            }
            Course course = new Course() { Id = 1, CourseTitle = "Physics", Modules = modules, CourseImageUrls = imageUrls, CourseVideoUrls = videoUrls };
            return View("Index", course);
        }

    }
}
