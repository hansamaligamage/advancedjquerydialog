using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jqueryconfirmdialog.ViewModels
{
    public class Course
    {

        public int Id { get; set; }

        public string CourseTitle { get; set; }
        public List<Module> Modules { get; set; }

        public List<Resource> CourseImageUrls { get; set; }
        public List<Resource> CourseVideoUrls { get; set; }

    }

    public class Module
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Level { get; set; }

        public string Lecturer { get; set; }

    }

    public class Resource
    {
        public int Id { get; set; }

        public string Url { get; set; }
    }

}
