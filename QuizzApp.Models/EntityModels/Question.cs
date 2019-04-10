using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizzApp.Models.EntityModels
{
    public class Question
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Text { get; set; }

        public string Answer { get; set; }

        public string IsCorrect { get; set; }

        public int ModeId { get; set; }

        [ForeignKey("ModeId")]
        public virtual Mode Mode { get; set; }

        public virtual List<Choice> Choices { get; set; }
    }
}
