public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        List<string> cities = paths.SelectMany(path => path).Distinct().ToList();   
    
        foreach(var path in paths)
        {
            string? firstCityInPath = cities.FirstOrDefault(city => city == path[0]);

            if(firstCityInPath != null)
                cities.Remove(firstCityInPath);
        }

        return cities.FirstOrDefault();
    }
}