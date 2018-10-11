using Khss.ServiceContracts;
using KhssData;
using KhssData.DomainModels.Attendance;
using Microsoft.EntityFrameworkCore;
using System;
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
            return _context.Classes;
        }
        public Class GetClassById(int id)
        {
            return GetAllClasses()
                      .SingleOrDefault(cls => cls.ClassId == id);
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
        public IQueryable<Section> GetAllSections()
        {
            return _context.Sections;
        }
        public Section GetSectionById(int id)
        {
            return GetAllSections()
                    .SingleOrDefault(section => section.SectionId == id);
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
            return _context.Students;
        }
        public Student GetStudentById(int id)
        {
            return GetAllStudents()
                     .SingleOrDefault(student => student.StudentId == id);
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
            return _context.Attendances;
        }
        public Attendance GetAttendanceById(int id)
        {
            return GetAllAttendances()
                        .SingleOrDefault(attendance => attendance.AttendanceId == id);
        }
        public IQueryable<Attendance> GetAllAttendancesByStudentClassId(int studenClasstId)
        {
            return GetAllAttendances()
                        .Include(attendance => attendance.StudentClass)
                        .Where(attendance => attendance.StudentClassRefId == studenClasstId);
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
            return _context.StudentClasses
                        .Include(student => student.Student)
                        .Include(cls => cls.Class)
                        .Include(section => section.Section);
        }
        public IQueryable<StudentClass> GetStudentClassByStudentId(int studentId)
        {
            return GetAllStudentClasses()
                        .Where(student => student.StudentRefId == studentId);
        }
        public IQueryable<StudentClass> GetStudentClassbyClassId(int clasesId)
        {
            return GetAllStudentClasses()
                        .Where(cls => cls.ClassRefId == clasesId);
        }
        public IQueryable<StudentClass> GetStudentClassBySectionId(int sectionId)
        {
            return GetAllStudentClasses()
                        .Where(section => section.SectionRefId == sectionId);
        }
        public IQueryable<StudentClass> GetStudentByClassAndSectionId(int classId, int sectionId)
        {
            return GetAllStudentClasses()
                        .Where(stdcls => stdcls.ClassRefId == classId &&
                        stdcls.SectionRefId == sectionId);
        }
        #endregion
    }
}
