namespace ProjectEulerAlgorithms
{
    public class ProjectEulerTasks
    {
        public static int Task1_MultiplesOf(int naturalMaxNum, int multiple1, int multiple2)
        {
            var sum = 0;

            for (int i = 0; i < naturalMaxNum; i++)
            {
                if (i % multiple1 == 0 || i % multiple2 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static long Task2_EvenFibbonaciNumbers(int maxFibNum = 4000000)
        {
            var sum = 0;


            var fib1 = 1;
            var fib2 = 2;
            var fib3 = 2;


            while (true)    
            {
                if (fib3 % 2 == 0)
                    sum += fib3;


                fib3 = fib2 + fib1;

                fib1 = fib2;
                fib2 = fib3;



                if (fib3 > maxFibNum)
                    break;
            }

            return sum;
        }


    }
}
