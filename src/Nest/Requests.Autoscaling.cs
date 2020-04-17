// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using Elasticsearch.Net;
using Elasticsearch.Net.Utf8Json;
using Elasticsearch.Net.Specification.AutoscalingApi;

// ReSharper disable RedundantBaseConstructorCall
// ReSharper disable UnusedTypeParameter
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
namespace Nest
{
	[InterfaceDataContract]
	public partial interface IDeleteAutoscalingPolicyRequest : IRequest<DeleteAutoscalingPolicyRequestParameters>
	{
		[IgnoreDataMember]
		Name Name
		{
			get;
		}
	}

	///<summary>Request for DeletePolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/autoscaling-delete-autoscaling-policy.html</para></summary>
	///<remarks>Note: Experimental within the Elasticsearch server, this functionality is experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features.</remarks>
	public partial class DeleteAutoscalingPolicyRequest : PlainRequestBase<DeleteAutoscalingPolicyRequestParameters>, IDeleteAutoscalingPolicyRequest
	{
		protected IDeleteAutoscalingPolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingDeletePolicy;
		///<summary>/_autoscaling/policy/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public DeleteAutoscalingPolicyRequest(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected DeleteAutoscalingPolicyRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IDeleteAutoscalingPolicyRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		[Obsolete("Unmapped, blacklist this API in CodeConfiguration.cs or implement DeleteAutoscalingPolicyDescriptor and DeleteAutoscalingPolicyRequest in a file called DeleteAutoscalingPolicyRequest.cs in NEST's codebase", true)]
		public bool IsUnmapped => true;
		public bool UseIsUnmapped => IsUnmapped;
	}

	[InterfaceDataContract]
	public partial interface IGetAutoscalingPolicyRequest : IRequest<GetAutoscalingPolicyRequestParameters>
	{
		[IgnoreDataMember]
		Name Name
		{
			get;
		}
	}

	///<summary>Request for GetPolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/autoscaling-get-autoscaling-policy.html</para></summary>
	///<remarks>Note: Experimental within the Elasticsearch server, this functionality is experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features.</remarks>
	public partial class GetAutoscalingPolicyRequest : PlainRequestBase<GetAutoscalingPolicyRequestParameters>, IGetAutoscalingPolicyRequest
	{
		protected IGetAutoscalingPolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingGetPolicy;
		///<summary>/_autoscaling/policy/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public GetAutoscalingPolicyRequest(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected GetAutoscalingPolicyRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IGetAutoscalingPolicyRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		[Obsolete("Unmapped, blacklist this API in CodeConfiguration.cs or implement GetAutoscalingPolicyDescriptor and GetAutoscalingPolicyRequest in a file called GetAutoscalingPolicyRequest.cs in NEST's codebase", true)]
		public bool IsUnmapped => true;
		public bool UseIsUnmapped => IsUnmapped;
	}

	[InterfaceDataContract]
	public partial interface IPutAutoscalingPolicyRequest : IRequest<PutAutoscalingPolicyRequestParameters>
	{
		[IgnoreDataMember]
		Name Name
		{
			get;
		}
	}

	///<summary>Request for PutPolicy <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/autoscaling-put-autoscaling-policy.html</para></summary>
	///<remarks>Note: Experimental within the Elasticsearch server, this functionality is experimental and may be changed or removed completely in a future release. Elastic will take a best effort approach to fix any issues, but experimental features are not subject to the support SLA of official GA features.</remarks>
	public partial class PutAutoscalingPolicyRequest : PlainRequestBase<PutAutoscalingPolicyRequestParameters>, IPutAutoscalingPolicyRequest
	{
		protected IPutAutoscalingPolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingPutPolicy;
		///<summary>/_autoscaling/policy/{name}</summary>
		///<param name = "name">this parameter is required</param>
		public PutAutoscalingPolicyRequest(Name name): base(r => r.Required("name", name))
		{
		}

		///<summary>Used for serialization purposes, making sure we have a parameterless constructor</summary>
		[SerializationConstructor]
		protected PutAutoscalingPolicyRequest(): base()
		{
		}

		// values part of the url path
		[IgnoreDataMember]
		Name IPutAutoscalingPolicyRequest.Name => Self.RouteValues.Get<Name>("name");
		// Request parameters
		[Obsolete("Unmapped, blacklist this API in CodeConfiguration.cs or implement PutAutoscalingPolicyDescriptor and PutAutoscalingPolicyRequest in a file called PutAutoscalingPolicyRequest.cs in NEST's codebase", true)]
		public bool IsUnmapped => true;
		public bool UseIsUnmapped => IsUnmapped;
	}
}