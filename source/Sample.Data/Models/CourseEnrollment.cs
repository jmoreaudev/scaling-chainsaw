﻿using System;

namespace Sample.Data.Models
{
    public class CourseEnrollment
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public decimal Grade { get; set; }
    }
}