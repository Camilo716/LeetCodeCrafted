class Solution {

    /**
     * @param String[] $words
     * @param String $s
     * @return Integer
     */
    function countPrefixes($words, $s) {
        $fnIsPrefixOfString = fn($prefix) => str_starts_with($s, $prefix);
        $prefixes = array_filter($words, $fnIsPrefixOfString);
        return count($prefixes);
    }
}