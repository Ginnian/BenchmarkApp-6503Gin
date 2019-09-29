namespace BenchmarkApp_6503Gin
{
    //Staff member object blueprint
    public class Staff
    {
        //Staff attributes
        private string firstName;
        private string lastName;
        private int staffID;
        private string dateOfBirth;
        private string email;
        private float salary;

        //Staff object constructor
        public Staff()
        {
            this.firstName = "NA";
            this.lastName = "NA";
            this.staffID = 0;
            this.dateOfBirth = "18/01/1991";
            this.email = "NA";
            this.salary = 0;
        }

        //Getter and setter for communicating the first name of the staff member
        public string FirstName { get => firstName; set => firstName = value; }

        //Getter and setter for communicating the last name of the staff member
        public string LastName { get => lastName; set => lastName = value; }

        ///Getter and setter for communicating the staff ID of the staff member
        public int StaffID { get => staffID; set => staffID = value; }

        //Getter and setter for communicating the date of birth of the staff member
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        //Getter and setter for communicating the email of the staff member
        public string Email { get => email; set => email = value; }

        //Getter and setter for communicating the salary of the staff member
        public float Salary { get => salary; set => salary = value; }

        //String method for populating text boxes and list views with staff information
        public override string ToString()
        {
            return firstName + " " + lastName + " Staff ID: " + staffID + " DOB: " + dateOfBirth + " Email: " + email + " Salary: $" + salary;
        }
    }
}
