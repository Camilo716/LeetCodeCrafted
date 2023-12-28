class Solution {

    /**
     * @param String $s
     * @param String $c
     * @return Integer[]
     */
    function shortestToChar($s, $c) {
        $answer = [];

        foreach(str_split($s) as $index => $char)
        {
            $shortestDistanceToRight = $this->getShortestDistanceToRight($index, $c, $s);
            $shortestDistanceToLeft = $this->getShortestDistanceToLeft($index, $c, $s);

            $answer[] = min([$shortestDistanceToRight, $shortestDistanceToLeft]);
        }

        return $answer;
    }

    function getShortestDistanceToRight($needleIndex, $needle, $haystack)
    {
        for($i = $needleIndex; $i < strlen($haystack); $i++)
        {
            if($needle == $haystack[$i])
            {
                return $i - $needleIndex;
            }
        }
        return PHP_INT_MAX;
    }

    function getShortestDistanceToLeft($needleIndex, $needle, $haystack)
    {
        for($i = $needleIndex; $i >= 0; $i--)
        {
            if($needle == $haystack[$i])
            {
                return $needleIndex - $i;
            }
        }

        return PHP_INT_MAX;
    }
}