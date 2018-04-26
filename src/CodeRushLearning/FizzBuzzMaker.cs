using System;
using System.Collections.Generic;

namespace CodeRushLearning
{
    public class FizzBuzzConsumer
    {
        public string Msg { get; set; }
        public bool Truthiness { get; set; }
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; } = "Danger";
        public FizzBuzzConsumer(int id, 
            string msg, 
            bool truthiness)
        {
            Truthiness = truthiness;
            Msg = msg;
        }
        void DoSomething(string msg, double weight, bool truthiness, int p1, int p2, int p3)
        {
            List<string> list = new List<string>();
        }
    }

    public enum UserRole
    {
        Moderator,
        Administrator,
        Subscriber,
        Follower,
        Everyone
    }

    public class FizzBuzzMaker
    {
        public FizzBuzzMaker()
        {
        }
        public static List<string> GetList(int value, string msg)
        {
            List<string> resultList = new List<string>();

            for (int i = 1; i <= value; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    resultList.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    resultList.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    resultList.Add("Buzz");
                }
                else
                {
                    resultList.Add(i.ToString());
                }
            }

            var fizzBuzzConsumer = new FizzBuzzConsumer(1, msg, true) { };

            List<FizzBuzzConsumer> list = new List<FizzBuzzConsumer>();

            FizzBuzzConsumer[] myList = { null };

            Queue<FizzBuzzConsumer> queue = new Queue<FizzBuzzConsumer>();

            IList<int> varName = new List<int>{ };

            List<string> thisonehascurlybraces = new List<string> { "fdfds", "sdfsdf" };

            List<string> list1 = new List<string>();

            var sdfkjahf = new List<string>();


            StringComparer currentCulture = StringComparer.CurrentCulture;

            if (currentCulture == null)
            {
                if (currentCulture != null)
                {
                    if (currentCulture == null)
                        return null;
                }
            }

            IList<string> strings = varName as IList<string>;

            return resultList;
        }
    }
}
