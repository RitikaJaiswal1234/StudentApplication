using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplicationProject
{

    /**
    * Class Name : Excuter
    * Objective :It contain main method
    * @author : Ritika jaiswal
    * Date : 15\04\22
    **/
    public class Excuter
    {
        /**
       * Method Name :  Main method
       * Objective : To execute all methods.
       * Input : list of students
       * Output : Gives output to the coressponding method calling.
       * Date : 15\04\22
       **/
        public static void Main(String [] args)
        {
            List<Student> listOfStudent = new List<Student>();
            listOfStudent.Add(new Student(101, "bhanu", "java", "complete", 5));
            listOfStudent.Add(new Student(102, "bhawna", "java", "progress", 3));
            listOfStudent.Add(new Student(103, "sajal", "c#", "complete", 5));
            listOfStudent.Add(new Student(101, "bhanu", "unittest", "notdone", 0));
            listOfStudent.Add(new Student(105, "ritika", "java", "notdone", 0));
            listOfStudent.Add(new Student(104, "uttkarsh", "web", "progress", 4));
            listOfStudent.Add(new Student(105, "ritika", "web", "complete", 6));
            listOfStudent.Add(new Student(104, "uttkarsh", "java", "complete", 8));
            listOfStudent.Add(new Student(101, "bhanu", "c#", "complete", 12));
            listOfStudent.Add(new Student(102, "bhawna", "unittest", "complete", 6));

            StudentOperationsImpl studentOperationsImpl = new StudentOperationsImpl();


            List<StudentCountsByAssignment> finalResult1 = studentOperationsImpl.getStudentCountGroupByAssignment(listOfStudent);
            foreach (StudentCountsByAssignment studentCountsbyAssignment in finalResult1)
            {
                Console.WriteLine(studentCountsbyAssignment);
            }

            Console.WriteLine("***********************************************************************************************");


            List<StudentCountForAssignmentTaken> finalResult2 = studentOperationsImpl.getStudentCountForAssignmentTaken(listOfStudent);
            foreach (StudentCountForAssignmentTaken studentCountForAssignmentTaken in finalResult2)
            {
                Console.WriteLine(studentCountForAssignmentTaken);
            }
            Console.WriteLine("************************************************************************************************");

            List<AssignmentsWithStatus> finalResult3 = studentOperationsImpl.getAssignmentsWithStatus(listOfStudent);
            foreach (AssignmentsWithStatus assignmentsWithStatus in finalResult3)
            {
                Console.WriteLine(assignmentsWithStatus);
            }

        }

    }
}

    

