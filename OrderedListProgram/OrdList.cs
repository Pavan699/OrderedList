using System;
using System.Collections.Generic;
using System.Text;

namespace OrderedListProgram
{
    /// <summary>
    /// OrdList class to make order list
    /// </summary>
    class OrdList
    {
        /// <summary>
        /// ListOrder() to add,sort and check if present give msg else add it into list
        /// </summary>
        public static void ListOrder()
        {
            List<int> list = new List<int>();

            list.Add(27);
            list.Add(90);
            list.Add(43);
            list.Add(35);
            list.Add(86);
            list.Add(11);
            //sorting the list
            list.Sort();
            foreach (int i in list)
            {
                Console.Write(" " + i);
            }
            //getting user input for searching
            Console.WriteLine();
            Console.Write("Enter the Number to Search : ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool flag = false;
            for (int j = 0; j < list.Count; j++)
            {
                if (list[j] == number)
                {
                    Console.WriteLine("Value {0} is Present in the list", number);
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Number {0} is Not Present We Are Adding the Number", number);
                list.Add(number);
                list.Sort();
            }
            //printing
            foreach (int i in list)
            {
                Console.Write(" " + i);
            }
        }
    }
}

