//question4
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        int oddCount = 0;
        int evenCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            if (numbers[i] % 2 != 0)
                oddCount++;
            else
                evenCount++;
        }

        //Store odd numbers into an array
        int[] oddNumbers = new int[oddCount];
        int[] evenNumbers = new int[evenCount];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 != 0)
                oddNumbers[--oddCount] = numbers[i];
            else
                evenNumbers[--evenCount] = numbers[i];
        }

        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddNumbers.Length; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < evenNumbers.Length; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }

        Console.ReadLine();
    }
}

