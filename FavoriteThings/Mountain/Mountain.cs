using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThingss
{
    class Mountain
    {

        public string State { get; set; }
        public string Area { get; set; }
        public string Trail { get; set; }




        public void Hike()
        {
            Console.WriteLine("There are so many great trails to choose from. Wanna see a waterfall?");
        }



        public void Unplug(bool cellSignal)
        {
            if (!cellSignal)
            {
                Console.WriteLine("Well, back to the real world. I have cell service again, but do I really want to look at my phone?");
            }
            else
            {
                
                Console.WriteLine("It's nice to unplug from time to time.");

            }
        }
    }
}
