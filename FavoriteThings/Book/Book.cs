using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Book
    {

        // properties - info to share with other files
        public string Title { get; set; }
        public string Author { get; set; }
        public bool _onReadList { get; set; }
        public bool _haveTime { get; set; }





        public void Read(bool _haveTime)
        {
            if (_haveTime)
            {
                Console.WriteLine("While I have a few minutes, I should read another chapter.");
            }
            else
            {
                Console.WriteLine("I look forward to getting some time to read.");
            }
        }




        public void Share(bool _onReadList)
        {
            if (_onReadList)
            {
                Console.WriteLine("You're intersted in reading this book, please take it!");
            }
            else
            {
                Console.WriteLine("If you haven't heard about this book, I highly recommend it.");
            }
        }
    }
}
