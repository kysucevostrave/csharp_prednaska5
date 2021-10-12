using System;

namespace csharp_prednaska5
{
    public class A
    {
        private int[] someData; // = {0, 1, 2, 3, 4, 5, 6 };

        /*public int[] SomeData
        {
            get => someData;
            set => someData = value;
        }*/
        /*public int this[int index]  //indexer - takmer vzdy public
        {
            //get { return someData[index]; }
            get {
                if (index >= someData.length)
                {
                    Console.WriteLine("Chyba");
                    return -1;
                }
                else
                {
                    return someData[index];
                }
            }
            //set{ someData[index] = value; }
            set
            {
                if (index >= someData.length)
                {
                    someData[index] = value;
                }
                else
                {
                    Console.WriteLine("Chyba");
                    someData[index] = -1;
                }
            }
        }*/
        /*public int this[string text]{
            get
            {
                if (text == "aaa")
                {
                    return someData[5];
                }
                else { retrun - 1; }
            }
        }*/
        public A()
        {
            someData = new int[7];
        }
    }

    //OPERATOR ----------------------------
    public class Vector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Vector() { X = 0.0f; Y = 0.0f; }
        public Vector(float _x, float _y)
        {
            X = _x;
            Y = _y;
        }
        public static Vector operator +(Vector a, Vector b) {
            return new Vector(a.X + b.X, a.Y + b.Y);
        }
    }
    //OPERATOR ----------------------------

    //NESTED TYPE-------------------------
    class Outer
    {
        private int X { get; set; }
        protected int Y { get; set; }
        private int Z { get; set; }
        public class Inner
        {
            private int A { get; set; }
            protected int B { get; set; }
            private int C { get; set; }
            public void MMM(Outer o)
            {
                Console.WriteLine(o.X);
                Console.WriteLine(o.Y);         //vnutorne vidi vsetko vonkajsieho
                Console.WriteLine(o.Z);
            }
        }

        public void MMMMMMM(Inner i)
        {
            Console.WriteLine(i.A);
            Console.WriteLine(i.B);     //vonkajsie vidi iba public vnotorneho
            Console.WriteLine(i.C);
        }
    }
    //NESTED TYPE-------------------------
    //DEDICNOST --------------------------
    public class B
    {
        public void M() { Console.WriteLine("B"); }
    }
    public class A : B
    {
        public void M() { Console.WriteLine("A"); }
    }
    //DEDICNOST --------------------------



    class Program
    {
        static void Main(string[] args)
        {

            //DEDICNOST --------------------------


            A a = new B();


            //DEDICNOST --------------------------

            /*A a = new A();
            //a.someData = null;
            a[4] = 8;
            Console.WriteLine(a[4]);
            */

            //OPERATOR ----------------------------
            Vector v = new Vector(0, 0);
            Vector u = new Vector(1, 2);
            Vector z = u + v;
            //OPERATOR ----------------------------




        }
    }
}
