﻿using System.ComponentModel.DataAnnotations;

namespace TP4GestionDesStudents.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? phone_number { get; set; }
        public string? university { get; set; }
        public string? timestamp { get; set; }
        public string? course { get; set; }

    }
}
