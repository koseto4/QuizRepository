using QuizzApp.Data1.MVC;
using QuizzApp.Services;
using QuizzApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizzApp.Services
{
    public class QuestionService : IQuestionService
    {
        private IUnitOfWork _unitOfWork;

        public QuestionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public QuestionViewModel getQuestion(int id)
        {

            Random rand = new Random();
            var numQue = _unitOfWork.QuestionRepository.All().Where(x => x.ModeId == id).ToList();
            int skip = rand.Next(0, numQue.Count());
            var ranQue = numQue.OrderBy(x => x.Id).Skip(skip).Take(1).First();
            QuestionViewModel question = new QuestionViewModel()
            {
                Id = ranQue.Id,
                Text = ranQue.Text,
                Answer = ranQue.Answer,
                IsCorrect = ranQue.IsCorrect,
                Choices = new List<ChoiceViewModel>()
            };

            foreach (var q in ranQue.Choices)
            {
                question.Choices.Add(new ChoiceViewModel() { Id = q.Id, ChoiceText = q.ChoiceText });
            }

            return question;


        }
    }
}