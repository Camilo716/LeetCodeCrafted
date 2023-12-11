class Solution {

    /**
     * @param String[] $words
     * @return Integer
     */
    function uniqueMorseRepresentations($words) {
        $ENGLISH_ALPHABET = [
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
            'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
            'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        ];
        $MORSE_ALPHABET = [
            ".-","-...","-.-.","-..",".","..-.", "--.","....","..",
            ".---","-.-",".-..", "--","-.","---",".--.","--.-",".-.",
            "...", "-","..-","...-",".--","-..-","-.--","--.."
        ];

        $words_in_morse = array_map(function ($word) use ($ENGLISH_ALPHABET, $MORSE_ALPHABET) {
            $word_in_morse = "";
            foreach (str_split($word) as $letter) {
                $letter_index = array_search(strtoupper($letter), $ENGLISH_ALPHABET);
                $word_in_morse .= $MORSE_ALPHABET[$letter_index];
            }
            return $word_in_morse;
        } , $words);

        return count(array_unique($words_in_morse));
    }
}