namespace Test
{
    class BasicIO
    {
        static void Main()
        {
            Console.WriteLine("««Курский государственный политехнический колледж»»");
            Console.WriteLine("Контактная информация");

            long number = 74712370219;
            string result = String.Format("{0:+# (####) ##-##-##}", number);
            Console.WriteLine($"Контактные телефоны: {result}");
            Console.WriteLine($"Контактный факс: {result}");
        }
    }
}
