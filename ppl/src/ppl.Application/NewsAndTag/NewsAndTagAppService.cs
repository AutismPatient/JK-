using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsAndTag
{
    public class NewsAndTagAppService:pplAppServiceBase
    {
        private readonly IRepository<NewAndTag, Guid> _andrepository;
        public NewsAndTagAppService(IRepository<NewAndTag, Guid> andrepository)
        {
            _andrepository = andrepository;
        }
    }
}
