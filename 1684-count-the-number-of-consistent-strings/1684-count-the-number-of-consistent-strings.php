class Solution {

    /**
     * @param String $allowed
     * @param String[] $words
     * @return Integer
     */
    function countConsistentStrings($allowed, $words) {
        $allowed_chars = str_split($allowed);
        $counter = count($words);

        foreach($words as $word)
        {
            $letters = str_split($word);
            foreach($letters as $letter)
            {
                $char_not_allowed = !in_array($letter, $allowed_chars);
                if($char_not_allowed)
                {
                    $counter--;
                    break;
                }
            }
        }
        return $counter;
    }
}