class Solution {

    /**
     * @param String[] $words
     * @param String $x
     * @return Integer[]
     */
    function findWordsContaining($words, $x) {
        $indexes = [];

        for($i = 0; $i <= count($words); $i++)
        {
            if(str_contains($words[$i], $x))
                $indexes[] = $i;
        }
        
        return $indexes;
    }
}