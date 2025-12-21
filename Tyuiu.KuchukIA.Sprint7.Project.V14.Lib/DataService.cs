using System;
using System.IO;
using System.Text;

namespace Tyuiu.KuchukIA.Sprint7.Project.V14.Lib
{
    public class DataService
    {
        public string[,] LoadFromFile(string path)
        {
            if (!File.Exists(path)) return new string[0, 8];

            string[] lines = File.ReadAllLines(path);
            string[,] result = new string[lines.Length, 8];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                for (int j = 0; j < 8; j++)
                {
                    if (j < parts.Length)
                        result[i, j] = parts[j];
                    else
                        result[i, j] = "";
                }
            }

            return result;
        }

        public void SaveToFile(string path, string[,] array)
        {
            int rows = array.GetLength(0);
            string[] lines = new string[rows];

            for (int i = 0; i < rows; i++)
            {
                string line = "";
                for (int j = 0; j < 8; j++)
                {
                    line += array[i, j];
                    if (j < 7) line += ";";
                }
                lines[i] = line;
            }

            File.WriteAllLines(path, lines);
        }

        public string[,] Search(string[,] array, string text)
        {
            int rows = array.GetLength(0);
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                bool found = false;

                for (int j = 0; j < 8; j++)
                {
                    if (array[i, j].ToLower().Contains(text.ToLower()))
                    {
                        found = true;
                        break;
                    }
                }

                if (found) count++;
            }

            string[,] result = new string[count, 8];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                bool found = false;

                for (int j = 0; j < 8; j++)
                {
                    if (array[i, j].ToLower().Contains(text.ToLower()))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        result[index, j] = array[i, j];
                    }
                    index++;
                }
            }

            return result;
        }

        public int VehicleAmount(string[,] array)
        {
            return array.GetLength(0);
        }

        public int RouteAmount(string[,] array)
        {
            int count = 0;
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                bool seen = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j, 2] == array[i, 2])
                    {
                        seen = true;
                        break;
                    }
                }
                if (!seen) count++;
            }

            return count;
        }

        public int MinTime(string[,] array)
        {
            int min = 1000000;
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                try
                {
                    int time = int.Parse(array[i, 6]);
                    if (time < min) min = time;
                }
                catch { }
            }

            if (min == 1000000) return 0;
            return min;
        }

        public int MaxTime(string[,] array)
        {
            int max = 0;
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                try
                {
                    int time = int.Parse(array[i, 6]);
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
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                try
                {
                    sum += int.Parse(array[i, 6]);
                    count++;
                }
                catch { }
            }

            if (count == 0) return 0;
            return sum / count;
        }

        public int RouteAmount_Route(string[,] array, string route)
        {
            int count = 0;
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                if (array[i, 2] == route) count++;
            }

            return count;
        }

        public int MinTime_Route(string[,] array, string route)
        {
            int min = 1000000;
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                if (array[i, 2] == route)
                {
                    try
                    {
                        int time = int.Parse(array[i, 6]);
                        if (time < min) min = time;
                    }
                    catch { }
                }
            }

            if (min == 1000000) return 0;
            return min;
        }

        public int MaxTime_Route(string[,] array, string route)
        {
            int max = 0;
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                if (array[i, 2] == route)
                {
                    try
                    {
                        int time = int.Parse(array[i, 6]);
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
            int rows = array.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                if (array[i, 2] == route)
                {
                    try
                    {
                        sum += int.Parse(array[i, 6]);
                        count++;
                    }
                    catch { }
                }
            }

            if (count == 0) return 0;
            return sum / count;
        }
    }
}