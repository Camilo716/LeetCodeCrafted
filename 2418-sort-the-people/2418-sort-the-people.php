class Solution {

    /**
     * @param String[] $names
     * @param Integer[] $heights
     * @return String[]
     */
    function sortPeople($names, $heights) {
        array_multisort($heights, SORT_DESC, $names);
        return $names;
    }
}