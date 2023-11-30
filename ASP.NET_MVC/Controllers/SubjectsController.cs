using ASP.NET_MVC.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace ASP.NET_MVC.Controllers {
    public class SubjectsController : Controller {
        public StudentsController(StudentService studentService) {
            this.service = studentService;
        }
    }
}

