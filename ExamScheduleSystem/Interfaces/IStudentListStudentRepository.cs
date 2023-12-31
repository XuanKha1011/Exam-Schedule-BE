﻿using ExamScheduleSystem.Model;

namespace ExamScheduleSystem.Interfaces
{
    public interface IStudentListStudentRepository
    {
        bool AddStudentListStudent(StudentListStudent studentListStudent);
        bool UpdateStudentListStudent(string StudentListId, List<StudentListStudent> studentListStudent);
        bool Save();
        int GetTotalStudentOfStudentList(string StudentListId);
        List<Student> GetStudentByStudentListId(string studentListId);
    }
}
