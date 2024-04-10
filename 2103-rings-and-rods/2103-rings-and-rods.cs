public class Solution {
    Dictionary<char, List<char>> ringsPerRod = [];

    public int CountPoints(string rings) {
        CalculateRingsPerRod(rings);
        return CalculateNumberOfRodsWithAllColors();
    }

    private void CalculateRingsPerRod(string rings)
    {
        for (int i = 1; i < rings.Length; i += 2)
        {
            char rod = rings[i];
            char colorOfRing = rings[i - 1];

            ringsPerRod.TryAdd(rod, []);
            ringsPerRod[rod].Add(colorOfRing);
        }
    }

    private int CalculateNumberOfRodsWithAllColors()
    {
        int rodsWithAllColors = 0;

        foreach (List<char> item in ringsPerRod.Values)
        {
            if (HasAllColors(item))
                rodsWithAllColors++;
        }

        return rodsWithAllColors;
    }

    private bool HasAllColors(IEnumerable<char> item)
        => item.Distinct().Count() == 3;

}