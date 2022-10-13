using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class Array<T> : IEnumerable<T> , ICloneable
    {
        private T[] InnerList;
        public int Count  { get;private set; }
        public int Capasity => InnerList.Length;

        public Array()
        {
            InnerList = new T[2];
            Count = 0;
        }
        public Array(IEnumerable<T> collection)
        {
            InnerList =new T[collection.ToArray().Length] ;
            Count = 0;
            foreach (var item in collection)
                Add(item);
        }
        public Array(params  T[] initial)
        {
            InnerList = new T[initial.Length];
            Count = 0;
            foreach (var item in initial)
            {
                Add(item);
            }
        }
        public void Add(T item)
        {
            if (Count== InnerList.Length)
                DoubleArray();
            InnerList[Count] = item;
            Count ++;
        }
        public T Remove()
        {
            if (Count == 0)
                throw new  Exception("There is no more item to be remove from the array");

            if (InnerList.Length / 4 == Count)
                HalfArray();



            var temp = InnerList[Count-1];
            if (Count>0)
                Count--;
            return temp;
        }

        public void HalfArray()
        {
            if (InnerList.Length>2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList, temp, InnerList.Length / 4);
                InnerList = temp;
            }
        }

        private void DoubleArray()
        {
            var temp = new T[InnerList.Length * 2];
            System.Array.Copy(InnerList,temp, InnerList.Length);
            InnerList = temp;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)InnerList.Take(Count).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        ///
        //The array class is used in program.cs
        ///
        #region Program.cs


        //var p1 = new DataStructures.Array<int>(1, 2, 3, 42);
        //var p2 = new int[] { 1, 43, 23, 56, 788 };
        //var p3 = new List<int>() { 21, 32, 54, 32 };
        //var p4 = new ArrayList() { 21, 43, 766, 34 };

        //var arr = new DataStructures
        //            .Array<int>(0);

        //for (int i = 0; i < 8; i++)
        //{
        //    arr.Add(i + 1);
        //    Console.WriteLine($"{arr.Count} /{ arr.Capasity}");

        //}

        //Console.WriteLine();
        //for (int i = arr.Count; i >= 1; i--)
        //{
        //    Console.WriteLine(arr.Remove());
        //}



        #endregion

    }
}
