using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplicationProject
{

    /**
    * Class Name : StudentOperationsImpl
    * Objective : To give all methods defination which are prsent in Interface.
    * @author : Ritika jaiswal
    * Date : 15\04\22
    **/
    public class StudentOperationsImpl : IStudentOpertion
    {
        /**
        * Method Name :  getStudentCountGroupByAssignment
        * Objective : To give Student number which are group by Assignment.
        * Input : List Of Student
        * Output : Give the number of student grouped by assignment.
        * Date : 15\04\22
        **/

        public List<StudentCountsByAssignment> getStudentCountGroupByAssignment(List<Student> list)
        {
            Dictionary<string, StudentCountsByAssignment> dic = new Dictionary<string, StudentCountsByAssignment>();
            foreach (Student student in list)
            {
                if (dic.ContainsKey(student.Assignment))
                {
                    StudentCountsByAssignment studentCountsbyAssignment = dic[student.Assignment];
                    studentCountsbyAssignment.NumberOfStudents++;
                }
                else
                {
                    StudentCountsByAssignment StudentCountsByAssignment = new StudentCountsByAssignment();
                    StudentCountsByAssignment.Assignment = student.Assignment;
                    StudentCountsByAssignment.NumberOfStudents++;
                    dic.Add(student.Assignment, StudentCountsByAssignment);
                }
            }
            List<StudentCountsByAssignment> finalResult = new List<StudentCountsByAssignment>();
            foreach (var element in dic)
            {
                finalResult.Add(element.Value);
            }



            return finalResult;

        }

        /**
        * Method Name :  getAssignmentsWithStatus
        * Objective : To give Assignment to the coressponding Status.
        * Input : List Of Student
        * Output : Give the List of assignment to the related status.
        * Date : 15\04\22
        **/
        public List<AssignmentsWithStatus> getAssignmentsWithStatus(List<Student> list)
        {
            Dictionary<Tuple<string, string>, AssignmentsWithStatus> dictionary = new Dictionary<Tuple<string, string>, AssignmentsWithStatus>();
            foreach (Student student in list)
            {

                if (dictionary.ContainsKey(new Tuple<string, string>(student.Assignment, student.Status)))
                {
                    AssignmentsWithStatus assignmentsWithStatus = dictionary[new Tuple<string, string>(student.Assignment, student.Status)];
                    assignmentsWithStatus.Assignment = student.Assignment;
                    assignmentsWithStatus.Numberofstudents++;
                    assignmentsWithStatus.TotalDays += student.Days;
                    assignmentsWithStatus.Status = student.Status;

                }

                else
                {

                    AssignmentsWithStatus assignmentsWithStatus = new AssignmentsWithStatus();
                    assignmentsWithStatus.Assignment = student.Assignment;
                    assignmentsWithStatus.Numberofstudents++;
                    assignmentsWithStatus.TotalDays = student.Days;
                    assignmentsWithStatus.Status = student.Status;
                    dictionary.Add(new Tuple<string, string>(student.Assignment, student.Status), assignmentsWithStatus);


                }
            }
            List<AssignmentsWithStatus> finalResult = new List<AssignmentsWithStatus>();
            foreach (var element in dictionary)
            {
                finalResult.Add(element.Value);
            }

            return finalResult;
        }

        /**
         * Method Name : getStudentCountForAssignmentTaken
         * Objective : Count the student which has Asignment 
         * Input : List Of Student
         * Output : Give the student Number According to Assignent Status.
         * Date : 15\04\22
         **/
        public List<StudentCountForAssignmentTaken> getStudentCountForAssignmentTaken(List<Student> list)
        {
            Dictionary<int, StudentCountForAssignmentTaken> dict = new Dictionary<int, StudentCountForAssignmentTaken>();
            foreach (Student student in list)
            {
                if (dict.ContainsKey(student.Id))
                {
                    StudentCountForAssignmentTaken studentCountForAssignmentTaken = dict[student.Id];
                    studentCountForAssignmentTaken.Count++;
                    studentCountForAssignmentTaken.NumberOfDays += student.Days;
                }
                else
                {
                    StudentCountForAssignmentTaken studentCountForAssignmentTaken = new StudentCountForAssignmentTaken();
                    studentCountForAssignmentTaken.Id = student.Id;
                    studentCountForAssignmentTaken.Name = student.Name;
                    studentCountForAssignmentTaken.Count++;
                    studentCountForAssignmentTaken.NumberOfDays = student.Days;
                    dict.Add(student.Id, studentCountForAssignmentTaken);

                }
            }
            List<StudentCountForAssignmentTaken> finalResult = new List<StudentCountForAssignmentTaken>();
            foreach (var element in dict)
            {
                finalResult.Add(element.Value);
            }

            return finalResult;


        }
    }

}

