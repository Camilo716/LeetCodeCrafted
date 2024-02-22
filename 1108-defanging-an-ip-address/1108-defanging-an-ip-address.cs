public class Solution {
    public string DefangIPaddr(string address) {
        return string.Join("[.]", address.Split('.'));
    }
}