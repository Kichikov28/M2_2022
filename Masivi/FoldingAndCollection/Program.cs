using System;
using System.Linq;

namespace FoldingAndCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rowLeft = nums.Length / 4;
            int rowRight = nums.Length / 4;
            int rowMiddle = nums.Length / 2;

            int[] numsLeft = new int[rowLeft];
            int[] numsRight = new int[rowRight];
            int[] numsMiddle = new int[rowMiddle];

            for (int i = 0; i < numsLeft.Length; i++)
            {
                numsLeft[i] = nums[i];
            }
            for (int i = 0; i < numsMiddle.Length; i++)
            {
                numsMiddle[i] = nums[i + rowLeft];
            }
            for (int i = 0; i < numsRight.Length; i++)
            {
                numsRight[i] = nums[i + rowLeft + rowMiddle];
            }
            Array.Reverse(numsLeft);
            Array.Reverse(numsRight);

            int[] finalnums = new int[rowMiddle];
            for (int i = 0; i < rowMiddle; i++)
            {
                if (i < rowLeft)
                {
                    finalnums[i] = numsLeft[i] + numsMiddle[i];
                }

                if (i >= rowLeft && i < rowMiddle)
                {
                    finalnums[i] = numsMiddle[i] + numsRight[i - (rowRight / 2 + 1)];
                }
            }

            Console.WriteLine(string.Join(" ",finalnums));
            //Console.WriteLine(string.Join(" ", numsLeft));
            //Console.WriteLine(string.Join(" ", numsMiddle));
            //Console.WriteLine(string.Join(" ", numsRight));



        }
    }
}
