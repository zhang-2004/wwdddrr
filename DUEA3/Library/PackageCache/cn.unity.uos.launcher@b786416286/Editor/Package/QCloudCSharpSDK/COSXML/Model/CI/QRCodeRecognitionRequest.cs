using System;
using System.Collections.Generic;

using System.Text;
using Unity.UOS.COSXML.Common;
using Unity.UOS.COSXML.Model.Object;
using Unity.UOS.COSXML.CosException;

namespace Unity.UOS.COSXML.Model.CI
{
    public sealed class QRCodeRecognitionRequest : ObjectRequest
    {
        public QRCodeRecognitionRequest(string bucket, string key, int cover)
            : base(bucket, key)
        {
            this.method = CosRequestMethod.GET;
            this.queryParameters.Add("ci-process", "QRcode");
            this.queryParameters.Add("cover", cover.ToString());
        }

    }
}
