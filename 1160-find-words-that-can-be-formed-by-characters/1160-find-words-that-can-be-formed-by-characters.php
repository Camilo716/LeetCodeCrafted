class Solution {

    /**
     * @param String[] $words
     * @param String $chars
     * @return Integer
     */
    function countCharacters($words, $chars) {
        $fnWordCanBeFormed = function($word) use ($chars) {
            return $this->wordCanBeFormed($word, $chars);
        };

        $wordsThatCanBeFormed = array_filter($words, $fnWordCanBeFormed);

        return $this->countTotalCharactersInArray($wordsThatCanBeFormed);
    }

    function wordCanBeFormed($word, $chars) {
        $charsLeftToBeFormed = str_split($word);

        foreach(str_split($chars) as $char)
        {
            $indexCharToBeFormed = array_search($char, $charsLeftToBeFormed);

            if($indexCharToBeFormed !== false)
                unset($charsLeftToBeFormed[$indexCharToBeFormed]);
        }

        return $wordCanBeFormed = empty($charsLeftToBeFormed);
    }

    function countTotalCharactersInArray($array)
    {   
        return array_reduce($array, function($charsCount, $currWord){
            return $charsCount + strlen($currWord); 
        }, 0);
    }
}