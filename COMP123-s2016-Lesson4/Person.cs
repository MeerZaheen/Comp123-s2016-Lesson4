using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
{
    /**
    * This class defines a generic Person
    *
    * @class Person
    * @field _name {string}
    * @field _age {int}
    */
    public class Person
    {
        // Private Intance variables ++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;


        // Public properties ++++++++++++++++++++++++++++++++++++++++++++++


        /**
        * <summay>
        * This is a property for our _name field
        * </summay>
        *
        * @property {string} Name
        */
        public string Name  // CAN ALSO USE THIS: public string Name { get; set; }
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }

        /**
        * <summary>
        * This is a public property for our private _age field
        * </summary>
        * 
        * @property {int} Age
        */

        public int Age  // CAN ALSO USE THIS: public string Age { get; set; }
        {
            get
            {
                return this._age;
            }

            set
            {
                this._age = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This is the default empty constructor for the Persons Class
        * </summary>
        *
        * @constructor Person
        */

        public Person()
        {
            this._initialize();
        }

        /**
        * <summary>
        * This is a consructor that takes name as a parameter and passes 
        * it to the _name private instance variable
        * </summary>
        * 
        * @constructor Person
        * @param {string} name
        */

        public Person(string name)
        {
            this._initialize();
            this.Name = name;
        }

        /**
        * <summary>
        * This is a constructor that takes age as a parameter and passes
        * it to the _age private instance variable
        * </summary>
        * 
        * @constructor Person
        * @param {int} age
        */

        public Person(int age)
        {
            this._initialize();
            this.Age = age;
        }

        /** <summary>
        * This is a constructor that takes both name and age as parameters.
        * It assigns the local name value to the Name property.
        * It assigns the local age value to the age property.
        * </summary>
        * 
        * @constructor Person
        * @param {string} name
        * @param {int} age
        * @param {string} profession
        */

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        // PUBLIC METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        /**
         * <summary>
         * This method initializes the public properties Name and Age
         * </summary>
         * 
         * @private
         * @method _initialize
         * @returns {void}
         */
        private void _initialize()
        {
            this.Name = "unknown name!";
            this.Age = 0;
        }

        /**
         * <summary>
         * This method outputs the _name value with " says hello!" to the console.
         * </summary>
         * 
         * @method SaysHello
         * @returns {void}
         */

        public void SaysHello()
        {
            Console.WriteLine(this.Name + " says hello!");
        }

        /**
         * <summary>
         * This method outputs the _name and _age values in the following
         * format: _name + " is " + _age + " years old".
         * </summary>
         * 
         * @method ShowAge
         * @returns {void}
         */

        public void ShowAge()
        {
            Console.WriteLine(this.Name + " is " + this.Age + " years old.");
        }
    }
}


/** MY OWN CODE MISTAKES:

/**
* This is the default empty constructor for the Persons Class
*
* @constructor Person


public Person()
{
    this._name = "Meer";
    this._age = 26;
}

/**
* This is a constructor that takes name as a parameter and passes
* it to the _name private instance variable
*
* @constructor Person
* @param {string} name
* @param {int} age


public void SaysHelloMessage()
{
    Console.WriteLine("{0}, says hello", this._name);
}

public void ShowAge()
{
    Console.WriteLine("{0}, is {1} years old", this._name, this._age);
}
*/
