using Khss.ServiceContracts;
using KhssData;
using KhssData.DomainModels.Attendance;
using System;
using System.Collections.Generic;
using System.Linq;

namespace khss.Services
{
    public class AttendanceSystemService : IAttendanceSystemService
    {
        #region Life Cycle
        private readonly KhssContext _context;
        public AttendanceSystemService(KhssContext context) => this._context = context;  
        
        #endregion

        #region Classes Service Implemented
        public IQueryable<Class> GetAllClasses()
        {
            throw new NotImplementedException();
        }
        public Class GetClassById(int id)
        {
            throw new NotImplementedException();
        }
        public void AddClass(Class newClass)
        {
            throw new NotImplementedException();
        }
        public int DeleteClass(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Section Service Implemented        
        public IQueryable<Section> GetAllSection()
        {
            throw new NotImplementedException();
        }
        public Section GetSectionById(int id)
        {
            throw new NotImplementedException();
        }
        public void AddSection(Section newSection)
        {
            throw new NotImplementedException();
        }
        public int DelteSection(int id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Student Service Implemented
        public IQueryable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }
        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }
        public void AddStudent(Student newStudent)
        {
            throw new NotImplementedException();
        }
        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Attendance Service Implemented
        public IQueryable<Attendance> GetAllAttendances()
        {
            throw new NotImplementedException();
        }
        public Attendance GetAttendanceById(int id)
        {
            throw new NotImplementedException();
        }
       public IQueryable<Attendance> GetAllAttendancesByStudentId(int studenClasstId)
        {
            throw new NotImplementedException();
        }
        public void AddAttendance(Attendance newAttendance)
        {
            throw new NotImplementedException();
        }
        public int DeleteAttendance(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region StudentClass Service Implemented        
        public IQueryable<StudentClass> GetAllStudentClasses()
        {
            throw new NotImplementedException();
        }
        public IQueryable<StudentClass> GetStudentClassByStudentId(int id)
        {
            throw new NotImplementedException();
        }
        public IQueryable<StudentClass> GetStudentClassbyClassId(int id)
        {
            throw new NotImplementedException();
        }
        public IQueryable<StudentClass> GetStudentClassBySectionId(int id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
