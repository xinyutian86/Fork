﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Y.Utils.Net20.FileUtils;
using Y.Utils.Net20.ListUtils;

namespace Y.Utils.Net20.TxtUtils
{
    public class TxtTool
    {
        public static bool Append(string file, List<string> txt)
        {
            try
            {
                DirTool.Create(Path.GetDirectoryName(file));
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    if (!ListTool.IsNullOrEmpty(txt))
                        foreach (var t in txt)
                            sw.WriteLine(t);
                }
                return true;
            }
            catch (Exception e) { }
            return false;
        }
        public static bool Append(string file, string txt)
        {
            try
            {
                DirTool.Create(Path.GetDirectoryName(file));
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine(txt);
                }
                return true;
            }
            catch (Exception e) { }
            return false;
        }
        public static bool Create(string file, string txt)
        {
            try
            {
                DirTool.Create(Path.GetDirectoryName(file));
                using (StreamWriter sw = new StreamWriter(file, false, Encoding.UTF8))
                {
                    sw.WriteLine(txt);
                }
                return true;
            }
            catch (Exception e) { }
            return false;
        }
        public static string Read(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
                {
                    string result = "", line;
                    while ((line = sr.ReadLine()) != null)
                        result += line.ToString() + Environment.NewLine;
                    return result;
                }
            }
            catch (Exception e) { }
            return null;
        }
        public static string Read(string file, Encoding encoding)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file, encoding))
                {
                    string result = "", line;
                    while ((line = sr.ReadLine()) != null)
                        result += line.ToString() + Environment.NewLine;
                    return result;
                }
            }
            catch (Exception e) { }
            return null;
        }
        public static List<string> ReadLine(string file)
        {
            try
            {
                using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
                {
                    List<string> result = new List<string>();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        result.Add(line.ToString());
                    return result;
                }
            }
            catch (Exception e) { }
            return null;
        }
        public static long CountLine(string file, string[] filter)
        {
            long count = 0;
            try
            {
                using (StreamReader sr = new StreamReader(file, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        bool access = true;
                        if (ListTool.HasElements(filter))
                        {
                            foreach (var f in filter)
                            {
                                if (line.Trim() == f) access = false;
                            }
                        }
                        if (access) count++;
                    }
                }
            }
            catch (Exception e) { }
            return count;
        }
    }
}
