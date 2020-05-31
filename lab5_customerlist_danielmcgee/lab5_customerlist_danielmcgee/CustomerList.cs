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
                        private int customerCount;

                        public CustomerList()
                        {
                                    customerList = new List<Customer>();
                                    customerCount = 0;
                        }

                        public CustomerList(List<Customer> cList)
                        {
                                    customerList = cList;
                                    customerCount = cList.Count;
                        }

                        public int CustomerCount
                        {
                                    get
                                    {
                                                return customerCount;
                                    }
                        }

                        public Customer this[int index]
                        {
                                   
                                    get
                                    {
                                                if (index < 0 || index >= customerCount)
                                                            return null;
                                                return customerList[index];
                                    }
                                    set
                                    {
                                                if (index < 0 || index >= customerCount)
                                                            return;
                                                customerList[index] = value;
                                    }
                        }

                        public static CustomerList operator +(CustomerList a, Customer b)
                        {
                                    if (!a.customerList.Contains(b))
                                    {
                                                a.Add(b);
                                    }
                                    return a;
                        }

                        public static CustomerList operator -(CustomerList a, Customer b)
                        {
                                    if (a.customerList.Contains(b))
                                    { 
                                                a.Remove(b);
                                    }
                                    return a;
                        }

                        public Customer Remove(Customer a)
                        {
                                    if (customerList.Contains(a))
                                                customerList.Remove(a); customerCount--;
                                    return a;
                        }

                        public void Add(Customer a)
                        {
                                    if (!customerList.Contains(a))
                                                customerList.Add(a); customerCount++;
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
