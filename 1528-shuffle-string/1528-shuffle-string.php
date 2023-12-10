class Solution {

    /**
     * @param String $s
     * @param Integer[] $indices
     * @return String
     */
    function restoreString($s, $indices) {
        $arrayShuffled = array_fill(0, count($indices), "");

        foreach($indices as $key => $position)
        {
            $arrayShuffled[$position] = $s[$key];
        }

        return implode("", $arrayShuffled);
    }
}