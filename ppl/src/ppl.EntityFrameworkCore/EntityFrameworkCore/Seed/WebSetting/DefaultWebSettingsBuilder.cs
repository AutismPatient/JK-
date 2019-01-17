using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppl.EntityFrameworkCore.Seed.WebSetting
{
    public class DefaultWebSettingsBuilder
    {
        private readonly pplDbContext _context;
        public DefaultWebSettingsBuilder(pplDbContext dbContext)
        {
            _context = dbContext;
        }
        public void Create()
        {
            CreateOfSetting();
        }
        private void CreateOfSetting()
        {
            var Single = _context.WebSettings.IgnoreQueryFilters().FirstOrDefault(x => x.HomeUrlTitle == DefaultStting.DefaultTitleStr);
            if (Single == null)
            {
                Single = new WebSettings.WebSetting()
                {
                    IconUrl=DefaultStting.IconStr,
                    Describe=DefaultStting.DefaultDescribe,
                    HomeUrlTitle=DefaultStting.DefaultTitleStr,
                    IsEnabled=DefaultStting.DefaultIsEnabled,
                    KeyWord=DefaultStting.DefaultKeyWord
                };
                _context.WebSettings.Add(Single);
                _context.SaveChanges();
            }
        }
    }
}
