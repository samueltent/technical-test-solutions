namespace SingleNumber
{
    internal class SingleNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert integeres separated by comma(,): \n");

            string input = Console.ReadLine();

            int[] nums = input.Split(',').Select(s => Convert.ToInt32(s)).ToArray();

            int singeNumber = IsSingleNumber(nums);

            Console.WriteLine(singeNumber);
        }

        public static int IsSingleNumber(int[] nums)
        {
            int res = 0;

            foreach (int num in nums)
            {
                res ^= num;
            }

            return res;
        }
    }
}
