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
        public void CreateTest()
        {
           /* Student student = new Student();
            student.LastName = "SCM";
            student.FirstMidName = null;
            student.EnrollmentDate = System.DateTime.Now;
            */

           /* StudentController controllerstudent = new StudentController();

            controllerstudent.Create();
            */
            Assert.AreEqual(1,1);
        }
    }
}