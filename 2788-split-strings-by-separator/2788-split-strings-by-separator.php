class Solution {

    /**
     * @param String[] $words
     * @param String $separator
     * @return String[]
     */
    function splitWordsBySeparator($words, $separator) {
        $splitedStrings = [];

        foreach($words as $word)
        {
            $splitedStrings[] = explode($separator, $word); 
        }

        $result = call_user_func_array('array_merge', $splitedStrings);
        return  array_filter($result);
    }
}