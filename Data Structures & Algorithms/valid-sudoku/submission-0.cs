public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var row = new Dictionary<int, HashSet<char>>();
        var column = new Dictionary<int, HashSet<char>>();
        var box = new Dictionary<int, HashSet<char>>();

        for(int x = 0; x < 9; x++)
        {
            row.TryAdd(x, new HashSet<char>());
            column.TryAdd(x, new HashSet<char>());
            box.TryAdd(x, new HashSet<char>());

            for(int y = 0; y < 9; y++)
            {
                row.TryAdd(y, new HashSet<char>());
                column.TryAdd(y, new HashSet<char>());
                box.TryAdd(y, new HashSet<char>());

                var current = board[x][y];

                if(current != '.')
                {
                    if(!row[x].Add(current))
                    {
                        return false;
                    }

                    if(!column[y].Add(current))
                    {
                        return false;
                    }

                    var boxIndex = (x / 3) * 3 + (y / 3);

                    if(!box[boxIndex].Add(current))
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}
