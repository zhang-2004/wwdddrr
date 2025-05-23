using System;
using System.Collections.Generic;

using System.Text;
using Unity.UOS.COSXML.Common;

namespace Unity.UOS.COSXML.Model.Bucket
{
    public sealed class DeleteBucketRequest : BucketRequest
    {
        /// <summary>
        /// 删除 空 Bucket
        /// </summary>
        /// <param name="bucket"></param>
        public DeleteBucketRequest(string bucket)
            : base(bucket)
        {
            this.method = CosRequestMethod.DELETE;
        }
    }
}
