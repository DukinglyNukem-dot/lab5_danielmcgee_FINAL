using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_customerlist_danielmcgee
{
            public class Customer
            {
                        private string email = "";
                        private string firstName = "";
                        private int id;
                        private string lastName = "";
                        private string phone = "";

                        public Customer() { }

                        public Customer(int customerId, string firstName, string lastName, string email, string phone)
                        {
                                    Id = customerId;
                                    FirstName = firstName;
                                    Email = email;
                                    LastName = email;
                                    Phone = phone;
                        }

                        public override bool Equals(object obj)
                        {
                                    var cust = obj as Customer;
                                    if (cust == null)
                                                return false;
                                    return cust.Email == Email && cust.FirstName == FirstName && cust.Id == Id && cust.LastName == LastName && cust.Phone == Phone;
                        }

                        public string Email   // property
                        {
                                    get { return email; }   // get method
                                    set { email = value; }  // set method
                        }

                        public string FirstName   // property
                        {
                                    get { return firstName; }   // get method
                                    set { firstName = value; }  // set method
                        }
                        public int Id   // property
                        {
                                    get { return id; }   // get method
                                    set { id = value; }  // set method
                        }
                        public string LastName   // property
                        {
                                    get { return lastName; }   // get method
                                    set { lastName = value; }  // set method
                        }
                        public string Phone   // property
                        {
                                    get { return phone; }   // get method
                                    set { phone = value; }  // set method
                        }

                        public override string ToString()
                        {
                                    return String.Format("Email: {0} First name: {1} Identification: {2} Last name: {3:C} Phone: {4}", email, firstName, id, lastName, phone);
                        }

                        public override int GetHashCode()
                        {
                                    return new { Email,FirstName,Id,LastName,Phone}.GetHashCode();
                        }

            }
}
