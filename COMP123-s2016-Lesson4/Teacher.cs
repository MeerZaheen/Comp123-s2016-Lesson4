using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
{
    /**
    * <summary> 
    * The teacher class is derived from the Person class
    * </summary>
    *
    * @class Teacher 
    * @extends Person
    */
    class Teacher:Person
    {
        // Private instance variables +++++++++++++++++++++++++++++++++++++++++++++++++

        private string _employeeID;

        // Public properties +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public string EmployeeID
        {
            get
            {
                return this._employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }

        // Constructor ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This constructor method takes three parameters: name, age, and employeeID
        * </summary>
        *
        * @constructor Teacher
        * @param {string} name
        * @param {int} age
        * @param {string} employeeID
        */
        public Teacher(string name, int age, string employeeID)
            :base(name, age)
        {
            this.EmployeeID = employeeID;
        }

        // Public methods +++++++++++

        /**
        * <summary>
        * This method enables the Teacher behaviour for the Teacher class
        * </summary>
        *
        * @method teaches
        * @returns {void}
        */
        public void Teaches()
        {
            Console.WriteLine(this.Name + " teaches.");
        }
    }
}
