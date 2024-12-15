namespace Test
{
    class BasicIO
    {
        static void Main()
        {
            string str;

            str = "Фамилия: {{ {0} }}, дата рождения: {{ {1} }}, место рождения: {{ {2} }}, возраст: {{ {3} }}";
            str = String.Format(str, "Васильев", "10.10.2020", "г.Курск", 24);
            Console.WriteLine(str);
        }
    }
}
