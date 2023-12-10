class Solution {

    /**
     * @param String[][] $items
     * @param String $ruleKey
     * @param String $ruleValue
     * @return Integer
     */
    function countMatches($items, $ruleKey, $ruleValue) {
        $itemsMatchingRuleCount = 0;

        foreach($items as $item)
        {
            $matchesRuleForType = $ruleKey == 'type' && $item[0] == $ruleValue;
            $matchesRuleForColor = $ruleKey == 'color' && $item[1] == $ruleValue;
            $matchesRuleForName = $ruleKey == 'name' && $item[2] == $ruleValue;

            $matchesRule = $matchesRuleForType || $matchesRuleForColor || $matchesRuleForName;
            if($matchesRule)
                $itemsMatchingRuleCount++;
        }

        return $itemsMatchingRuleCount;
    }
}