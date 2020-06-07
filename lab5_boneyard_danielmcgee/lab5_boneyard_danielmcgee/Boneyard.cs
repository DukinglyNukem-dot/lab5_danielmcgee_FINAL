using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_boneyard_danielmcgee
{
            class Boneyard
            {
                        public List<Domino> dominoBoneyard;

                        // only get.
                        public int DominosRemaining
                        {
                                    get
                                    {
                                                return dominoBoneyard.Count;
                                    }
                        }

                        // The highest dot will be the maxdot, and the lowest will be zero.
                        public Boneyard(int maxDots)
                        {
                                    dominoBoneyard = new List<Domino>();
                                    for (int t = 0; t <= maxDots; t++)
                                    {
                                                for (int b = 0; b <= maxDots; b++)
                                                {
                                                            dominoBoneyard.Add(new Domino(t,b));
                                                }
                                    }
                        }

                        // Retrieve or add a domino in the list.
                        public Domino this[int i]
                        {
                                    get
                                    {
                                                if (i > -1 && i < DominosRemaining)
                                                {
                                                            return dominoBoneyard[i];
                                                } else throw new IndexOutOfRangeException();
                                    }
                                    set
                                    {
                                                if (i > -1 && i < DominosRemaining)
                                                {
                                                            dominoBoneyard[i] = value;
                                                }
                                    }
                        }

                        // Remove the highest domino in the list and return it.
                        public Domino Draw()
                        {
                                    if (DominosRemaining > 0)
                                    {
                                                Domino d = dominoBoneyard[DominosRemaining - 1];
                                                dominoBoneyard.Remove(d);
                                                return d;
                                    }
                                    throw new Exception("Could not find a domino.");
                        }

                        // Is the domino boneyard empty?
                        public bool IsEmpty()
                        {
                                    return (DominosRemaining == 0) ? true : false;
                        }

                        // Shuffle around all the dominos.
                        public void Shuffle()
                        {
                                    if (DominosRemaining == 2)
                                    {
                                                Domino temp = dominoBoneyard[0];
                                                dominoBoneyard[0] = dominoBoneyard[1];
                                                dominoBoneyard[1] = temp;
                                    }
                                    else if (DominosRemaining > 2)
                                    {
                                                Random r = new Random();
                                                for (int i = 0; i < DominosRemaining / 2; i++)
                                                {
                                                            int ranNumber = r.Next(DominosRemaining/2,DominosRemaining);
                                                            Domino temp = dominoBoneyard[i];
                                                            dominoBoneyard[i] = dominoBoneyard[ranNumber];
                                                            dominoBoneyard[ranNumber] = temp;
                                                }
                                    }
                        }

                        // Get the information of all the dominos.
                        public override string ToString()
                        {
                                    string result = "";
                                    foreach(Domino c in dominoBoneyard)
                                    {
                                                result += (c.ToString() + "\n");
                                    }
                                    return result;
                        }

            }
}
