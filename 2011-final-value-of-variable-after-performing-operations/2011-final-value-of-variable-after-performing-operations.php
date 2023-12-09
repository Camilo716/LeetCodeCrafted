class Solution {

    /**
     * @param String[] $operations
     * @return Integer
     */
    function finalValueAfterOperations($operations) {
        $x = 0;

        foreach($operations as $operation)
        {
            $isIncrement = strpos($operation, "+") !== false;
            if($isIncrement)
            {
                $x++;
            }
            else
            {
                $x--;
            }
        }

        return $x;
    }
}