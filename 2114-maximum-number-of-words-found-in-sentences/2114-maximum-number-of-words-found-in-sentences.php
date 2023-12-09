class Solution {

    /**
     * @param String[] $sentences
     * @return Integer
     */
    function mostWordsFound($sentences) {
       $maxNumWordsInSentence = 0;

       foreach($sentences as $sentence)
       {
            $words = explode(" ", $sentence);

            if(count($words) > $maxNumWordsInSentence)
            {
                $maxNumWordsInSentence = count($words);
            }
       }

       return $maxNumWordsInSentence;
    }
}