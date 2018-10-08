using KhssData.DomainModels.Attendance;
using System;
using System.Collections.Generic;
using System.Text;

namespace Khss.ServiceContracts
{
   public interface IAttendanceSystemService
    {
        #region Service Method For Class Domain        
        IEnumerable<Class> GetAllClasses();
        Class GetClassById(int id);
        void AddClass(Class newClass);
        int DeleteClass(int id);
        #endregion

        #region Service Method fo Student Domain
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student newStudent);
        void DeleteStudent(int id);

        #endregion
                
        #region Service Method for Section Domain
        IEnumerable<Section> GetAllSection();
        Section GetSectionById(int id);
        void AddSection(Section newSection);
        int DelteSection(int id);

        #endregion

        #region Service Method for Attendance Domain
        IEnumerable<Attendance> GetAllAttendances();
        Attendance GetAttendanceById(int id);
        void AddAttendance(Attendance newAttendance);
        int DeleteAttendance(int id);
        #endregion

        #region Service Method for StudentClass
        IEnumerable<StudentClass> GetAllStudentClasses();
        StudentClass GetStudentClassById(int id);        
        
        #endregion
    }
}
