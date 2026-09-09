public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++) 
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        // 2. Traverse every cell in the 9x9 grid
        for (int r = 0; r < 9; r++) 
        {
            for (int c = 0; c < 9; c++) 
            {
                char val = board[r][c];

                // Skip empty spots
                if (val == '.') 
                {
                    continue;
                }

                // Flatten the 3x3 sub-box coordinates (r / 3, c / 3) into an index 0..8
                int boxIndex = (r / 3) * 3 + (c / 3);

                // If already present in row, col, or box, the board is invalid
                if (rows[r].Contains(val) || 
                    cols[c].Contains(val) || 
                    boxes[boxIndex].Contains(val)) 
                {
                    return false;
                }

                // Register the character
                rows[r].Add(val);
                cols[c].Add(val);
                boxes[boxIndex].Add(val);
            }
        }

        // No conflicts found
        return true;
    }

  
 }

