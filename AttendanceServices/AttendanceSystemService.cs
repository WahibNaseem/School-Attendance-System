using Khss.ServiceContracts;
using KhssData.DomainModels.Attendance;
using System;
using System.Collections.Generic;
using System.Text;

namespace khss.Services
{
    public class AttendanceSystemService : IAttendanceSystemService
    {
        public void AddAttendance(Attendance newAttendance)
        {
            throw new NotImplementedException();
        }

        public void AddClass(Class newClass)
        {
            throw new NotImplementedException();
        }

        public void AddSection(Section newSection)
        {
            throw new NotImplementedException();
        }

        public void AddStudent(Student newStudent)
        {
            throw new NotImplementedException();
        }

        public int DeleteAttendance(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteClass(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public int DelteSection(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Attendance> GetAllAttendances()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> GetAllClasses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Section> GetAllSection()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StudentClass> GetAllStudentClasses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Attendance GetAttendanceById(int id)
        {
            throw new NotImplementedException();
        }

        public Class GetClassById(int id)
        {
            throw new NotImplementedException();
        }

        public Section GetSectionById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public StudentClass GetStudentClassById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
