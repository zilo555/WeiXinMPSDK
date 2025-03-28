﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2025 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2025 Senparc

    文件名：BrowserUtility.cs
    文件功能描述：浏览器公共类


    创建标识：Senparc - 20150419

    修改标识：Senparc - 20161219
    修改描述：v4.9.6 修改错别字：Browser->Browser

    修改标识：Senparc - 20161219
    修改描述：v4.11.2 修改SideInWeixinBrowser判断逻辑

    修改标识：Senparc - 20180513
    修改描述：v4.11.2 1、增加对小程序请求的判断方法 SideInWeixinMiniProgram()
                      2、添加 GetUserAgent() 方法

    ----  CO2NET   ----

    修改标识：Senparc - 20180601
    修改描述：v5.0.0 引入 Senparc.CO2NET

    修改标识：Senparc - 20180618
    修改描述：v5.0.1 引入 Senparc.CO2NET v0.1.1，BrowserUtility.GetUserAgent() 返回原始字符串，不再返回大写

----------------------------------------------------------------*/


using System;
using System.Web;

#if !NET462
using Microsoft.AspNetCore.Http;
#endif

namespace Senparc.Weixin.BrowserUtility
{
    /// <summary>
    /// 浏览器公共类
    /// </summary>
    public static class BrowserUtility
    {
       
        /// <summary>
        /// 判断是否在微信内置浏览器中
        /// </summary>
        /// <param name="httpContext">HttpContextBase对象</param>
        /// <returns>true：在微信内置浏览器内。false：不在微信内置浏览器内。</returns>
#if NET462
        public static bool SideInWeixinBrowser(this HttpContextBase httpContext)
#else
        public static bool SideInWeixinBrowser(this HttpContext httpContext)
#endif
        {
            string userAgent = CO2NET.Utilities.BrowserUtility.GetUserAgent(httpContext.Request).ToUpper();
            //判断是否在微信浏览器内部
            var isInWeixinBrowser = userAgent != null &&
                        (userAgent.Contains("MICROMESSENGER")/*MicroMessenger*/ ||
                        userAgent.Contains("WINDOWS PHONE")/*Windows Phone*/);
            return isInWeixinBrowser;
        }

        /// <summary>
        /// 判断是否在微信小程序内发起请求（注意：此方法在Android下有效，在iOS下暂时无效！）
        /// </summary>
        /// <param name="httpContext">HttpContextBase对象</param>
        /// <returns>true：在微信内置浏览器内。false：不在微信内置浏览器内。</returns>
#if NET462
        public static bool SideInWeixinMiniProgram(this HttpContextBase httpContext)
#else
        public static bool SideInWeixinMiniProgram(this HttpContext httpContext)
#endif
        {
            string userAgent = CO2NET.Utilities.BrowserUtility.GetUserAgent(httpContext.Request).ToUpper();
            //判断是否在微信小程序的 web-view 组件内部
            var isInWeixinMiniProgram = userAgent != null && userAgent.Contains("MINIPROGRAM")/*miniProgram*/;
            return isInWeixinMiniProgram;
        }
    }
}
