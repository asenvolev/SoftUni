using System;
using System.Reflection;
using System.Text;
using System.Linq;
public class Spy
{
    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] classFields = classType.GetFields(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
        MethodInfo[] classPublicMethods = classType.GetMethods(
            BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(
            BindingFlags.Instance | BindingFlags.NonPublic);
        var sb = new StringBuilder();
        foreach (FieldInfo field in classFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (MethodInfo method in classNonPublicMethods.Where(x=>x.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }
        foreach (MethodInfo method in classPublicMethods.Where(x => x.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }
        return sb.ToString().TrimEnd();
    }
}