using System;
using System.Threading;

namespace RepoUpdater
{
    class Program
    {
        static GitLabUpdater gitLab = new GitLabUpdater();
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What kind of repo would you want to check?\n" +
                              "1) Gitlab\n" +
                              "Q) Quit");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    GitLab();
                    break;
                case 'q':
                    break;
                default:
                    Console.WriteLine("\nMust be '1' or 'q'");
                    Thread.Sleep(500);
                    Menu();
                    break;
            }
        }

        static void GitLab()
        {
            Console.Clear();
            Console.Write("Please enter the URL to your project (just up to project name, do NOT include '/-/releases'): ");
            string url = Console.ReadLine();
            Console.Write("Current installed version/tag: ");
            string tag = Console.ReadLine();
            gitLab.GetReleases(url, tag);
            Console.WriteLine("1) to list all releases\n" +
                              "2) to show json\n" +
                              "Or press any key to return to the menu");
            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Console.Clear();
                    gitLab.ListAll();
                    break;
                case '2':
                    Console.Clear();
                    gitLab.ShowJson();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            Menu();
        }

        static void GitHub()
        {
            //  TODO
        }
    }
}
