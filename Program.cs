namespace FilterArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строки через пробел:");
            string input = Console.ReadLine();

            string[] originalArray = input.Split(' ');
        }

        static string[] FilterStrings(string[] originalArray)
        {
            int count = 0;

            // Подсчитываем количество строк, удовлетворяющих условию
            for (int i = 0; i < originalArray.Length; i++)
            {
                if (originalArray[i].Length <= 3)
                {
                    count++;
                }
            }

            // Создаем новый массив
            string[] newArray = new string[count];

            // Заполняем новый массив
            int index = 0;
            for (int i = 0; i < originalArray.Length; i++)
            {
                if (originalArray[i].Length <= 3)
                {
                    newArray[index] = originalArray[i];
                    index++;
                }
            }

            return newArray;
        }
    }
}