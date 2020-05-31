using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_boneyard_danielmcgee
{
            class Domino
            {
                        public int topDots;
                        public int bottomDots;

                        public int TopDots
                        {
                                    get
                                    {
                                                return topDots;
                                    }
                        }

                        public int BottomDots
                        {
                                    get
                                    {
                                                return bottomDots;
                                    }
                        }

                        public Domino(int t = 0, int b = 0)
                        {
                                    topDots = t;
                                    bottomDots = b;
                        }

                        public override string ToString()
                        {
                                    return "Top dots: " + TopDots.ToString() + ", bottom dots: " + BottomDots.ToString();
                        }

                        public override int GetHashCode()
                        {
                                    return new { TopDots, BottomDots }.GetHashCode();
                        }

            }
}
