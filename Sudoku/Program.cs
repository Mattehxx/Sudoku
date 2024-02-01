using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    internal class Program
    {
        public static readonly int[,] table = {
            { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
            { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
            { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
            { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
            { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
            { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
            { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
            { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
            { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
        };

        public static int[,] editableTable = (int[,])table.Clone();

        public const string instructions = "Press enter to close the program, " +
            "otherwise insert x, y and value in the following format (x, y, value): ";

        public static bool CheckCoordinates(int x, int y)
        {
            if ((x >= 0 && x <= 8) && (y >= 0 && y <= 8))
                return true;

            return false;
        }

        public static bool IsEditable(int x, int y)
        {
            if (table[y, x] == 0)
            {
                return true;
            }
            return false;
        }

        public static bool CheckValue(int value)
        {
            //1 - 9
            return false;
        }

        public static bool EditTable(int x, int y, int value)
        {
            if (CheckCoordinates(x, y) && CheckValue(value) && IsEditable(x, y))
            {
                editableTable[x, y] = value;
                return true;
            } 
            return false;
        }

        public static void PrintTable ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(PrintHorizontalLines());

            for(int y = 0; y < table.GetLength(0); y++)
            {
                for (int x = 0; x < table.GetLength(1); x++)
                {
                    sb.Append(editableTable[y, x]);
                    if (x < table.GetLength(0) - 1)
                        sb.Append(" | ");
                }
                sb.AppendLine();
                sb.AppendLine(PrintHorizontalLines());
            }

            sb.AppendLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(sb.ToString());

            Console.ResetColor();

            Console.Write(instructions);
        }

        public static string PrintHorizontalLines()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (i < table.GetLength(0) - 1)
                    sb.Append("- - ");
                else
                    sb.Append("-");
            }

            return sb.ToString();
        public static bool CheckColumns(int x, int y, int value)
        {
            if (editableTable[y, x] == value)
                return true;
            for (int i = 0; i < 9; i++)
            {
                if (editableTable[y, i] == value)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckRows(int x, int y, int value)
        {
            if (editableTable[y, x] == value)
                return true;
            for (int i = 0; i < 9; i++)
            {
                if (editableTable[i, x] == value)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckBoxes(int x, int y, int value)
        {
            if (editableTable[y, x] == value)
                return true;
            if ((x >= 0 && x <= 2) && (y >= 0 && y <= 2))
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    if (editableTable[i, j] == value)
                    {
                        return false;
                    }
                }
            }

            if ((x >= 3 && x <= 5) && (y >= 0 && y <= 2))
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 3; j < 6; j++)
                        if (editableTable[i, j] == value)
                        {
                            return false;
                        }
                }
            }

            if ((x >= 6 && x <= 8) && (y >= 0 && y <= 2))
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 6; j < 9; j++)
                        if (editableTable[i, j] == value)
                        {
                            return false;
                        }
                }
            }

            if ((x >= 0 && x <= 2) && (y >= 3 && y <= 5))
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 0; j < 3; j++)
                        if (editableTable[i, j] == value)
                        {
                            return false;
                        }
                }
            }
            if ((x >= 0 && x <= 2) && (y >= 3 && y <= 5))
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 0; j < 3; j++)
                        if (editableTable[i, j] == value)
                        {
                            return false;
                        }
                }
            }
            if ((x >= 3 && x <= 5) && (y >= 3 && y <= 5))
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 3; j < 6; j++)
                        if (editableTable[i, j] == value)
                        {
                            return false;
                        }
                }
            }
            if ((x >= 6 && x <= 8) && (y >= 3 && y <= 5))
            {
                for (int i = 3; i < 6; i++)
                {
                    for (int j = 6; j < 9; j++)
                        if (editableTable[i, j] == value)
                        {
                            return false;
                        }
                }
            }
            if ((x >= 0 && x <= 2) && (y >= 6 && y <= 8))
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 0; j < 3; j++)
                        if (editableTable[i, j] == value)
                        {
                            return false;
                        }
                }
            }
            if ((x >= 3 && x <= 5) && (y >= 6 && y <= 8))
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 3; j < 6; j++)
                        if (editableTable[i, j] == value)
                        {
                            return false;
                        }
                }
            }
            if ((x >= 6 && x <= 8) && (y >= 6 && y <= 8))
            {
                for (int i = 6; i < 9; i++)
                {
                    for (int j = 6; j < 9; j++)
                        if (editableTable[i, j] == value)
                        {
                            return false;
                        }
                }
            }
        }
        public static string PrintTable ()
        {
            //Print the editable table
            return "";
        }

        static void Main(string[] args)
        {
            string readLine = "";

            do
            {
                PrintTable();
                readLine = Console.ReadLine();
                readLine = readLine.Trim();
                if (readLine.Length > 0)
                {
                    var parts = readLine.Split(',');

                    if (parts.Length == 3)
                    {
                        if (int.TryParse(parts[0], out int x) &&
                        int.TryParse(parts[1], out int y) &&
                        int.TryParse(parts[2], out int value))
                        {
                            EditTable(x, y, value);
                        }
                        else
                        {
                            Console.WriteLine("Inserted values are not acceptable");
                            Console.WriteLine();
                        }
                    } else
                    {
                        Console.WriteLine("Missing argouments");
                        Console.WriteLine();
                    }
                }
            } while (readLine != "");
        }
    }
}
