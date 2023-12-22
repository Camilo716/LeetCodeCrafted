class Solution {

    /**
     * @param String[] $words
     * @param Integer $left
     * @param Integer $right
     * @return Integer
     */
    function vowelStrings($words, $left, $right) {
        $wordsInRange = array_slice($words, $left, $right - $left + 1);
        $vowels = ['a', 'e', 'i', 'o', 'u'];
        $numberOfVowelStrings = 0;

        foreach($wordsInRange as $word)
        {
            $firstChar = strtolower($word[0]);
            $lastChar = strtolower($word[strlen($word) - 1]);

            $startsWithVowel = in_array($firstChar, $vowels);
            $endsWithVowel = in_array($lastChar, $vowels);

            if($startsWithVowel && $endsWithVowel)
                $numberOfVowelStrings++;
        }

        return $numberOfVowelStrings;
    }
}