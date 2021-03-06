﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ununion_Lists
{
    class ununionLists
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            int listCnt = int.Parse(Console.ReadLine());

            for (int i = 0; i < listCnt; i++)
            {
                List<int> currentList = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

                for (int index = 0; index < currentList.Count; index++)
                {
                    int currentElement = currentList[index];
                    if (primalList.Contains(currentElement))
                    {
                        primalList.RemoveAll(e => e == currentElement);
                    }
                    else
                    {
                        primalList.Add(currentElement);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
