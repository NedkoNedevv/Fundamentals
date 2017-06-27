using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Track_downloader
{
    class trackDownloader
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine()
                  .Split(new char[] { ' ' },
                  StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

            var trackName = Console.ReadLine();

            var finalList = new List<string>();

            while (trackName != "end")
            {
                finalList.Add(trackName);

                for (int i = 0; i < blackList.Count; i++)
                {
                    if (trackName.Contains(blackList[i]))
                    {
                        finalList.RemoveAt(finalList.Count - 1);
                        break;
                    }
                }
                trackName = Console.ReadLine();
            }
            finalList.Sort();
            Console.WriteLine(string.Join(Environment.NewLine, finalList));
        }
    }
}
