using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.Languages.Dto
{
    public class LanguagesInput
    {
        [Required]
        public LanguageEditDto Language { get; set; }
    }
}
