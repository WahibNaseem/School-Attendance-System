using KhssData.DomainModels.Attendance;
using System.Linq;


namespace Khss.ServiceContracts
{
   public interface IAttendanceSystemService
    {
        #region Service Method For Class Domain        
        IQueryable<Class> GetAllClasses();
        Class GetClassById(int id);
        void AddClass(Class newClass);
        int DeleteClass(int id);
        #endregion

        #region Service Method for Section Domain
        IQueryable<Section> GetAllSections();
        Section GetSectionById(int id);
        void AddSection(Section newSection);
        int DelteSection(int id);

        #endregion

        #region Service Method fo Student Domain
        IQueryable<Student> GetAllStudents();
        Student GetStudentById(int id);
        void AddStudent(Student newStudent);
        void DeleteStudent(int id);

        #endregion       

        #region Service Method for Attendance Domain
        IQueryable<Attendance> GetAllAttendances();
        Attendance GetAttendanceById(int id);
        IQueryable<Attendance> GetAllAttendancesByStudentClassId(int studenClasstId);
        void AddAttendance(Attendance newAttendance);
        int DeleteAttendance(int id);
        #endregion

        #region Service Method for StudentClass
        IQueryable<StudentClass> GetAllStudentClasses();
        IQueryable<StudentClass> GetStudentClassByStudentId(int id);
        IQueryable<StudentClass> GetStudentClassbyClassId(int id);
        IQueryable<StudentClass> GetStudentClassBySectionId(int id);
        IQueryable<StudentClass> GetStudentByClassAndSectionId(int classId, int sectionId);
        
        #endregion
    }
}
