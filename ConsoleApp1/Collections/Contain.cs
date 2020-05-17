using System;
using System.Collections.Generic;

namespace Collections
{
    public class Contain
    {
        private List<int> scoreList = new List<int>();
        private readonly Random rand = new Random();

        public void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                Add(rand.Next(1,10));
            }
        }

        public void Print()
        {
            foreach (int item in scoreList)
            {
                Console.Write(" "+ item);
            }
            Console.WriteLine();
        }

        public void Add(int temp)
        {
            scoreList.Add(temp);
        }

        public void Remove(int temp)
        {
            scoreList.Remove(temp);
        }

        public int Length()
        {
            return scoreList.Count;
        }
    }
}
