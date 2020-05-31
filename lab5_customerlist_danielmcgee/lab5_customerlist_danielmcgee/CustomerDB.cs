using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace lab5_customerlist_danielmcgee
{
            public static class CustomerDB
            {
                        private const string Path = @"..\..\..\lab5_customerlist_danielmcgee\data\Customers.xml";

                        public static List<Customer> GetCustomers()
                        {
                                    // create the list
                                    List<Customer> customers = new List<Customer>();

                                    // create the XmlReaderSettings object
                                    XmlReaderSettings settings = new XmlReaderSettings();
                                    settings.IgnoreWhitespace = true;
                                    settings.IgnoreComments = true;

                                    // create the XmlReader object
                                    XmlReader xmlIn = XmlReader.Create(Path, settings);

                                    // read past all nodes to the first Product node
                                    if (xmlIn.ReadToDescendant("Customer"))
                                    {
                                                // create one Product object for each Product node
                                                do
                                                {
                                                            //            public Customer(int customerId, string firstName, string lastName, string email, string phone)
                                                            Customer customer = new Customer();
                                                            xmlIn.ReadStartElement("Customer");
                                                            customer.Id = xmlIn.ReadElementContentAsInt();
                                                            customer.FirstName = xmlIn.ReadElementContentAsString();
                                                            customer.LastName = xmlIn.ReadElementContentAsString();
                                                            customer.Email = xmlIn.ReadElementContentAsString();
                                                            customer.Phone = xmlIn.ReadElementContentAsString();
                                                            customers.Add(customer);
                                                }
                                                while (xmlIn.ReadToNextSibling("Customer"));
                                    }

                                    // close the XmlReader object
                                    xmlIn.Close();

                                    return customers;
                        }

                        public static void SaveCustomers(List<Customer> customers)
                        {
                                    // create the XmlWriterSettings object
                                    XmlWriterSettings settings = new XmlWriterSettings();
                                    settings.Indent = true;
                                    settings.IndentChars = ("    ");

                                    // create the XmlWriter object
                                    XmlWriter xmlOut = XmlWriter.Create(Path, settings);

                                    // write the start of the document
                                    xmlOut.WriteStartDocument();
                                    xmlOut.WriteStartElement("Customers");

                                    // write each product object to the xml file
                                    foreach (Customer customer in customers)
                                    {
                                                //            public Customer(int customerId, string firstName, string lastName, string email, string phone)
                                                xmlOut.WriteStartElement("Customer");
                                                xmlOut.WriteElementString("Id", customer.Id.ToString());
                                                xmlOut.WriteElementString("FirstName", customer.FirstName.ToString());
                                                xmlOut.WriteElementString("LastName", customer.LastName.ToString());
                                                xmlOut.WriteElementString("Email", customer.Email.ToString());
                                                xmlOut.WriteElementString("Phone", customer.Phone.ToString());
                                                xmlOut.WriteEndElement();
                                    }

                                    // write the end tag for the root element
                                    xmlOut.WriteEndElement();

                                    // close the xmlWriter object
                                    xmlOut.Close();
                        }
            }
}
