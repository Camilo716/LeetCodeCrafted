public class Solution {
    public string DefangIPaddr(string address) {
        string[] ipBytes = address.Split('.');
        return string.Join("[.]", ipBytes);
    }
}