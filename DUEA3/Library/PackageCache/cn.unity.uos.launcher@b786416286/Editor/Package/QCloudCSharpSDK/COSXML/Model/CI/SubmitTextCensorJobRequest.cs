using System;
using System.Collections.Generic;

using System.Text;
using Unity.UOS.COSXML.Common;
using Unity.UOS.COSXML.Model.Object;
using Unity.UOS.COSXML.Model.Tag;
using Unity.UOS.COSXML.CosException;
using Unity.UOS.COSXML.Utils;

namespace Unity.UOS.COSXML.Model.CI
{
    /// <summary>
    /// 提交文本审核任务
    /// <see href="https://cloud.tencent.com/document/product/436/56289"/>
    /// </summary>
    public sealed class SubmitTextCensorJobRequest : CIRequest
    {
        public TextCensorJobInfo textCensorJobInfo;
        public SubmitTextCensorJobRequest(string bucket)
            : base(bucket)
        {
            textCensorJobInfo = new TextCensorJobInfo();
            this.method = CosRequestMethod.POST;
            this.SetRequestPath("/text/auditing");
            this.SetRequestHeader("Content-Type", "application/xml");
            textCensorJobInfo.input = new TextCensorJobInfo.Input();
            textCensorJobInfo.conf = new TextCensorJobInfo.Conf();
        }

        public void SetCensorObject(string key)
        {
            textCensorJobInfo.input.obj = key;
        }

        public void SetCensorUrl(string url)
        {
            textCensorJobInfo.input.url = url;
        }

        public void SetCensorContent(string content)
        {
            textCensorJobInfo.input.content = content;
        }

        public void SetDetectType(string detectType)
        {
            textCensorJobInfo.conf.detectType = detectType;
        }

        public void SetCallback(string callbackUrl)
        {
            textCensorJobInfo.conf.callback = callbackUrl;
        }

        public void SetBizType(string BizType)
        {
            textCensorJobInfo.conf.bizType = BizType;
        }

        public override Network.RequestBody GetRequestBody()
        {
            return GetXmlRequestBody(textCensorJobInfo);
        }

    }
}
