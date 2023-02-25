using consumindo_Api;
using System.Threading.Tasks;

public class Program {
    public static async Task Main(string[] args)
    {
        await ConsumindoApi.ConsumirApi();
    }
}


