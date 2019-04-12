using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            doWork();
        }


        static void doWork()
        {
            RouletteElement someElement;

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

            RouletteElement[] rouletteWheel = {Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
                Eleven, Twelve, Thirteen, Fourteen, Fifteen, Sixteen, Seventeen, Eighteen, Nineteen, Twenty,
                TwentyOne, TwentyTwo, TwentyThree, TwentyFour, TwentyFive, TwentySix, TwentySeven, TwentyEight, TwentyNine, Thirty,
                ThirtyOne, ThirtyTwo, ThirtyThree, ThirtyFour, ThirtyFive, ThirtySix, ZeroZero
            };

            WinningOptions winOpts = new WinningOptions();

            winOpts.SplitTest(rouletteWheel[1]);






        }









    }

    //randomly generate 38 num from 0 to 37
    //37 is 00



    //if rNum == 0 its green
    //else if rNum % 2 = 0 its black
    //else rNum is red


//create a class for each number 
// bool even, if num % 2 = 0
//string Red/black =   
//lows/highs


//1. Numbers: the number of the bin
//2. Evens/Odds: even or odd numbers
//3. Reds/Blacks: red or black colored numbers
//4. Lows/Highs: low(1 {
//        18) or high(19 {
//            38) numbers.
//5.Dozens: row thirds, 1 {
//                12, 13 {
//                    24, 25 {
//                        36
//6.Columns: rst, second, or third columns
//7.Street: rows, e.g., 1 / 2 / 3 or 22 / 23 / 24
//8. 6 Numbers: double rows, e.g., 1 / 2 / 3 / 4 / 5 / 6 or 22 / 23 / 24 / 25 / 26 / 26
//9.Split: at the edge of any two contiguous numbers, e.g., 1 / 2, 11 / 14, and 35 / 36
//10.Corner: at the intersection of any four contiguous numbers, e.g., 1 / 2 / 4 / 5, or 23 / 24 / 26 / 27



                        //10 pts per bet.  10 bets total.




                    }
