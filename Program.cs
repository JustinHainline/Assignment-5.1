namespace Assignment_5._1
{
    internal class Program
    {
        public static bool IsPalindrome(string x)
        {
            string str = x;
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter a number.");
            string num1 = Console.ReadLine();
            Console.WriteLine($"Is {num1} a Palindrome? {IsPalindrome(num1)}");

            Console.WriteLine("Please enter a number.");
            string num2 = Console.ReadLine();
            Console.WriteLine($"Is {num2} a Palindrome? {IsPalindrome(num2)}");
        }   
    }
}
