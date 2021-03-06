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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class CreateMergeRequestResponseUnmarshaller
    {
        public static CreateMergeRequestResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateMergeRequestResponse createMergeRequestResponse = new CreateMergeRequestResponse();

			createMergeRequestResponse.HttpResponse = _ctx.HttpResponse;
			createMergeRequestResponse.RequestId = _ctx.StringValue("CreateMergeRequest.RequestId");
			createMergeRequestResponse.ErrorCode = _ctx.StringValue("CreateMergeRequest.ErrorCode");
			createMergeRequestResponse.Success = _ctx.BooleanValue("CreateMergeRequest.Success");
			createMergeRequestResponse.ErrorMessage = _ctx.StringValue("CreateMergeRequest.ErrorMessage");

			CreateMergeRequestResponse.CreateMergeRequest_Result result = new CreateMergeRequestResponse.CreateMergeRequest_Result();
			result.Id = _ctx.LongValue("CreateMergeRequest.Result.Id");
			result.ProjectId = _ctx.LongValue("CreateMergeRequest.Result.ProjectId");
			result.Title = _ctx.StringValue("CreateMergeRequest.Result.Title");
			result.Description = _ctx.StringValue("CreateMergeRequest.Result.Description");
			result.State = _ctx.StringValue("CreateMergeRequest.Result.State");
			result.MergeStatus = _ctx.StringValue("CreateMergeRequest.Result.MergeStatus");
			result.CreatedAt = _ctx.StringValue("CreateMergeRequest.Result.CreatedAt");
			result.UpdatedAt = _ctx.StringValue("CreateMergeRequest.Result.UpdatedAt");
			result.TargetBranch = _ctx.StringValue("CreateMergeRequest.Result.TargetBranch");
			result.SourceBranch = _ctx.StringValue("CreateMergeRequest.Result.SourceBranch");
			result.WebUrl = _ctx.StringValue("CreateMergeRequest.Result.WebUrl");
			result.AcceptedRevision = _ctx.StringValue("CreateMergeRequest.Result.AcceptedRevision");
			result.MergeError = _ctx.StringValue("CreateMergeRequest.Result.MergeError");
			result.MergedRevision = _ctx.StringValue("CreateMergeRequest.Result.MergedRevision");
			result.NameWithNamespace = _ctx.StringValue("CreateMergeRequest.Result.NameWithNamespace");
			result.MergeType = _ctx.StringValue("CreateMergeRequest.Result.MergeType");
			result.AheadCommitCount = _ctx.IntegerValue("CreateMergeRequest.Result.AheadCommitCount");
			result.BehindCommitCount = _ctx.IntegerValue("CreateMergeRequest.Result.BehindCommitCount");

			CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_Author author = new CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_Author();
			author.Id = _ctx.LongValue("CreateMergeRequest.Result.Author.Id");
			author.ExternUserId = _ctx.StringValue("CreateMergeRequest.Result.Author.ExternUserId");
			author.AvatarUrl = _ctx.StringValue("CreateMergeRequest.Result.Author.AvatarUrl");
			author.Name = _ctx.StringValue("CreateMergeRequest.Result.Author.Name");
			result.Author = author;

			CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult approveCheckResult = new CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult();
			approveCheckResult.TotalCheckResult = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.TotalCheckResult");

			List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_SatisfiedCheckResultsItem> approveCheckResult_satisfiedCheckResults = new List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_SatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults.Length"); i++) {
				CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_SatisfiedCheckResultsItem satisfiedCheckResultsItem = new CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_SatisfiedCheckResultsItem();
				satisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckStatus");
				satisfiedCheckResultsItem.CheckName = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckName");
				satisfiedCheckResultsItem.CheckType = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].CheckType");

				List<string> satisfiedCheckResultsItem_satisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_satisfiedItems.Add(_ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.SatisfiedItems = satisfiedCheckResultsItem_satisfiedItems;

				List<string> satisfiedCheckResultsItem_unsatisfiedItems = new List<string>();
				for (int j = 0; j < _ctx.Length("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					satisfiedCheckResultsItem_unsatisfiedItems.Add(_ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				satisfiedCheckResultsItem.UnsatisfiedItems = satisfiedCheckResultsItem_unsatisfiedItems;

				List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_SatisfiedCheckResultsItem.CreateMergeRequest_ExtraUsersItem> satisfiedCheckResultsItem_extraUsers = new List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_SatisfiedCheckResultsItem.CreateMergeRequest_ExtraUsersItem>();
				for (int j = 0; j < _ctx.Length("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_SatisfiedCheckResultsItem.CreateMergeRequest_ExtraUsersItem extraUsersItem = new CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_SatisfiedCheckResultsItem.CreateMergeRequest_ExtraUsersItem();
					extraUsersItem.Id = _ctx.LongValue("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem.ExternUserId = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem.AvatarUrl = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem.Name = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.SatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					satisfiedCheckResultsItem_extraUsers.Add(extraUsersItem);
				}
				satisfiedCheckResultsItem.ExtraUsers = satisfiedCheckResultsItem_extraUsers;

				approveCheckResult_satisfiedCheckResults.Add(satisfiedCheckResultsItem);
			}
			approveCheckResult.SatisfiedCheckResults = approveCheckResult_satisfiedCheckResults;

			List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_UnsatisfiedCheckResultsItem> approveCheckResult_unsatisfiedCheckResults = new List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_UnsatisfiedCheckResultsItem>();
			for (int i = 0; i < _ctx.Length("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults.Length"); i++) {
				CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_UnsatisfiedCheckResultsItem unsatisfiedCheckResultsItem = new CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_UnsatisfiedCheckResultsItem();
				unsatisfiedCheckResultsItem.CheckStatus = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckStatus");
				unsatisfiedCheckResultsItem.CheckName = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckName");
				unsatisfiedCheckResultsItem.CheckType = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].CheckType");

				List<string> unsatisfiedCheckResultsItem_satisfiedItems1 = new List<string>();
				for (int j = 0; j < _ctx.Length("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_satisfiedItems1.Add(_ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].SatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.SatisfiedItems1 = unsatisfiedCheckResultsItem_satisfiedItems1;

				List<string> unsatisfiedCheckResultsItem_unsatisfiedItems2 = new List<string>();
				for (int j = 0; j < _ctx.Length("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems.Length"); j++) {
					unsatisfiedCheckResultsItem_unsatisfiedItems2.Add(_ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].UnsatisfiedItems["+ j +"]"));
				}
				unsatisfiedCheckResultsItem.UnsatisfiedItems2 = unsatisfiedCheckResultsItem_unsatisfiedItems2;

				List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_UnsatisfiedCheckResultsItem.CreateMergeRequest_ExtraUsersItem4> unsatisfiedCheckResultsItem_extraUsers3 = new List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_UnsatisfiedCheckResultsItem.CreateMergeRequest_ExtraUsersItem4>();
				for (int j = 0; j < _ctx.Length("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers.Length"); j++) {
					CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_UnsatisfiedCheckResultsItem.CreateMergeRequest_ExtraUsersItem4 extraUsersItem4 = new CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_ApproveCheckResult.CreateMergeRequest_UnsatisfiedCheckResultsItem.CreateMergeRequest_ExtraUsersItem4();
					extraUsersItem4.Id = _ctx.LongValue("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Id");
					extraUsersItem4.ExternUserId = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].ExternUserId");
					extraUsersItem4.AvatarUrl = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].AvatarUrl");
					extraUsersItem4.Name = _ctx.StringValue("CreateMergeRequest.Result.ApproveCheckResult.UnsatisfiedCheckResults["+ i +"].ExtraUsers["+ j +"].Name");

					unsatisfiedCheckResultsItem_extraUsers3.Add(extraUsersItem4);
				}
				unsatisfiedCheckResultsItem.ExtraUsers3 = unsatisfiedCheckResultsItem_extraUsers3;

				approveCheckResult_unsatisfiedCheckResults.Add(unsatisfiedCheckResultsItem);
			}
			approveCheckResult.UnsatisfiedCheckResults = approveCheckResult_unsatisfiedCheckResults;
			result.ApproveCheckResult = approveCheckResult;

			List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_AssigneeListItem> result_assigneeList = new List<CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_AssigneeListItem>();
			for (int i = 0; i < _ctx.Length("CreateMergeRequest.Result.AssigneeList.Length"); i++) {
				CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_AssigneeListItem assigneeListItem = new CreateMergeRequestResponse.CreateMergeRequest_Result.CreateMergeRequest_AssigneeListItem();
				assigneeListItem.Id = _ctx.StringValue("CreateMergeRequest.Result.AssigneeList["+ i +"].Id");
				assigneeListItem.ExternUserId = _ctx.StringValue("CreateMergeRequest.Result.AssigneeList["+ i +"].ExternUserId");
				assigneeListItem.AvatarUrl = _ctx.StringValue("CreateMergeRequest.Result.AssigneeList["+ i +"].AvatarUrl");
				assigneeListItem.Name = _ctx.StringValue("CreateMergeRequest.Result.AssigneeList["+ i +"].Name");

				result_assigneeList.Add(assigneeListItem);
			}
			result.AssigneeList = result_assigneeList;
			createMergeRequestResponse.Result = result;
        
			return createMergeRequestResponse;
        }
    }
}
