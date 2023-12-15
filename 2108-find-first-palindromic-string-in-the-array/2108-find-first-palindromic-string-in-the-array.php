class Solution {

    /**
     * @param String[] $words
     * @return String
     */
    function firstPalindrome($words) {
        $fnIsPalindromic = fn($word) => $word == strrev($word);
        $palindromicStrings = array_filter($words, $fnIsPalindromic);
        return array_shift($palindromicStrings) ?? "";
    }
}