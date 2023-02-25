using System.Threading.Tasks;
using Newtonsoft.Json;

namespace consumindo_Api;
    public class ConsumindoApi
    {
        public static async Task ConsumirApi()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://economia.awesomeapi.com.br/USD-BRL");
            var res = await client.GetAsync("USD");
            var content = await res.Content.ReadAsStringAsync();
            var listProps = JsonConvert.DeserializeObject<Ibid.Currency[]>(content);
            foreach(var item in listProps) {
                Console.WriteLine($"Cotação atual do Dolar: R${item.Bid.ToString("N2")}");
            }
        }
    }

