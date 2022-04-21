using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplicationProject
{
    /**
    * Interface Name : IStudentOpertion
    * Objective : To give all methods decleration which are used in implementation.
    * @author : Ritika jaiswal
    * Date : 15\04\22
    **/
    internal interface IStudentOpertion
    {
        public List<StudentCountsByAssignment> getStudentCountGroupByAssignment(List<Student> list);
        public List<AssignmentsWithStatus> getAssignmentsWithStatus(List<Student> list);
        public List<StudentCountForAssignmentTaken> getStudentCountForAssignmentTaken(List<Student> list);
    }
}
