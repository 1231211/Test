/*
此代码由Rpc工具直接生成，非必要请不要修改此处代码
*/
#pragma warning disable
using System;
using TouchSocket.Core;
using TouchSocket.Sockets;
using TouchSocket.Rpc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
namespace RpcProxy
{
public interface ICompanyRpcServer:TouchSocket.Rpc.IRemoteServer
{
///<summary>
///无注释信息
///</summary>
/// <exception cref="System.TimeoutException">调用超时</exception>
/// <exception cref="TouchSocket.Rpc.RpcInvokeException">Rpc调用异常</exception>
/// <exception cref="System.Exception">其他异常</exception>
ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] GetCompanyList(System.Int32 page,System.Int32 size,System.String propertyName="Id",System.Boolean isAsc=false,IInvokeOption invokeOption = default);
///<summary>
///无注释信息
///</summary>
/// <exception cref="System.TimeoutException">调用超时</exception>
/// <exception cref="TouchSocket.Rpc.RpcInvokeException">Rpc调用异常</exception>
/// <exception cref="System.Exception">其他异常</exception>
Task<ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]> GetCompanyListAsync(System.Int32 page,System.Int32 size,System.String propertyName="Id",System.Boolean isAsc=false,IInvokeOption invokeOption = default);

}
public class CompanyRpcServer :ICompanyRpcServer
{
public CompanyRpcServer(IRpcClient client)
{
this.Client=client;
}
public IRpcClient Client{get;private set; }
///<summary>
///无注释信息
///</summary>
/// <exception cref="System.TimeoutException">调用超时</exception>
/// <exception cref="TouchSocket.Rpc.RpcInvokeException">Rpc调用异常</exception>
/// <exception cref="System.Exception">其他异常</exception>
public ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] GetCompanyList(System.Int32 page,System.Int32 size,System.String propertyName="Id",System.Boolean isAsc=false,IInvokeOption invokeOption = default)
{
if(this.Client==null)
{
throw new RpcException("IRpcClient为空，请先初始化或者进行赋值");
}
object[] @_parameters = new object[]{page,size,propertyName,isAsc};
ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] returnData=(ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]])this.Client.Invoke("GetCompanyList",typeof(ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]),invokeOption, @_parameters);
return returnData;

}
///<summary>
///无注释信息
///</summary>
public async Task<ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]> GetCompanyListAsync(System.Int32 page,System.Int32 size,System.String propertyName="Id",System.Boolean isAsc=false,IInvokeOption invokeOption = default)
{
if(this.Client==null)
{
throw new RpcException("IRpcClient为空，请先初始化或者进行赋值");
}
object[] parameters = new object[]{page,size,propertyName,isAsc};
return (ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]) await this.Client.InvokeAsync("GetCompanyList",typeof(ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]),invokeOption, parameters);

}

}
public static class CompanyRpcServerExtensions
{
///<summary>
///无注释信息
///</summary>
/// <exception cref="System.TimeoutException">调用超时</exception>
/// <exception cref="TouchSocket.Rpc.RpcInvokeException">Rpc调用异常</exception>
/// <exception cref="System.Exception">其他异常</exception>
public static ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] GetCompanyList<TClient>(this TClient client,System.Int32 page,System.Int32 size,System.String propertyName="Id",System.Boolean isAsc=false,IInvokeOption invokeOption = default) where TClient:
TouchSocket.Dmtp.Rpc.IDmtpRpcActor{
object[] @_parameters = new object[]{page,size,propertyName,isAsc};
ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]] returnData=(ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]])client.Invoke("GetCompanyList",typeof(ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]),invokeOption, @_parameters);
return returnData;

}
///<summary>
///无注释信息
///</summary>
public static async Task<ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]> GetCompanyListAsync<TClient>(this TClient client,System.Int32 page,System.Int32 size,System.String propertyName="Id",System.Boolean isAsc=false,IInvokeOption invokeOption = default) where TClient:
TouchSocket.Dmtp.Rpc.IDmtpRpcActor{
object[] parameters = new object[]{page,size,propertyName,isAsc};
return (ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]) await client.InvokeAsync("GetCompanyList",typeof(ConsoleApp1.FastPage`1[[ConsoleApp1.Spsoft_Company, ConsoleApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]),invokeOption, parameters);

}

}
public class Spsoft_Company
{
public System.String Id { get; set; }
public System.String CompanyName { get; set; }
public System.String CompanyShort { get; set; }
public System.Boolean IsEnable { get; set; }
public System.String? CompanyAddress { get; set; }
}

}
