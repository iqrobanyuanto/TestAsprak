using System.Collections.Generic;
using System.Text.Json;

namespace TestAsprak
{
    public static class JsonLibrary
    {
        static string jsonpath = Path.Combine("D:/Sekolah/Rekruitasi Asprak/TestAsprak/TestAsprak/jsontest.json");

        public static void serialize(List<Barang> baranglist)
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            String jsonString = JsonSerializer.Serialize(baranglist, options);
            File.WriteAllText(jsonpath, jsonString);
        }

        public static List<Barang> deserialize()
        {
            string jsonFile = File.ReadAllText(jsonpath);
            return JsonSerializer.Deserialize<List<Barang>>(jsonFile);

        }

        public static void check()
        {
            try
            {
                List<Barang> baranglist = deserialize();
            }
            catch (Exception)
            {
                List<Barang> baranglist = new List<Barang>();
                serialize(new List<Barang>());
            }
        }
    }
}
