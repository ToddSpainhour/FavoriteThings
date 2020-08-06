using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Art
    {

        public string Meduim { get; set; }
          

        public void Paint()
        {
            Console.WriteLine("With Photoshop and a drawing tablet, the possibilities are endless... or I could just paint another mountain.");
        }

        public void Display()
        {
            Console.WriteLine("I kind of like this painting. Maybe I should display it somewhere in the house.");
        }
    }
}
