using System;
using System.Numerics;
using System.Diagnostics;

namespace projekt2LiczbyPierwsze
{
    class Program
    {
        static ulong DivsNum;
        const int NIter = 10; //liczba powtórzeń testu
        static bool AlgorytmPrzykładowy(BigInteger Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            else for (BigInteger u = 3; u < Num / 2; u += 2)
                {
                    DivsNum++;
                    if (Num % u == 0) return false;
                }
            return true;         
        }
        static bool IsPresent_AlgorytmPrzykładowyInstrumentacja(BigInteger Num)
        {
            for(int i=0; i<Num; i++)
            {
                DivsNum++;
                if (AlgorytmPrzykładowy(Num)) return true;
            }
            return false;
        }
        static bool IsPresent_AlgorytmPrzykładowyTime(BigInteger Num)
        {
            for (int i = 0; i < Num; i++)
            {
                if (AlgorytmPrzykładowy(Num)) return true;
            }
            return false;
        }
        static void AlgorytmPrzykładowyInstrumentacja(BigInteger Num)
        {
            DivsNum = 0;
            bool Present = IsPresent_AlgorytmPrzykładowyInstrumentacja(Num);
            Console.WriteLine("\t" + DivsNum);
        }
        static void AlgorytmPrzykładowyTime(BigInteger Num)
        {
            double ElapsedSeconds;
            long ElapsedTime = 0, MinTime = long.MaxValue, MaxTime = long.MinValue, IterationElapsedTime;
            for (int n = 0; n < (NIter + 1 + 1); ++n)
            {
                long StartingTime = Stopwatch.GetTimestamp();
                bool Present = IsPresent_AlgorytmPrzykładowyTime(Num);
                long EndingTime = Stopwatch.GetTimestamp();
                IterationElapsedTime = EndingTime - StartingTime;
                ElapsedTime += IterationElapsedTime;
                if (IterationElapsedTime < MinTime) MinTime = IterationElapsedTime;
                if (IterationElapsedTime > MaxTime) MaxTime = IterationElapsedTime;
            }
            ElapsedTime -= (MinTime + MaxTime);
            ElapsedSeconds = ElapsedTime * (1.0 / (NIter * Stopwatch.Frequency));
            Console.Write("\t" + ElapsedSeconds.ToString("F10"));
        }
        static bool AlgorytmLepszy(BigInteger Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            else for (BigInteger u = 3; u*u <= Num; u += 2)
                {
                    DivsNum++;
                    if (Num % u == 0) return false;
                }
            return true;
        }
        static bool IsPresent_AlgorytmLepszyInstrumentacja(BigInteger Num)
        {
            for (int i = 0; i < Num; i++)
            {
                DivsNum++;
                if (AlgorytmLepszy(Num)) return true;
            }
            return false;
        }
        static bool IsPresent_AlgorytmLepszyTime(BigInteger Num)
        {
            for (int i = 0; i < Num; i++)
            {
                if (AlgorytmLepszy(Num)) return true;
            }
            return false;
        }
        static void AlgorytmLepszyInstrumentacja(BigInteger Num)
        {
            DivsNum = 0;
            bool Present = IsPresent_AlgorytmLepszyInstrumentacja(Num);
            Console.WriteLine("\t" + DivsNum);
        }
        static void AlgorytmLpeszyTime(BigInteger Num)
        {
            double ElapsedSeconds;
            long ElapsedTime = 0, MinTime = long.MaxValue, MaxTime = long.MinValue, IterationElapsedTime;
            for (int n = 0; n < (NIter + 1 + 1); ++n)
            {
                long StartingTime = Stopwatch.GetTimestamp();
                bool Present = IsPresent_AlgorytmLepszyTime(Num);
                long EndingTime = Stopwatch.GetTimestamp();
                IterationElapsedTime = EndingTime - StartingTime;
                ElapsedTime += IterationElapsedTime;
                if (IterationElapsedTime < MinTime) MinTime = IterationElapsedTime;
                if (IterationElapsedTime > MaxTime) MaxTime = IterationElapsedTime;
            }
            ElapsedTime -= (MinTime + MaxTime);
            ElapsedSeconds = ElapsedTime * (1.0 / (NIter * Stopwatch.Frequency));
            Console.Write("\t" + ElapsedSeconds.ToString("F10"));
        }
        static bool AlgorytmJeszczeLepszy(BigInteger Num)
        {
            if (Num < 2) return false;
            else if (Num < 4) return true;
            else if (Num % 2 == 0) return false;
            else
            {
                for (BigInteger u = 3; u*u <= (long)Math.Sqrt((double)Num); u += 2)
                {
                    DivsNum++;
                    if (Num % u == 0) return false;
                }  
            }
            return true;
        }
        static bool IsPresent_AlgorytmJeszczeLepszyInstrumentacj(BigInteger Num)
        {
            for (int i = 0; i < Num; i++)
            {
                DivsNum++;
                if (AlgorytmJeszczeLepszy(Num)) return true;
            }
            return false;
        }
        static bool IsPresent_AlgorytmJeszczeLepszyTime(BigInteger Num)
        {
            for (int i = 0; i < Num; i++)
            {
                if (AlgorytmJeszczeLepszy(Num)) return true;
            }
            return false;
        }
        static void AlgorytmJeszczeLepszyInstrumentacja(BigInteger Num)
        {
            DivsNum = 0;
            bool Present = IsPresent_AlgorytmJeszczeLepszyInstrumentacj(Num);
            Console.WriteLine("\t" + DivsNum);
        }
        static void AlgorytmJeszczeLpeszyTime(BigInteger Num)
        {
            double ElapsedSeconds;
            long ElapsedTime = 0, MinTime = long.MaxValue, MaxTime = long.MinValue, IterationElapsedTime;
            for (int n = 0; n < (NIter + 1 + 1); ++n)
            {
                long StartingTime = Stopwatch.GetTimestamp();
                bool Present = IsPresent_AlgorytmJeszczeLepszyTime(Num);
                long EndingTime = Stopwatch.GetTimestamp();
                IterationElapsedTime = EndingTime - StartingTime;
                ElapsedTime += IterationElapsedTime;
                if (IterationElapsedTime < MinTime) MinTime = IterationElapsedTime;
                if (IterationElapsedTime > MaxTime) MaxTime = IterationElapsedTime;
            }
            ElapsedTime -= (MinTime + MaxTime);
            ElapsedSeconds = ElapsedTime * (1.0 / (NIter * Stopwatch.Frequency));
            Console.Write("\t" + ElapsedSeconds.ToString("F10"));
        }
        static void Main(string[] args)
        {
            BigInteger[] PrimeNums = new BigInteger[]{ 101, 1009, 10091, 100913, 1009139, 10091401, 100914061, 1009140611, 10091406133, 100914061337, 1009140613399 };

            //BigInteger[] PrimeNums = new BigInteger[] { 101, 1009, 10091, 100913, 1009139, 10091401, 100914061, 1009140611 };

            //BigInteger[] PrimeNums = new BigInteger[] { 10091406133 };

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            stopwatch.Start();
            foreach (BigInteger numb in PrimeNums)
            {
                Console.WriteLine("Badana liczba:\t\t{0}",numb);
                Console.Write("AlgPrzykłInstr:\t");
                AlgorytmPrzykładowyInstrumentacja(numb);
                Console.Write("AlgPrzykłTime:\t");
                AlgorytmPrzykładowyTime(numb);
                Console.Write("\nAlgLepszyInstr:\t");
                AlgorytmLepszyInstrumentacja(numb);
                Console.Write("AlgLepszyTime:\t");
                AlgorytmLpeszyTime(numb);
                Console.Write("\nAlgJeszLepszyInst:");
                AlgorytmJeszczeLepszyInstrumentacja(numb);
                Console.Write("AlgJeszLepszyTime:");
                AlgorytmJeszczeLpeszyTime(numb);
                Console.WriteLine();
                Console.WriteLine();
            }
            stopwatch.Stop();
            Console.WriteLine("Time taken : {0}", stopwatch.Elapsed);
        }
    }
}
