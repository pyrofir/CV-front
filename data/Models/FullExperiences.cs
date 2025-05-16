using CV_front.Models;

namespace CV_front.Models
{
    public class FullExperiences
    {
        public Experience experiences { get; init; }
        public List<Competence> competences { get; init; }
        public List<TacheExperience> taches { get; init; }
        public string? type { get; init; }
        
    }
}
