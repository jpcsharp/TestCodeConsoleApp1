namespace TestCodeConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyClass myInstance = new MyClass();
            myInstance.MyEvent += MyEventHandler;
            GenericClass<MyAZ> obj = new GenericClass<MyAZ>();
        }


        public delegate void MyDelegate(object sender, EventArgs e);

        public class MyClass
        {
            public event MyDelegate MyEvent;
        }

        private void MyEventHandler(object sender, EventArgs e)
        {

        }


        //--------------  Generic class que




        public class MyBase
        { }

        public class MyA : MyBase
        { }

        public class MyB
        { }

        public class MyC : MyB
        { }

        public class MyAZ
        {
            public MyAZ(MyB b, MyA a)
            {
            }

            public MyAZ(MyC c, MyA a)
            {
            }
        }
        public class GenericClass<T> where T : new(MyC,MyA){ }
        private ICollection<MyAZ> ts { get; set; }
    }
}