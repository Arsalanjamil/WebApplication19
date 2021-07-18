using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class DepartmentController : Controller
    {
        //private readonly AppDbContext context;

        //public DepartmentController(AppDbContext context)
        //{
        //    this.context = context;
        //}

        //[HttpPost]
        ////[Route("Department/Save")]
        //public IActionResult Save([FromBody] Department department)
        //{
        //    if (department.DepartmentID == 0)
        //    {
        //        context.Departments.Add(department);
        //    }
        //    else
        //    {
        //        var dep = context.Departments.Attach(department);
        //        dep.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    }
        //    context.SaveChanges();

        //    //return department;
        //    return Json(department);
        //}

        //[HttpDelete]
        ////[Route("Department/delete/{id}")]
        //public IActionResult delete(int id)
        //{
        //    Department department = context.Departments.Find(id);
        //    if (department != null)
        //    {
        //        context.Departments.Remove(department);
        //        context.SaveChanges();
        //    }
        //    return Json(department);
        //}


        //public IActionResult GetAllDepartment(int id)
        //{
        //    if (id == 0)
        //    {
        //        return Json(context.Departments);
        //    }
        //    return Json(context.Departments.Find(id));
        //}

    }
}