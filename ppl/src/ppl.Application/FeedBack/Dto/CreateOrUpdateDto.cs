using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.FeedBack.Dto
{
    public class CreateOrUpdateDto:GetFeedBackEditDto
    {
        public virtual string IP { get; set; }
    }
}
