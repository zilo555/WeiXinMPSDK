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
    
    文件名：GenerateNFCSchemeJumpWxa.cs
    文件功能描述：GenerateNFCScheme() 接口中的 jumpWxa 参数

    创建标识：Senparc - 20241114

----------------------------------------------------------------*/



namespace Senparc.Weixin.WxOpen.AdvancedAPIs.UrlScheme
{
    /// <summary>
    /// GenerateNFCScheme() 接口中的 jumpWxa 参数
    /// </summary>
    public class GenerateNFCSchemeJumpWxa
    {
        /// <summary>
        /// （必填）通过scheme码进入的小程序页面路径，必须是已经发布的小程序存在的页面，不可携带query。path为空时会跳转小程序主页。
        /// </summary>
        public string path { get; set; }
        /// <summary>
        /// （必填）通过scheme码进入小程序时的query，最大128个字符，只支持数字，大小写英文以及部分特殊字符：!#$&'()*+,/:;=?@-._~
        /// </summary>
        public string query { get; set; }
        /// <summary>
        /// (选填)默认值"release"。要打开的小程序版本。正式版为"release"，体验版为"trial"，开发版为"develop"，仅在微信外打开时生效。
        /// </summary>
        public string env_version { get; set; }

        /// <summary>
        /// GenerateScheme() 接口中的 jumpWxa 参数
        /// </summary>
        /// <param name="path"></param>
        /// <param name="query"></param>
        /// <param name="env_version"></param>
        public GenerateNFCSchemeJumpWxa(string path, string query, string env_version = null)
        {
            this.path = path ?? "";
            this.query = query ?? "";
            this.env_version = env_version ?? "release";
        }
    }
}
