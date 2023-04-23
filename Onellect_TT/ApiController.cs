using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Onellect_TT
{
    public class ApiController
    {
        public async Task<HttpResponseMessage> SendNumbers(IEnumerable<int> numbers, string url)
        {
            HttpResponseMessage responseMessage = null;
            using (HttpClient httpClient = new HttpClient())
            {
                var numbersJson = JsonSerializer.Serialize(numbers);
                HttpContent content = new StringContent(numbersJson, Encoding.UTF8, "application/json");
                responseMessage = await httpClient.PostAsync(url, content);
            }
            return responseMessage;
        }
    }
}
