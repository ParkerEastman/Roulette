using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{

    public class RouletteElement
    {
        public string Name;
        public int Value;
        public string Color;

        public RouletteElement(string Name, int Value, string Color)
        {
            this.Name = Name;
            this.Value = Value;
            this.Color = Color;
        }

    }

    public class RouletteWheel {


        RouletteElement Zero = new RouletteElement("0", 0, "Green");
        RouletteElement ZeroZero = new RouletteElement("00", 0, "Green");
        RouletteElement One = new RouletteElement("1", 1, "Red");
        RouletteElement Two = new RouletteElement("2", 2, "Black");
        RouletteElement Three = new RouletteElement("3", 3, "Red");
        RouletteElement Four = new RouletteElement("4", 4, "Black");
        RouletteElement Five = new RouletteElement("5", 5, "Red");
        RouletteElement Six = new RouletteElement("6", 6, "Black");
        RouletteElement Seven = new RouletteElement("7", 7, "Red");
        RouletteElement Eight = new RouletteElement("8", 8, "Black");
        RouletteElement Nine = new RouletteElement("9", 9, "Red");
        RouletteElement Ten = new RouletteElement("10", 10, "Black");
        RouletteElement Eleven = new RouletteElement("11", 11, "Black");
        RouletteElement Twelve = new RouletteElement("12", 12, "Red");
        RouletteElement Thirteen = new RouletteElement("13", 13, "Black");
        RouletteElement Fourteen = new RouletteElement("14", 14, "Red");
        RouletteElement Fifteen = new RouletteElement("15", 15, "Black");
        RouletteElement Sixteen = new RouletteElement("16", 16, "Red");
        RouletteElement Seventeen = new RouletteElement("17", 17, "Black");
        RouletteElement Eighteen = new RouletteElement("18", 18, "Red");
        RouletteElement Nineteen = new RouletteElement("19", 19, "Red");
        RouletteElement Twenty = new RouletteElement("20", 20, "Black");
        RouletteElement TwentyOne = new RouletteElement("21", 21, "Red");
        RouletteElement TwentyTwo = new RouletteElement("22", 22, "Black");
        RouletteElement TwentyThree = new RouletteElement("23", 23, "Red");
        RouletteElement TwentyFour = new RouletteElement("24", 24, "Black");
        RouletteElement TwentyFive = new RouletteElement("25", 25, "Red");
        RouletteElement TwentySix = new RouletteElement("26", 26, "Black");
        RouletteElement TwentySeven = new RouletteElement("27", 27, "Red");
        RouletteElement TwentyEight = new RouletteElement("28", 28, "Black");
        RouletteElement TwentyNine = new RouletteElement("29", 29, "Black");
        RouletteElement Thirty = new RouletteElement("30", 30, "Red");
        RouletteElement ThirtyOne = new RouletteElement("31", 31, "Black");
        RouletteElement ThirtyTwo = new RouletteElement("32", 32, "Red");
        RouletteElement ThirtyThree = new RouletteElement("33", 33, "Black");
        RouletteElement ThirtyFour = new RouletteElement("34", 34, "Red");
        RouletteElement ThirtyFive = new RouletteElement("35", 35, "Black");
        RouletteElement ThirtySix = new RouletteElement("36", 36, "Red");


        List<RouletteElement> rouletteWheel = new List<RouletteElement>();

        













    }


    
    public class WinningOptions
    {
        //split

        //Left
        public void LeftSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the left");
            Console.WriteLine(element.Value);
            Console.WriteLine(element.Value - 1);
        }


        //Right
        public void RightSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the right");
            Console.WriteLine(element.Value);
            Console.WriteLine(element.Value+1);
        }


        //Top
        public void TopSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the top");
            Console.WriteLine(element.Value);
            Console.WriteLine(element.Value-3);
        }
        //Bottom
        public void BottomSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the bottom");
            Console.WriteLine(element.Value);
            Console.WriteLine(element.Value+3);
        }
        //TopLeft
        public void TopLeftSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the top-left");
            Console.WriteLine(element.Value);
            Console.WriteLine(element.Value-1);
            Console.WriteLine(element.Value-3);
            Console.WriteLine(element.Value-4);
        }
        //TopRight
        public void TopRightSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the top-right");
            Console.WriteLine(element.Value);
            Console.WriteLine(element.Value+1);
            Console.WriteLine(element.Value-2);
            Console.WriteLine(element.Value-3);
        }
        //BottomLeft
        public void BottomLeftSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the bottom-left");
            Console.WriteLine(element.Value);
            Console.WriteLine(element.Value-1);
            Console.WriteLine(element.Value+2);
            Console.WriteLine(element.Value+3);
        }
        //BottomRight
        public void BottomRightSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the bottom-right");
            Console.WriteLine(element.Value);
            Console.WriteLine(element.Value + 1);
            Console.WriteLine(element.Value + 3);
            Console.WriteLine(element.Value + 4);
        }

        public bool IsTopRow(RouletteElement element)
        {
            if (element.Value - 3 <= 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool IsBottomRow(RouletteElement element)
        {
            if (element.Value + 3 >= 36)
            {
                return true;
            }
            else
                return false;
        }


        public void SplitTest(RouletteElement element)
        {
            //test if in first column
            if((element.Value - 1) % 3 == 0)
            {
                //if not in first row
                if (!IsTopRow(element))
                {
                    TopSplit(element);
                    TopRightSplit(element);
                }
                //if not in last row
                if (!IsBottomRow(element))
                {
                    BottomSplit(element);
                    BottomRightSplit(element);
                }
                //no matter what
                RightSplit(element);
            }

            //test if in second column
            else if((element.Value - 2) % 3 == 0)
            {

                //if not in first row
                if (!IsTopRow(element))
                {
                    TopLeftSplit(element);
                    TopSplit(element);
                    TopRightSplit(element);
                }
                //if not in last row
                if (!IsBottomRow(element))
                {
                    BottomLeftSplit(element);
                    BottomSplit(element);
                    BottomRightSplit(element);
                }
                //no matter what
                RightSplit(element);
                LeftSplit(element);

            }

               
           //test if in third column
           else if(element.Value % 3 == 0)
            {

                //if not in first row
                if (!IsTopRow(element))
                {
                    TopLeftSplit(element);
                    TopSplit(element);
                }
                //if not in last row
                if (!IsBottomRow(element))
                {
                    BottomLeftSplit(element);
                    BottomSplit(element);
                }
                //no matter what
                LeftSplit(element);

            }
        }





        //red/black


        //evens/odd

        //row

        //street



    }
}
