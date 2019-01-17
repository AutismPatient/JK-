﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.NewsTag.Dto
{
    public class GetTagEdit: FullAuditedEntityDto<Guid>
    {
        public virtual string TagName { get; set; }

    }
}
