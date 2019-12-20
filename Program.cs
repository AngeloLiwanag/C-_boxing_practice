using System;
using System.Collections.Generic;

namespace box
{
    class Program
    {
        static void Main(string[] args)
        {
            box();
        }

        public static void box()
        {
            int sum = 0;
            List<object> box = new List<object>();
            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add("chair");

            for (int i = 0; i < box.Count; i++)
            {
                System.Console.WriteLine(box[i]);
                if (box[i] is int)
                {
                    sum += (int)box[i];
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
//  Create an empty List of type object
//  Add the following values to the list: 7, 28, -1, true, "chair"
//  Loop through the list and print all values (Hint: Type Inference might help here!)
//  Add all values that are Int type together and output the sum