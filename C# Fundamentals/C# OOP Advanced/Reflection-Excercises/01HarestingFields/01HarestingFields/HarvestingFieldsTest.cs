namespace _01HarestingFields
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Text;

    public class HarvestingFieldsTest
    {
        public static void Main(string[] args)
        {
            var typeFields = Console.ReadLine();
            while (typeFields!="HARVEST")
            {
                Console.WriteLine(GetFields(typeFields));
                typeFields = Console.ReadLine();
            }
        }
        public static string GetFields(string fieldType)
        {
            string className = typeof(HarvestingFields).FullName;
            Type classType = Type.GetType(className);
            FieldInfo[] fields = classType.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            var sb = new StringBuilder();
            if (fieldType == "private")
            {
                foreach (FieldInfo field in fields.Where(x => x.IsPrivate))
                {
                    sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                }
                return sb.ToString().Trim();
            }
            if (fieldType == "public")
            {
                foreach (FieldInfo field in fields.Where(x => x.IsPublic))
                {
                    sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                }
                return sb.ToString().Trim();
            }
            if (fieldType == "protected")
            {
                foreach (FieldInfo field in fields.Where(x => x.IsFamily))
                {
                    sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
                }
                return sb.ToString().Replace("family", "protected").Trim();
            }
            foreach (FieldInfo field in fields)
            {
                sb.AppendLine($"{field.Attributes.ToString().ToLower()} {field.FieldType.Name} {field.Name}");
            }
            return sb.ToString().Replace("family", "protected").Trim();
        }
    }
}
