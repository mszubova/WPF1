using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Ball
{
    public class AnswerGenerator
    {
        private static string[] answers = new string[5] { "Возможно", "Не возможно", "Да", "Нет", "Сомнительно" };
        private static string answer;
        private static Random random = new Random();
        public static string GetRandomAnswer()
        {
            answer = answers[random.Next(0, answers.Length)];
            return answer;
        }
    }
}
