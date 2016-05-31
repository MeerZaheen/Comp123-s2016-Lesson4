using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
{
    /**
    * <summary>
    * This is the course class - we are using this as a suctom data type for our Teacher and Student Classes
    * </summary>
    *
    * @class Course
    */
    class Course
    {
        // Private instance variables +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _code;
        private string _description;

        // Public properties ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public string Code
        {
            get
            {
                return this._code;
            }
            
            set
            {
                this._code = value;
            }
        }

        public string Description
        {
            get
            {
                return this._description;
            }

            set
            {
                this._description = value;
            }
        }
        /**
        * <summary>
        * This constructor takes two parameters: Code and Description
        * </summary>
        *
        * @constructor Course
        * @param {string} code
        * @param {string} description
        */

        public Course(string code, string description)
        {
            this.Code = code;
            this.Description = description;
        }
    }
}
