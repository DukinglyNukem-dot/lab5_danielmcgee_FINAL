using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_boneyard_danielmcgee
{
            class Program
            {
                        static void Main(string[] args)
                        {
                                    Console.WriteLine("Creating boneyard, there should be 16");
                                    Boneyard b = new Boneyard(3);
                                    Console.WriteLine("Boneyard count: " + b.DominosRemaining);
                                    Console.WriteLine("Showing all of the dominos on the screen: \n" + b.ToString());
                                    b.Shuffle();
                                    Console.WriteLine("Let's shuffle, the order should be randomized now as with the result on the screen: \n" + b.ToString());
                                    Console.WriteLine("Drawing a domino, let's see: " + b.Draw().ToString());
                                    Console.WriteLine("What does the first domino look like? " + b[0].ToString());
                        }
            }
}
