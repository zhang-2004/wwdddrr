using System;
using System.Collections.Generic;

using System.Text;
using Unity.UOS.COSXML.Common;

namespace Unity.UOS.COSXML.Model.Bucket
{
    /// <summary>
    /// 检索 Bucket 是否存在
    /// <see href="https://cloud.tencent.com/document/product/436/7735"/>
    /// </summary>
    public sealed class DoesBucketExistRequest : BucketRequest
    {
        public DoesBucketExistRequest(string bucket)
            : base(bucket)
        {
            this.method = CosRequestMethod.HEAD;
        }
    }
}
