﻿using IndividualPartB.Repositories.CourseRepository;
using IndividualPartB.Repositories.StudentRepository;
using IndividualPartB.Views.CourseView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Menu.MenuServices
{
    /// <summary>
    /// The Class Where the Repository, Input and Print services are compine to produce
    /// the results for The Course Entity
    /// Furthermore includes the 3 methods to produce: 1. Student Per Course, 2. Trainer Per Course
    /// and 3. Assignment Per Student Per Course  Queries.
    /// </summary>
    internal class CourseController : IController
    {
        public void Creating()
        {
            CourseRepository rep = new CourseRepository();
            InputCourse input = new InputCourse();

            var course = input.GetCourseData();
            rep.Add(course);
        }

        public void Deleting()
        {
            CourseRepository rep = new CourseRepository();
            InputCourse input = new InputCourse();

            int id = input.GetIdForDelete();
            rep.Delete(id);
        }

        public void Editing()
        {
            CourseRepository rep = new CourseRepository();
            InputCourse input = new InputCourse();

            var course = input.GetDataForEdit();
            rep.Update(course);
        }


        public void Reading()
        {
            CourseRepository rep = new CourseRepository();
            PrintCourse printCourse = new PrintCourse();

            var course = rep.GetALL();
            printCourse.PrintCourses(course);
        }

        public void StudentPerCourse()
        {
            CourseRepository rep = new CourseRepository();
            PrintCourse print = new PrintCourse();

            var course = rep.StudentPerCourse();
            print.StudentsPer(course);

        }

        public void TrainerPerCourse()
        {
            CourseRepository rep = new CourseRepository();
            PrintCourse print = new PrintCourse();

            var course = rep.TrainerPerCourse();
            print.TrainersPer(course);

        }

        public void AssignmentPerStudentPerCourse()
        {
            CourseRepository rep = new CourseRepository();
            PrintCourse print = new PrintCourse();

            var course = rep.AssignmentPerStudentPerCourse();
            print.AssignmentPerStudentPer(course);

        }


    }
}
