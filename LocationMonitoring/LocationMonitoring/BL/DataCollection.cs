using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LocationMonitoring.BL
{
    public class DataCollection
    {
        public static async Task CollectData(ICollection<string> output, CancellationToken ct)
        {
            try
            {
                while (!ct.IsCancellationRequested)
                {
                    var location = await LocationHelper.GetLocationAsync().ConfigureAwait(true);
                    output.Add($"Latitude: {location?.Lat}, Longitude: {location?.Long}, Altitude: {location?.Alt}");

                    await Task.Delay(100);
                }
            }
            catch
            {

            }
        }
    }
}
