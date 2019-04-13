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
            Random rand = new Random();
            rand.Next(0, 37);

            RouletteWheel rwInst = new RouletteWheel();


            WinningOptions winOpts = new WinningOptions();

            winOpts.SplitTest(rwInst.rouletteWheel[rand.Next(0, 37)]);






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
