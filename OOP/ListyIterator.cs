using System;
using System.Collections;
using System.Collections.Generic;

namespace _01.ListyIterator
{
    public class Collection : IEnumerable<string>
    {
        private List<string> list;

        public Collection(List<string> list )
        {
            this.List = list;
        }

        public List<string> List
        {
            get
            {
                return list;
            }

            set
            {
                list = value;
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.list.GetEnumerator();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputCollection = Console.ReadLine().Split(' ');

            List<string> list = new List<string>();

            for (int i = 1; i < inputCollection.Length; i++)
            {
                list[i - 1] = inputCollection[i];
            }

            Collection coll = new Collection(list);




        }
    }
}
