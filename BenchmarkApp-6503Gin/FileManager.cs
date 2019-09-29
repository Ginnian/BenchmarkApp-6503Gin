using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BenchmarkApp_6503Gin
{
    //Class used for storing and retrieving staff data
    class FileManager
    {
        //Method for loading all staff from a file and storing the data in a list of staff objects
        public List<Staff> LoadStaff()
        {
            try
            {
                List<Staff> staffList = new List<Staff>();

                StreamReader sr = new StreamReader("Staff.txt");

                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();
                    string[] values = temp.Split(',');

                    Staff c = new Staff()
                    {
                        FirstName = values[0],
                        LastName = values[1],
                        StaffID = int.Parse(values[2]),
                        DateOfBirth = values[3],
                        Email = values[4],
                        Salary = int.Parse(values[5])
                    };

                    staffList.Add(c);
                }

                sr.Dispose();

                return staffList;
            }
            catch (Exception)
            {
                return null;
            }

        }

        //Method for saving staff information to a text file
        public bool SaveStaff(Staff c, string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName);

                sw.WriteLine("STAFF DETAILS");
                sw.WriteLine("Name: " + c.FirstName + " " + c.LastName);
                sw.WriteLine("ID: " + c.StaffID);
                sw.WriteLine("DOB: " + c.DateOfBirth);
                sw.WriteLine("Email: " + c.Email);
                sw.WriteLine("Salary: $" + c.Salary);

                sw.Dispose();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
