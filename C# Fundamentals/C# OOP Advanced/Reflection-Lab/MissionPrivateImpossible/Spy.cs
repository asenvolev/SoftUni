using System;
using System.Reflection;
using System.Text;
using System.Linq;
public class Spy
{
    public string RevealPrivateMethods(string className)
    {
        Type classType = Type.GetType(className);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(
            BindingFlags.Instance | BindingFlags.NonPublic);
        var sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");
        foreach (MethodInfo method in classNonPublicMethods)
        {
            sb.AppendLine(method.Name);
        }
        return sb.ToString().TrimEnd();
    }
}