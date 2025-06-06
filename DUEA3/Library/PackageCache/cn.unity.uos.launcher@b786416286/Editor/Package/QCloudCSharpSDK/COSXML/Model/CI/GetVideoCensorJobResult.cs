using System;
using System.IO;
using System.Collections.Generic;
using Unity.UOS.COSXML.Model.Tag;
using Unity.UOS.COSXML.Transfer;

namespace Unity.UOS.COSXML.Model.CI
{
    /// <summary>
    /// 视频审核结果
    /// </summary>
    public sealed class GetVideoCensorJobResult : CosDataResult<VideoCensorResult>
    {
        /// <summary>
        /// 视频审核结果
        /// </summary>
        /// <value></value>
        public VideoCensorResult resultStruct { 
            get {return _data; } 
        }
    }
}
