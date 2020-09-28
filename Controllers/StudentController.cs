using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class StudentController : Controller
    {
        IList<StudentModel> studentList = new List<StudentModel>() {
                    new StudentModel(){ student_id=1, student_name="Steve", age = 21 },
                    new StudentModel(){ student_id=2, student_name="Bill", age = 25 },
                    new StudentModel(){ student_id=3, student_name="Ram", age = 20 },
                    new StudentModel(){ student_id=4, student_name="Ron", age = 31 },
                    new StudentModel(){ student_id=5, student_name="Rob", age = 19 }
                };
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.TotalStudent = studentList.Count();

            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
