﻿using ExamScheduleSystem.Model;

namespace ExamScheduleSystem.DTO
{
    public class PaginatedClassroom<Classroom>
    {
        public Pagination Pagination { get; set; }
        public List<PaginationClassroomDTO> Data { get; set; }
    }

    public class PaginationClassroomDTO
    {
        public string ClassroomId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public string Status { get; set; }
    }
   
}
