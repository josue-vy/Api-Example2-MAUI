using ApiExample2.Models;

namespace ApiExample2.Services
{
    public interface IMangaTop
    {
        public Task<List<MangasResponse>> Get();
    }
}