using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebApp.Models
{
    public class gradecalculatorModel
    {

        [Range(0, 100)]
        public byte assignments { get; set; }

        [Range(0, 100)]
        public byte group_project { get; set; }

        [Range(0, 100)]
        public byte quizzes { get; set; }

        [Range(0, 100)]
        public byte exams { get; set; }

        [Range(0, 100)]
        public byte intex { get; set; }
    }

    public class gradeModel
    {
        public double total_percentage { get; set;  }
        public string grade_letter { get; set; }
    }

}
