namespace LeetCode.Strings;

public class BankLaserBeams
{
    public int NumberOfBeams(string[] bank)
    {
        int beamsCount = 0;
        int prevFloorDeviceCount = 0;
        foreach (var floor in bank)
        {
            var currentFloorDeviceCount = 0;
            for (var i = 0; i < floor.Length; i++)
            {
                var device = floor.Substring(i, 1);
                if (int.Parse(device) == 1)
                    currentFloorDeviceCount++;
            }

            if (currentFloorDeviceCount > 0)
            {
                beamsCount += currentFloorDeviceCount * prevFloorDeviceCount;
                prevFloorDeviceCount = currentFloorDeviceCount;
            }
        }

        return beamsCount;
    }
}