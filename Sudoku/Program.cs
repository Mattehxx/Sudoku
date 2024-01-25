using System;
using System.Collections.Generic;
using System.Linq;
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
            if (CheckCoordinates(x, y) && CheckValue(value) && IsEditable(x, y))
            {
                editableTable[x, y] = value;
                return true;
            } 
            return false;
        }

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

        }
    }
}
