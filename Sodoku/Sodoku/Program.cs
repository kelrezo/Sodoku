using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sodoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[9,9];
            int row = 9;
            int col = 9;
            Debug.WriteLine(col);
            test(ref row,ref col);
            //iterate form 1 to 9
            //check col [k][i]
            //check row [i][k]
            //check grid
        }
        static void test(ref int row,ref int col)
        {
            row++;
            col++;
        }
        static bool UsedInBox(int[,] grid ,int boxStartRow, int boxStartCol, int num)
        {
            for (int row = 0; row < 3; row++)
                for (int col = 0; col < 3; col++)
                    if (grid[row + boxStartRow,col + boxStartCol] == num)
                        return true;
            return false;
        }
        static bool RowCheck(int [,] grid,int row,int num)
        {
            for (int x=0;x<9;x++)
            {
                if (grid[row, x] == num)
                    return true;
            }
            return false;
        }
        static bool ColCheck(int[,] grid, int col, int num)
        {
            for (int x = 0; x < 9; x++)
            {
                if (grid[x,col] == num)
                    return true;
            }
            return false;
        }
        static bool FindUnassignedLocation(int[,] grid, ref int row, ref int col)
        {
            for (row = 0; row < 9; row++)
                for (col = 0; col < 9; col++)
                    if (grid[row,col] == 0)
                        return true;
            return false;
        }

        static void solver()
        {

        }
    }
}
