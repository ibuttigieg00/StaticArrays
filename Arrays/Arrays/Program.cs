using Arrays;

class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;

        int [] orderedNums = solution.OrderList(nums);
        Console.WriteLine(solution.ReadAllElements(orderedNums));

        orderedNums = solution.RemoveLastElement(orderedNums);
        Console.WriteLine(solution.ReadAllElements(orderedNums));

        //Console.WriteLine(solution.RemoveElement(nums, val));

        Console.ReadLine();
    }
}