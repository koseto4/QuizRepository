using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizzApp.Data.MVC;
using QuizzApp.Data1.Repositories;
using QuizzApp.Models.EntityModels;

namespace QuizzApp.Data1.MVC
{
    public class UnitOfWork : IUnitOfWork
    {
        private QuizzAppDbContext _context;
        private readonly IGenericRepository<Question> _questionRepository;

        public UnitOfWork(QuizzAppDbContext context)
        {
            this._context = context;
        }


        public IGenericRepository<Question> QuestionRepository => _questionRepository ?? new GenericRepository<Question>(_context);

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
