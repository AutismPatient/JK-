namespace ppl
{
    /// <summary>
    /// 定义常量
    /// </summary>
    public class JklConsts
    {
        public const string LocalizationSourceName = "ppl";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;

        
        public const int MaxTitleLength = 64;
        public const int MaxAbstractLength = 256;
        public const int MaxBodyLength = 6400;
        public const int MaxTagsLength = 32;
        public const int MaxCategoryLength = 8;
        /// <summary>
        /// 列表类型（高质量、普通）
        /// </summary>
        public enum ListType
        {
            Quality,
            Ordinary
        }
        /// <summary>
        /// 是否编辑推荐
        /// </summary>
        public enum Recommend
        {
            Yes,
            No
        }
        /// <summary>
        /// 是否审核
        /// </summary>
        public enum Audit
        {
            Yes,
            No
        }
        /// <summary>
        /// 状态
        /// </summary>
        public enum Status
        {
            已通过审核,
            未通过审核,
            待审核,
            暂时下架,
            封禁
        }
    }
}
