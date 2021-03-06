/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imageenhan.Model.V20190930;

namespace Aliyun.Acs.imageenhan.Transform.V20190930
{
    public class RecolorImageResponseUnmarshaller
    {
        public static RecolorImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RecolorImageResponse recolorImageResponse = new RecolorImageResponse();

			recolorImageResponse.HttpResponse = _ctx.HttpResponse;
			recolorImageResponse.RequestId = _ctx.StringValue("RecolorImage.RequestId");

			RecolorImageResponse.RecolorImage_Data data = new RecolorImageResponse.RecolorImage_Data();

			List<string> data_imageList = new List<string>();
			for (int i = 0; i < _ctx.Length("RecolorImage.Data.ImageList.Length"); i++) {
				data_imageList.Add(_ctx.StringValue("RecolorImage.Data.ImageList["+ i +"]"));
			}
			data.ImageList = data_imageList;
			recolorImageResponse.Data = data;
        
			return recolorImageResponse;
        }
    }
}
