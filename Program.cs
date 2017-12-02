using System;

namespace Molot_5
{
    class MyClass
    {
        private int[] _array;
        // private int _maxIndex;
        public int Length { get; }
        public int MinIndex { get; }
        public int MaxIndex { get; }
       
        public MyClass (int length,int minIndex)
        {
            this.Length = length;
            this.MinIndex = minIndex;
            this.MaxIndex = this.MinIndex + this.Length - 1;
            this._array = new int[this.Length]; 
        }

        public int this[int index]
        {
            get
            {
                if (index < this.MinIndex || index > this.MaxIndex)
                    throw new IndexOutOfRangeException ( String.Format("This index ({0}) is out of range from {1} to {2}.",index, this.MinIndex, this.MaxIndex) );

                return this._array[index-this.MinIndex];
            }
            set
            {
                if (index < this.MinIndex || index > this.MaxIndex)
                    throw new IndexOutOfRangeException ( String.Format("This index ({0}) is out of range from {1} to {2}.",index, this.MinIndex, this.MaxIndex) );

                this._array[index-this.MinIndex] = value;
            }
        }

        public override string ToString()
        {
            string strArr = "";
            foreach (int el in this._array)
                strArr = strArr + el + ", ";
            return "{"+ strArr.Substring(0, strArr.Length - 2) + "}";
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int arrayLength = 0;
                int arrayMinIndex = 7;
                MyClass arr = new MyClass(arrayLength, arrayMinIndex);
                // a[11] = 32;
                // int y = a[11];
                for (int i = arr.MinIndex; i <= arr.MaxIndex; i++)
                    arr[i] = i;

                Console.WriteLine(arr);
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }

        }
    }
}
