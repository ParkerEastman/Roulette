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

        public List<RouletteElement> rouletteWheel;

        readonly RouletteElement Zero = new RouletteElement("0", 0, "Green");
        readonly RouletteElement ZeroZero = new RouletteElement("00", 0, "Green");
        readonly RouletteElement One = new RouletteElement("1", 1, "Red");
        readonly RouletteElement Two = new RouletteElement("2", 2, "Black");
        readonly RouletteElement Three = new RouletteElement("3", 3, "Red");
        readonly RouletteElement Four = new RouletteElement("4", 4, "Black");
        readonly RouletteElement Five = new RouletteElement("5", 5, "Red");
        readonly RouletteElement Six = new RouletteElement("6", 6, "Black");
        readonly RouletteElement Seven = new RouletteElement("7", 7, "Red");
        readonly RouletteElement Eight = new RouletteElement("8", 8, "Black");
        readonly RouletteElement Nine = new RouletteElement("9", 9, "Red");
        readonly RouletteElement Ten = new RouletteElement("10", 10, "Black");
        readonly RouletteElement Eleven = new RouletteElement("11", 11, "Black");
        readonly RouletteElement Twelve = new RouletteElement("12", 12, "Red");
        readonly RouletteElement Thirteen = new RouletteElement("13", 13, "Black");
        readonly RouletteElement Fourteen = new RouletteElement("14", 14, "Red");
        readonly RouletteElement Fifteen = new RouletteElement("15", 15, "Black");
        readonly RouletteElement Sixteen = new RouletteElement("16", 16, "Red");
        readonly RouletteElement Seventeen = new RouletteElement("17", 17, "Black");
        readonly RouletteElement Eighteen = new RouletteElement("18", 18, "Red");
        readonly RouletteElement Nineteen = new RouletteElement("19", 19, "Red");
        readonly RouletteElement Twenty = new RouletteElement("20", 20, "Black");
        readonly RouletteElement TwentyOne = new RouletteElement("21", 21, "Red");
        readonly RouletteElement TwentyTwo = new RouletteElement("22", 22, "Black");
        readonly RouletteElement TwentyThree = new RouletteElement("23", 23, "Red");
        readonly RouletteElement TwentyFour = new RouletteElement("24", 24, "Black");
        readonly RouletteElement TwentyFive = new RouletteElement("25", 25, "Red");
        readonly RouletteElement TwentySix = new RouletteElement("26", 26, "Black");
        readonly RouletteElement TwentySeven = new RouletteElement("27", 27, "Red");
        readonly RouletteElement TwentyEight = new RouletteElement("28", 28, "Black");
        readonly RouletteElement TwentyNine = new RouletteElement("29", 29, "Black");
        readonly RouletteElement Thirty = new RouletteElement("30", 30, "Red");
        readonly RouletteElement ThirtyOne = new RouletteElement("31", 31, "Black");
        readonly RouletteElement ThirtyTwo = new RouletteElement("32", 32, "Red");
        readonly RouletteElement ThirtyThree = new RouletteElement("33", 33, "Black");
        readonly RouletteElement ThirtyFour = new RouletteElement("34", 34, "Red");
        readonly RouletteElement ThirtyFive = new RouletteElement("35", 35, "Black");
        readonly RouletteElement ThirtySix = new RouletteElement("36", 36, "Red");


        public RouletteWheel()
        {
            rouletteWheel = new List<RouletteElement>
            {
                Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
                Eleven, Twelve, Thirteen, Fourteen, Fifteen, Sixteen, Seventeen, Eighteen, Nineteen, Twenty,
                TwentyOne, TwentyTwo, TwentyThree, TwentyFour, TwentyFive, TwentySix, TwentySeven, TwentyEight, TwentyNine, Thirty,
                ThirtyOne, ThirtyTwo, ThirtyThree, ThirtyFour, ThirtyFive, ThirtySix, ZeroZero
            };
        

        
        }

        public void WinningBets(RouletteElement element)
        {
                WinningOptions wins = new WinningOptions();
                wins.PossibleWins(element);
        }
















    }


    
    public class WinningOptions
    {

        //Left
        private void LeftSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the left");
            //Console.WriteLine(element.Value);
            //Console.WriteLine(element.Value - 1);
        }

        //Right
        private void RightSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the right");
            //Console.WriteLine(element.Value);
            //Console.WriteLine(element.Value+1);
        }

        //Top
        private void TopSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the top");
            //Console.WriteLine(element.Value);
            //Console.WriteLine(element.Value-3);
        }
        //Bottom
        private void BottomSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the bottom");
            //Console.WriteLine(element.Value);
            //Console.WriteLine(element.Value+3);
        }
        //TopLeft
        private void TopLeftSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the top-left corner");
            //Console.WriteLine(element.Value);
            //Console.WriteLine(element.Value-1);
            //Console.WriteLine(element.Value-3);
            //Console.WriteLine(element.Value-4);
        }
        //TopRight
        private void TopRightSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the top-right corner");
            //Console.WriteLine(element.Value);
            //Console.WriteLine(element.Value+1);
            //Console.WriteLine(element.Value-2);
            //Console.WriteLine(element.Value-3);
        }
        //BottomLeft
        private void BottomLeftSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the bottom-left corner");
            //Console.WriteLine(element.Value);
            //Console.WriteLine(element.Value-1);
            //Console.WriteLine(element.Value+2);
            //Console.WriteLine(element.Value+3);
        }
        //BottomRight
        private void BottomRightSplit(RouletteElement element)
        {
            Console.WriteLine("Split on the bottom-right corner");
            //Console.WriteLine(element.Value);
            //Console.WriteLine(element.Value + 1);
            //Console.WriteLine(element.Value + 3);
            //Console.WriteLine(element.Value + 4);
        }

        private bool IsTopRow(RouletteElement element)
        {
            if (element.Value - 3 <= 0)
            {
                return true;
            }
            else
                return false;
        }

        private bool IsBottomRow(RouletteElement element)
        {
            if (element.Value + 3 >= 36)
            {
                return true;
            }
            else
                return false;
        }


        private void SplitTest(RouletteElement element)
        {
            if(IsFirstColumn(element))
            {
                if (!IsTopRow(element))
                {
                    TopSplit(element);
                    TopRightSplit(element);
                }
                if (!IsBottomRow(element))
                {
                    BottomSplit(element);
                    BottomRightSplit(element);
                }
                //no matter what
                RightSplit(element);
            }

            else if(IsSecondColumn(element))
            {

                if (!IsTopRow(element))
                {
                    TopLeftSplit(element);
                    TopSplit(element);
                    TopRightSplit(element);
                }
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

               
           else if(IsThirdColumn(element))
            {
                if (!IsTopRow(element))
                {
                    TopLeftSplit(element);
                    TopSplit(element);
                }
                if (!IsBottomRow(element))
                {
                    BottomLeftSplit(element);
                    BottomSplit(element);
                }
                //no matter what
                LeftSplit(element);

            }
        }

        private bool IsFirstColumn(RouletteElement element)
        {
            if((element.Value > 0) && ((element.Value - 1) % 3 == 0))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private bool IsSecondColumn(RouletteElement element)
        {
            if((element.Value > 0) && ((element.Value - 2) % 3 == 0))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private bool IsThirdColumn(RouletteElement element)
        {
            if((element.Value > 0) && (element.Value % 3 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void EvenorOdd(RouletteElement element)
        {
            if(element.Value>0 && element.Value % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else if(element.Value>0 && element.Value % 2 == 1)
            {
                Console.WriteLine("Odd");
            }
        }

        private void RedorBlack(RouletteElement element)
        {
            if(element.Color == "Red")
            {
                Console.WriteLine("Red");
            }
            else if(element.Color == "Black")
            {
                Console.WriteLine("Black");
            }
        }

        private void Column(RouletteElement element)
        {
            if (IsFirstColumn(element))
            {
                Console.WriteLine("Column 1");
            }
            else if (IsSecondColumn(element))
            {
                Console.WriteLine("Column 2");
            }
            else if (IsThirdColumn(element))
            {
                Console.WriteLine("Column 3");
            }

        }

        private void LowHigh(RouletteElement element)
        {
            int set = InGroupsOf(element, 18);
            if(set == 1)
            {
                Console.WriteLine("Low");
            }
            else if(set == 2)
            {
                Console.WriteLine("High");
            }
        }

        private void Dozens(RouletteElement element)
        {
                Console.WriteLine($"Dozen {InGroupsOf(element, 12)}");
        }

        private void Street(RouletteElement element)
        {
            Console.WriteLine($"Street {InGroupsOf(element, 3)}");
        }

        private void SetOfSix(RouletteElement element)
        {
            Console.WriteLine($"Set of Six number {InGroupsOf(element, 6)}");
        }

        private int InGroupsOf(RouletteElement element, int group)  //returns location of subset group
        {
            int inGroup = 0;
            if (element.Value > 0)
            {
                if (element.Value % group == 0)
                {
                    inGroup = element.Value / group;
                }
                else
                {   //floor to the next group (since the first group is group "Zero")
                    inGroup = (((element.Value + group) - element.Value % group) / group);
                }

            }
            return inGroup;
        }

        public void PossibleWins(RouletteElement element)
        {
            Console.WriteLine($"Winning bets for {element.Name} Are: ");
            Console.WriteLine(element.Value);
            if (element.Value > 0)
            {
                EvenorOdd(element);
                RedorBlack(element);
                LowHigh(element);
                Dozens(element);
                Column(element);
                Street(element);
                SetOfSix(element);
                SplitTest(element);
            }

            Console.WriteLine("\n\n\n\n\n");
        }

    }



}
