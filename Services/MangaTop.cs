using ApiExample2.Models;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ApiExample2.Services
{
    public class MangaTop : IMangaTop
    {
        private string urlApi = "https://manga-apiv1.vercel.app/api/popular";

        public async Task<List<MangasResponse>> Get()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlApi);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();

                // Deserializar la respuesta directamente en una lista de MangasResponse
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // Opcional, para que coincida con el nombre de las propiedades en CamelCase
                };

                var data = JsonSerializer.Deserialize<List<MangasResponse>>(responseBody, options);
                if (data != null)
                {
                    return data;
                }
            }

            // Manejar errores aquí
            return new List<MangasResponse>();
        }
    }
}
