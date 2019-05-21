using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7._Byte_Flip
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split();

            
            List<string> list = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 2)
                {
                    string reversedNum = arr[i].Substring(1) + arr[i].Substring(0, 1);
                    list.Add(reversedNum);
                   
                }
            }

            list.Reverse();

            string decoded = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                decoded += Convert.ToInt32(list[i][0]).ToString() + " ";
                Convert.ToChar(decoded[i]);


            }
