class Solution {

    /**
     * @param String[] $words1
     * @param String[] $words2
     * @return Integer
     */
    function countWords($words1, $words2) {
        $wordsAppearingOnceInBoth = array_filter($words1, function($word) use ($words1, $words2) {
            return $this->appearsOnce($word, $words1) && $this->appearsOnce($word, $words2);
        });

        return count($wordsAppearingOnceInBoth);
    }

    function appearsOnce($value, $items) {
        $occurrences = 0;

        foreach ($items as $item) {
            if ($item == $value) {
                $occurrences++;
            }
        }

        return $occurrences === 1;
    }
}