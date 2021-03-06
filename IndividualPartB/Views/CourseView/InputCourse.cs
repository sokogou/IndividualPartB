using IndividualPartB.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views.CourseView
{
    /// <summary>
    /// In Connection with the Course Controller to Delete(GetIdForDelete), Create(GetCourseData)
    /// and Edit(GetDataForEdit) data in Course Table.
    /// </summary>
    internal class InputCourse : IInputData
    {
        public int GetIdForDelete()
        {
            Console.WriteLine("Give  the Course's Id that you wish to Delete");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }

        public Course GetCourseData()
        {
            string stream;
            string type;
            int tempType;

            Console.WriteLine("Give Course Tittle");
            string tittle = Console.ReadLine();
            Console.WriteLine("Give Course Stream");
            do
            {
                stream = Console.ReadLine();
            } while (!Validation.ProperCourseInput(stream));

            Console.WriteLine("Press 1 for Fulltime or 2 for Parttime");
            do
            {
                tempType = Validation.Integer(Console.ReadLine());
            } while (Validation.RangeCheck(tempType, 1, 2));
            type = CourseType(tempType);


            Console.WriteLine("Give Course starting date");
            DateTime startingDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give Course ending date");
            DateTime endingDate = Convert.ToDateTime(Console.ReadLine());

            return new Course(tittle, stream, type, startingDate, endingDate);
        }

        public Course GetDataForEdit()
        {
            string stream;
            int tempType;
            string type;

            Console.WriteLine("Give Course's ID wich you wish to edit");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Course Tittle");
            string tittle = Console.ReadLine();
            Console.WriteLine("Give Course Stream");
            do
            {
                stream = Console.ReadLine();
            } while (!Validation.ProperCourseInput(stream));

            Console.WriteLine("Press 1 for Fulltime or 2 for Parttime");
            do
            {
                tempType = Validation.Integer(Console.ReadLine());

            } while (Validation.RangeCheck(tempType, 1, 2));
            type = CourseType(tempType);

            Console.WriteLine("Give Course starting date");
            DateTime startingDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Give Course ending date");
            DateTime endingDate = Convert.ToDateTime(Console.ReadLine());

            return new Course() { ID = id, Title = tittle, Stream = stream, Type = type, StartDate = startingDate, EndDate = endingDate };
        }


        protected string CourseType(int type)
        {

            if (type == 1)
                return "Full-Time";
            else
                return "Part-Time";
        }
    }


}
