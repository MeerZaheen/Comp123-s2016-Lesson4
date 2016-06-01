using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
{
    /**
    * <summary>
    * This is the student class. It is derived from the Person Class
    * </summary>
    *
    * @class Student
    * @extends Person
    */
    class Student : Person
    {
        // Private Instance variables +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _studentID;
        private List<Course> _courses = new List<Course>();

        // Public properties ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        /**
         * <summary>
         * This property, StudentID, includes a getter and setter for the private
         * instance variable _studentID
         * </summary>
         * 
         * @property StudentID
         */
        public string StudentID
        {
            get
            {
                return this._studentID;
            }

            set
            {
                this._studentID = value;
            }
        }


        /**
         * <summary>
         * This read-only property gets a reference to the _courses - a List object of Course type
         * </summary>
         * 
         * @readOnly
         * @property Courses
         */
        public List<Course> Courses
        {
            get
            {
                return this._courses;
            }

        }

        // Constructors +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the empty / default constructor for the student class
        * </summary>
        *
        * @constructor Student
        * @extends Person
        * @param {string} name
        * @param {int} age
        * @param {string} studentID
        */

        public Student(string name, int age, string studentID)
            :base(name, age)
        {
            this.StudentID = studentID;
        }

        // Public methods ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This method enables the Studies behaviour from the student
        * </summary>
        *
        * @method studies
        * @returns {void}
        */

        public void Studies()
        {
            Console.WriteLine(this.Name + " studies.");
        }

        /**
        * <summary>
        * This method lists all the courses the student is currently enrollled in.
        * </summary>
        * 
        * @method ShowCourses
        * @returns {void}
        */
        public void ShowCourses()
        {
            Console.WriteLine();
            Console.WriteLine("Course List");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            foreach (Course course in this._courses)
            {
                Console.WriteLine("+ " + course.Code + " " + course.Description);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
        }
    }
}
    
