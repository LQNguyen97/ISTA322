using System.Collections.Generic;

namespace TranslationQuiz.Models
{
    public class Repository
    {
        private static List<StudentInput> responses = new List<StudentInput>();
        public static IEnumerable<StudentInput> Responses => responses;
        public static void AddResponse(StudentInput response)
        {
            responses.Add(response);
        }
    }
}

