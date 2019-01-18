using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ApiOutdatedFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Preparation
            string[] lines = File.ReadAllLines("Files/input.txt");
            List<(string ApplicationName, string ApiName, int ApiVersion)> linesPrepared = new List<(string ApplicationName, string ApiName, int ApiVersion)>();
            lines.ToList().ForEach(x =>
            {
                string[] splited = x.Split(',');
                linesPrepared.Add((splited[0], splited[1], Convert.ToInt32(splited[2].Trim().Replace("v", string.Empty))));
            });
            List<string> oldestApps = new List<string>();


            //Action
            linesPrepared.GroupBy(x => x.ApiName).Where(y => y.Count() > 1).ToList().ForEach(g =>
            {
                var oldests = g.Where(x => x.ApiVersion != g.Max(y => y.ApiVersion));
                oldestApps.AddRange(oldests.Select(x => x.ApplicationName));
            });

            File.WriteAllLines("Files/output.txt", oldestApps.Distinct());
        }
    }
}
