namespace LeetCode.Strings;

/// <summary>
/// https://leetcode.com/problems/execution-of-all-suffix-instructions-staying-in-a-grid/
/// There is an n x n grid, with the top-left cell at (0, 0) and the bottom-right cell at (n - 1, n - 1).
/// You are given the integer n and an integer array startPos where startPos = [startrow, startcol]
/// indicates that a robot is initially at cell (startrow, startcol).
/// 
/// You are also given a 0-indexed string s of length m where s[i] is the ith instruction for the robot:
/// 'L' (move left), 'R' (move right), 'U' (move up), and 'D' (move down).
/// 
/// The robot can begin executing from any ith instruction in s.
/// It executes the instructions one by one towards the end of s but it stops if either of these conditions is met:
/// 
/// The next instruction will move the robot off the grid.
/// There are no more instructions left to execute.
/// Return an array answer of length m where answer[i] is the number of instructions the robot can execute if the robot begins executing from the ith instruction in s.
/// </summary>
public class GridSuffixInstructions
{
    public int[] Execute(int n, int[] startPos, string operations)
    {
        int[] result = new int[operations.Length];

        for (var i = 0; i < operations.Length; i++)
        {
            int currentRow = startPos[0];
            int currentCol = startPos[1];
            for (var j = i; j < operations.Length; j++)
            {
                var operation = operations[j];
                if (TryMove(currentRow, currentCol, n, operation, out currentRow, out currentCol))
                    result[i] += 1;
                else
                    break;
            }
        }

        return result;
    }

    private bool TryMove(int currentRow, int currentCol, int gridSize, char operation, 
        out int newRow, out int newCol)
    {
        newRow = currentRow;
        newCol = currentCol;
        bool result = false;
        switch (operation)
        {
            case 'R':
                result = currentCol + 1 < gridSize;
                newCol += result ? 1 : 0;
                break;

            case 'L':
                result = currentCol - 1 >= 0;
                newCol -= result ? 1 : 0;
                break;

            case 'U':
                result = currentRow - 1 >= 0;
                newRow -= result ? 1 : 0;
                break;

            case 'D':
                result = currentRow + 1 < gridSize;
                newRow += result ? 1 : 0;
                break;
        }

        return result;
    }
}