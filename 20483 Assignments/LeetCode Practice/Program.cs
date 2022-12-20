namespace LeetCode_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 6, 7, 7, 8, 6 };
            int removeAt = 2;

            string[] strArr = new string[] { "a","a","b","b","b","a","a","a","c","c","c","d" };

            //int result = RemoveElement(myArray, removeAt);
            bool result = ValidMountainArray(myArray);
            Console.WriteLine(result);

            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
        }

        public static void CountRepeats(string[] a)
        {
            int count = 0;
            int writePointer = 0;
            string[] newArray = new string[a.Length];

            while (writePointer < a.Length)
            {
                for (int readPointer = 1; readPointer < a.Length; readPointer++)
                {

                }
            }
        }

        public static int RemoveElement(int[] nums, int val)
        {
            Array.Sort(nums);
            int total = nums.Length;
            int remainder = 0;
            int leftOver = 0;

            while (remainder < total)
            {
                if (nums[remainder] == val)
                {
                    nums[remainder] = 0;
                    leftOver++;
                }
                remainder++;
            }
            return leftOver;
        }

        public static bool CheckIfExist(int[] arr)
        {
            var set = new HashSet<int>();
            int zerosCount = 0;
            foreach (var num in arr)
            {
                if (num == 0)
                    zerosCount++;
                set.Add(num * 2);
            }

            return zerosCount > 1 || arr.Any(num => set.Contains(num) && num != 0);
        }

        public static bool ValidMountainArray(int[] arr)
        {
            int mid = (arr.Length / 2);
            int begin = 1;
            int end = arr.Length - 1;
            if (arr.Length < 3)
            {
                return false;
            }

            do
            {
                if (arr[begin] <= arr[begin - 1])
                {
                    return false;
                }
                else if (arr[end] >= arr[end - 1])
                {
                    return false;
                }
                else
                {
                    begin++;
                    end--;
                }
            } while (begin != mid && end != mid) ;
            return true;
        }
    }
}