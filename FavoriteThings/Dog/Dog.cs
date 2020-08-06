using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace FavoriteThings
{
    class Dog
    {
        //---------------------------------------------------------------------
        // properties - variables to share with other files
        public string Name { get; set; }
        public string wasAdopted { get; set; }
        public bool seesCritter { get; set; }









    //---------------------------------------------------------------------
    // field - variables just for this file/class









    //---------------------------------------------------------------------
    // methods - functionality of the class


    public void Run()
        {
            Console.WriteLine($"\"I'm the fastest pup in the land,\" {Name} proclaimed while out on partol.");  // prints 'Scout' in {Name}
        }


        public void Bark(bool seesCritter)
        {
            if (seesCritter)
            {
                Console.WriteLine("He struck fear into critters with his vicous bark, and enjoyed walking away victorious.");
            }
            else
            {
                Console.WriteLine("When no animals were around, He sometimes barked at the UPS truck for no apparent reason.");
            }


        }
    }
}
