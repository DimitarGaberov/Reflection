namespace _01HarestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            Type harvestingFieldsType = typeof(HarvestingFields);
            FieldInfo[] harvestingFields = harvestingFieldsType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            FieldInfo[] gatheredFields;

            string requestedAccMod;
            while ((requestedAccMod = Console.ReadLine()) != "HARVEST")
            {
                switch (requestedAccMod)
                {
                    case "private":
                        gatheredFields = harvestingFields.Where(f => f.IsPrivate).ToArray();
                        break;
                    case "protected":
                        gatheredFields = harvestingFields.Where(f => f.IsFamily).ToArray();
                        break;
                    case "public":
                        gatheredFields = harvestingFields.Where(f => f.IsPublic).ToArray();
                        break;
                    case "all":
                        gatheredFields = harvestingFields.ToArray();
                        break;
                    default:
                        gatheredFields = null;
                        break;
                }

                string[] result = gatheredFields
                    .Select(f => $"{f.Attributes.ToString().ToLower()} {f.FieldType.Name} {f.Name}")
                    .ToArray();
                Console.WriteLine(string.Join(Environment.NewLine, result).Replace("family", "protected"));
            }
        }
    }
}
