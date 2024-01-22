public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        var cities = paths.SelectMany(path => path);
        var firstCitiesByPath = paths.Select(path => path[0]);   

        return cities.Except(firstCitiesByPath).FirstOrDefault();
    }
}