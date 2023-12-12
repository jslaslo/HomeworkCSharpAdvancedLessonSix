namespace Homework
{
    internal class Program
    {
       static public List <int> Find(int[] nums, int target)
        {
            Array.Sort(nums);
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length-2; i++)
            {
                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add(nums[i]);
                        result.Add(nums[left]);
                        result.Add(nums[right]);
                        break;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;    
                    }
                    if(result.Count > 0)
                    {
                        break;
                    }
                }
            }
            return result;            
        }
        static void Main(string[] args)
        {
           int [] listArray = new int [] {1,2,3,4,5,6,7,8,9 };
           List<int> a =  Find(listArray, 10); 

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

        }
    }
}
