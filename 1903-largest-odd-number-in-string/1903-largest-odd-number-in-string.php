class Solution {

    /**
     * @param String $num
     * @return String
     */
    function largestOddNumber($num) {

        for($i = strlen($num); $i >= 0; $i--)
        {
            $isOdd = intval($num[$i]) % 2 != 0;
            if($isOdd) 
                return substr($num, 0, $i+1);
        }

        return "";
    }
}