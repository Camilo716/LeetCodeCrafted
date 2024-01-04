class Solution {

    /**
     * @param String[] $words
     * @return Integer
     */
    function similarPairs($words) {
        $pairCounter = 0;

        $wordsLength = count($words);
        for($i = 0; $i < $wordsLength ; $i++)
        {
            for($j = $i + 1; $j < $wordsLength; $j++)
            {
                $uniqueCharsI = array_unique(str_split($words[$i]));
                $uniqueCharsJ = array_unique(str_split($words[$j]));

                sort($uniqueCharsI);
                sort($uniqueCharsJ);

                if($uniqueCharsI === $uniqueCharsJ)
                    $pairCounter++;
            }
        }

        return $pairCounter;
    }
}