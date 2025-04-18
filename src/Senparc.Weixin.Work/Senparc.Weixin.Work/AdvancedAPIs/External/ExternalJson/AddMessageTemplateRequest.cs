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
    
    文件名：AddMessageTemplateRequest.cs
    文件功能描述：“创建企业群发”接口请求信息
    

----------------------------------------------------------------*/

namespace Senparc.Weixin.Work.AdvancedAPIs.External.ExternalJson
{
    /// <summary>
    /// “创建企业群发”接口请求信息
    /// </summary>
    public class AddMessageTemplateRequest
    {
        /// <summary>
        /// 群发任务的类型，默认为single，表示发送给客户，group表示发送给客户群
        /// </summary>
        public string chat_type { get; set; }
        /// <summary>
        /// 客户的外部联系人id列表，仅在chat_type为single时有效，不可与sender同时为空，最多可传入1万个客户
        /// </summary>
        public string[] external_userid { get; set; }
        /// <summary>
        /// 发送企业群发消息的成员userid，当类型为发送给客户群时必填
        /// </summary>
        public string sender { get; set; }
        /// <summary>
        /// 消息文本内容
        /// </summary>
        public Text text { get; set; }
        /// <summary>
        /// 附件，最多支持添加9个附件
        /// </summary>
        public Attachment[] attachments { get; set; }

        public class Text
        {
            /// <summary>
            /// 消息文本内容，最多4000个字节
            /// </summary>
            public string content { get; set; }
        }

        public class Attachment
        {
            /// <summary>
            /// 类型：image、link、miniprogram、video、file。
            /// <para>选择相关类型后，需要提供对应类别的详细信息，其他类型请留空</para>
            /// </summary>
            public string msgtype { get; set; }
            public Image image { get; set; }
            public Link link { get; set; }
            public Miniprogram miniprogram { get; set; }
            public Video video { get; set; }
            public File file { get; set; }
        }

        public class Image
        {
            /// <summary>
            /// 图片的media_id，可以通过<see href="https://developer.work.weixin.qq.com/document/path/90253">素材管理接口</see>获得
            /// </summary>
            public string media_id { get; set; }
            /// <summary>
            /// 图片的链接，仅可使用<see href="https://developer.work.weixin.qq.com/document/path/92135#13219">上传图片</see>接口得到的链接
            /// </summary>
            public string pic_url { get; set; }
        }

        public class Link
        {
            /// <summary>
            /// 图文消息标题，最长128个字节
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 图文消息封面的url，最长2048个字节
            /// </summary>
            public string picurl { get; set; }
            /// <summary>
            /// 图文消息的描述，最多512个字节
            /// </summary>
            public string desc { get; set; }
            /// <summary>
            /// 图文消息的链接，最长2048个字节
            /// </summary>
            public string url { get; set; }
        }

        public class Miniprogram
        {
            /// <summary>
            /// 小程序消息标题，最多64个字节
            /// </summary>
            public string title { get; set; }
            /// <summary>
            /// 小程序消息封面的mediaid，封面图建议尺寸为520*416
            /// </summary>
            public string pic_media_id { get; set; }
            /// <summary>
            /// 小程序appid（可以在微信公众平台上查询），必须是关联到企业的小程序应用
            /// </summary>
            public string appid { get; set; }
            /// <summary>
            /// 小程序page路径
            /// </summary>
            public string page { get; set; }
        }

        public class Video
        {
            /// <summary>
            /// 视频的media_id，可以通过<see href="https://developer.work.weixin.qq.com/document/path/90253">素材管理接口</see>接口获得
            /// </summary>
            public string media_id { get; set; }
        }

        public class File
        {
            /// <summary>
            /// 文件的media_id，可以通过<see href="https://developer.work.weixin.qq.com/document/path/90253">素材管理接口</see>接口获得
            /// </summary>
            public string media_id { get; set; }
        }

    }
}
