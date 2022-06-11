namespace Logical_programming
{

    class Program
    {

        public void Main(string[]args)
        {
            int n;
            Console.WriteLine("Welcome To Day 6 of programming,Choose from the following numbers");
            Console.WriteLine("1.Fibonacci series");
            Console.WriteLine("2.Prime number");
            Console.WriteLine("3.Perfect number");
            Console.WriteLine("4.Reverse a number");
            n = Convert.ToInt32(Console.ReadLine());



            switch(n)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Series();
                    break;

                case 2:
                    Prime prime = new Prime();
                    prime.PRIME();
                    break;


                case 3:
                    Perfect_number perfect_Number = new Perfect_number();
                    perfect_Number.PERFECT();
                    break;



                case 4:
                    Reverse reverse = new Reverse();
                    reverse.REVERSE();
                    break;





                    

            

            }

        }


    }


}