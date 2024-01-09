class Solution {

    /**
     * @param String[] $words
     * @return String[]
     */
    function stringMatching($words) {
        $matchingStrings = [];
        $allWords = implode(' ', $words);

        foreach($words as $word) {
            $foundCoincidences = substr_count($allWords, $word) > 1;
            if($foundCoincidences)
                $matchingStrings[] = $word;
        }

        return $matchingStrings;
    }
}