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
    
    文件名：RequestMessageEvent_AddExpressPath.cs
    文件功能描述：运单轨迹更新事件
    
    
    创建标识：chinanhb - 20230529
    
----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senparc.Weixin.WxOpen.Entities
{
    public class RequestMessageEvent_WxVerifyDispatch : RequestMessageEventBase,IRequestMessageEventBase
    {
        /// <summary>
        /// 事件类型
        /// </summary>
        public override Event Event
        {
            get { return Event.wx_verify_dispatch; }
        }
        /// <summary>
        /// 微信认证审核机构
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// 微信认证审核机构联系方式
        /// </summary>
        public string Contact { get; set; }

        /// <summary>
        /// 微信认证派单时间
        /// </summary>
        public long DispatchTime { get; set; }
    }
}
