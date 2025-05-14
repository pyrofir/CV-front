using CV_front.Models;
using Microsoft.Extensions.Configuration;

namespace data
{
    public class CvHttpClient
    {
        private readonly HttpClient _httpClient;

        public CvHttpClient(HttpClient httpClient,IConfiguration configuration)
        {
            _httpClient = httpClient;

        }




        public async Task<List<Competence>> GetAllCompetencesAsync() 
        {
            try 
            {                
                return await _httpClient.GetFromJsonAsync<List<Competence>>("CV/Competence");
            }
            catch (Exception)
            {
                return new List<Competence>();
            }
        }


        public async Task<List<SortCompetences>> GetAllSortCompetencesAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<SortCompetences>>("CV/Competence/sort");
            }
            catch (Exception)
            {
                return new List<SortCompetences>();
            }
        }


        public async Task<List<Formation>> GetAllFormationAsync() 
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Formation>>("CV/Formation");
            }
            catch (Exception) 
            {
                return new List<Formation>();
            }
        }
    }
}
