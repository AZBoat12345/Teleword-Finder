using System;
using System.Collections.Generic;
using System.Linq;

namespace Teleword_Finder
{
    class Program
    {
        static bool Find_left(char[,] grid, string find, int srow, int scol, int mrow, int mcol)
        {
            int i = 0;
            string check = null;
            while ((srow < mrow) && (scol < mcol) && (srow >= 0) && (scol >= 0) && (i<find.Length))
            {
                if (grid[srow,scol] != find[i])
                    break;
                check += grid[srow, scol];
                scol--;
                i++;
            }
            if(check == find)
                return true;
            else
                return false;
        }
        static bool Find_right(char[,] grid, string find, int srow, int scol, int mrow, int mcol)
        {
            int i = 0;
            string check = null;
            while ((srow < mrow) && (scol < mcol) && (srow >= 0) && (scol >= 0) && (i < find.Length))
            {
                if (grid[srow,scol] != find[i])
                    break;
                check += grid[srow, scol];
                scol++;
                i++;
            }
            if(check == find)
                return true;
            else
                return false;
        }
        static bool Find_up(char[,] grid, string find, int srow, int scol, int mrow, int mcol)
        {
            int i = 0;
            string check = null;
            while ((srow < mrow) && (scol < mcol) && (srow >= 0) && (scol >= 0) && (i < find.Length))
            {
                if (grid[srow,scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow--;
                i++;
            }
            if(check == find)
                return true;
            else
                return false;
        }
        static bool Find_down(char[,] grid, string find, int srow, int scol, int mrow, int mcol)
        {
            int i = 0;
            string check = null;
            while ((srow < mrow) && (scol < mcol) && (srow >= 0) && (scol >= 0) && (i < find.Length))
            {
                if (grid[srow,scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow++;
                i++;
            }
            if(check == find)
                return true;
            else
                return false;
        }
        static bool Find_northeast(char[,] grid, string find, int srow, int scol, int mrow, int mcol)
        {
            int i = 0;
            string check = null;
            while ((srow < mrow) && (scol < mcol) && (srow >= 0) && (scol >= 0) && (i < find.Length))
            {
                if (grid[srow,scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow--;
                scol++;
                i++;
            }
            if(check == find)
                return true;
            else
                return false;
        }
        static bool Find_southeast(char[,] grid, string find, int srow, int scol, int mrow, int mcol)
        {
            int i = 0;
            string check = null;
            while ((srow < mrow) && (scol < mcol) && (srow >= 0) && (scol >= 0) && (i < find.Length))
            {
                if (grid[srow,scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow++;
                scol++;
                i++;
            }
            if(check == find)
                return true;
            else
                return false;
        }
        static bool Find_southwest(char[,] grid, string find, int srow, int scol, int mrow, int mcol)
        {
            int i = 0;
            string check = null;
            while ((srow < mrow) && (scol < mcol) && (srow >= 0) && (scol >= 0) && (i < find.Length))
            {
                if (grid[srow,scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow++;
                scol--;
                i++;
            }
            if(check == find)
                return true;
            else
                return false;
        }
        static bool Find_northwest(char[,] grid, string find, int srow, int scol, int mrow, int mcol)
        {
            int i = 0;
            string check = "";
            while ((srow < mrow) && (scol < mcol) && (srow >= 0) && (scol >= 0) && (i < find.Length))
            {
                if (grid[srow,scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow--;
                scol--;
                i++;
            }
            if(check == find)
                return true;
            else
                return false;
        }
        static void Showboard(char[,] grid,int mrow,int mcol)
        {
            for(int i=0;i<mrow;i++)
            {
                for(int j=0;j<mcol;j++)
                {
                    Console.Write(grid[i,j]);
                }
                Console.WriteLine();
            }
        }
        static int Main()
        {
        RESET:
            int n,m;
            Console.Clear();
            Console.WriteLine("Enter grid's dimension(n x m)");
            Console.Write("X Axis: ");
            var input_m = Console.ReadLine();
            while(!int.TryParse(input_m, out m))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid Input!");
                Console.WriteLine("Try Again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("X Axis: ");
                input_m = Console.ReadLine();
            }
            Console.Write("Y Axis: ");
            var input_n = Console.ReadLine();
            while(!int.TryParse(input_n, out n))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid Input!");
                Console.WriteLine("Try Again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("Y Axis: ");
                input_n = Console.ReadLine();
            }
            Console.Clear();
            char[,] grid = new char[n,m];
            char[] input_char;
            string input_string;
            Console.WriteLine("Enter character board.");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Line " + (i+1) + ": ");
                input_string = Console.ReadLine();
                input_string = input_string.ToLower();
                while(input_string.Length > m)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Invalid Input!");
                    Console.WriteLine("Try Again!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("Line " + (i + 1) + ": ");
                    input_string = Console.ReadLine();
                    input_string = input_string.ToLower();
                }
                input_char = input_string.ToCharArray();
                for (int j = 0; j < m; j++)
                {
                    grid[i, j] = input_char[j];
                }
            }
        FIND:
            Console.Clear();
            List<string> find = new List<string>();
            Console.WriteLine("Enter number of list word.");
            int nw;
            var input_nw = Console.ReadLine();
            while (!int.TryParse(input_nw, out nw))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid Input!");
                Console.WriteLine("Try Again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Enter number of list word.");
                input_nw = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Enter a word that you want find.");
            for(int i=0;i<nw;i++)
            {
                Console.Write("Word " + (i + 1) + ": ");
                var input_find = Console.ReadLine();
                input_find = input_find.ToLower();
                find.Add(input_find);

            }
            Console.Clear();
            Dictionary<string, List<Tuple<int, int, string>>> posdic = new Dictionary<string, List<Tuple<int, int, string>>>();
            foreach (string s in find)
            {
                List<Tuple<int, int, string>> poslist = new List<Tuple<int, int, string>>();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (Find_left(grid, s, i, j, n, m))
                        {
                            var pos = new Tuple<int, int, string>(j + 1, i + 1, "Left");
                            poslist.Add(pos);
                        }
                        if (Find_right(grid, s, i, j, n, m))
                        {
                            var pos = new Tuple<int, int, string>(j + 1, i + 1, "Right");
                            poslist.Add(pos);
                        }
                        if (Find_up(grid, s, i, j, n, m))
                        {
                            var pos = new Tuple<int, int, string>(j + 1, i + 1, "Up");
                            poslist.Add(pos);
                        }
                        if (Find_down(grid, s, i, j, n, m))
                        {
                            var pos = new Tuple<int, int, string>(j + 1, i + 1, "Down");
                            poslist.Add(pos);
                        }
                        if (Find_northeast(grid, s, i, j, n, m))
                        {
                            var pos = new Tuple<int, int, string>(j + 1, i + 1, "Northeast");
                            poslist.Add(pos);
                        }
                        if (Find_southeast(grid, s, i, j, n, m))
                        {
                            var pos = new Tuple<int, int, string>(j + 1, i + 1, "Southeast");
                            poslist.Add(pos);
                        }
                        if (Find_southwest(grid, s, i, j, n, m))
                        {
                            var pos = new Tuple<int, int, string>(j + 1, i + 1, "Southwest");
                            poslist.Add(pos);
                        }
                        if (Find_northwest(grid, s, i, j, n, m))
                        {
                            var pos = new Tuple<int, int, string>(j + 1, i + 1, "Northwest");
                            poslist.Add(pos);
                        }
                    }
                }
                if(poslist.Any())
                {
                    posdic.Add(s, poslist);
                }
            }
            foreach(string s in find)
            {
                if(posdic.ContainsKey(s))
                {
                    Console.WriteLine(s + ": ");
                    foreach (var i in posdic[s])
                    {
                        Console.WriteLine("(" + i.Item1 + ", " + i.Item2 + ") " + i.Item3);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not Found " + s + "!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        SELECTION:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Find Again[f]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Show Current Board[s]");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Reset Board[r]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Exit[e]");
            Console.ForegroundColor = ConsoleColor.Gray;
            string selection = Console.ReadLine();
            selection = selection.ToLower();
            while(selection != "f" && selection != "s" && selection != "r" && selection != "e")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid Input!");
                Console.WriteLine("Try Again!");
                Console.ForegroundColor = ConsoleColor.Gray;
                selection = Console.ReadLine();
            }
            if (selection == "f")
            {
                goto FIND;
            }
            else if (selection == "s")
            {
                Console.WriteLine();
                Console.WriteLine("Current Board:");
                Showboard(grid, n, m);
                goto SELECTION;
            }
            else if (selection == "r")
                goto RESET;
            else
                return 0;
        }
    }
}
