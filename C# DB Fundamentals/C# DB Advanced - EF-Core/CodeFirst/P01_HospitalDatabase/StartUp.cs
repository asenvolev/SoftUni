﻿using System;
using P01_HospitalDatabase.Data;
using P01_HospitalDatabase.Initializer;

namespace P01_HospitalDatabase
{
    public class StartUp
    {
        public static void Main()
        {
            DatabaseInitializer.ResetDatabase();
        }
    }
}
