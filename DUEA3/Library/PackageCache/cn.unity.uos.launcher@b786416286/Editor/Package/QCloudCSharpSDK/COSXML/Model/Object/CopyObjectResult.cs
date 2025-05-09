using System;
using System.Collections.Generic;

using System.Text;
using Unity.UOS.COSXML.Model.Tag;
using Unity.UOS.COSXML.Transfer;

namespace Unity.UOS.COSXML.Model.Object
{
    /// <summary>
    /// 复制对象返回的结果
    /// <see href="https://cloud.tencent.com/document/product/436/10881"/>
    /// </summary>
    public sealed class CopyObjectResult : CosDataResult<CopyObject>
    {
        /// <summary>
        /// 复制结果信息
        /// <see href="Model.Tag.CopyObject"/>
        /// </summary>
        public CopyObject copyObject { 
            get {return _data; } 
        }

    }
}
