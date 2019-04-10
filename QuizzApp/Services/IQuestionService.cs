using QuizzApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Services
{
    public interface IQuestionService
    {
        QuestionViewModel getQuestion(int id);
    }
}
