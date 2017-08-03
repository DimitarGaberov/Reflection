namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main(string[] args)
        {
            Type blackBoxType = typeof(BlackBoxInt);
            BlackBoxInt blackBoxInstance = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);

            //ConstructorInfo blackBoxCtor = blackBoxType
            //    .GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, Type.DefaultBinder, new Type[] { }, null );
            //blackBoxCtor.Invoke();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split('_');
                string methodName = tokens[0];
                int value = int.Parse(tokens[1]);

                blackBoxType.GetMethod(methodName, 
                    BindingFlags.Instance | BindingFlags.NonPublic)
                    .Invoke(blackBoxInstance, new object[] { value });

                object innerStateValue = blackBoxType
                    .GetFields(BindingFlags.Instance | BindingFlags.NonPublic)
                    .First()
                    .GetValue(blackBoxInstance);

                Console.WriteLine(innerStateValue);
            }
        }
    }
}
