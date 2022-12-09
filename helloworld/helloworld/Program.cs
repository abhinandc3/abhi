namespace varibles
{


class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var number = 112;
        var num = 12;
            Console.WriteLine((double)number + (double)num);

            string k = "12345";
            int i = Convert.ToInt32(k);
            int j = int.Parse(k);
            Console.WriteLine(i );
            Console.WriteLine(j);
            try
            {
                string n = "true";
                bool m = Convert.ToBoolean(n);
                Console.WriteLine(n);
            }
            catch (Exception ex)
            {

            }

             
    }
}
}