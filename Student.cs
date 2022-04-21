using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplicationProject
{
    /**
     * Class Name : Student
     * Objective : To get & set mock data to the All fields.
     * @author : Ritika jaiswal
     * Date : 15\04\22
     **/
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Assignment { get; set; }
        public string Status { get; set; }
        public int Days { get; set; }

        public Student(int id, string name, string assignment, string status, int days)
        {
            Id = id;
            Name = name;
            Assignment = assignment;
            Status = status;
            Days = days;
        }

    }

    /**
    * Class Name : StudentCountsByAssignment
    * Objective : To get & set those fields which are required to the output field.
    * @author : Ritika jaiswal
    * Date : 15\04\22
    **/
    public class StudentCountsByAssignment
    {
        public string Assignment { get; set; }
        public int NumberOfStudents { get; set; }

        public override string ToString()
        {
            return Assignment + "," + NumberOfStudents;
        }
    }

    /**
    * Class Name :  StudentCountForAssignmentTaken
    * Objective : To get & set those fields which are required to output field.
    * @author : Ritika jaiswal
    * Date : 15\04\22
    **/
    public class StudentCountForAssignmentTaken
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int NumberOfDays { get; set; }
        public override string ToString()
        {
            return Id + "," + Name + "," + Count + "," + NumberOfDays;

        }

    }

    /**
    * Class Name :  AssignmentsWithStatus
    * Objective : To get & set those fields which are required to output field.
    * @author : Ritika jaiswal
    * Date : 15\04\22
    **/
    public class AssignmentsWithStatus
    {
        public string Assignment { get; set; }
        public int Numberofstudents { get; set; }
        public int TotalDays { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return Assignment + "," + Numberofstudents + "," + TotalDays + "," + Status;
        }
    }

    //To set & get Composite key Which are requried to tuple.
    public class AssignmentCompositeStatus
    {
        public string Assignment { get; set; }
        public string Status { get; set; }
    }
}
          
