using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            string commands = Console.ReadLine();

            while (commands != "end of contests")
            {
                string[] cmdArgs = commands
                    .Split(':', StringSplitOptions.RemoveEmptyEntries);
                string contestName = cmdArgs[0];
                string contestPassword = cmdArgs[1];

                contests.Add(contestName, contestPassword);
                commands = Console.ReadLine();
            }

           
            Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] cmdArgs = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string contest = cmdArgs[0];
                string password = cmdArgs[1];
                string username = cmdArgs[2];
                int points = int.Parse(cmdArgs[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    if (candidates.ContainsKey(username))
                    {
                       

                        if (candidates[username].ContainsKey(contest))
                        {
                            
                            candidates[username][contest] = Math.Max(candidates[username][contest], points);
                        }
                        else
                        {
                           
                            candidates[username].Add(contest, points);
                        }
                    }
                    else
                    {
                        candidates.Add(username, new Dictionary<string, int>()
                        {
                            [contest] = points
                        });
                    }
                }

                input = Console.ReadLine();
            }

            string bestCandidateName = string.Empty;
            int bestCandidatePoints = 0;

            foreach (var candidate in candidates)
            {
              
                int candidatePoints = candidate.Value.Values.Sum();

                if (candidatePoints > bestCandidatePoints)
                {
                    bestCandidateName = candidate.Key;
                    bestCandidatePoints = candidatePoints;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidateName} with total {bestCandidatePoints} points.");
            Console.WriteLine("Ranking: ");

            foreach (var candidate in candidates.OrderBy(c => c.Key))
            {
               
                Console.WriteLine($"{candidate.Key}");

                foreach (var contest in candidate.Value.OrderByDescending(c => c.Value))
                {
                 
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
