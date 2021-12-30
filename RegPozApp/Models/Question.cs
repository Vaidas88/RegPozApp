using System.Collections.Generic;

namespace RegPozApp.Models
{
    public class Question : Entity
    {
        public List<Answer> Answers { get; set; }
    }
}
