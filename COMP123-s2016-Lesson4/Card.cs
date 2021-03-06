﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_s2016_Lesson4
{
    /**
    * <summary>
    * This class creates an object that represent a playing card
    * </summary>
    * 
    * @class Card
    */
    public class Card
    {
        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public int Face { get; set; }     // prop TAB TAB
        public string Suit { get; set; }

        /**
        * <summary>
        * This constructor takes two paramaters: face and suit to instantiate a Card object
        * </summary>
        *
        * @constructor Card
        * @param {int} face
        * @param {string} suit
        */

        public Card(int face, string suit)      // cc TAB TAB
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
