using Abp.Authorization;
using Abp.Configuration;
using Abp.Domain.Repositories;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.UI;
using ppl.Authorization;
using ppl.FeedBack.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ppl.FeedBack
{
    [AbpAuthorize(PermissionNames.Pages_FeedBack)]
    public class FeedBackAppService:pplAppServiceBase,IFeedBackAppService
    {
        private readonly IRepository<FeedBacks> _repository;
        private readonly IRepository<Setting,long> _setting;
        private readonly IEmailSender _emailSender;
        private readonly ISmtpEmailSenderConfiguration _smtpEmialSenderConfig;
        public FeedBackAppService(IRepository<FeedBacks> repository, IEmailSender emailSender, IRepository<Setting, long> setting, ISmtpEmailSenderConfiguration smtpEmialSenderConfig)
        {
            _repository = repository;
            _emailSender = emailSender;
            _setting = setting;
            _smtpEmialSenderConfig = smtpEmialSenderConfig;
        }
        [AbpAllowAnonymous]
        public async Task Create(CreateOrUpdateDto input)
        {
            HttpCookie http = HttpContext.Current.Request.Cookies[AppConsts.DefaultCookieName];
            if (http != null)
            {
                throw new UserFriendlyException("您已反馈过了，我们会给您放心的答复！");
            }
            var model = ObjectMapper.Map<FeedBacks>(input);
            await _repository.InsertAsync(model);
            await CurrentUnitOfWork.SaveChangesAsync();
            HttpCookie httpCookie = new HttpCookie(AppConsts.DefaultCookieName);
            httpCookie.Expires = DateTime.Now.AddDays(1);
            httpCookie.HttpOnly = true;
            HttpContext.Current.Response.Cookies.Add(httpCookie);
        }
        public async Task DeleteAsync(FeedBacks feedBacks)
        {
            if (!await PermissionChecker.IsGrantedAsync(PermissionNames.Pages_DeleteFeedBack)) throw new UserFriendlyException("您没有权限！");
            await _repository.DeleteAsync(feedBacks);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task Delete(int Id)
        {
            var single = await _repository.GetAsync(Id);
            await this.DeleteAsync(single);
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ListGuid"></param>
        /// <returns></returns>
        public async Task BatchDelete(string ListGuid)
        {
            string[] str = ListGuid.Split(',');
            foreach (var id in str)
            {
                var entity = await this._repository.GetAsync(Convert.ToInt32( id));
                await this.DeleteAsync(entity);
            }
        }
        /// <summary>
        /// 回复，发送邮件给用户
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Name"></param>
        /// <param name="mainstr"></param>
        /// <returns></returns>
        [AbpAuthorize(PermissionNames.Pages_SeedEmail)]
        public async Task SendToUsers(SeedDto seed)
        {
            var email = _setting.FirstOrDefault(x => x.Name == EmailSettingNames.Smtp.UserName).Value;
            if (string.IsNullOrWhiteSpace(email))
                return;
            await _emailSender.SendAsync(
                from: email,
                to: seed.Email,
                subject: $"这是一条来自‘{AppConsts.DefaultAppName}’的反馈回复！",
                body: $"尊敬的     <b>{seed.Name}</b>：<br /> <p style={AppConsts.DefaultMarginX}>{seed.SeedStr}</p>",
                isBodyHtml: true
                );
        }
        public async Task<List<FeedBackDto>> GetAll()
        {
            var model = await _repository.GetAllListAsync();
            return ObjectMapper.Map<List<FeedBackDto>>(model);
        }
        public async Task<FeedBackDto> GetEditModel(int id)
        {
            var single = await _repository.GetAsync(id);
            return ObjectMapper.Map<FeedBackDto>(single);
        }
    }
}
