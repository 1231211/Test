
namespace ConsoleApp1
{
    /// <summary>
    /// 公司表
    /// </summary>
    public class Spsoft_Company 
    {
        /// <summary>
        /// 单据编号
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; } = string.Empty;

        /// <summary>
        /// 公司简称
        /// </summary>
        public string CompanyShort { get; set; } = string.Empty;

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsEnable { get; set; } = true;

        /// <summary>
        /// 公司地址
        /// </summary>
        public string? CompanyAddress { get; set; }
    }
}
