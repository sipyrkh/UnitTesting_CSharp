using System;
using System.IO;

namespace PenUnitTesting.Utils
{
    public class PathFunctions
    {
        public static string GetPath(string filePath)
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);
        }
    }
}