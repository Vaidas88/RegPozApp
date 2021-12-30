namespace RegPozApp.Models
{
    public class Answer : Entity
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public bool Current { get; set; }
    }
}
