using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Practice_2
{
    internal class Triangle
    {
        public double FirstSide { get; set; }
        public double SecondSide { get; set; }
        public double ThirdSide { get; set; }

        public double perimeter { 
            get
            {
                return FirstSide + SecondSide + ThirdSide;
            }
        } 

        public bool IsIsosceles
        {
            get
            {
                if (FirstSide == SecondSide || FirstSide == ThirdSide || SecondSide == ThirdSide)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        
    }
}