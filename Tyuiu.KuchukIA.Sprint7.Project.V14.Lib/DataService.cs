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
            string[,] data = new string[lines.Length, 8];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(';');
                for (int j = 0; j < 8; j++)
                {
                    if (j < parts.Length)
                        data[i, j] = parts[j];
                    else
                        data[i, j] = "";
                }
            }
            return data;
        }

 
        public void SaveToFile(string path, string[,] data)
        {
            List<string> lines = new List<string>();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                string line = "";
                for (int j = 0; j < 8; j++)
                {
                    line += data[i, j];
                    if (j < 7) line += ";";
                }
                lines.Add(line);
            }

            File.WriteAllLines(path, lines, Encoding.UTF8);
        }


        public string[,] Search(string[,] data, string text)
        {
            List<string[]> result = new List<string[]>();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                bool found = false;

                for (int j = 0; j < 8; j++)
                {
                    if (data[i, j].ToLower().Contains(text.ToLower()))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    string[] row = new string[8];
                    for (int j = 0; j < 8; j++)
                        row[j] = data[i, j];
                    result.Add(row);
                }
            }

            string[,] final = new string[result.Count, 8];
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 0; j < 8; j++)
                    final[i, j] = result[i][j];
            }

            return final;
        }


        public int VehicleAmount(string[,] data)
        {
            return data.GetLength(0);
        }


        public int RouteAmount(string[,] data)
        {
            HashSet<string> routes = new HashSet<string>();

            for (int i = 0; i < data.GetLength(0); i++)
                routes.Add(data[i, 2]);

            return routes.Count;
        }


        public int MinTime(string[,] data)
        {
            int min = int.MaxValue;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (int.TryParse(data[i, 6], out int time))
                {
                    if (time < min)
                        min = time;
                }
            }

            return (min == int.MaxValue) ? 0 : min;
        }


        public int MaxTime(string[,] data)
        {
            int max = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (int.TryParse(data[i, 6], out int time))
                {
                    if (time > max)
                        max = time;
                }
            }

            return max;
        }


        public int AvgTime(string[,] data)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (int.TryParse(data[i, 6], out int time))
                {
                    sum += time;
                    count++;
                }
            }

            return (count == 0) ? 0 : sum / count;
        }


        public int RouteAmount_Route(string[,] data, string route)
        {
            int count = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 2] == route)
                    count++;
            }

            return count;
        }


        public int MinTime_Route(string[,] data, string route)
        {
            int min = int.MaxValue;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 2] == route && int.TryParse(data[i, 6], out int time))
                {
                    if (time < min)
                        min = time;
                }
            }

            return (min == int.MaxValue) ? 0 : min;
        }


        public int MaxTime_Route(string[,] data, string route)
        {
            int max = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 2] == route && int.TryParse(data[i, 6], out int time))
                {
                    if (time > max)
                        max = time;
                }
            }

            return max;
        }


        public int AvgTime_Route(string[,] data, string route)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 2] == route && int.TryParse(data[i, 6], out int time))
                {
                    sum += time;
                    count++;
                }
            }

            return (count == 0) ? 0 : sum / count;
        }
    }
}