class Solution {

    /**
     * @param String $s
     * @param Integer $k
     * @return String
     */
    function truncateSentence($s, $k) {
        $words = explode(" ", $s);
        $sentence_with_only_k_words = array_slice($words, 0, $k);
        return implode(" ", $sentence_with_only_k_words);
    }
}