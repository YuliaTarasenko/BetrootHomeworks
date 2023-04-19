namespace VoteProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> options = new Dictionary<string, int>();
            const string resultsFileName = "results.txt";
            if (!File.Exists(resultsFileName))
            {
                using (StreamWriter writer = File.CreateText(resultsFileName))
                {
                    writer.WriteLine("Results:");
                }
            }

            Console.WriteLine("Welcome to the voting system!");
            Console.Write("Enter the voting topic: ");
            string topic = Console.ReadLine();
            Console.WriteLine("Enter the voting options (type 'done' to finish):");
            string option;

            while ((option = Console.ReadLine()) != "done")
            {
                options.Add(option, 0);
            }

            Console.WriteLine("Voting options:");
            foreach (var kvp in options)
            {
                Console.WriteLine("- " + kvp.Key);
            }

            Console.WriteLine("Vote by typing the option name (e.g. 'Option A'):");
            Console.WriteLine("when you want to end your voting type \"exit\".");
            string vote = Console.ReadLine();
            while ((vote = Console.ReadLine()) != "exit")
            {
                if (!options.ContainsKey(vote))
                {
                    Console.WriteLine("Invalid vote! Please try again.");
                    continue;
                }
                options[vote]++;
                using (StreamWriter writer = new StreamWriter(resultsFileName))
                {
                    writer.WriteLine("Results for topic: " + topic);
                    foreach (var kvp in options)
                    {
                        writer.WriteLine(kvp.Key + ": " + kvp.Value);
                    }
                    writer.WriteLine();
                }
                Console.WriteLine("Thanks for voting!");              
                
            }
            Console.WriteLine("Voting has ended.");
            Console.WriteLine();

            foreach (string line in File.ReadAllLines(resultsFileName))
            {
                Console.WriteLine(line);
            }
        }
    }
}