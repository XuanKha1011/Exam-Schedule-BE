﻿using System.ComponentModel.DataAnnotations;

namespace ExamScheduleSystem.Model
{
    public class StudentList
    {
        [Key]
        public string StudentListId { get; set; }
        public string CourseId { get; set; }
        public string Status { get; set; }
        public int NumberOfProctoring { get; set; }
        public Course Course { get; set; }
        public ICollection<StudentListStudent> StudentListStudents { get; set; }
    }
}
