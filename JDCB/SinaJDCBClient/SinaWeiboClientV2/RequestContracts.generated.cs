using System.Runtime.Serialization;
using System;
using RestAPICore;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SinaWeiboClientV2
{
                

	namespace Emotions
	{
		/// <summary>
		/// <para>获取微博官方表情的详细信息 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/emotions.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：否  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>type</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	表情类别，face：普通表情、ani：魔法表情、cartoon：动漫表情，默认为face。</para>
			/// <para></para>
			/// </summary>
			public string Type
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("type") ? RequestData.QueryStringValues["type"].FirstOrDefault() : null; }
				set
				{
					var oldv=Type;
					var target = RequestData.QueryStringValues.ContainsKey("type") ? RequestData.QueryStringValues["type"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["type"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Type"));
				}
			}
			/// <summary>
			/// <para>language</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	语言类别，cnname：简体、twname：繁体，默认为cnname。</para>
			/// <para></para>
			/// </summary>
			public string Language
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("language") ? RequestData.QueryStringValues["language"].FirstOrDefault() : null; }
				set
				{
					var oldv=Language;
					var target = RequestData.QueryStringValues.ContainsKey("language") ? RequestData.QueryStringValues["language"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["language"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Language"));
				}
			}
		}
	}

                
                

	namespace CommentsByMe
	{
		/// <summary>
		/// <para>获取当前登录用户所发出的评论列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/by_me.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的评论（即比since_id时间晚的评论），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的评论，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>filter_by_source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	来源筛选类型，0：全部、1：来自微博的评论、2：来自微群的评论，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterBySource
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterBySource;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterBySource"));
				}
			}
		}
	}

                
                

	namespace CommentsCreate
	{
		/// <summary>
		/// <para>对一条微博进行评论 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/create.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>comment</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	评论内容，必须做URLencode，内容不超过140个汉字。</para>
			/// <para></para>
			/// </summary>
			public string Comment
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("comment") ? RequestData.PostFieldValues["comment"].FirstOrDefault() : null; }
				set
				{
					var oldv=Comment;
					var target = RequestData.PostFieldValues.ContainsKey("comment") ? RequestData.PostFieldValues["comment"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["comment"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Comment"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要评论的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
			/// <summary>
			/// <para>comment_ori</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	当评论转发微博时，是否评论给原微博，0：否、1：是，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string CommentOri
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("comment_ori") ? RequestData.PostFieldValues["comment_ori"].FirstOrDefault() : null; }
				set
				{
					var oldv=CommentOri;
					var target = RequestData.PostFieldValues.ContainsKey("comment_ori") ? RequestData.PostFieldValues["comment_ori"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["comment_ori"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("CommentOri"));
				}
			}
		}
	}

                
                

	namespace CommentsDestroy
	{
		/// <summary>
		/// <para>删除一条评论 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/destroy.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>cid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	要删除的评论ID，只能删除登录用户自己发布的评论。</para>
			/// <para></para>
			/// </summary>
			public string Cid
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("cid") ? RequestData.PostFieldValues["cid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Cid;
					var target = RequestData.PostFieldValues.ContainsKey("cid") ? RequestData.PostFieldValues["cid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["cid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Cid"));
				}
			}
		}
	}

                
                

	namespace CommentsDestroyBatch
	{
		/// <summary>
		/// <para>根据评论ID批量删除评论 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/destroy_batch.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>cids</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要删除的评论ID，用半角逗号隔开，最多20个。</para>
			/// <para></para>
			/// </summary>
			public string Cids
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("cids") ? RequestData.PostFieldValues["cids"].FirstOrDefault() : null; }
				set
				{
					var oldv=Cids;
					var target = RequestData.PostFieldValues.ContainsKey("cids") ? RequestData.PostFieldValues["cids"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["cids"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Cids"));
				}
			}
		}
	}

                
                

	namespace CommentsMentions
	{
		/// <summary>
		/// <para>获取最新的提到当前登录用户的评论，即@我的评论 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/mentions.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的评论（即比since_id时间晚的评论），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的评论，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>filter_by_author</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	作者筛选类型，0：全部、1：我关注的人、2：陌生人，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterByAuthor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterByAuthor;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_author"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterByAuthor"));
				}
			}
			/// <summary>
			/// <para>filter_by_source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	来源筛选类型，0：全部、1：来自微博的评论、2：来自微群的评论，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterBySource
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterBySource;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterBySource"));
				}
			}
		}
	}

                
                

	namespace CommentsReply
	{
		/// <summary>
		/// <para>回复一条评论 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/reply.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>cid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要回复的评论ID。</para>
			/// <para></para>
			/// </summary>
			public string Cid
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("cid") ? RequestData.PostFieldValues["cid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Cid;
					var target = RequestData.PostFieldValues.ContainsKey("cid") ? RequestData.PostFieldValues["cid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["cid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Cid"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要评论的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
			/// <summary>
			/// <para>comment</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	回复评论内容，必须做URLencode，内容不超过140个汉字。</para>
			/// <para></para>
			/// </summary>
			public string Comment
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("comment") ? RequestData.PostFieldValues["comment"].FirstOrDefault() : null; }
				set
				{
					var oldv=Comment;
					var target = RequestData.PostFieldValues.ContainsKey("comment") ? RequestData.PostFieldValues["comment"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["comment"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Comment"));
				}
			}
			/// <summary>
			/// <para>without_mention</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	回复中是否自动加入“回复@用户名”，0：是、1：否，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string WithoutMention
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("without_mention") ? RequestData.PostFieldValues["without_mention"].FirstOrDefault() : null; }
				set
				{
					var oldv=WithoutMention;
					var target = RequestData.PostFieldValues.ContainsKey("without_mention") ? RequestData.PostFieldValues["without_mention"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["without_mention"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("WithoutMention"));
				}
			}
			/// <summary>
			/// <para>comment_ori</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	当评论转发微博时，是否评论给原微博，0：否、1：是，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string CommentOri
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("comment_ori") ? RequestData.PostFieldValues["comment_ori"].FirstOrDefault() : null; }
				set
				{
					var oldv=CommentOri;
					var target = RequestData.PostFieldValues.ContainsKey("comment_ori") ? RequestData.PostFieldValues["comment_ori"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["comment_ori"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("CommentOri"));
				}
			}
		}
	}

                
                

	namespace CommentsShow
	{
		/// <summary>
		/// <para>根据微博ID返回某条微博的评论列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/show.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的评论（即比since_id时间晚的评论），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的评论，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>filter_by_author</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	作者筛选类型，0：全部、1：我关注的人、2：陌生人，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterByAuthor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterByAuthor;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_author"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterByAuthor"));
				}
			}
		}
	}

                
                

	namespace CommentsShowBatch
	{
		/// <summary>
		/// <para>根据评论ID批量返回评论信息 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/show_batch.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>cids</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的批量评论ID，用半角逗号分隔，最大50。</para>
			/// <para></para>
			/// </summary>
			public string Cids
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("cids") ? RequestData.QueryStringValues["cids"].FirstOrDefault() : null; }
				set
				{
					var oldv=Cids;
					var target = RequestData.QueryStringValues.ContainsKey("cids") ? RequestData.QueryStringValues["cids"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["cids"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Cids"));
				}
			}
		}
	}

                
                

	namespace CommentsTimeline
	{
		/// <summary>
		/// <para>获取当前登录用户的最新评论包括接收到的与发出的 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/timeline.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的评论（即比since_id时间晚的评论），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的评论，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>trim_user</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回值中user字段开关，0：返回完整user字段、1：user字段仅返回user_id，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string TrimUser
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"].FirstOrDefault() : null; }
				set
				{
					var oldv=TrimUser;
					var target = RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["trim_user"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrimUser"));
				}
			}
		}
	}

                
                

	namespace CommentsToMe
	{
		/// <summary>
		/// <para>获取当前登录用户所接收到的评论列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/comments/to_me.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的评论（即比since_id时间晚的评论），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的评论，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>filter_by_author</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	作者筛选类型，0：全部、1：我关注的人、2：陌生人，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterByAuthor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterByAuthor;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_author"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterByAuthor"));
				}
			}
			/// <summary>
			/// <para>filter_by_source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	来源筛选类型，0：全部、1：来自微博的评论、2：来自微群的评论，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterBySource
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterBySource;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterBySource"));
				}
			}
		}
	}

                
                

	namespace FriendshipsCreate
	{
		/// <summary>
		/// <para>关注一个用户 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/create.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要关注的用户ID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("uid") ? RequestData.PostFieldValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.PostFieldValues.ContainsKey("uid") ? RequestData.PostFieldValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要关注的用户昵称。</para>
			/// <para></para>
			/// </summary>
			public string ScreenName
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("screen_name") ? RequestData.PostFieldValues["screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=ScreenName;
					var target = RequestData.PostFieldValues.ContainsKey("screen_name") ? RequestData.PostFieldValues["screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ScreenName"));
				}
			}
		}
	}

                
                

	namespace FriendshipsDestroy
	{
		/// <summary>
		/// <para>取消关注一个用户 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/destroy.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要取消关注的用户ID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("uid") ? RequestData.PostFieldValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.PostFieldValues.ContainsKey("uid") ? RequestData.PostFieldValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要取消关注的用户昵称。</para>
			/// <para></para>
			/// </summary>
			public string ScreenName
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("screen_name") ? RequestData.PostFieldValues["screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=ScreenName;
					var target = RequestData.PostFieldValues.ContainsKey("screen_name") ? RequestData.PostFieldValues["screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ScreenName"));
				}
			}
		}
	}

                
                

	namespace FriendshipsFollowers
	{
		/// <summary>
		/// <para>获取用户的粉丝列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/followers.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	参数uid与screen_name二者必选其一，且只能选其一；最多返回5000条数据</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户昵称。</para>
			/// <para></para>
			/// </summary>
			public string ScreenName
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=ScreenName;
					var target = RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ScreenName"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50，最大不超过200。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>cursor</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的游标，下一页用返回值里的next_cursor，上一页用previous_cursor，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Cursor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("cursor") ? RequestData.QueryStringValues["cursor"].FirstOrDefault() : null; }
				set
				{
					var oldv=Cursor;
					var target = RequestData.QueryStringValues.ContainsKey("cursor") ? RequestData.QueryStringValues["cursor"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["cursor"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Cursor"));
				}
			}
			/// <summary>
			/// <para>trim_status</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回值中user字段中的status字段开关，0：返回完整status字段、1：status字段仅返回status_id，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string TrimStatus
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("trim_status") ? RequestData.QueryStringValues["trim_status"].FirstOrDefault() : null; }
				set
				{
					var oldv=TrimStatus;
					var target = RequestData.QueryStringValues.ContainsKey("trim_status") ? RequestData.QueryStringValues["trim_status"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["trim_status"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrimStatus"));
				}
			}
		}
	}

                
                

	namespace FriendshipsFriends
	{
		/// <summary>
		/// <para>获取用户的关注列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/friends.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户昵称。</para>
			/// <para></para>
			/// </summary>
			public string ScreenName
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=ScreenName;
					var target = RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ScreenName"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50，最大不超过200。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>cursor</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的游标，下一页用返回值里的next_cursor，上一页用previous_cursor，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Cursor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("cursor") ? RequestData.QueryStringValues["cursor"].FirstOrDefault() : null; }
				set
				{
					var oldv=Cursor;
					var target = RequestData.QueryStringValues.ContainsKey("cursor") ? RequestData.QueryStringValues["cursor"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["cursor"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Cursor"));
				}
			}
			/// <summary>
			/// <para>trim_status</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回值中user字段中的status字段开关，0：返回完整status字段、1：status字段仅返回status_id，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string TrimStatus
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("trim_status") ? RequestData.QueryStringValues["trim_status"].FirstOrDefault() : null; }
				set
				{
					var oldv=TrimStatus;
					var target = RequestData.QueryStringValues.ContainsKey("trim_status") ? RequestData.QueryStringValues["trim_status"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["trim_status"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrimStatus"));
				}
			}
		}
	}

                
                

	namespace FriendshipsGroups
	{
		/// <summary>
		/// <para>获取当前登陆用户好友分组列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/groups.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	返回的数据按设置的分组顺序排序；   好友分组上限为20，“未分组”不计入上限；   "未分组"的分组ID为0，此接口不返回“未分组”；</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
		}
	}

                
                

	namespace FriendshipsShow
	{
		/// <summary>
		/// <para>获取两个用户之间的详细关注关系情况 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/show.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	参数source_id与source_screen_name二者必选其一，且只能选其一   参数target_id与target_screen_name二者必选其一，且只能选其一</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>source_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	源用户的UID。</para>
			/// <para></para>
			/// </summary>
			public string SourceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source_id") ? RequestData.QueryStringValues["source_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SourceId;
					var target = RequestData.QueryStringValues.ContainsKey("source_id") ? RequestData.QueryStringValues["source_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SourceId"));
				}
			}
			/// <summary>
			/// <para>source_screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	源用户的微博昵称。</para>
			/// <para></para>
			/// </summary>
			public string SourceScreenName
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source_screen_name") ? RequestData.QueryStringValues["source_screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=SourceScreenName;
					var target = RequestData.QueryStringValues.ContainsKey("source_screen_name") ? RequestData.QueryStringValues["source_screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source_screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SourceScreenName"));
				}
			}
			/// <summary>
			/// <para>target_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	目标用户的UID。</para>
			/// <para></para>
			/// </summary>
			public string TargetId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("target_id") ? RequestData.QueryStringValues["target_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=TargetId;
					var target = RequestData.QueryStringValues.ContainsKey("target_id") ? RequestData.QueryStringValues["target_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["target_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TargetId"));
				}
			}
			/// <summary>
			/// <para>target_screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	目标用户的微博昵称。</para>
			/// <para></para>
			/// </summary>
			public string TargetScreenName
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("target_screen_name") ? RequestData.QueryStringValues["target_screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=TargetScreenName;
					var target = RequestData.QueryStringValues.ContainsKey("target_screen_name") ? RequestData.QueryStringValues["target_screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["target_screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TargetScreenName"));
				}
			}
		}
	}

                
                

	namespace FriendshipsFollowersActive
	{
		/// <summary>
		/// <para>获取用户的活跃粉丝列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/followers/active.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回的记录条数，默认为20，最大不超过200。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
		}
	}

                
                

	namespace FriendshipsFollowersIds
	{
		/// <summary>
		/// <para>获取用户粉丝的用户UID列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/followers/ids.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户昵称。</para>
			/// <para></para>
			/// </summary>
			public string ScreenName
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=ScreenName;
					var target = RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ScreenName"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为500，最大不超过5000。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>cursor</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的游标，下一页用返回值里的next_cursor，上一页用previous_cursor，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Cursor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("cursor") ? RequestData.QueryStringValues["cursor"].FirstOrDefault() : null; }
				set
				{
					var oldv=Cursor;
					var target = RequestData.QueryStringValues.ContainsKey("cursor") ? RequestData.QueryStringValues["cursor"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["cursor"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Cursor"));
				}
			}
		}
	}

                
                

	namespace FriendshipsFriendsBilateral
	{
		/// <summary>
		/// <para>获取用户的双向关注列表，即互粉列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/friends/bilateral.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	排序功能目前只支持一种</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要获取双向关注列表的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>sort</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	排序类型，0：按关注时间最近排序，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Sort
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("sort") ? RequestData.QueryStringValues["sort"].FirstOrDefault() : null; }
				set
				{
					var oldv=Sort;
					var target = RequestData.QueryStringValues.ContainsKey("sort") ? RequestData.QueryStringValues["sort"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["sort"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Sort"));
				}
			}
		}
	}

                
                

	namespace FriendshipsFriendsIds
	{
		/// <summary>
		/// <para>获取用户关注的用户UID列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/friends/ids.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户昵称。</para>
			/// <para></para>
			/// </summary>
			public string ScreenName
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=ScreenName;
					var target = RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ScreenName"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为500，最大不超过5000。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>cursor</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的游标，下一页用返回值里的next_cursor，上一页用previous_cursor，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Cursor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("cursor") ? RequestData.QueryStringValues["cursor"].FirstOrDefault() : null; }
				set
				{
					var oldv=Cursor;
					var target = RequestData.QueryStringValues.ContainsKey("cursor") ? RequestData.QueryStringValues["cursor"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["cursor"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Cursor"));
				}
			}
		}
	}

                
                

	namespace FriendshipsFriendsInCommon
	{
		/// <summary>
		/// <para>获取两个用户之间的共同关注人列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/friends/in_common.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要获取共同关注关系的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>suid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要获取共同关注关系的用户UID，默认为当前登录用户。</para>
			/// <para></para>
			/// </summary>
			public string Suid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("suid") ? RequestData.QueryStringValues["suid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Suid;
					var target = RequestData.QueryStringValues.ContainsKey("suid") ? RequestData.QueryStringValues["suid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["suid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Suid"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>trim_status</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回值中user字段中的status字段开关，0：返回完整status字段、1：status字段仅返回status_id，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string TrimStatus
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("trim_status") ? RequestData.QueryStringValues["trim_status"].FirstOrDefault() : null; }
				set
				{
					var oldv=TrimStatus;
					var target = RequestData.QueryStringValues.ContainsKey("trim_status") ? RequestData.QueryStringValues["trim_status"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["trim_status"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrimStatus"));
				}
			}
		}
	}

                
                

	namespace FriendshipsFriendsBilateralIds
	{
		/// <summary>
		/// <para>获取用户双向关注的用户ID列表，即互粉UID列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/friends/bilateral/ids.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	排序功能目前只支持一种</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要获取双向关注列表的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50，最大不超过2000。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>sort</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	排序类型，0：按关注时间最近排序，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Sort
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("sort") ? RequestData.QueryStringValues["sort"].FirstOrDefault() : null; }
				set
				{
					var oldv=Sort;
					var target = RequestData.QueryStringValues.ContainsKey("sort") ? RequestData.QueryStringValues["sort"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["sort"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Sort"));
				}
			}
		}
	}

                
                

	namespace FriendshipsFriendsChainFollowers
	{
		/// <summary>
		/// <para>获取当前登录用户的关注人中又关注了指定用户的用户列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/friends_chain/followers.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	指定的关注目标用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，默认为50。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
		}
	}

                
                

	namespace FriendshipsRemarkUpdate
	{
		/// <summary>
		/// <para>更新当前登录用户所关注的某个好友的备注信息 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/friendships/remark/update.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要修改备注信息的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("uid") ? RequestData.PostFieldValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.PostFieldValues.ContainsKey("uid") ? RequestData.PostFieldValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>remark</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	备注信息，需要URLencode。</para>
			/// <para></para>
			/// </summary>
			public string Remark
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("remark") ? RequestData.PostFieldValues["remark"].FirstOrDefault() : null; }
				set
				{
					var oldv=Remark;
					var target = RequestData.PostFieldValues.ContainsKey("remark") ? RequestData.PostFieldValues["remark"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["remark"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Remark"));
				}
			}
		}
	}

                
                

	namespace StatusesBilateralTimeline
	{
		/// <summary>
		/// <para>获取双向关注用户的最新微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/bilateral_timeline.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过100，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>base_app</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否只获取当前应用的数据。0为否（所有数据），1为是（仅当前应用），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string BaseApp
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"].FirstOrDefault() : null; }
				set
				{
					var oldv=BaseApp;
					var target = RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["base_app"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("BaseApp"));
				}
			}
			/// <summary>
			/// <para>feature</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	过滤类型ID，0：全部、1：原创、2：图片、3：视频、4：音乐，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Feature
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"].FirstOrDefault() : null; }
				set
				{
					var oldv=Feature;
					var target = RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["feature"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Feature"));
				}
			}
			/// <summary>
			/// <para>trim_user</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回值中user字段开关，0：返回完整user字段、1：user字段仅返回user_id，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string TrimUser
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"].FirstOrDefault() : null; }
				set
				{
					var oldv=TrimUser;
					var target = RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["trim_user"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrimUser"));
				}
			}
		}
	}

                
                

	namespace StatusesCount
	{
		/// <summary>
		/// <para>批量获取指定微博的转发数评论数 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/count.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>ids</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要获取数据的微博ID，多个之间用逗号分隔，最多不超过100个。</para>
			/// <para></para>
			/// </summary>
			public string Ids
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("ids") ? RequestData.QueryStringValues["ids"].FirstOrDefault() : null; }
				set
				{
					var oldv=Ids;
					var target = RequestData.QueryStringValues.ContainsKey("ids") ? RequestData.QueryStringValues["ids"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["ids"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Ids"));
				}
			}
		}
	}

                
                

	namespace StatusesDestroy
	{
		/// <summary>
		/// <para>根据微博ID删除指定微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/destroy.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	只能删除自己发布的微博</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要删除的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
		}
	}

                
                

	namespace StatusesFriendsTimeline
	{
		/// <summary>
		/// <para>获取当前登录用户及其所关注用户的最新微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/friends_timeline.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过100，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>base_app</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否只获取当前应用的数据。0为否（所有数据），1为是（仅当前应用），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string BaseApp
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"].FirstOrDefault() : null; }
				set
				{
					var oldv=BaseApp;
					var target = RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["base_app"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("BaseApp"));
				}
			}
			/// <summary>
			/// <para>feature</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	过滤类型ID，0：全部、1：原创、2：图片、3：视频、4：音乐，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Feature
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"].FirstOrDefault() : null; }
				set
				{
					var oldv=Feature;
					var target = RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["feature"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Feature"));
				}
			}
			/// <summary>
			/// <para>trim_user</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回值中user字段开关，0：返回完整user字段、1：user字段仅返回user_id，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string TrimUser
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"].FirstOrDefault() : null; }
				set
				{
					var oldv=TrimUser;
					var target = RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["trim_user"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrimUser"));
				}
			}
		}
	}

                
                

	namespace StatusesHomeTimeline
	{
		/// <summary>
		/// <para>获取当前登录用户及其所关注用户的最新微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/home_timeline.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过100，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>base_app</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否只获取当前应用的数据。0为否（所有数据），1为是（仅当前应用），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string BaseApp
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"].FirstOrDefault() : null; }
				set
				{
					var oldv=BaseApp;
					var target = RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["base_app"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("BaseApp"));
				}
			}
			/// <summary>
			/// <para>feature</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	过滤类型ID，0：全部、1：原创、2：图片、3：视频、4：音乐，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Feature
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"].FirstOrDefault() : null; }
				set
				{
					var oldv=Feature;
					var target = RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["feature"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Feature"));
				}
			}
			/// <summary>
			/// <para>trim_user</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回值中user字段开关，0：返回完整user字段、1：user字段仅返回user_id，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string TrimUser
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"].FirstOrDefault() : null; }
				set
				{
					var oldv=TrimUser;
					var target = RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["trim_user"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrimUser"));
				}
			}
		}
	}

                
                

	namespace StatusesMentions
	{
		/// <summary>
		/// <para>获取最新的提到登录用户的微博列表，即@我的微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/mentions.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过200，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>filter_by_author</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	作者筛选类型，0：全部、1：我关注的人、2：陌生人，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterByAuthor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterByAuthor;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_author"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterByAuthor"));
				}
			}
			/// <summary>
			/// <para>filter_by_source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	来源筛选类型，0：全部、1：来自微博、2：来自微群，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterBySource
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterBySource;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterBySource"));
				}
			}
			/// <summary>
			/// <para>filter_by_type</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	原创筛选类型，0：全部微博、1：原创的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterByType
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_type") ? RequestData.QueryStringValues["filter_by_type"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterByType;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_type") ? RequestData.QueryStringValues["filter_by_type"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_type"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterByType"));
				}
			}
			/// <summary>
			/// <para>trim_user</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回值中user字段开关，0：返回完整user字段、1：user字段仅返回user_id，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string TrimUser
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"].FirstOrDefault() : null; }
				set
				{
					var oldv=TrimUser;
					var target = RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["trim_user"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrimUser"));
				}
			}
		}
	}

                
                

	namespace StatusesPublicTimeline
	{
		/// <summary>
		/// <para>返回最新的200条公共微博，返回结果非完全实时 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/public_timeline.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过200，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
		}
	}

                
                

	namespace StatusesQueryid
	{
		/// <summary>
		/// <para>通过微博（评论、私信）MID获取其ID </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/queryid.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	否  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	形如“3z4efAo4lk”的MID即为经过base62转换的MID</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>mid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要查询的微博（评论、私信）MID，批量模式下，用半角逗号分隔，最多不超过20个。</para>
			/// <para></para>
			/// </summary>
			public string Mid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("mid") ? RequestData.QueryStringValues["mid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Mid;
					var target = RequestData.QueryStringValues.ContainsKey("mid") ? RequestData.QueryStringValues["mid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["mid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Mid"));
				}
			}
			/// <summary>
			/// <para>type</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	获取类型，1：微博、2：评论、3：私信，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Type
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("type") ? RequestData.QueryStringValues["type"].FirstOrDefault() : null; }
				set
				{
					var oldv=Type;
					var target = RequestData.QueryStringValues.ContainsKey("type") ? RequestData.QueryStringValues["type"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["type"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Type"));
				}
			}
			/// <summary>
			/// <para>is_batch</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否使用批量模式，0：否、1：是，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string IsBatch
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("is_batch") ? RequestData.QueryStringValues["is_batch"].FirstOrDefault() : null; }
				set
				{
					var oldv=IsBatch;
					var target = RequestData.QueryStringValues.ContainsKey("is_batch") ? RequestData.QueryStringValues["is_batch"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["is_batch"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("IsBatch"));
				}
			}
			/// <summary>
			/// <para>inbox</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	仅对私信有效，当MID类型为私信时用此参数，0：发件箱、1：收件箱，默认为0 。</para>
			/// <para></para>
			/// </summary>
			public string Inbox
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("inbox") ? RequestData.QueryStringValues["inbox"].FirstOrDefault() : null; }
				set
				{
					var oldv=Inbox;
					var target = RequestData.QueryStringValues.ContainsKey("inbox") ? RequestData.QueryStringValues["inbox"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["inbox"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Inbox"));
				}
			}
			/// <summary>
			/// <para>isBase62</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	MID是否是base62编码，0：否、1：是，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string IsBase62
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("isBase62") ? RequestData.QueryStringValues["isBase62"].FirstOrDefault() : null; }
				set
				{
					var oldv=IsBase62;
					var target = RequestData.QueryStringValues.ContainsKey("isBase62") ? RequestData.QueryStringValues["isBase62"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["isBase62"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("IsBase62"));
				}
			}
		}
	}

                
                

	namespace StatusesQuerymid
	{
		/// <summary>
		/// <para>通过微博（评论、私信）ID获取其MID </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/querymid.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	否  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的微博（评论、私信）ID，批量模式下，用半角逗号分隔，最多不超过20个。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
			/// <summary>
			/// <para>type</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	获取类型，1：微博、2：评论、3：私信，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Type
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("type") ? RequestData.QueryStringValues["type"].FirstOrDefault() : null; }
				set
				{
					var oldv=Type;
					var target = RequestData.QueryStringValues.ContainsKey("type") ? RequestData.QueryStringValues["type"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["type"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Type"));
				}
			}
			/// <summary>
			/// <para>is_batch</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否使用批量模式，0：否、1：是，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string IsBatch
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("is_batch") ? RequestData.QueryStringValues["is_batch"].FirstOrDefault() : null; }
				set
				{
					var oldv=IsBatch;
					var target = RequestData.QueryStringValues.ContainsKey("is_batch") ? RequestData.QueryStringValues["is_batch"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["is_batch"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("IsBatch"));
				}
			}
		}
	}

                
                

	namespace StatusesRepost
	{
		/// <summary>
		/// <para>转发一条微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/repost.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	要转发的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
			/// <summary>
			/// <para>status</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	添加的转发文本，必须做URLencode，内容不超过140个汉字，不填则默认为“转发微博”。</para>
			/// <para></para>
			/// </summary>
			public string Status
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("status") ? RequestData.PostFieldValues["status"].FirstOrDefault() : null; }
				set
				{
					var oldv=Status;
					var target = RequestData.PostFieldValues.ContainsKey("status") ? RequestData.PostFieldValues["status"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["status"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Status"));
				}
			}
			/// <summary>
			/// <para>is_comment</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否在转发的同时发表评论，0：否、1：评论给当前微博、2：评论给原微博、3：都评论，默认为0 。</para>
			/// <para></para>
			/// </summary>
			public string IsComment
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("is_comment") ? RequestData.PostFieldValues["is_comment"].FirstOrDefault() : null; }
				set
				{
					var oldv=IsComment;
					var target = RequestData.PostFieldValues.ContainsKey("is_comment") ? RequestData.PostFieldValues["is_comment"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["is_comment"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("IsComment"));
				}
			}
		}
	}

                
                

	namespace StatusesRepostByMe
	{
		/// <summary>
		/// <para>获取当前用户最新转发的微博列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/repost_by_me.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过200，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
		}
	}

                
                

	namespace StatusesRepostTimeline
	{
		/// <summary>
		/// <para>获取指定微博的转发微博列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/repost_timeline.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过200，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>filter_by_author</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	作者筛选类型，0：全部、1：我关注的人、2：陌生人，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterByAuthor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterByAuthor;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_author"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterByAuthor"));
				}
			}
		}
	}

                
                

	namespace StatusesShow
	{
		/// <summary>
		/// <para>根据微博ID获取单条微博内容 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/show.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要获取的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
		}
	}

                
                

	namespace StatusesUpdate
	{
		/// <summary>
		/// <para>发布一条新微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/update.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>status</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	要发布的微博文本内容，必须做URLencode，内容不超过140个汉字。</para>
			/// <para></para>
			/// </summary>
			public string Status
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("status") ? RequestData.PostFieldValues["status"].FirstOrDefault() : null; }
				set
				{
					var oldv=Status;
					var target = RequestData.PostFieldValues.ContainsKey("status") ? RequestData.PostFieldValues["status"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["status"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Status"));
				}
			}
			/// <summary>
			/// <para>visible</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	微博的可见性，0：所有人能看，1：仅自己可见，2：密友可见，3：指定分组可见，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Visible
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("visible") ? RequestData.PostFieldValues["visible"].FirstOrDefault() : null; }
				set
				{
					var oldv=Visible;
					var target = RequestData.PostFieldValues.ContainsKey("visible") ? RequestData.PostFieldValues["visible"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["visible"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Visible"));
				}
			}
			/// <summary>
			/// <para>list_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	微博的保护投递指定分组ID，只有当visible参数为3时生效且必选。</para>
			/// <para></para>
			/// </summary>
			public string ListId
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("list_id") ? RequestData.PostFieldValues["list_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=ListId;
					var target = RequestData.PostFieldValues.ContainsKey("list_id") ? RequestData.PostFieldValues["list_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["list_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ListId"));
				}
			}
			/// <summary>
			/// <para>lat</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	float</para>
			/// <para>说明:</para>
			/// <para>	纬度，有效范围：-90.0到+90.0，+表示北纬，默认为0.0。</para>
			/// <para></para>
			/// </summary>
			public string Lat
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("lat") ? RequestData.PostFieldValues["lat"].FirstOrDefault() : null; }
				set
				{
					var oldv=Lat;
					var target = RequestData.PostFieldValues.ContainsKey("lat") ? RequestData.PostFieldValues["lat"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["lat"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Lat"));
				}
			}
			/// <summary>
			/// <para>long</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	float</para>
			/// <para>说明:</para>
			/// <para>	经度，有效范围：-180.0到+180.0，+表示东经，默认为0.0。</para>
			/// <para></para>
			/// </summary>
			public string Long
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("long") ? RequestData.PostFieldValues["long"].FirstOrDefault() : null; }
				set
				{
					var oldv=Long;
					var target = RequestData.PostFieldValues.ContainsKey("long") ? RequestData.PostFieldValues["long"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["long"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Long"));
				}
			}
			/// <summary>
			/// <para>annotations</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	元数据，主要是为了方便第三方应用记录一些适合于自己使用的信息，每条微博可以包含一个或者多个元数据，必须以json字串的形式提交，字串长度不超过512个字符，具体内容可以自定。</para>
			/// <para></para>
			/// </summary>
			public string Annotations
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("annotations") ? RequestData.PostFieldValues["annotations"].FirstOrDefault() : null; }
				set
				{
					var oldv=Annotations;
					var target = RequestData.PostFieldValues.ContainsKey("annotations") ? RequestData.PostFieldValues["annotations"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["annotations"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Annotations"));
				}
			}
		}
	}

                
                

	namespace StatusesUpload
	{
		/// <summary>
		/// <para>上传图片并发布一条新微博 </para>
		/// <para>URL:</para>
		/// <para>	https://upload.api.weibo.com/2/statuses/upload.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	请求必须用POST方式提交，并且注意采用multipart/form-data编码方式；   非会员发表定向微博，分组成员数最多200。</para>
		/// <para></para>
		/// </summary>
		public class Request : MultiPartPostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>status</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	要发布的微博文本内容，必须做URLencode，内容不超过140个汉字。</para>
			/// <para></para>
			/// </summary>
			public string Status
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("status") ? RequestData.PostFieldValues["status"].FirstOrDefault() : null; }
				set
				{
					var oldv=Status;
					var target = RequestData.PostFieldValues.ContainsKey("status") ? RequestData.PostFieldValues["status"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["status"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Status"));
				}
			}
			/// <summary>
			/// <para>visible</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	微博的可见性，0：所有人能看，1：仅自己可见，2：密友可见，3：指定分组可见，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Visible
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("visible") ? RequestData.PostFieldValues["visible"].FirstOrDefault() : null; }
				set
				{
					var oldv=Visible;
					var target = RequestData.PostFieldValues.ContainsKey("visible") ? RequestData.PostFieldValues["visible"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["visible"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Visible"));
				}
			}
			/// <summary>
			/// <para>list_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	微博的保护投递指定分组ID，只有当visible参数为3时生效且必选。</para>
			/// <para></para>
			/// </summary>
			public string ListId
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("list_id") ? RequestData.PostFieldValues["list_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=ListId;
					var target = RequestData.PostFieldValues.ContainsKey("list_id") ? RequestData.PostFieldValues["list_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["list_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ListId"));
				}
			}
			/// <summary>
			/// <para>lat</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	float</para>
			/// <para>说明:</para>
			/// <para>	纬度，有效范围：-90.0到+90.0，+表示北纬，默认为0.0。</para>
			/// <para></para>
			/// </summary>
			public string Lat
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("lat") ? RequestData.PostFieldValues["lat"].FirstOrDefault() : null; }
				set
				{
					var oldv=Lat;
					var target = RequestData.PostFieldValues.ContainsKey("lat") ? RequestData.PostFieldValues["lat"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["lat"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Lat"));
				}
			}
			/// <summary>
			/// <para>long</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	float</para>
			/// <para>说明:</para>
			/// <para>	经度，有效范围：-180.0到+180.0，+表示东经，默认为0.0。</para>
			/// <para></para>
			/// </summary>
			public string Long
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("long") ? RequestData.PostFieldValues["long"].FirstOrDefault() : null; }
				set
				{
					var oldv=Long;
					var target = RequestData.PostFieldValues.ContainsKey("long") ? RequestData.PostFieldValues["long"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["long"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Long"));
				}
			}
			/// <summary>
			/// <para>annotations</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	元数据，主要是为了方便第三方应用记录一些适合于自己使用的信息，每条微博可以包含一个或者多个元数据，必须以json字串的形式提交，字串长度不超过512个字符，具体内容可以自定。</para>
			/// <para></para>
			/// </summary>
			public string Annotations
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("annotations") ? RequestData.PostFieldValues["annotations"].FirstOrDefault() : null; }
				set
				{
					var oldv=Annotations;
					var target = RequestData.PostFieldValues.ContainsKey("annotations") ? RequestData.PostFieldValues["annotations"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["annotations"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Annotations"));
				}
			}
			/// <summary>
			/// <para>pic</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	binary</para>
			/// <para>说明:</para>
			/// <para>	要上传的图片，仅支持JPEG、GIF、PNG格式，图片大小小于5M。</para>
			/// <para></para>
			/// </summary>
			public FileUploadInfo Pic
			{ 
				get { return RequestData.UploadFiles.ContainsKey("pic") ? RequestData.UploadFiles["pic"] : null; }
				set
				{
					RequestData.UploadFiles["pic"] = value;
					if(PropertyChanged != null)PropertyChanged(this , new PropertyChangedEventArgs("Pic"));
				}
			}
		}
	}

                
                

	namespace StatusesUploadUrlText
	{
		/// <summary>
		/// <para>指定一个图片URL地址抓取后上传并同时发布一条新微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/upload_url_text.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>status</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	要发布的微博文本内容，必须做URLencode，内容不超过140个汉字。</para>
			/// <para></para>
			/// </summary>
			public string Status
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("status") ? RequestData.PostFieldValues["status"].FirstOrDefault() : null; }
				set
				{
					var oldv=Status;
					var target = RequestData.PostFieldValues.ContainsKey("status") ? RequestData.PostFieldValues["status"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["status"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Status"));
				}
			}
			/// <summary>
			/// <para>visible</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	微博的可见性，0：所有人能看，1：仅自己可见，2：密友可见，3：指定分组可见，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Visible
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("visible") ? RequestData.PostFieldValues["visible"].FirstOrDefault() : null; }
				set
				{
					var oldv=Visible;
					var target = RequestData.PostFieldValues.ContainsKey("visible") ? RequestData.PostFieldValues["visible"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["visible"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Visible"));
				}
			}
			/// <summary>
			/// <para>list_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	微博的保护投递指定分组ID，只有当visible参数为3时生效且必选。</para>
			/// <para></para>
			/// </summary>
			public string ListId
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("list_id") ? RequestData.PostFieldValues["list_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=ListId;
					var target = RequestData.PostFieldValues.ContainsKey("list_id") ? RequestData.PostFieldValues["list_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["list_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ListId"));
				}
			}
			/// <summary>
			/// <para>url</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	图片的URL地址，必须以http开头。</para>
			/// <para></para>
			/// </summary>
			public string Url
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("url") ? RequestData.PostFieldValues["url"].FirstOrDefault() : null; }
				set
				{
					var oldv=Url;
					var target = RequestData.PostFieldValues.ContainsKey("url") ? RequestData.PostFieldValues["url"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["url"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Url"));
				}
			}
			/// <summary>
			/// <para>lat</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	float</para>
			/// <para>说明:</para>
			/// <para>	纬度，有效范围：-90.0到+90.0，+表示北纬，默认为0.0。</para>
			/// <para></para>
			/// </summary>
			public string Lat
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("lat") ? RequestData.PostFieldValues["lat"].FirstOrDefault() : null; }
				set
				{
					var oldv=Lat;
					var target = RequestData.PostFieldValues.ContainsKey("lat") ? RequestData.PostFieldValues["lat"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["lat"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Lat"));
				}
			}
			/// <summary>
			/// <para>long</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	float</para>
			/// <para>说明:</para>
			/// <para>	经度，有效范围：-180.0到+180.0，+表示东经，默认为0.0。</para>
			/// <para></para>
			/// </summary>
			public string Long
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("long") ? RequestData.PostFieldValues["long"].FirstOrDefault() : null; }
				set
				{
					var oldv=Long;
					var target = RequestData.PostFieldValues.ContainsKey("long") ? RequestData.PostFieldValues["long"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["long"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Long"));
				}
			}
			/// <summary>
			/// <para>annotations</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	元数据，主要是为了方便第三方应用记录一些适合于自己使用的信息，每条微博可以包含一个或者多个元数据，必须以json字串的形式提交，字串长度不超过512个字符，具体内容可以自定。</para>
			/// <para></para>
			/// </summary>
			public string Annotations
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("annotations") ? RequestData.PostFieldValues["annotations"].FirstOrDefault() : null; }
				set
				{
					var oldv=Annotations;
					var target = RequestData.PostFieldValues.ContainsKey("annotations") ? RequestData.PostFieldValues["annotations"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["annotations"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Annotations"));
				}
			}
		}
	}

                
                

	namespace StatusesUserTimeline
	{
		/// <summary>
		/// <para>获取某个用户最新发表的微博列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/user_timeline.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	参数uid与screen_name二者必选其一，且只能选其一   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户ID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户昵称。</para>
			/// <para></para>
			/// </summary>
			public string ScreenName
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=ScreenName;
					var target = RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ScreenName"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过100，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>base_app</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否只获取当前应用的数据。0为否（所有数据），1为是（仅当前应用），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string BaseApp
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"].FirstOrDefault() : null; }
				set
				{
					var oldv=BaseApp;
					var target = RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["base_app"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("BaseApp"));
				}
			}
			/// <summary>
			/// <para>feature</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	过滤类型ID，0：全部、1：原创、2：图片、3：视频、4：音乐，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Feature
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"].FirstOrDefault() : null; }
				set
				{
					var oldv=Feature;
					var target = RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["feature"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Feature"));
				}
			}
			/// <summary>
			/// <para>trim_user</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回值中user字段开关，0：返回完整user字段、1：user字段仅返回user_id，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string TrimUser
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"].FirstOrDefault() : null; }
				set
				{
					var oldv=TrimUser;
					var target = RequestData.QueryStringValues.ContainsKey("trim_user") ? RequestData.QueryStringValues["trim_user"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["trim_user"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrimUser"));
				}
			}
		}
	}

                
                

	namespace StatusesFilterCreate
	{
		/// <summary>
		/// <para>屏蔽某条微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/filter/create.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	微博id。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
		}
	}

                
                

	namespace StatusesFriendsTimelineIds
	{
		/// <summary>
		/// <para>获取当前登录用户及其所关注用户的最新微博的ID </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/friends_timeline/ids.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过100，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>base_app</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否只获取当前应用的数据。0为否（所有数据），1为是（仅当前应用），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string BaseApp
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"].FirstOrDefault() : null; }
				set
				{
					var oldv=BaseApp;
					var target = RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["base_app"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("BaseApp"));
				}
			}
			/// <summary>
			/// <para>feature</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	过滤类型ID，0：全部、1：原创、2：图片、3：视频、4：音乐，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Feature
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"].FirstOrDefault() : null; }
				set
				{
					var oldv=Feature;
					var target = RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["feature"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Feature"));
				}
			}
		}
	}

                
                

	namespace StatusesMentionsIds
	{
		/// <summary>
		/// <para>获取@当前用户的最新微博的ID </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/mentions/ids.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过200，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>filter_by_author</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	作者筛选类型，0：全部、1：我关注的人、2：陌生人，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterByAuthor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterByAuthor;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_author"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterByAuthor"));
				}
			}
			/// <summary>
			/// <para>filter_by_source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	来源筛选类型，0：全部、1：来自微博、2：来自微群，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterBySource
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterBySource;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_source") ? RequestData.QueryStringValues["filter_by_source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterBySource"));
				}
			}
			/// <summary>
			/// <para>filter_by_type</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	原创筛选类型，0：全部微博、1：原创的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterByType
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_type") ? RequestData.QueryStringValues["filter_by_type"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterByType;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_type") ? RequestData.QueryStringValues["filter_by_type"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_type"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterByType"));
				}
			}
		}
	}

                
                

	namespace StatusesMentionsShield
	{
		/// <summary>
		/// <para>屏蔽某个@到我的微博以及后续由对其转发引起的@提及 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/mentions/shield.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要屏蔽的@提到我的微博ID。此ID必须在statuses/mentions列表中。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
			/// <summary>
			/// <para>follow_up</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否仅屏蔽当前微博。0：仅屏蔽当前@提到我的微博；1：屏蔽当前@提到我的微博，以及后续对其转发而引起的@提到我的微博。默认1。</para>
			/// <para></para>
			/// </summary>
			public string FollowUp
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("follow_up") ? RequestData.PostFieldValues["follow_up"].FirstOrDefault() : null; }
				set
				{
					var oldv=FollowUp;
					var target = RequestData.PostFieldValues.ContainsKey("follow_up") ? RequestData.PostFieldValues["follow_up"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["follow_up"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FollowUp"));
				}
			}
		}
	}

                
                

	namespace StatusesRepostTimelineIds
	{
		/// <summary>
		/// <para>获取一条原创微博的最新转发微博的ID </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/repost_timeline/ids.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.QueryStringValues.ContainsKey("id") ? RequestData.QueryStringValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过200，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>filter_by_author</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	作者筛选类型，0：全部、1：我关注的人、2：陌生人，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string FilterByAuthor
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"].FirstOrDefault() : null; }
				set
				{
					var oldv=FilterByAuthor;
					var target = RequestData.QueryStringValues.ContainsKey("filter_by_author") ? RequestData.QueryStringValues["filter_by_author"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["filter_by_author"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("FilterByAuthor"));
				}
			}
		}
	}

                
                

	namespace StatusesToMeIds
	{
		/// <summary>
		/// <para>获取当前登录用户关注的人发给其的定向微博ID列表 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/to_me/ids.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	A与B互相关注，B在A的分组G中，A发送定向微博S到G，则，在B的【发给我的微博中】会包括S这条微博；</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的条数数量，最大不超过200，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
		}
	}

                
                

	namespace StatusesUserTimelineIds
	{
		/// <summary>
		/// <para>获取用户发布的微博的ID </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/statuses/user_timeline/ids.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	参数uid与screen_name二者必选其一，且只能选其一，uid优先   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户ID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户昵称。</para>
			/// <para></para>
			/// </summary>
			public string ScreenName
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=ScreenName;
					var target = RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ScreenName"));
				}
			}
			/// <summary>
			/// <para>since_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string SinceId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=SinceId;
					var target = RequestData.QueryStringValues.ContainsKey("since_id") ? RequestData.QueryStringValues["since_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["since_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("SinceId"));
				}
			}
			/// <summary>
			/// <para>max_id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string MaxId
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"].FirstOrDefault() : null; }
				set
				{
					var oldv=MaxId;
					var target = RequestData.QueryStringValues.ContainsKey("max_id") ? RequestData.QueryStringValues["max_id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["max_id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("MaxId"));
				}
			}
			/// <summary>
			/// <para>count</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	单页返回的记录条数，最大不超过100，默认为20。</para>
			/// <para></para>
			/// </summary>
			public string Count
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"].FirstOrDefault() : null; }
				set
				{
					var oldv=Count;
					var target = RequestData.QueryStringValues.ContainsKey("count") ? RequestData.QueryStringValues["count"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["count"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Count"));
				}
			}
			/// <summary>
			/// <para>page</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	返回结果的页码，默认为1。</para>
			/// <para></para>
			/// </summary>
			public string Page
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"].FirstOrDefault() : null; }
				set
				{
					var oldv=Page;
					var target = RequestData.QueryStringValues.ContainsKey("page") ? RequestData.QueryStringValues["page"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["page"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Page"));
				}
			}
			/// <summary>
			/// <para>base_app</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	是否只获取当前应用的数据。0为否（所有数据），1为是（仅当前应用），默认为0。</para>
			/// <para></para>
			/// </summary>
			public string BaseApp
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"].FirstOrDefault() : null; }
				set
				{
					var oldv=BaseApp;
					var target = RequestData.QueryStringValues.ContainsKey("base_app") ? RequestData.QueryStringValues["base_app"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["base_app"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("BaseApp"));
				}
			}
			/// <summary>
			/// <para>feature</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	过滤类型ID，0：全部、1：原创、2：图片、3：视频、4：音乐，默认为0。</para>
			/// <para></para>
			/// </summary>
			public string Feature
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"].FirstOrDefault() : null; }
				set
				{
					var oldv=Feature;
					var target = RequestData.QueryStringValues.ContainsKey("feature") ? RequestData.QueryStringValues["feature"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["feature"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Feature"));
				}
			}
		}
	}

                
                

	namespace UsersCancelTopStatus
	{
		/// <summary>
		/// <para>取消当前用户主页置顶微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/users/cancel_top_status.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要取消设置为置顶微博的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
		}
	}

                
                

	namespace UsersCounts
	{
		/// <summary>
		/// <para>批量获取用户的粉丝数、关注数、微博数 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/users/counts.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uids</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要获取数据的用户UID，多个之间用逗号分隔，最多不超过100个。</para>
			/// <para></para>
			/// </summary>
			public string Uids
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uids") ? RequestData.QueryStringValues["uids"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uids;
					var target = RequestData.QueryStringValues.ContainsKey("uids") ? RequestData.QueryStringValues["uids"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uids"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uids"));
				}
			}
		}
	}

                
                

	namespace UsersDomainShow
	{
		/// <summary>
		/// <para>通过个性化域名获取用户资料以及用户最新的一条微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/users/domain_show.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>domain</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要查询的个性化域名。</para>
			/// <para></para>
			/// </summary>
			public string Domain
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("domain") ? RequestData.QueryStringValues["domain"].FirstOrDefault() : null; }
				set
				{
					var oldv=Domain;
					var target = RequestData.QueryStringValues.ContainsKey("domain") ? RequestData.QueryStringValues["domain"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["domain"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Domain"));
				}
			}
		}
	}

                
                

	namespace UsersGetTopStatus
	{
		/// <summary>
		/// <para>获取用户主页置顶微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/users/get_top_status.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户UID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
		}
	}

                
                

	namespace UsersSetTopStatus
	{
		/// <summary>
		/// <para>设置当前用户主页置顶微博 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/users/set_top_status.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	POST</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		/// <para></para>
		/// </summary>
		public class Request : PostRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.PostFieldValues.ContainsKey("source") ? RequestData.PostFieldValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.PostFieldValues.ContainsKey("access_token") ? RequestData.PostFieldValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>id</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要设置为置顶微博的微博ID。</para>
			/// <para></para>
			/// </summary>
			public string Id
			{ 
				get { return RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"].FirstOrDefault() : null; }
				set
				{
					var oldv=Id;
					var target = RequestData.PostFieldValues.ContainsKey("id") ? RequestData.PostFieldValues["id"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.PostFieldValues["id"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Id"));
				}
			}
		}
	}

                
                

	namespace UsersShow
	{
		/// <summary>
		/// <para>根据用户ID获取用户信息 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/users/show.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	int64</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户ID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
			/// <summary>
			/// <para>screen_name</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户昵称。</para>
			/// <para></para>
			/// </summary>
			public string ScreenName
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"].FirstOrDefault() : null; }
				set
				{
					var oldv=ScreenName;
					var target = RequestData.QueryStringValues.ContainsKey("screen_name") ? RequestData.QueryStringValues["screen_name"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["screen_name"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("ScreenName"));
				}
			}
		}
	}

                
                

	namespace UsersShowRank
	{
		/// <summary>
		/// <para>获取用户等级信息 </para>
		/// <para>URL:</para>
		/// <para>	https://api.weibo.com/2/users/show_rank.json</para>
		/// <para>支持格式:</para>
		/// <para>	JSON</para>
		/// <para>HTTP请求方式:</para>
		/// <para>	GET</para>
		/// <para>是否需要登录:</para>
		/// <para>	是  关于登录授权，参见 如何登录授权</para>
		/// <para>访问授权限制:</para>
		/// <para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		/// <para>注意事项:</para>
		/// <para>	无</para>
		/// <para></para>
		/// </summary>
		public class Request : GetRequest, INotifyPropertyChanged
		{
			public Request()
			{
			}

			public event PropertyChangedEventHandler PropertyChanged;

			/// <summary>
			/// <para>source</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式不需要此参数，其他授权方式为必填参数，数值为应用的AppKey。</para>
			/// <para></para>
			/// </summary>
			public string Source
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"].FirstOrDefault() : null; }
				set
				{
					var oldv=Source;
					var target = RequestData.QueryStringValues.ContainsKey("source") ? RequestData.QueryStringValues["source"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["source"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Source"));
				}
			}
			/// <summary>
			/// <para>access_token</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	false</para>
			/// <para>类型及范围:</para>
			/// <para>	string</para>
			/// <para>说明:</para>
			/// <para>	采用OAuth授权方式为必填参数，其他授权方式不需要此参数，OAuth授权后获得。</para>
			/// <para></para>
			/// </summary>
			public string AccessToken
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"].FirstOrDefault() : null; }
				set
				{
					var oldv=AccessToken;
					var target = RequestData.QueryStringValues.ContainsKey("access_token") ? RequestData.QueryStringValues["access_token"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["access_token"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("AccessToken"));
				}
			}
			/// <summary>
			/// <para>uid</para>
			/// <para></para>
			/// <para>必选:</para>
			/// <para>	true</para>
			/// <para>类型及范围:</para>
			/// <para>	int</para>
			/// <para>说明:</para>
			/// <para>	需要查询的用户ID。</para>
			/// <para></para>
			/// </summary>
			public string Uid
			{ 
				get { return RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"].FirstOrDefault() : null; }
				set
				{
					var oldv=Uid;
					var target = RequestData.QueryStringValues.ContainsKey("uid") ? RequestData.QueryStringValues["uid"] : new List<string> () ;
					target.Clear();
					target.Add(value);
					RequestData.QueryStringValues["uid"] = target;
					if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Uid"));
				}
			}
		}
	}

                
	

}
