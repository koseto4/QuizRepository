using QuizzApp.Data1.Repositories;
using QuizzApp.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzApp.Data1.MVC
{
    public interface IUnitOfWork
    {
        IGenericRepository<Question> QuestionRepository { get; }
        void SaveChanges();
    }
}
