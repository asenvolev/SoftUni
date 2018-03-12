namespace _02BlackBoxInteger
{
    using System;
    using System.Reflection;
    using System.Linq;

    class BlackBoxIntegerTests
    {
        static void Main(string[] args)
        {
            Type blackBoxType = typeof(BlackBoxInt);
            BlackBoxInt blackBox = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);
            var input = Console.ReadLine();
            while (input!="END")
            {
                var tokens = input.Split('_');
                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);
                blackBoxType.GetMethod(methodName, BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(blackBox, new object[] { value });
                object innerStateValue = blackBoxType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                    .First().GetValue(blackBox);
                Console.WriteLine(innerStateValue);
                input = Console.ReadLine();
            }
        }
    }
}
