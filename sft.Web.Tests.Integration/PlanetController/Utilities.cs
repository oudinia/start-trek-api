using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace sft.Web.Tests.Integration.PlanetController
{
    internal class Utilities
    {
        public static int GivenExpectedCount(int count)
        {
            return count;
        }

        public static async Task<T[]?>  WhenGetSerializedResponse<T>(string uri, HttpClient client)
        {
            var planetsResponse = await client.GetAsync(uri);
            var statusCode = planetsResponse.StatusCode;

            if (statusCode == System.Net.HttpStatusCode.NotFound)
                return new List<T>().ToArray();

            var response = await planetsResponse.Content.ReadAsStringAsync();
            var planets = JsonSerializer.Deserialize<T[]>(response);
            return  planets;
        }
    }
}
