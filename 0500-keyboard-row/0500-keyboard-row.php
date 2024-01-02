class Solution {

    /**
     * @param String[] $words
     * @return String[]
     */
    function findWords($words) {
        return array_filter(
            $words,
            fn($word) => $this->canBeTypedUsingOnlyOneRow($word)
        );
    }

    function canBeTypedUsingOnlyOneRow($word)
    {
        $word = str_split(strtolower($word));
        $charactersPerRow = [
            1 => 'qwertyuiop',
            2 => 'asdfghjkl',
            3 => 'zxcvbnm'
        ];

        foreach($charactersPerRow as $row)
        {
            $canBeTypedWithRow = !array_diff($word, str_split($row));

            if($canBeTypedWithRow)
                return true;
        }

        return false;
    }
}