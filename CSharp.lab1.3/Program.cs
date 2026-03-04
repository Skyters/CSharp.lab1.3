namespace CSharp.lab1._3
{
    public class Logic
    {
        public static string Transformation(string str)
        {
            int count = 0;
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    count++;
                }

            }

            double percent = (double)count / str.Length * 100;
            result += "\nБукв: " + count;
            result += "\nПроцент букв: " + percent.ToString("F2");

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string str = Console.ReadLine();

            var res = Logic.Transformation(str);

            Console.WriteLine(res);
        }
    }
}
