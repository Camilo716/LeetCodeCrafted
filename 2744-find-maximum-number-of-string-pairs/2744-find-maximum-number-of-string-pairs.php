class Solution {

    /**
     * @param String[] $words
     * @return Integer
     */
    function maximumNumberOfStringPairs($words) {
        $maxNumberofPairs;

        foreach($words as $key => $word)
        {
            $tmpWord = $words[$key];
            unset($words[$key]);

            $reversedPairExists = in_array(strrev($tmpWord), $words);
            if($reversedPairExists)
                $maxNumberOfPairs++;
        }

        return $maxNumberOfPairs ?? 0;
    }
}