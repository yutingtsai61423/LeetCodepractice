public class Solution {
        public bool IsValidSudoku(char[][] board)
        {
            //用dictionary key= 行號 value = set,紀錄那些數字有看過了

            //row dictionary set
            Dictionary<int, HashSet<int>> rowDic = new Dictionary<int, HashSet<int>>();
            //column dictionary set
            Dictionary<int, HashSet<int>> colDic = new Dictionary<int, HashSet<int>>();
            //init
            for (int i = 0; i < 9; i++)
            {
                rowDic[i] = new HashSet<int>();
                colDic[i] = new HashSet<int>();
            }

            //grid set
            HashSet<int>[,] grid = new HashSet<int>[3, 3];
            //init
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <3; j++)
                {
                    grid[i, j] = new HashSet<int>();
                }
            }


            //for loop 看有沒有已經在set裡面，如果有就代表不合理的數獨，回傳false就回傳

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[0].Length; col++)
                {
                    if (board[row][col] == '.') continue;
                    int c = board[row][col] - '0';
                    //rol
                    bool inRow = rowDic[row].Contains(c);
                    //col
                    bool inCol = colDic[col].Contains(c);
                    //grid
                    bool inGrid = grid[row / 3, col / 3].Contains(c);

                    if (inRow || inCol || inGrid) return false;

                    rowDic[row].Add(c);
                    colDic[col].Add(c);
                    grid[row / 3, col / 3].Add(c);
                }
            }

            return true;
        }
}
