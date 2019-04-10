using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizzApp.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Answer { get; set; }
        public string IsCorrect { get; set; }
        public ICollection<ChoiceViewModel> Choices { get; set; }
    }
}