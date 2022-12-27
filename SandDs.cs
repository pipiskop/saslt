using Newtonsoft.Json;

namespace MYASAAAA
{
    internal class flack
    {
        public static void sdsd()
        {
            string Tuk = File.ReadAllText("C:\\10 Практическая\\Данные.json");
            List<List<string>> Vse = JsonConvert.DeserializeObject<List<List<string>>>(Tuk);
            mayasko4.AllVse = Vse;
        }
        public static void S()
        {
            string json = JsonConvert.SerializeObject(mayasko4.AllVse);
            File.WriteAllText("C:\\10 Практическая\\Данные.json", json);
        }
    }
}
