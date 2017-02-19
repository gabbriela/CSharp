using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Executor.DataStructures
{
    public class SimpleSortedList<T> : ISimpleOrderedBag<T> where T : IComparable<T>
    {
        private const int DefaultSize = 16;

        private T[] innerCollection;
        private int size;
        private IComparer<T> comparison;

        public SimpleSortedList(int capacity)
            : this (Comparer<T>.Create((x, y) => x.CompareTo(y)), capacity)
        {

        }

        private SimpleSortedList(Comparer<T> comparer, int capacity)
        {
            this.comparison = comparer;
        }

        //create two more constructors

        private void InitializeInnerCollection(int capacity)
        {
            if (capacity < 0)
            {
               throw new ArgumentException("Capacity cannot be negative!");
            }

            this.innerCollection = new T[capacity];
        }


        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T element)
        {
            if (this.innerCollection.Length == this.size)
            {
                Resize();
            }
            
            innerCollection[size] = element;
            this.size++;
            Array.Sort(this.innerCollection, 0, size, comparison);
        }

        public void AddAll(ICollection<T> elements)
        {
            if (this.Size + elements.Count >= this.innerCollection.Length)
            {
                this.MultiResize(elements);
            }

            foreach (var element in elements)
            {
                this.innerCollection[Size] = element;
                this.size++;
            }
        }

        private void MultiResize(ICollection<T> elements)
        {
            int newSize = this.innerCollection.Length*2;
            while (this.Size + elements.Count >= newSize)
            {
                newSize *= 2;
            }

            T[] newCollection = new T[newSize];
            Array.Copy(this.innerCollection, newCollection, size);
            this.innerCollection = newCollection;
        }

        public int Size
        {
            get { return this.size; }
        }

        public string JoinWith(string joiner)
        {
            StringBuilder builder = new StringBuilder();

            foreach (var element in this)
            {
                builder.Append(element);
                builder.Append(joiner);
            }

            builder.Remove(builder.Length - 1, 1);
            return builder.ToString();
        }

        private void Resize()
        {
            T[] newCollection = new T[this.Size * 2];
            Array.Copy(innerCollection, newCollection, Size);
            innerCollection = newCollection;
        }

        
    }
}
