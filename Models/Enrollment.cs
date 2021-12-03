﻿using System.ComponentModel.DataAnnotations;

namespace GAMF.Models
{
    public enum Grade { A, B, C, D, F }



    public class Enrollment

    {

        public int EnrollmentId { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        [Display(Name = "Jegy")]
        public Grade? Grade { get; set; }

        [Display(Name = "Kurzus")]
        public virtual Course Course { get; set; }

        [Display(Name = "Hallgató")]
        public virtual Student Student { get; set; }

    }
}
