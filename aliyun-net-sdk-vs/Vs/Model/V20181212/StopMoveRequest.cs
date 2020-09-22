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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class StopMoveRequest : RpcAcsRequest<StopMoveResponse>
    {
        public StopMoveRequest()
            : base("vs", "2018-12-12", "StopMove", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? tilt;

		private string id;

		private bool? pan;

		private bool? zoom;

		private long? ownerId;

		public bool? Tilt
		{
			get
			{
				return tilt;
			}
			set	
			{
				tilt = value;
				DictionaryUtil.Add(QueryParameters, "Tilt", value.ToString());
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public bool? Pan
		{
			get
			{
				return pan;
			}
			set	
			{
				pan = value;
				DictionaryUtil.Add(QueryParameters, "Pan", value.ToString());
			}
		}

		public bool? Zoom
		{
			get
			{
				return zoom;
			}
			set	
			{
				zoom = value;
				DictionaryUtil.Add(QueryParameters, "Zoom", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

        public override StopMoveResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StopMoveResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}