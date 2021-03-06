﻿using CatLib.API.Buffer;
using CatLib.API.Network;
using System;

namespace CatLib.Network
{

    /// <summary>
    /// 网络服务提供商
    /// </summary>
    public class NetworkProvider : ServiceProvider
    {

        public override Type[] ProviderDepend
        {
            get { return new Type[] { typeof(IPacking) , typeof(IBufferBuilder) }; }
        }

        public override void Register()
        {
            App.Singleton<Network>().Alias<INetworkFactory>();
            App.Bind<HttpWebRequest>().Alias<IConnectorHttp>();
            App.Bind<WebRequest>().Alias("network.webrequest");
            App.Bind<TcpRequest>().Alias<IConnectorTcp>();
            App.Bind<UdpRequest>().Alias<IConnectorUdp>();
        }


    }

}