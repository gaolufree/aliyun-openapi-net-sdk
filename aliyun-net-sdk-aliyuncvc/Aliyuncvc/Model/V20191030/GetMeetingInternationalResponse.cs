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

namespace Aliyun.Acs.aliyuncvc.Model.V20191030
{
	public class GetMeetingInternationalResponse : AcsResponse
	{

		private int? errorCode;

		private string message;

		private bool? success;

		private string requestId;

		private GetMeetingInternational_MeetingInfo meetingInfo;

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

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

		public GetMeetingInternational_MeetingInfo MeetingInfo
		{
			get
			{
				return meetingInfo;
			}
			set	
			{
				meetingInfo = value;
			}
		}

		public class GetMeetingInternational_MeetingInfo
		{

			private string meetingName;

			private long? validTime;

			private string meetingCode;

			private long? createTime;

			private string userId;

			private string meetingUUID;

			private string password;

			private List<GetMeetingInternational_MemberListItem> memberList;

			public string MeetingName
			{
				get
				{
					return meetingName;
				}
				set	
				{
					meetingName = value;
				}
			}

			public long? ValidTime
			{
				get
				{
					return validTime;
				}
				set	
				{
					validTime = value;
				}
			}

			public string MeetingCode
			{
				get
				{
					return meetingCode;
				}
				set	
				{
					meetingCode = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string MeetingUUID
			{
				get
				{
					return meetingUUID;
				}
				set	
				{
					meetingUUID = value;
				}
			}

			public string Password
			{
				get
				{
					return password;
				}
				set	
				{
					password = value;
				}
			}

			public List<GetMeetingInternational_MemberListItem> MemberList
			{
				get
				{
					return memberList;
				}
				set	
				{
					memberList = value;
				}
			}

			public class GetMeetingInternational_MemberListItem
			{

				private string userAvatarUrl;

				private string memberUUID;

				private string userName;

				private string userId;

				private string status;

				public string UserAvatarUrl
				{
					get
					{
						return userAvatarUrl;
					}
					set	
					{
						userAvatarUrl = value;
					}
				}

				public string MemberUUID
				{
					get
					{
						return memberUUID;
					}
					set	
					{
						memberUUID = value;
					}
				}

				public string UserName
				{
					get
					{
						return userName;
					}
					set	
					{
						userName = value;
					}
				}

				public string UserId
				{
					get
					{
						return userId;
					}
					set	
					{
						userId = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}
			}
		}
	}
}
