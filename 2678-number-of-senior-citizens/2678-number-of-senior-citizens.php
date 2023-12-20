class Solution {

    /**
     * @param String[] $details
     * @return Integer
     */
    function countSeniors($details) {
        $fnIsSenior = fn($citizen) => substr($citizen, 11, 2) > 60;  
        $seniorCitizens = array_filter($details, $fnIsSenior);
        return count($seniorCitizens);
    }
}