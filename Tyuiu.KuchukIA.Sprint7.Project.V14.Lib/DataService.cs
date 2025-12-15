using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14.Lib
{
    public class DataService
    {
        public string[,] LoadFromFile(string path)
        {
            if (!File.Exists(path)) return new string[0, 8];

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);
            string[,] array = new string[lines.Length, 8];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                for (int j = 0; j < 8; j++)
                {
                    if (j < parts.Length)
                        array[i, j] = parts[j];
                    else
                        array[i, j] = "";
                }
            }
            return array;
        }

        public void SaveToFile(string path, string[,] array)
        {
            List<string> lines = new List<string>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                string line = "";
                for (int j = 0; j < 8; j++)
                {
                    line += array[i, j];
                    if (j < 7) line += ";";
                }
                lines.Add(line);
            }

            File.WriteAllLines(path, lines, Encoding.UTF8);
        }

        public string[,] Search(string[,] array, string text)
        {
            List<string[]> result = new List<string[]>();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (array[i, j].ToLower().Contains(text.ToLower()))
                    {
                        string[] row = new string[8];
                        for (int k = 0; k < 8; k++)
                            row[k] = array[i, k];

                        result.Add(row);
                        break;
                    }
                }
            }

            string[,] final = new string[result.Count, 8];
            for (int i = 0; i < result.Count; i++)
                for (int j = 0; j < 8; j++)
                    final[i, j] = result[i][j];

            return final;
        }

        public int VehicleAmount(string[,] array)
        {
            return array.GetLength(0);
        }

        public int RouteAmount(string[,] array)
        {
            string[] used = new string[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (!used.Contains(array[i, 2]))
                    used[i] = array[i, 2];
            }

            return used.Count(id => id != null);
        }

        public int MinTime(string[,] array)
        {
            int min = 999999;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    int time = Convert.ToInt32(array[i, 6]);
                    if (time < min) min = time;
                }
                catch { }
            }

            return min == 999999 ? 0 : min;
        }

        public int MaxTime(string[,] array)
        {
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    int time = Convert.ToInt32(array[i, 6]);
                    if (time > max) max = time;
                }
                catch { }
            }

            return max;
        }

        public int AvgTime(string[,] array)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    sum += Convert.ToInt32(array[i, 6]);
                    count++;
                }
                catch { }
            }

            return count == 0 ? 0 : sum / count;
        }

        public int RouteAmount_Route(string[,] array, string route)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 2] == route)
                    count++;
            }

            return count;
        }

        public int MinTime_Route(string[,] array, string route)
        {
            int min = 999999;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 2] == route)
                {
                    try
                    {
                        int time = Convert.ToInt32(array[i, 6]);
                        if (time < min) min = time;
                    }
                    catch { }
                }
            }

            return min == 999999 ? 0 : min;
        }

        public int MaxTime_Route(string[,] array, string route)
        {
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 2] == route)
                {
                    try
                    {
                        int time = Convert.ToInt32(array[i, 6]);
                        if (time > max) max = time;
                    }
                    catch { }
                }
            }

            return max;
        }

        public int AvgTime_Route(string[,] array, string route)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 2] == route)
                {
                    try
                    {
                        sum += Convert.ToInt32(array[i, 6]);
                        count++;
                    }
                    catch { }
                }
            }

            return count == 0 ? 0 : sum / count;
        }
    }
}