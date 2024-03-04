public class Solution {
    List<string> cellsInRange = new();

    public IList<string> CellsInRange(string s) {
        char colStart = s[0];
        char rowStart = s[1];
        char colEnd = s[3];
        char rowEnd = s[4];

        for(char col = colStart; col <= colEnd; col++)
        {
            for(char row = rowStart; row <= rowEnd; row++)
            {
                cellsInRange.Add($"{col}{row}");
            }
        }

        return cellsInRange;
    }
}