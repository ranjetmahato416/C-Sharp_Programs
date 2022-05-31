namespace Name 
{
    public class Functions
    {
        public void FunctionOne(int i)
        {
            int[] ints = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (var item in ints)
            {
                if(i == item)
                {
                    return;
                }
            }
        }

        public void FunctionTwo(int a, string b)
        {
            //do something
            Console.WriteLine($"Received input is {a} and {b}");
        }

        public void FunctionThree(int[] a)
        {
            Console.WriteLine($"Received Input is\n");
            for(int i =0; i < a.Length; i++)
            {

                Console.WriteLine(a[i]);
            }

        }
        public void FunctionFour(params int[] a)
        {
            Console.WriteLine($"Received Input is\n");
            for(int i =0; i < a.Length; i++)
            {

                Console.WriteLine(a[i]);
            }

        }

        public int FunctionFive(int a, int b)
        {
            return a+b;
        }

        public int FunctionFiveV2(int a, int b) => a+b;

        public void FunctionSix(int a, int b, out int res)
        {
            a++;
            b++;
            res = a+b;
        }

        public void FunctionSeven(in int a, in int b, out int res)
        {
            //a and b are readOnly variables within the function scope
            //a++ // not possible or
            //b++ // not possible
            res = a+b;
        }

        public void FunctionEight(int a, int b, ref int res)
        {
            res = a+b;
        }
    }
}