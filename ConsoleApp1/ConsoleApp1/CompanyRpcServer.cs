using System.Text;
using TouchSocket.Dmtp;
using TouchSocket.Dmtp.Rpc;
using TouchSocket.Rpc;

namespace ConsoleApp1
{
    /// <summary>
    /// 公司服务
    /// </summary>
    public class CompanyRpcServer : RpcServer
    {
        /// <summary>
        /// 获取公司列表
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="propertyName"></param>
        /// <param name="isAsc"></param>
        /// <returns></returns>
        [DmtpRpc(MethodInvoke = true)]
        public async Task<FastPage<Spsoft_Company>> GetCompanyListAsync(ICallContext callContext, int page, int size, string propertyName = "Id", bool isAsc = false)
        {
            if (callContext.Caller is not TcpDmtpSessionClient SessionClient)
            {
                throw new Exception("获取用户上下文失败");
            }
            FastPage<Spsoft_Company> fastPage = new FastPage<Spsoft_Company>()
            {
                Page = page,
                Size = size,
                TotalCount = 0,
                Data = null
            };
            return fastPage;
        }
    }
}
