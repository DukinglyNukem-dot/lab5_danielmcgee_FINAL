using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_customerlist_danielmcgee
{
            class CustomerList
            {
                        private List<Customer> customerList;

                        public CustomerList()
                        {
                                    customerList = new List<Customer>();
                        }

                        public CustomerList(List<Customer> cList)
                        {
                                    customerList = cList;
                        }

                        public int CustomerCount
                        {
                                    get
                                    {
                                                return customerList.Count;
                                    }
                        }

                        public Customer this[int index]
                        {
                                   
                                    get
                                    {
                                                if (index < 0 || index >= CustomerCount)
                                                            throw new System.IndexOutOfRangeException();
                                                return customerList[index];
                                    }
                                    set
                                    {
                                                if (index < 0 || index >= CustomerCount)
                                                            throw new System.IndexOutOfRangeException();
                                                customerList[index] = value;
                                    }
                        }

                        public static CustomerList operator +(CustomerList a, Customer b)
                        {
                                    if (a.FindByEmail(b.Email) != null)
                                    {
                                                a.Add(b);
                                    }
                                    return a;
                        }

                        public static CustomerList operator -(CustomerList a, Customer b)
                        {
                                    if (a.FindByEmail(b.Email) != null)
                                    { 
                                                a.Remove(b);
                                    }
                                    return a;
                        }

                        public Customer Remove(Customer a)
                        {
                                    if (customerList.Contains(a))
                                                customerList.Remove(a);
                                    return a;
                        }

                        public void Add(Customer a)
                        {
                                    if (!customerList.Contains(a))
                                                customerList.Add(a);
                        }

                        public void Add(string email,string firstName, int id,string lastName,string phoneNumber)
                        {
                                    Customer c = new Customer(id,firstName,email,lastName, phoneNumber);
                                    Add(c);
                        }

                        public Customer FindByEmail(string email)
                        {
                                    foreach(Customer c in customerList)
                                    {
                                                if (c.Email == email)
                                                            return c;
                                    }
                                    return null;
                        }
                        
                        public Customer RemoveCustomerByHashcode(int h)
                        {
                                    foreach (Customer c in customerList)
                                    {
                                                if (c.GetHashCode() == h)
                                                {
                                                            return Remove(c);
                                                }
                                    }
                                    return null;
                        }

                        public List<Customer> RetrieveCustomerList()
                        {
                                    return customerList;
                        }

            }
}
