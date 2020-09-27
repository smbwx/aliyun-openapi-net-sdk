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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class DescribeCdnWafDomainResponseUnmarshaller
    {
        public static DescribeCdnWafDomainResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCdnWafDomainResponse describeCdnWafDomainResponse = new DescribeCdnWafDomainResponse();

			describeCdnWafDomainResponse.HttpResponse = context.HttpResponse;
			describeCdnWafDomainResponse.RequestId = context.StringValue("DescribeCdnWafDomain.RequestId");
			describeCdnWafDomainResponse.TotalCount = context.IntegerValue("DescribeCdnWafDomain.TotalCount");

			List<DescribeCdnWafDomainResponse.DescribeCdnWafDomain_OutPutDomain> describeCdnWafDomainResponse_outPutDomains = new List<DescribeCdnWafDomainResponse.DescribeCdnWafDomain_OutPutDomain>();
			for (int i = 0; i < context.Length("DescribeCdnWafDomain.OutPutDomains.Length"); i++) {
				DescribeCdnWafDomainResponse.DescribeCdnWafDomain_OutPutDomain outPutDomain = new DescribeCdnWafDomainResponse.DescribeCdnWafDomain_OutPutDomain();
				outPutDomain.Status = context.StringValue("DescribeCdnWafDomain.OutPutDomains["+ i +"].Status");
				outPutDomain.Domain = context.StringValue("DescribeCdnWafDomain.OutPutDomains["+ i +"].Domain");
				outPutDomain.WafStatus = context.StringValue("DescribeCdnWafDomain.OutPutDomains["+ i +"].WafStatus");
				outPutDomain.CcStatus = context.StringValue("DescribeCdnWafDomain.OutPutDomains["+ i +"].CcStatus");
				outPutDomain.AclStatus = context.StringValue("DescribeCdnWafDomain.OutPutDomains["+ i +"].AclStatus");

				describeCdnWafDomainResponse_outPutDomains.Add(outPutDomain);
			}
			describeCdnWafDomainResponse.OutPutDomains = describeCdnWafDomainResponse_outPutDomains;
        
			return describeCdnWafDomainResponse;
        }
    }
}
