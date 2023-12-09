class Solution {

    /**
     * @param String[] $words
     * @return Integer[]
     */
    function lastVisitedIntegers($words) {
        $consecutives_prev = 0;
        $nums=[];
        $nums_reverse = [];
 
        for($i = 0; $i <= count($words); $i++)
        {
            $isInt = $words[$i] != 'prev';
            if($isInt)
            {
                $consecutives_prev = 0;
                $nums[] = $words[$i];
                continue;
            }

            $consecutives_prev++;
            $total_visited_integers = count($nums);

            $nums_reverse[] = ($consecutives_prev > $total_visited_integers)
                ? -1
                : $nums[$total_visited_integers-$consecutives_prev];
        }

        return $nums_reverse;
    }
}