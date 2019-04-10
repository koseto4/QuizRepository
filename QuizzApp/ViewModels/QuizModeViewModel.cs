using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace QuizzApp.ViewModels
{
    public class QuizModeViewModel
    {
        public int Mode { get; set; }
        public IEnumerable<SelectListItem> Modes { get; set; }
    }
}