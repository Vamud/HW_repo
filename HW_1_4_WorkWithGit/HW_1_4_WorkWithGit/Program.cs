namespace HW_1_4_WorkWithGit
{
    /// <summary>
    /// Main class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Method.
        /// </summary>
        /// <param name="args">One method.</param>
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] randomArray = new int[arrayLength];

            // filling an array with random numbers
            // count even and odd numbers
            int counterEvenNumbers = 0;
            int counterOddNumbers = 0;
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = new Random().Next(1, 26);

                if (randomArray[i] % 2 == 0)
                {
                    counterEvenNumbers++;
                }
                else
                {
                    counterOddNumbers++;
                }
            }

            // create arrays for even and odd numbers
            // filling these arrays
            int[] arrayEvenNumbers = new int[counterEvenNumbers];
            int[] arrayOddNumbers = new int[counterOddNumbers];
            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < randomArray.Length; i++)
            {
                if (randomArray[i] % 2 == 0)
                {
                    arrayEvenNumbers[counter1] = randomArray[i];
                    counter1++;
                }
                else
                {
                    arrayOddNumbers[counter2] = randomArray[i];
                    counter2++;
                }
            }

            // creat and filling arrays of literal equivalents
            List<char> list = new List<char>();
            for (char c = 'a'; c <= 'z'; ++c)
            {
                list.Add(c);
            }

            char[] alphabet = list.ToArray();

            char[] numbersToCharEven = new char[arrayEvenNumbers.Length];
            char[] numbersToCharOdd = new char[arrayOddNumbers.Length];

            for (int i = 0; i < numbersToCharEven.Length; i++)
            {
                numbersToCharEven[i] = alphabet[arrayEvenNumbers[i]];
            }

            for (int i = 0; i < numbersToCharOdd.Length; i++)
            {
                numbersToCharOdd[i] = alphabet[arrayOddNumbers[i]];
            }

            // handle the exception
            // count who has more uppercase
            char[] exception = { 'a', 'e', 'i', 'd', 'h', 'j' };

            int ToUpperExceptionNumber(char[] array, char[] exceptionArray)
            {
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < exceptionArray.Length; j++)
                    {
                        if (array[i] == exceptionArray[j])
                        {
                            array[i] = char.ToUpper(array[i]);
                            counter++;
                        }
                    }
                }

                return counter;
            }

            int arrayEven = ToUpperExceptionNumber(numbersToCharEven, exception);
            int arrayOdd = ToUpperExceptionNumber(numbersToCharOdd, exception);

            // convert the array to a sting separated by spaces
            string OutputWithSpases(char[] array)
            {
                char[] result = new char[array.Length + (array.Length - 1)];
                int counter = 0;
                string readyString;

                for (int i = 0; i < result.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        result[i] = array[counter];
                        counter++;
                    }
                    else
                    {
                        result[i] = ' ';
                    }
                }

                readyString = new string(result);
                return readyString;
            }

            // output the array with a more uppercase
            if (arrayEven < arrayOdd)
            {
                Console.WriteLine($"Array more uppercase: {OutputWithSpases(numbersToCharOdd)}");
            }
            else
            {
                Console.WriteLine($"Array more uppercase: {OutputWithSpases(numbersToCharEven)}");
            }

            // output all arrays6
            Console.WriteLine($"Array of even numbers: {OutputWithSpases(numbersToCharEven)}");
            Console.WriteLine($"Array of odd numbers: {OutputWithSpases(numbersToCharOdd)}");
        }
    }
}