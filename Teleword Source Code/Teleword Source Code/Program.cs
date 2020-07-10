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
            while ((srow < mrow) && (scol < mcol) && (srow >= 0) && (scol >= 0) && (i < find.Length))
            {
                if (grid[srow, scol] != find[i])
                    break;
                check += grid[srow, scol];
                scol--;
                i++;
            }
            if (check == find)
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
                if (grid[srow, scol] != find[i])
                    break;
                check += grid[srow, scol];
                scol++;
                i++;
            }
            if (check == find)
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
                if (grid[srow, scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow--;
                i++;
            }
            if (check == find)
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
                if (grid[srow, scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow++;
                i++;
            }
            if (check == find)
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
                if (grid[srow, scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow--;
                scol++;
                i++;
            }
            if (check == find)
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
                if (grid[srow, scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow++;
                scol++;
                i++;
            }
            if (check == find)
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
                if (grid[srow, scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow++;
                scol--;
                i++;
            }
            if (check == find)
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
                if (grid[srow, scol] != find[i])
                    break;
                check += grid[srow, scol];
                srow--;
                scol--;
                i++;
            }
            if (check == find)
                return true;
            else
                return false;
        }
        static void Showboard(char[,] grid, int mrow, int mcol)
        {
            for (int i = 0; i < mrow; i++)
            {
                for (int j = 0; j < mcol; j++)
                {
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
        }
        static int Main()
        {
        RESET:
            int n, m;
            Console.Clear();
            Console.WriteLine("Enter grid's dimension(n x m)");
            Console.Write("X Axis: ");
            var input_m = Console.ReadLine();
            while (!int.TryParse(input_m, out m))
            {
                Console.WriteLine("Error: Invalid Input!");
                Console.WriteLine("Try Again!");
                Console.Write("X Axis: ");
                input_m = Console.ReadLine();
            }
            Console.Write("Y Axis: ");
            var input_n = Console.ReadLine();
            while (!int.TryParse(input_n, out n))
            {
                Console.WriteLine("Error: Invalid Input!");
                Console.WriteLine("Try Again!");
                Console.Write("Y Axis: ");
                input_n = Console.ReadLine();
            }
            Console.Clear();
            char[,] grid = new char[n, m];
            char[] input_char;
            string input_string;
            Console.WriteLine("Enter character board.");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Line " + (i + 1) + ": ");
                input_string = Console.ReadLine();
                input_string = input_string.ToLower();
                while (input_string.Length > m)
                {
                    Console.WriteLine("Error: Invalid Input!");
                    Console.WriteLine("Try Again!");
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
            string find;
            Console.WriteLine("Enter a word that you want find.");
            find = Console.ReadLine();
            find = find.ToLower();
            Console.Clear();
            List<Tuple<int, int, string>> poslist = new List<Tuple<int, int, string>>();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (Find_left(grid, find, i, j, n, m))
                    {
                        var pos = new Tuple<int, int, string>(j + 1, i + 1, "Left");
                        poslist.Add(pos);
                    }
                    if (Find_right(grid, find, i, j, n, m))
                    {
                        var pos = new Tuple<int, int, string>(j + 1, i + 1, "Right");
                        poslist.Add(pos);
                    }
                    if (Find_up(grid, find, i, j, n, m))
                    {
                        var pos = new Tuple<int, int, string>(j + 1, i + 1, "Up");
                        poslist.Add(pos);
                    }
                    if (Find_down(grid, find, i, j, n, m))
                    {
                        var pos = new Tuple<int, int, string>(j + 1, i + 1, "Down");
                        poslist.Add(pos);
                    }
                    if (Find_northeast(grid, find, i, j, n, m))
                    {
                        var pos = new Tuple<int, int, string>(j + 1, i + 1, "Northeast");
                        poslist.Add(pos);
                    }
                    if (Find_southeast(grid, find, i, j, n, m))
                    {
                        var pos = new Tuple<int, int, string>(j + 1, i + 1, "Southeast");
                        poslist.Add(pos);
                    }
                    if (Find_southwest(grid, find, i, j, n, m))
                    {
                        var pos = new Tuple<int, int, string>(j + 1, i + 1, "Southwest");
                        poslist.Add(pos);
                    }
                    if (Find_northwest(grid, find, i, j, n, m))
                    {
                        var pos = new Tuple<int, int, string>(j + 1, i + 1, "Northwest");
                        poslist.Add(pos);
                    }
                }
            }
            if (!poslist.Any())
            {
                Console.WriteLine("Not Found " + find + "!");
            }
            else
            {
                Console.WriteLine("Found " + find + " position(x, y) and direction.");
                foreach (var i in poslist)
                {
                    Console.WriteLine("(" + i.Item1 + ", " + i.Item2 + ") " + i.Item3);
                }
            }
        SELECTION:
            Console.WriteLine();
            Console.WriteLine("Find Next[f]");
            Console.WriteLine("Show Current Board[s]");
            Console.WriteLine("Reset Board[r]");
            Console.WriteLine("Exit[e]");
            string selection = Console.ReadLine();
            selection = selection.ToLower();
            while (selection != "f" && selection != "s" && selection != "r" && selection != "e")
            {
                Console.WriteLine("Error: Invalid Input!");
                Console.WriteLine("Try Again!");
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
