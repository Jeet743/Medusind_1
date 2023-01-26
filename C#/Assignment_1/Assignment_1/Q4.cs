using System;


namespace Assignment_1
{
    internal class Q4
    {
        public static void Main(string[]args)
        {
            int[] arr1 = new int[10];
            int i, maxi, mini, no;
                
            Console.Write("Please Enter The Number Of Elements For Array: ");
            no = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} Elements In The Array :", no);
            for (i = 0; i < no; i++)
            {
                Console.Write("\nElement - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Average
            float sum = 0f;
            for (i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }
            Console.WriteLine("\nAverage value of Array elements : {0}", (sum / arr1.Length));

            // Min Max
            maxi = arr1[0];
            mini = arr1[0];

            for (i = 1; i < no; i++)
            {
                if (arr1[i] > maxi)
                {
                    maxi = arr1[i];
                }


                if (arr1[i] < mini)
                {
                    mini = arr1[i];
                } 
            }

           
            Console.Write("\nMaximum Element Is : {0}\n", maxi);
            Console.Write("\nMinimum Element Is : {0}", mini);
            Console.ReadLine();
        }

        

        
    }
}
