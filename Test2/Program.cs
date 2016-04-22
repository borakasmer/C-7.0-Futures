using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    //1-) Up to 30 percent faster than Visual Studio 2015
    //2-) Execute in Interactive (Execute your Code Snippet Inside C# Interactive Window)

    class Program
    {
        static void Main(string[] args)
        {
            //Local functions

            String[] words = { "orange", "apple", "Article", "elephant", "star", "and" };

            string Selector(string keyword)
            {
                return keyword.ToUpper();
            }
            //A-)
            IEnumerable<String> aWords = words.Select(Selector);
            foreach (String word in aWords)
                Console.WriteLine(word);
/*

            //B-)
            bool predicate(String str,int index) { return str.Length == index; }           
            IEnumerable<String> aWords2 = words.Where(predicate).Select(str => str);

            foreach (String word2 in aWords2)
                Console.WriteLine(word2);
*/
            Console.WriteLine("".PadRight(40, '-'));
/*
            //Pattern matching
            //------------------------------------------------------------------------------------

            T GetValue<T>(T nesne)
            {
                return nesne;
            }

            string obje = "Bora";
            object v = GetValue(obje);
            switch (v)
            {
                case string s:
                    Console.WriteLine($"{v} is a string of length {s.Length}");
                    break;
                case int i:
                    Console.WriteLine($"{v} is an {(i % 2 == 0 ? "even" : "odd")} int");
                    break;
                default:
                    Console.WriteLine($"{v} is something else");
                    break;
            }

            //-------------------------------------------------------------------------------------
            Console.WriteLine("".PadRight(40, '-'));

            //Ref returns and ref locals
            var foo = new FooVariables();
            Console.WriteLine(foo); // 0, 0

            foo.GetByRef("x") = 42;

            ref int y = ref foo.GetByRef("y");
            y = 99;

            Console.WriteLine(foo); // 42, 99           

            //-------------------------------------------------------------------------------------
            Console.WriteLine("".PadRight(40, '-'));

            //Binary literals ve digit separators
            int oneBillion = 1_000_000_000;
            Console.WriteLine("Big Number :" + oneBillion * 5);


            Byte[] GetBytesFromBinaryString(String binary)
            {
                var list = new List<Byte>();

                for (int i = 0; i < binary.Length; i += 8)
                {
                    String t = binary.Substring(i, 8);

                    list.Add(Convert.ToByte(t, 2));
                }

                return list.ToArray();
            }
            int foo2 = 0x7FFF_1234;
            var data = GetBytesFromBinaryString("010000010100001001000011");
            Console.WriteLine("Binary Deger: "+Encoding.ASCII.GetString(data));

            int bar = 0b1001_0110_1010_0101;            

*/           
            Console.ReadLine();
        }

        //1-) Tuple------------------------------------
        //public (int sum, int count) Tally(IEnumerable<int> values)
        //{
        //    sum = 0; count = 0;
        //    foreach (var value in values) { sum += value; count++; }
        //    return (sum, count);
        //}
        //var t = Tally(myValues);
        //var sum = t.Sum;
        //var count = t.Count;

        //2-) Non-Nullable Reference Types
        //(string?) or avoid null (string!)

        //3-) Records (or Record Types)
        //public class Cube(int Width, int Height, int Depth)

        //4-) Immutable Types 
        //Person per = new Person("Bora", "Kasmer");
        //var per2 = per with {SurName="Kasmer"};      
    }

    class FooVariables
    {
        private int x;
        private int y;

        public ref int GetByRef(string name)
        {
            if (name == "x")
                return ref x;
            if (name == "y")
                return ref y;
            throw new ArgumentException(nameof(name));
        }

        public override string ToString() => $"{x},{y}";
    }

    public class Person
    {
        public Person(string name, string surname)
        {
            Name = name;
            SurName = surname;
        }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
