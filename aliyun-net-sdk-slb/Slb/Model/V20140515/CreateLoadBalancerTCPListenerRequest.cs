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
using Aliyun.Acs.Slb.Transform;
using Aliyun.Acs.Slb.Transform.V20140515;

namespace Aliyun.Acs.Slb.Model.V20140515
{
    public class CreateLoadBalancerTCPListenerRequest : RpcAcsRequest<CreateLoadBalancerTCPListenerResponse>
    {
        public CreateLoadBalancerTCPListenerRequest()
            : base("Slb", "2014-05-15", "CreateLoadBalancerTCPListener", "slb", "openAPI")
        {
        }

		private int? healthCheckConnectTimeout;

		private long? resourceOwnerId;

		private string healthCheckURI;

		private string description;

		private int? unhealthyThreshold;

		private int? healthyThreshold;

		private string aclStatus;

		private string scheduler;

		private string aclType;

		private int? establishedTimeout;

		private int? persistenceTimeout;

		private string vServerGroupId;

		private string aclId;

		private int? listenerPort;

		private string healthCheckType;

		private string resourceOwnerAccount;

		private int? bandwidth;

		private string healthCheckDomain;

		private string ownerAccount;

		private long? ownerId;

		private string loadBalancerId;

		private string masterSlaveServerGroupId;

		private int? backendServerPort;

		private int? healthCheckInterval;

		private int? healthCheckConnectPort;

		private string healthCheckHttpCode;

		public int? HealthCheckConnectTimeout
		{
			get
			{
				return healthCheckConnectTimeout;
			}
			set	
			{
				healthCheckConnectTimeout = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConnectTimeout", value.ToString());
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string HealthCheckURI
		{
			get
			{
				return healthCheckURI;
			}
			set	
			{
				healthCheckURI = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckURI", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public int? UnhealthyThreshold
		{
			get
			{
				return unhealthyThreshold;
			}
			set	
			{
				unhealthyThreshold = value;
				DictionaryUtil.Add(QueryParameters, "UnhealthyThreshold", value.ToString());
			}
		}

		public int? HealthyThreshold
		{
			get
			{
				return healthyThreshold;
			}
			set	
			{
				healthyThreshold = value;
				DictionaryUtil.Add(QueryParameters, "HealthyThreshold", value.ToString());
			}
		}

		public string AclStatus
		{
			get
			{
				return aclStatus;
			}
			set	
			{
				aclStatus = value;
				DictionaryUtil.Add(QueryParameters, "AclStatus", value);
			}
		}

		public string Scheduler
		{
			get
			{
				return scheduler;
			}
			set	
			{
				scheduler = value;
				DictionaryUtil.Add(QueryParameters, "Scheduler", value);
			}
		}

		public string AclType
		{
			get
			{
				return aclType;
			}
			set	
			{
				aclType = value;
				DictionaryUtil.Add(QueryParameters, "AclType", value);
			}
		}

		public int? EstablishedTimeout
		{
			get
			{
				return establishedTimeout;
			}
			set	
			{
				establishedTimeout = value;
				DictionaryUtil.Add(QueryParameters, "EstablishedTimeout", value.ToString());
			}
		}

		public int? PersistenceTimeout
		{
			get
			{
				return persistenceTimeout;
			}
			set	
			{
				persistenceTimeout = value;
				DictionaryUtil.Add(QueryParameters, "PersistenceTimeout", value.ToString());
			}
		}

		public string VServerGroupId
		{
			get
			{
				return vServerGroupId;
			}
			set	
			{
				vServerGroupId = value;
				DictionaryUtil.Add(QueryParameters, "VServerGroupId", value);
			}
		}

		public string AclId
		{
			get
			{
				return aclId;
			}
			set	
			{
				aclId = value;
				DictionaryUtil.Add(QueryParameters, "AclId", value);
			}
		}

		public int? ListenerPort
		{
			get
			{
				return listenerPort;
			}
			set	
			{
				listenerPort = value;
				DictionaryUtil.Add(QueryParameters, "ListenerPort", value.ToString());
			}
		}

		public string HealthCheckType
		{
			get
			{
				return healthCheckType;
			}
			set	
			{
				healthCheckType = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckType", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public int? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
			}
		}

		public string HealthCheckDomain
		{
			get
			{
				return healthCheckDomain;
			}
			set	
			{
				healthCheckDomain = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckDomain", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

		public string LoadBalancerId
		{
			get
			{
				return loadBalancerId;
			}
			set	
			{
				loadBalancerId = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancerId", value);
			}
		}

		public string MasterSlaveServerGroupId
		{
			get
			{
				return masterSlaveServerGroupId;
			}
			set	
			{
				masterSlaveServerGroupId = value;
				DictionaryUtil.Add(QueryParameters, "MasterSlaveServerGroupId", value);
			}
		}

		public int? BackendServerPort
		{
			get
			{
				return backendServerPort;
			}
			set	
			{
				backendServerPort = value;
				DictionaryUtil.Add(QueryParameters, "BackendServerPort", value.ToString());
			}
		}

		public int? HealthCheckInterval
		{
			get
			{
				return healthCheckInterval;
			}
			set	
			{
				healthCheckInterval = value;
				DictionaryUtil.Add(QueryParameters, "healthCheckInterval", value.ToString());
			}
		}

		public int? HealthCheckConnectPort
		{
			get
			{
				return healthCheckConnectPort;
			}
			set	
			{
				healthCheckConnectPort = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckConnectPort", value.ToString());
			}
		}

		public string HealthCheckHttpCode
		{
			get
			{
				return healthCheckHttpCode;
			}
			set	
			{
				healthCheckHttpCode = value;
				DictionaryUtil.Add(QueryParameters, "HealthCheckHttpCode", value);
			}
		}

        public override CreateLoadBalancerTCPListenerResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLoadBalancerTCPListenerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
