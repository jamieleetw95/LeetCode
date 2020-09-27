using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCheckConsole.Solution
{
    public partial class Solution
    {
        private SubrectangleQueries fSubrectangle;

        private void ExecuteFunction(string functionName, ParameterObj parameters)
        {
            switch(functionName)
            {
                case "SubrectangleQueries":
                    fSubrectangle = new SubrectangleQueries(parameters.Rectangle);
                    break;
                case "getValue":
                    fSubrectangle.GetValue(parameters.Row1, parameters.Col1);
                    break;
                case "updateSubrectangle":
                    fSubrectangle.UpdateSubrectangle(parameters.Row1, parameters.Col1, parameters.Row2, parameters.Col2, parameters.NewValue);
                    break;
                default:
                    break;
            }
        }



        public void SubrectangleQueriesTest()
        {
            List<string> input = new List<string> { "SubrectangleQueries", "getValue", "updateSubrectangle", "getValue", "getValue", "updateSubrectangle", "getValue" };



        }
    }
    public class SubrectangleQueries
    {
        private int[][] fRectangle;

        public SubrectangleQueries(int[][] rectangle)
        {
            fRectangle = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            int rowMax = row2 < fRectangle.Count() ? row2 : fRectangle.Count();
            
            for(int r = row1; r < rowMax; r++)
            {
                int[] tempRow = fRectangle.ElementAtOrDefault(r);

                if(tempRow == null)
                {
                    continue;
                }

                int colMax = col2 < tempRow.Count() ? col2 : tempRow.Count();

                for(int c = col1; c < colMax; c++)
                {
                    fRectangle[r][c] = newValue;
                }
            }
        }

        public int GetValue(int row, int col)
        {
            int[] tempRow = fRectangle.ElementAtOrDefault(row);

            return tempRow == null ? default(int) : tempRow.ElementAtOrDefault(col);
        }
    }

    internal class ParameterObj
    {
        public int Row1;
        public int Col1;
        public int Row2;
        public int Col2;
        public int NewValue;
        public int[][] Rectangle;
    }
}
