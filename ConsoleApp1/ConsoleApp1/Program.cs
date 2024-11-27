using ConsoleApp1;
using System.Data;
using TouchSocket.Core;
using TouchSocket.Dmtp;
using TouchSocket.Dmtp.Rpc;
using TouchSocket.Rpc;
using TouchSocket.Sockets;

public class Program
{
    public static bool _isDatabaseInit = false;

    private static async Task Main(string[] args)
    {
        var service = new TcpDmtpService();
        var config = new TouchSocketConfig()//配置
               .SetListenIPHosts(7789)
               .ConfigureContainer(a =>
               {
                   a.AddRpcStore(store =>
                   {
                       store.RegisterServer<CompanyRpcServer>();//注册服务
                       File.WriteAllText(@"../../../RpcProxy.cs", store.GetProxyCodes("RpcProxy", new Type[] { typeof(DmtpRpcAttribute) }));
                   });
               })
               .ConfigurePlugins(m =>
               {
                   m.UseDmtpRpc();
               })
               .SetSendTimeout(0)
               .SetDmtpOption(new DmtpOption()
               {
                   VerifyToken = "Dmtp"//设定连接口令，作用类似账号密码
               });
        await service.SetupAsync(config);
        await service.StartAsync();
        Console.WriteLine($"服务已启动，端口{7789}");
        Console.ReadLine();
    }
}