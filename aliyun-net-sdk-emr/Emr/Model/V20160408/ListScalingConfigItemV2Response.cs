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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListScalingConfigItemV2Response : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private string nextToken;

		private List<ListScalingConfigItemV2_Item> items;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
			}
		}

		public List<ListScalingConfigItemV2_Item> Items
		{
			get
			{
				return items;
			}
			set	
			{
				items = value;
			}
		}

		public class ListScalingConfigItemV2_Item
		{

			private string configItemType;

			private string scalingGroupBizId;

			private string scalingConfigItemBizId;

			private string configItemInformation;

			public string ConfigItemType
			{
				get
				{
					return configItemType;
				}
				set	
				{
					configItemType = value;
				}
			}

			public string ScalingGroupBizId
			{
				get
				{
					return scalingGroupBizId;
				}
				set	
				{
					scalingGroupBizId = value;
				}
			}

			public string ScalingConfigItemBizId
			{
				get
				{
					return scalingConfigItemBizId;
				}
				set	
				{
					scalingConfigItemBizId = value;
				}
			}

			public string ConfigItemInformation
			{
				get
				{
					return configItemInformation;
				}
				set	
				{
					configItemInformation = value;
				}
			}
		}
	}
}
