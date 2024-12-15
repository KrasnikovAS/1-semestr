namespace Test
{
    class BasicIO
    {
        static void Main()
        {
            Console.WriteLine("Введите номер телефона");

            long number = Convert.ToInt64(Console.ReadLine());
            string result = String.Format("{0:+# (####) ##-##-##}", number);
            Console.WriteLine($"Номер телефона: {result}");
        }
    }
}
