class Solution {

    /**
     * @param String[] $words
     * @param String $pref
     * @return Integer
     */
    function prefixCount($words, $pref) {
        $fnWordHasGivenPrefix = fn($word) => str_starts_with($word, $pref);
        $wordsWhichStartsWithGivenPrefix = array_filter($words, $fnWordHasGivenPrefix);
        return count($wordsWhichStartsWithGivenPrefix);
    }
}