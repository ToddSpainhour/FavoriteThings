using FavoriteThings;
using FavoriteThingss;
using System;
using System.Data;
using System.Net;
using System.Reflection;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {


            var scout = new Dog
            {
                Name = "Scout",
                // wasAdopted = true,
                seesCritter = true,
            };


            var Evie = new Dog
            {
                Name = "Evie",
            };


            Console.WriteLine($"This story is about a young pup named {scout.Name}.");

            Console.WriteLine($"{scout.Name}'s past is mystirous since he was rescued from a local shelter.");


            scout.Run();

            scout.Bark(false);

            Console.WriteLine($"{scout.Name} hasn't made many other pup friends over the years, but he did get along with {Evie.Name}.");


            Console.WriteLine("\n");


            //---------------------------------




            var orwellsBook = new Book()
            {
                Title = "1984",
                Author = "George Orwell"
            };


            var stephenKing = new Book()
            {
                Title = "The Stand",
                Author = "Stephen King"
            };

            Console.WriteLine($"Have you ever read {orwellsBook.Author}'s book {orwellsBook.Title}?");
            Console.WriteLine($"How about {stephenKing.Author}'s {stephenKing.Title}?");

            stephenKing.Share(true);

            orwellsBook.Read(true);

            Console.WriteLine("\n");


            //---------------------------------



            var vacation = new Mountain()
            {
                State = "Virginia",
                Area = "Southwest",
                Trail = "Appalachian Trail"
            };

            Console.WriteLine($"We enjoy getting away to {vacation.Area} {vacation.State} and doing some day hikes on the {vacation.Trail}.");

            vacation.Hike();

            vacation.Unplug(false);



            Console.WriteLine("\n");



            //---------------------------------


            var myPainting = new Art()
            {
                Meduim = "digital painting",
            };

            Console.WriteLine($"I think one of the best forms of therapy is {myPainting.Meduim}.");

            myPainting.Paint();

            myPainting.Display();







            Console.ReadKey();

        }
    }
}
