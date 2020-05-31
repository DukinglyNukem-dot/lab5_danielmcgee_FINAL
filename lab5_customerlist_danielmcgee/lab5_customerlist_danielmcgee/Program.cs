using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab5_customerlist_danielmcgee
{
            class Program
            {
                        static void Main(string[] args)
                        {
                                    Console.WriteLine("Creating a customer list, 2 will start out in it, 3 will be added in.");
                                    Customer c1 = new Customer(5,"jorge","whatever","whatevergmail","6665607878");
                                    Customer c2 = new Customer(2,"nobody","nowhere","nowhergmail","2224767878");
                                    CustomerList custL = new CustomerList(new List<Customer> { c1, c2 });
                                    custL.Add("3gmail","customer",3,"3","3333333333");
                                    custL.Add("4gmail", "customer", 4,"4","444444444");
                                    custL.Add("5gmail", "customer", 5,"5","5555555555");
                                    Console.WriteLine("We should have 5 customers in our customer list, TOTAL: " + custL.CustomerCount);
                                    Console.WriteLine("Let's index the third customer out of the customer list and show it's contents.");
                                    Console.WriteLine((custL[2] != null) ? "SECCESS: " + custL[2].ToString() : "FAILURE...");

                                    Console.WriteLine("Now let's get an out of range index to see if it breaks, we should get FAILURE...");
                                    Console.WriteLine((custL[6] != null) ? "SECCESS: " + custL[2].ToString() : "FAILURE...");

                                    Console.WriteLine("We will remove a customer with the - operator by it's first index");
                                    custL = custL - custL[0];

                                    Console.WriteLine("Now we should have 4 customers in our customer list, TOTAL: " + custL.CustomerCount);

                                    Console.WriteLine("We will use the method Remove() to remove the second index.");
                                    custL.Remove(custL[1]);

                                    Console.WriteLine("Now we should have 3 customers in our customer list, TOTAL: " + custL.CustomerCount);

                                    Console.WriteLine("We will now use the + operator and then use the Add() method to add in two more customers.");

                                    custL.Add(new Customer(456, "l", "WAHTEVER", "wutevregmail", "567567567"));
                                    custL = custL + (new Customer(899, "Nobody", "Nowhere", "wutewdeawdvregmail", "0957986"));

                                    Console.WriteLine("Now we should have 5 customers in our customer list, TOTAL: " + custL.CustomerCount);

                                    Console.WriteLine("We will write all of these customers into the XML database.");
                                    foreach(Customer c in custL.RetrieveCustomerList())
                                    {
                                                Console.WriteLine("Firstname!" + c.FirstName + "!");
                                    }
                                    CustomerDB.SaveCustomers(custL.RetrieveCustomerList());
                                    Console.WriteLine("Let's get our customers back in a new list.");
                                    CustomerList custLTWO = new CustomerList(CustomerDB.GetCustomers());

                                    Console.WriteLine("With our new customer list we should have 5 customers in our customer list, TOTAL: " + custLTWO.CustomerCount);

                                    Console.WriteLine("Removing by hashcode of first object, result is: " + (custLTWO.RemoveCustomerByHashcode(custLTWO[0].GetHashCode()) != null ? true : false));
                                    Console.WriteLine("Finding by email wutewdeawdvregmail: " + (custLTWO.FindByEmail("wutewdeawdvregmail") != null ? true : false));
                        }
            }



}
