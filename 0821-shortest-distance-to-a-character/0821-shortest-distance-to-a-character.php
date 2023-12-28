class Solution {

    /**
     * @param String $s
     * @param String $c
     * @return Integer[]
     */
    function shortestToChar($s, $c) {
        $shortestDistancesToRight = $this->getShortestDistancesToRight($c, $s, PHP_INT_MAX);
        $shortestDistancesToLeft = $this->getShortestDistancesToLeft($c, $s, PHP_INT_MAX);

        return array_map('min', $shortestDistancesToRight, $shortestDistancesToLeft);
    }

    function getShortestDistancesToRight($needle, $haystack, $placeholder="#")
    {
        $shortestDistancesToRight = [];
        $previousCoincidenceIndex = $placeholder;

        for($i = strlen($haystack) - 1; $i >= 0; $i--)
        {
            if($haystack[$i] == $needle)
            {
                array_unshift($shortestDistancesToRight , 0);
                $previousCoincidenceIndex = 0;
                continue; 
            }

            $previousCoincidenceIndex--;
            array_unshift($shortestDistancesToRight, abs($previousCoincidenceIndex));
        }

        return $shortestDistancesToRight;
    }

    function getShortestDistancesToLeft($needle, $haystack, $placeholder="#")
    {
        $shortestDistancesToLeft = [];
        $previousCoincidenceIndex = $placeholder;

        for($i = 0; $i < strlen($haystack); $i++)
        {
            if($haystack[$i] == $needle)
            {
                $shortestDistancesToLeft[] = 0;
                $previousCoincidenceIndex = 0;
                continue; 
            }

            $notYetFoundCoincidence = $previousCoincidenceIndex === $placeholder;
            if($notYetFouncCoincidence)
            {
               $shortestDistancesToLeft[] = $placeholder;
               continue; 
            }

            $previousCoincidenceIndex++;
            $shortestDistancesToLeft[] = $previousCoincidenceIndex;
        }

        return $shortestDistancesToLeft;
    }
}