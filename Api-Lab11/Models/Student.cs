﻿namespace Api_Lab11.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public List<Grade> Grades { get; set; }  // Un estudiante puede tener muchas calificaciones
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

    }
}
