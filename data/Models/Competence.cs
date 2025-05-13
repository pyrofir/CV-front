using System.ComponentModel.DataAnnotations.Schema;

namespace CV_front.Models
{
    public class Competence
    {
        public int id { get; init; }
        public int type { get; init; }
        public int note { get; init; }
        public string name { get; init; }
    }
}
