﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
public class Spy
{
    public string StealFieldInfo(string className, params string[] fields)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] classFields = classType.GetFields(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
        var sb = new StringBuilder();
        Object classInstance = Activator.CreateInstance(classType, new object[] { });
        sb.AppendLine($"Class under investigation: {className}");
        foreach (FieldInfo field in classFields.Where(f=>fields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }
        return sb.ToString().Trim();
    }
}