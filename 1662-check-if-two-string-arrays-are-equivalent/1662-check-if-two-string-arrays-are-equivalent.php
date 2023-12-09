class Solution {

    /**
     * @param String[] $word1
     * @param String[] $word2
     * @return Boolean
     */
    function arrayStringsAreEqual($word1, $word2) {
        $word1String = implode('', $word1);
        $word2String = implode('', $word2);

        return $word1String === $word2String;
    }
}