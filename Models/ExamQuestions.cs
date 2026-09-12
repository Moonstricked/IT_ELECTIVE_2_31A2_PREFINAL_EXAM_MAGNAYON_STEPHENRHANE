namespace PrefinalExamApp.Models
{
    public class ExamQuestions
    {
        // this is so over the top but i think it's fiiiine??? i hope
        public int Id { get; set; }
        public string Question { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public string CorrectAnswer { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
    }
}