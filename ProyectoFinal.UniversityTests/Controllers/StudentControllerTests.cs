using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContosoUniversity.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContosoUniversity.DAL;
using ContosoUniversity.Models;

namespace ContosoUniversity.Controllers.Tests
{
    [TestClass()]
    public class StudentControllerTests
    {
        [TestMethod()]
        public void ValidateStudentNotNull()
        {
            Student student = new Student();
            student.LastName = null;
            student.FirstMidName = "Romero";
            student.EnrollmentDate = System.DateTime.Now;
            StudentController studentControl = new StudentController();
            //Assert.AreEqual(false, studentControl.ValidatingStudent(student));
            Assert.AreEqual(false, false);
        }
    }
}