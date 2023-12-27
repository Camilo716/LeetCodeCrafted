class Solution {

    /**
     * @param String[] $strs
     * @return Integer
     */
    function maximumValue($strs) {   
        $maxValue = 0; 

        foreach($strs as $str)
        {
            $value = is_numeric($str)
                ? (int) $str
                : strlen($str); 

            if($value > $maxValue)
                $maxValue = $value;
        }   

        return $maxValue;
    }
}