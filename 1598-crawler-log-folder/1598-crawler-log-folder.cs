public class Solution {
    public int MinOperations(string[] logs) {
        int depth = 0;

        foreach(string log in logs)
        {
            bool movedToParentFolder = log == "../";
            bool movedToChildFolder = !log.StartsWith(".");
            
            if(movedToParentFolder && depth > 0)
                depth--;

            if(movedToChildFolder)
                depth++;
        }

        return depth;
    }
}