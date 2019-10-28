using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyTest
{
    public class ThroughCave
    {
        static void Main(string[] args)
        {
            Thread th = new Thread(GoThrough);
            th.Start();
        }

        private static void GoThrough(object obj)
        {
            List<Person> p = new List<Person>();
            List<Person> newPerson = new List<Person>();
            p.Add(new Person("小明"));
            p.Add(new Person("小华"));
            p.Add(new Person("小李"));
            p.Add(new Person("小王"));
            p.Add(new Person("小黑"));
            p.Add(new Person("小白"));
            p.Add(new Person("小红"));
            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                int rr = r.Next(0, p.Count);
                newPerson.Add(p[rr]);
                Console.WriteLine("现在过山洞的是" + p[rr].Name);
                Thread.Sleep(1000);
                Console.WriteLine(1);
                Thread.Sleep(1000);
                Console.WriteLine(2);
                Thread.Sleep(1000);
                Console.WriteLine(3);
                Thread.Sleep(1000);
                Console.WriteLine(4);
                Thread.Sleep(1000);
                Console.WriteLine(5);
            }
        }
    }

    public class Person
    {
        private string _name;
        public Person()
        {

        }
        public Person(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }

}
