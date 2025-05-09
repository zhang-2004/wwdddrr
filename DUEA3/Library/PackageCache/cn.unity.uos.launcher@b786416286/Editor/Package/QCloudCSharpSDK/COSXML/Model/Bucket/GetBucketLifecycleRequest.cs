using System;
using System.Collections.Generic;

using System.Text;
using Unity.UOS.COSXML.Common;

namespace Unity.UOS.COSXML.Model.Bucket
{
    /// <summary>
    /// 查询 Bucket 的生命周期配置
    /// <see href="https://cloud.tencent.com/document/product/436/8278"/>
    /// </summary>
    public sealed class GetBucketLifecycleRequest : BucketRequest
    {
        public GetBucketLifecycleRequest(string bucket)
            : base(bucket)
        {
            this.method = CosRequestMethod.GET;
            this.queryParameters.Add("lifecycle", null);
        }
    }
}
