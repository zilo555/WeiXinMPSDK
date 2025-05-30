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
    
    文件名：AddCategoryData.cs
    文件功能描述：添加栏目接口请求数据
    
    
    创建标识：Senparc - 20180906

    修改标识：Senparc - 20200528
    修改描述：v4.7.502.1 fix bug: 开放平台添加类目的参数大小写错误 https://github.com/JeffreySu/WeiXinMPSDK/issues/2180

----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.Weixin.Open.WxOpenAPIs.AddCategoryJson
{
    /// <summary>
    /// 添加栏目接口请求数据
    /// </summary>
    public class AddCategoryData
    {
        /// <summary>
        /// 一级类目ID
        /// </summary>
        public uint first { get; set; }
        /// <summary>
        /// 二级类目ID
        /// </summary>
        public uint second { get; set; }
        /// <summary>
        /// key：资质名称，value：资质图片
        /// </summary>
        public List<AddCategoryData_Certicates> certicates { get; set; }
    }

    public class AddCategoryData_Certicates
    {
        public string key { get; set; }
        public string value { get; set; }
    }
}
