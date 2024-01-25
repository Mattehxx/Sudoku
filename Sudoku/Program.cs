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
            //Edit the temporary table
            return false;
        }

        public static string PrintTable()
        {
            //Print the editable table
            return "";
        }

        static void Main(string[] args)
        {

        }
    }
}
