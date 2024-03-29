﻿using MVC6amNaturalsBatch.Filter;
using MVC6amNaturalsBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC6amNaturalsBatch.Controllers
{

    public class NewController : Controller
    {
        // GET: New
        public string Index(int? id)
        {
            string a = Index2();
            return a;
        }
        [NonAction]
        public string Index2()
        {
            return "Hello World2";
        }

        public string Index3(int id, string name, string designation)
        {

            return "My Id is " + id + " and Name is " + name + " and designation is " + designation;
        }


        public ViewResult GetmeView()
        {
            return View();
        }

        [Route("jungle/tiger")]
        [Route("jungle/Lion")]
        [Route("jungle/cheetah/{number}")]
        [Route("jungle/rabbit")]
        [Route("jungle/Monkey/{number}")]
        public string Index4(int? number)
        {
            return "Hello World " + number;
        }

        public ActionResult GetEmployee()
        {

            ViewBag.name = "James";
            return View();
        }

        public ActionResult GetEmployee2()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 210000;

            ViewBag.emp = emp;

            return View();
        }

        public ActionResult GetEmployee3()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 210000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Alicia";
            emp1.EmpSalary = 310000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Jessica";
            emp2.EmpSalary = 410000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            ViewBag.Employees = listEmp;


            return View();
        }

        public ActionResult GetEmployee4()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "naveena";
            emp.EmpSalary = 210000;


            //object model=emp
            return View(emp);
        }


        public ActionResult GetEmployee5()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 210000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Alicia";
            emp1.EmpSalary = 310000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Jessica";
            emp2.EmpSalary = 410000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            return View(listEmp);
        }

        public ActionResult GetEmployee6()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 210000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Alicia";
            emp1.EmpSalary = 310000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Jessica";
            emp2.EmpSalary = 410000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            List<DepartmentModel> listDept = new List<Models.DepartmentModel>();

            DepartmentModel dept1 = new Models.DepartmentModel();
            dept1.DeptId = 1211;
            dept1.DeptName = "IT";
            DepartmentModel dept2 = new Models.DepartmentModel();
            dept2.DeptId = 1212;
            dept2.DeptName = "Hr";


            listDept.Add(dept1);
            listDept.Add(dept2);

            EmpDept ed = new EmpDept();
            ed.emp = listEmp;
            ed.dept = listDept;


            return View(ed);//object model
        }

        public RedirectResult goToGoogle()
        {
            return Redirect("http://www.google.com");
        }
        public RedirectResult goToanotherMethod()
        {
            return Redirect("~/new/GetEmployee6");
        }

        public ActionResult GetPartialView()
        {
            return View();
        }

        public ActionResult GetPartialView2()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 210000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Alicia";
            emp1.EmpSalary = 310000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Jessica";
            emp2.EmpSalary = 410000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            return View(listEmp);
        }

        public PartialViewResult GetPartialView3()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 210000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Alicia";
            emp1.EmpSalary = 310000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Jessica";
            emp2.EmpSalary = 410000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            return PartialView("_GetAllEmployeesPartialView", listEmp);
        }

        public JsonResult GetJEmployeeJsonData()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();


            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "James";
            emp.EmpSalary = 210000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Alicia";
            emp1.EmpSalary = 310000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Jessica";
            emp2.EmpSalary = 410000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);


            return Json(listEmp, JsonRequestBehavior.AllowGet);//javascript object notation 
        }

        public ViewResult AccessEmployeeJsonData()
        {
            return View();
        }

        public FileResult GetMeFile()
        {
            return File("~/Web.config","text", "Web.config");
        }
        public FileResult GetMeFile2()
        {
            return File("~/Web.config", "application/xml");
        }

        public ContentResult getContent(int? id)
        {
            if (id == 1)
            {
                return Content("Hello World");

            }
            else if (id == 2)
            {
                return Content("<p style='color:red;'>Hello World</p>");
            }
            else
            {
                return Content("<script>alert('Hello World')</script>");
            }
        }

        public RedirectToRouteResult getRoute()
        {
            return RedirectToRoute("asdfasdf");
        }

        public RedirectToRouteResult getRoute2()
        {
            return RedirectToAction("index","new",new {id=2 });
        }

        public ActionResult HtmlHelperExample()
        {
            StateEntities db = new Models.StateEntities();
            EmployeeModel emp = new EmployeeModel();
            emp.EmpName = "Shruti";
            ViewBag.StateDet = new SelectList(db.States, "Id", "StateName",3);
            return View(emp);
        }

        public ActionResult RegistrationModel()
        {
            StateEntities db = new Models.StateEntities();

            ViewBag.StateDet = new SelectList(db.States, "Id", "StateName", 3);

            return View();
        }

        [HttpPost]
        public ActionResult RegistrationModel(Register reg)
        {
            StateEntities db = new Models.StateEntities();

            ViewBag.StateDet = new SelectList(db.States, "Id", "StateName", 3);

            return View(reg);
        }

        public JsonResult getDropdowncity(int? StateId)
        {
            string City = string.Empty;
            if (StateId == 1) {
                City = "abc City";
            }
            else
            {
                City = "xyz city";
            }

            return Json(City,JsonRequestBehavior.AllowGet);
        }
        [CustomFilter]

        public ActionResult UserDefinedControl()
        {
            return View();
        }
        public ActionResult ValidationExample()
        {
      
            return View();
        }

        [HttpPost]
        public ActionResult ValidationExample(RegistrationForm reg)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("UserDefinedControl");
            }
            else
            {
                return View(reg);
            }
        }

        [CustomFilter]
        public ActionResult TestFilter()
        {
            ViewBag.WinIPL="RCB";

            return View();
        }
    }
}