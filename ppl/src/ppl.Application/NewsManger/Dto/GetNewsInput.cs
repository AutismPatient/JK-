using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsManger.Dto
{
    public class GetNewsInput : SeacrhNewsDto
    {
        public virtual List<NewsDto> News { get; set; }
    }
}
