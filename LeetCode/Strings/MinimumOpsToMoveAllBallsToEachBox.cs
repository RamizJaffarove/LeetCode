namespace LeetCode.Strings;

/// <summary>
/// https://leetcode.com/problems/minimum-number-of-operations-to-move-all-balls-to-each-box/
/// You have n boxes. You are given a binary string boxes of length n,
/// where boxes[i] is '0' if the ith box is empty, and '1' if it contains one ball.
/// 
/// In one operation, you can move one ball from a box to an adjacent box.
/// Box i is adjacent to box j if abs(i - j) == 1.
/// Note that after doing so, there may be more than one ball in some boxes.
/// 
/// Return an array answer of size n, where answer[i] is the minimum number of operations
/// needed to move all the balls to the ith box.
/// 
/// Each answer[i] is calculated considering the initial state of the boxes.
/// </summary>
public class MinimumOpsToMoveAllBallsToEachBox
{
    public int[] MinOperations(string boxes)
    {
        var result = new int[boxes.Length];
        var ballInBox = new bool[boxes.Length];
        for (int i = 0; i < boxes.Length; i++)
        {
            for (int j = 0; j < boxes.Length; j++)
            {
                if (i == 0) ballInBox[j] = int.Parse(boxes.Substring(j, 1)) == 1;
                if (i == j) continue;

                result[i] += ballInBox[j] ? Math.Abs(i - j) : 0;
            }
        }

        return result;
    }
}