using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BenchmarkApp_6503Gin;
using System.Collections.Generic;

namespace BMUnitTests
{
    [TestClass]
    public class StaffUnitTests
    {
        [TestMethod]
        public void TestStaffFirstName()
        {
            Staff c = new Staff();

            c.FirstName = "Fluffy";

            Assert.AreEqual("Fluffy", c.FirstName);
        }

        [TestMethod]
        public void TestStaffLastName()
        {
            Staff c = new Staff();

            c.LastName = "Fluffy";

            Assert.AreEqual("Fluffy", c.LastName);
        }

        [TestMethod]
        public void TestStaffID()
        {
            Staff c = new Staff();

            c.StaffID = 1;

            Assert.AreEqual(1, c.StaffID);
        }

        [TestMethod]
        public void TestDateOfBirth()
        {
            Staff c = new Staff();

            c.DateOfBirth = "18/01/1991";

            Assert.AreEqual("18/01/1991", c.DateOfBirth);
        }

        [TestMethod]
        public void TestStaffEmail()
        {
            Staff c = new Staff();

            c.Email = "gin@gin.com";

            Assert.AreEqual("gin@gin.com", c.Email);
        }

        [TestMethod]
        public void TestStaffSalary()
        {
            Staff c = new Staff();

            c.Salary = 1;

            Assert.AreEqual(1, c.Salary);
        }

        [TestMethod]
        public void TestStaffConstructor()
        {
            Staff c = new Staff();

            Assert.AreEqual("NA", c.FirstName, "First name Fail");
            Assert.AreEqual("NA", c.LastName, "Last name Fail");
            Assert.AreEqual(0, c.StaffID, "Staff ID Fail");
            Assert.AreEqual("18/01/1991", c.DateOfBirth, "Date of birth Fail");
            Assert.AreEqual("NA", c.Email, "Email Fail");
            Assert.AreEqual(0, c.Salary, "Salary Fail");
        }

        [TestMethod]
        public void TestStaffToStringFormat()
        {
            Staff c = new Staff
            {
                FirstName = "Gin",
                LastName = "Waikari",
                StaffID = 1,
                DateOfBirth = "18/01/1991",
                Email = "gin@gin.com",
                Salary = 0
            };

            Assert.AreEqual("Gin Waikari Staff ID: 1 DOB: 18/01/1991 Email: gin@gin.com Salary: $0", c.ToString());
        }
    }

    [TestClass]
    public class FilterUnitTests
    {
        [TestMethod]
        public void TestFilterSortAZ()
        {
            Staff c1 = new Staff()
            {
                FirstName = "first1",
                LastName = "last1",
                StaffID = 0,
                DateOfBirth = "18/01/1991",
                Email = "gin@gin.com",
                Salary = 0
            };

            Staff c2 = new Staff()
            {
                FirstName = "first2",
                LastName = "last2",
                StaffID = 0,
                DateOfBirth = "18/01/1991",
                Email = "gin@gin.com",
                Salary = 0
            };

            Staff c3 = new Staff()
            {
                FirstName = "first3",
                LastName = "last3",
                StaffID = 0,
                DateOfBirth = "18/01/1991",
                Email = "gin@gin.com",
                Salary = 0
            };

            Staff c4 = new Staff()
            {
                FirstName = "first4",
                LastName = "last4",
                StaffID = 0,
                DateOfBirth = "18/01/1991",
                Email = "gin@gin.com",
                Salary = 0
            };

            List<Staff> cListExpected = new List<Staff>();

            cListExpected.Add(c1);
            cListExpected.Add(c2);
            cListExpected.Add(c3);
            cListExpected.Add(c4);

            List<Staff> cList = new List<Staff>();

            cList.Add(c3);
            cList.Add(c2);
            cList.Add(c4);
            cList.Add(c1);

            Filter f = new Filter();

            cList = f.SortAZ(cList);

            CollectionAssert.AreEqual(cListExpected, cList);
        }

        [TestMethod]
        public void TestFilterSortZA()
        {
            Staff c1 = new Staff()
            {
                FirstName = "first1",
                LastName = "last1",
                StaffID = 0,
                DateOfBirth = "18/01/1991",
                Email = "gin@gin.com",
                Salary = 0
            };

            Staff c2 = new Staff()
            {
                FirstName = "first2",
                LastName = "last2",
                StaffID = 0,
                DateOfBirth = "18/01/1991",
                Email = "gin@gin.com",
                Salary = 0
            };

            Staff c3 = new Staff()
            {
                FirstName = "first3",
                LastName = "last3",
                StaffID = 0,
                DateOfBirth = "18/01/1991",
                Email = "gin@gin.com",
                Salary = 0
            };

            Staff c4 = new Staff()
            {
                FirstName = "first4",
                LastName = "last4",
                StaffID = 0,
                DateOfBirth = "18/01/1991",
                Email = "gin@gin.com",
                Salary = 0
            };

            List<Staff> cListExpected = new List<Staff>();

            cListExpected.Add(c1);
            cListExpected.Add(c2);
            cListExpected.Add(c3);
            cListExpected.Add(c4);

            List<Staff> cList = new List<Staff>();

            cList.Add(c3);
            cList.Add(c2);
            cList.Add(c4);
            cList.Add(c1);

            Filter f = new Filter();

            cList = f.SortAZ(cList);

            CollectionAssert.AreEqual(cListExpected, cList);
        }

        [TestMethod]
        public void TestFilterSearch()
        {
            Staff c1 = new Staff()
            {
                FirstName = "Fluffy"
            };

            Staff c2 = new Staff()
            {
                FirstName = "Butch"
            };

            Staff c3 = new Staff()
            {
                FirstName = "Buggs"
            };

            Staff c4 = new Staff()
            {
                FirstName = "Frankie"
            };

            List<Staff> cList = new List<Staff>();

            cList.Add(c3);
            cList.Add(c2);
            cList.Add(c4);
            cList.Add(c1);

            Filter f = new Filter();

            List<Staff> searchResults = new List<Staff>();

            searchResults = f.Search(cList, "u");

            CollectionAssert.Contains(searchResults, c1);
            CollectionAssert.Contains(searchResults, c2);
            CollectionAssert.Contains(searchResults, c3);
            CollectionAssert.DoesNotContain(searchResults, c4);
        }
    }
}
