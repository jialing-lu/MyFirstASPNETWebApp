using Microsoft.AspNetCore.Mvc;
using MyFirstASPNETWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASPNETWebApp.Controllers
{
    public class Ex1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult gradecalculator()
        {
            return View();
        }

        gradeModel finalgrade = new gradeModel();

        
        [HttpPost]
        public IActionResult gradecalculator(gradecalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                double assignments = model.assignments * 0.55;
                double group_project = model.group_project * 0.05;
                double quizzes = model.quizzes * 0.1;
                double exams = model.exams * 0.2;
                double intex = model.intex * 0.1;
                double tScore = assignments + group_project + quizzes + exams + intex;
                tScore = Math.Round((Double)tScore, 2);
                
                string letterGrade = "";


                if (tScore <= 100 && tScore >= 94)
                {
                    letterGrade = "A";
                }
                else if (tScore < 94 && tScore >= 90)
                {
                    letterGrade = "A-";
                }
                else if (tScore < 90 && tScore >= 87)
                {
                    letterGrade = "B+";
                }
                else if (tScore < 87 && tScore >= 84)
                {
                    letterGrade = "B";
                }
                else if (tScore < 84 && tScore >= 80)
                {
                    letterGrade = "B-";
                }
                else if (tScore < 80 && tScore >= 77)
                {
                    letterGrade = "C+";
                }
                else if (tScore < 77 && tScore >= 74)
                {
                    letterGrade = "C";
                }
                else if (tScore < 74 && tScore >= 70)
                {
                    letterGrade = "C-";
                }
                else if (tScore < 70 && tScore >= 67)
                {
                    letterGrade = "D+";
                }
                else if (tScore < 67 && tScore >= 64)
                {
                    letterGrade = "D";
                }
                else if (tScore < 64 && tScore >= 60)
                {
                    letterGrade = "D-";
                }
                else if (tScore < 60)
                {
                    letterGrade = "E";
                }
                else
                {
                    letterGrade = "F";
                }

                finalgrade.total_percentage = tScore;
                finalgrade.grade_letter = letterGrade;

                ViewBag.tPct = finalgrade.total_percentage;
                ViewBag.lGrade = finalgrade.grade_letter;
            }

            return View();

        }
    }
}
