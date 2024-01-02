class Solution {

    /**
     * @param String $s
     * @param Integer[] $distance
     * @return Boolean
     */
    function checkDistances($s, $distance) {
        $alphabet = array_flip(range('a', 'z'));

        $letters = str_split($s);
        while($letters)
        {
            $letter = end($letters);

            $firstApparitionIndex = array_search($letter, $letters);
            unset($letters[$firstApparitionIndex]);

            $secondApparitionIndex = array_search($letter, $letters);
            unset($letters[$secondApparitionIndex]);

            $indexOfLetterInAlphabet = $alphabet[$letter];
            $matchesDistance = $distance[$indexOfLetterInAlphabet] === $secondApparitionIndex - $firstApparitionIndex - 1;
            if(!$matchesDistance)
                return false;
        }

        return true;
    }
}