using System;
using System.Collections.Generic;
using System.Text;

namespace QuizzApp.Models.EntityModels
{
    public class Mode
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Question> Questions { get; set; }

    }
}
