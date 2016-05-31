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
    */
    class Student : Person
    {
        // Private Instance variables +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _studentID;

        // Public properties ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        
        /**
        * <summary> 
        * This is a property, StudentID, includes
        * </summary>
        *
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
    }
}
