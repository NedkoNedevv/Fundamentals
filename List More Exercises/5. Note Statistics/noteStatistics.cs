using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Note_Statistics
{
    class noteStatistics
    {
        static void Main(string[] args)
        {
            List<string> initialNotes = new List<string>(new string[]
                {
            "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"
            });
            List<double> initialFreguencies = new List<double>(new double[]
            {
                  261.63, 277.18, 293.66, 311.13, 329.63, 349.23, 369.99, 392.00, 415.30, 440.00, 466.16, 493.88
            });

            List<double> freguencies = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToList();

            List<string> totalNotes = new List<string>();
            List<string> naturals = new List<string>();
            List<string> sharps = new List<string>();

            double naturalSum = 0;
            double sharpSum = 0;

            for (int i = 0; i < freguencies.Count; i++)
            {
                double currentFreguency = freguencies[i];
                int index = initialFreguencies.IndexOf(currentFreguency);

                string currentNotes = initialNotes[index];

                if (IsNatural(currentNotes))
                {
                    naturals.Add(currentNotes);
                    naturalSum += currentFreguency;
                }
                else
                {
                    sharps.Add(currentNotes);
                    sharpSum += currentFreguency;
                }
                totalNotes.Add(currentNotes);
            }
            Console.WriteLine("Notes: {0}",
                string.Join(" ", totalNotes));
            Console.WriteLine("Naturals: {0}",
                string.Join(", ", naturals));
            Console.WriteLine("Sharps: {0}",
                string.Join(", ", sharps));
            Console.WriteLine("Naturals sum: {0}",
                string.Join(" ", naturalSum));
            Console.WriteLine("Sharps sum: {0}",
                string.Join(" ", sharpSum));

        }
        static bool IsNatural(string note)
        {
            return (note.Length == 1);
        }
    }
}
