namespace Name
{
    public class Test
    {
        public int Add(int a, int b)
        {
            if(a == 0)
            {
                throw new ArgumentException("The First Number Cannot be zero.");
            }
            return a+b;
        }
    }
}