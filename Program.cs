using System;

namespace Molot_5
{
    class MyClass
    {
        private int[] _array;
        public int Length { get; }

        public MyClass (int length)
        {
            this.Length = length;
            this._array = new int[this.Length]; 
        }
        public void SetValue(int index, int expValue)
        {
            this._array[index] = expValue;
        }
        public int this[int index]
        {
            get
            {
                return this._array[index];
            }
            set
            {
                this._array[index] = value;
            }
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;

            //Console.WriteLine("Insert value");
            //int lenght = Convert.ToInt32(Console.ReadLine ());
            int[] list = new int[3];
            list[1] = x;
            int y = list[1];
            //for (int k = 0; k<lenght; k++)
            //    list[k] = Convert.ToInt32(Console.ReadLine());

            MyClass a = new MyClass(x);
            Console.WriteLine(a.Length);
            //a.SetValue(1, 42);
            a[1] = 32;
            y = a[1];
            Console.WriteLine(y);
        }
    }
}
