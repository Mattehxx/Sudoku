using System;
using System.Collections.Generic;
using System.Linq;
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

        public const string instructions = "Insert x, y and value in the following format (x, y, value): ";

        public static bool CheckCoordinates(int x, int y)
        {
            //0 - 8
            return false;
        }

        public static bool IsEditable (int x, int y)
        {
            //value[x][y] == 0
            return false;
        }

        public static bool CheckValue (int value)
        {
            //1 - 9
            return false;
        }

        public static bool EditTable (int x, int y, int value)
        {
            //Edit the temporary table
            return false;
        }

        public static string PrintTable ()
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
            sb.Append(instructions);

            return sb.ToString();
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
        }
 
        static void Main(string[] args)
        {
            Console.Write(PrintTable());
            Console.ReadLine();
        }
    }
}
