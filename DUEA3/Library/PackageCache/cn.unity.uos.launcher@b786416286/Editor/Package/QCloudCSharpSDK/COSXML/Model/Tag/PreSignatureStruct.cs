using System;
using System.Collections.Generic;
using System.Text;

namespace Unity.UOS.COSXML.Model.Tag
{
    public sealed class PreSignatureStruct
    {
        /// <summary>
        /// cos 服务的appid
        /// </summary>
        public string appid;

        /// <summary>
        /// 存储桶名称
        /// </summary>
        public string bucket;

        /// <summary>
        /// Bucket所属地域
        /// </summary>
        public string region;

        /// <summary>
        /// 设置 host
        /// </summary>
        public string host;

        /// <summary>
        /// 对象键
        /// </summary>
        public string key;

        /// <summary>
        /// true:https; false: http
        /// </summary>
        public bool isHttps;

        /// <summary>
        /// 签名中是否签入host
        /// </summary>
        public bool signHost = false;

        /// <summary>
        /// http request method : get , put , etc.
        /// </summary>
        public string httpMethod;

        /// <summary>
        /// 签名需要校验的url中查询参数
        /// </summary>
        public Dictionary<string, string> queryParameters;

        /// <summary>
        /// 签名需要校验的headers
        /// </summary>
        public Dictionary<string, string> headers;

        /// <summary>
        /// 签名 sign的有效期，若 小于 0，则取keyTime.
        /// </summary>
        public long signDurationSecond;

        /// <summary>
        /// 签名 key的有效期，不设置 或 小于 0, 则取 QCloudCredential中的keyTime
        /// </summary>
        public long keyDurationSecond;
    }
}
