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
namespace SinaWeiboClientV1
{


				

	/// <summary>
	/// <para>返回新浪微博官方所有表情、魔法表情的相关信息。包括短语、表情类型、表情分类，是否热门等。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/emotions.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	false  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	false  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class EmotionsRequest : GetRequest, INotifyPropertyChanged
	{
		public EmotionsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>type</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	string, 默认为"face"</para>
		/// <para>说明:</para>
		/// <para>	表情类别。"face":普通表情，"ani"：魔法表情，"cartoon"：动漫表情</para>
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
		/// <para>	string, 默认为"cnname"</para>
		/// <para>说明:</para>
		/// <para>	语言类别，"cnname"简体，"twname"繁体</para>
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

				
								

	/// <summary>
	/// <para>返回登录用户最近收藏的20条微博消息，和用户在主站上“我的收藏”页面看到的内容是一致的。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/favorites.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class FavoritesRequest : GetRequest, INotifyPropertyChanged
	{
		public FavoritesRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>page</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	页码。</para>
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

				
								

	/// <summary>
	/// <para>      清除已验证用户的session，退出登录，并将cookie设为null。主要用于widget等web应用场合。 </para>
	/// <para>                                                                                       </para>
	/// <para>URL                                                                                    </para>
	/// <para>	http://api.t.sina.com.cn/account/end_session.(json|xml)                              </para>
	/// <para>                                                                                       </para>
	/// <para>HTTP请求方式                                                                           </para>
	/// <para>	POST                                                                                 </para>
	/// <para>                                                                                       </para>
	/// <para>是否需要登录                                                                            </para>
	/// <para>	true                                                                                 </para>
	/// <para>关于授权机制，参见授权机制声明                                                           </para>
	/// <para>                                                                                       </para>
	/// <para>请求数限制                                                                              </para>
	/// <para>	true                                                                                 </para>
	/// <para>关于请求数限制，参见接口访问权限说明                                                     </para>
	/// <para>
	/// 
	/// </summary>
	public class AccountEndSessionRequest : PostRequest, INotifyPropertyChanged
	{
		public AccountEndSessionRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
	}

				
								

	/// <summary>
	/// <para>获取隐私信息设置情况 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/account/get_privacy.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class AccountGetPrivacyRequest : GetRequest, INotifyPropertyChanged
	{
		public AccountGetPrivacyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
	}

				
								

	/// <summary>
	/// <para>获取API的访问频率限制。返回当前小时内还能访问的次数。频率限制是根据用户请求来做的限制，具体细节参见：接口访问权限说明。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/account/rate_limit_status.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class AccountRateLimitStatusRequest : GetRequest, INotifyPropertyChanged
	{
		public AccountRateLimitStatusRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
	}

				
								

	/// <summary>
	/// <para>设置隐私信息 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/account/update_privacy.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class AccountUpdatePrivacyRequest : PostRequest, INotifyPropertyChanged
	{
		public AccountUpdatePrivacyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>comment</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	谁可以评论此账号的微薄。0：所有人，1：我关注的人。默认为0。</para>
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
		/// <para>message</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	谁可以给此账号发私信。0：所有人，1：我关注的人。默认为1。</para>
		/// <para></para>
		/// </summary>
		public string Message
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("message") ? RequestData.PostFieldValues["message"].FirstOrDefault() : null; }
			set
			{
				var oldv=Message;
				var target = RequestData.PostFieldValues.ContainsKey("message") ? RequestData.PostFieldValues["message"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["message"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Message"));
			}
		}
		/// <summary>
		/// <para>realname</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	是否允许别人通过真实姓名搜索到我， 0允许，1不允许，默认值1。</para>
		/// <para></para>
		/// </summary>
		public string Realname
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("realname") ? RequestData.PostFieldValues["realname"].FirstOrDefault() : null; }
			set
			{
				var oldv=Realname;
				var target = RequestData.PostFieldValues.ContainsKey("realname") ? RequestData.PostFieldValues["realname"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["realname"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Realname"));
			}
		}
		/// <summary>
		/// <para>geo</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	发布微博，是否允许微博保存并显示所处的地理位置信息。 0允许，1不允许，默认值0。</para>
		/// <para></para>
		/// </summary>
		public string Geo
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("geo") ? RequestData.PostFieldValues["geo"].FirstOrDefault() : null; }
			set
			{
				var oldv=Geo;
				var target = RequestData.PostFieldValues.ContainsKey("geo") ? RequestData.PostFieldValues["geo"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["geo"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Geo"));
			}
		}
		/// <summary>
		/// <para>badge</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	勋章展现状态，值—1私密状态，0公开状态，默认值0。</para>
		/// <para></para>
		/// </summary>
		public string Badge
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("badge") ? RequestData.PostFieldValues["badge"].FirstOrDefault() : null; }
			set
			{
				var oldv=Badge;
				var target = RequestData.PostFieldValues.ContainsKey("badge") ? RequestData.PostFieldValues["badge"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["badge"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Badge"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>更新当前登录用户在新浪微博上的基本信息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/account/update_profile.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class AccountUpdateProfileRequest : PostRequest, INotifyPropertyChanged
	{
		public AccountUpdateProfileRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>name</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	昵称，不超过20个字符</para>
		/// <para></para>
		/// </summary>
		public string Name
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("name") ? RequestData.PostFieldValues["name"].FirstOrDefault() : null; }
			set
			{
				var oldv=Name;
				var target = RequestData.PostFieldValues.ContainsKey("name") ? RequestData.PostFieldValues["name"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["name"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Name"));
			}
		}
		/// <summary>
		/// <para>gender</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	性别， m 表示男性，f 表示女性。</para>
		/// <para></para>
		/// </summary>
		public string Gender
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("gender") ? RequestData.PostFieldValues["gender"].FirstOrDefault() : null; }
			set
			{
				var oldv=Gender;
				var target = RequestData.PostFieldValues.ContainsKey("gender") ? RequestData.PostFieldValues["gender"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["gender"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Gender"));
			}
		}
		/// <summary>
		/// <para>province</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	省份代码，参考省份城市编码表</para>
		/// <para></para>
		/// </summary>
		public string Province
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("province") ? RequestData.PostFieldValues["province"].FirstOrDefault() : null; }
			set
			{
				var oldv=Province;
				var target = RequestData.PostFieldValues.ContainsKey("province") ? RequestData.PostFieldValues["province"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["province"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Province"));
			}
		}
		/// <summary>
		/// <para>city</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	城市代码，1000表示不指定具体城市。参考省份城市编码表</para>
		/// <para></para>
		/// </summary>
		public string City
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("city") ? RequestData.PostFieldValues["city"].FirstOrDefault() : null; }
			set
			{
				var oldv=City;
				var target = RequestData.PostFieldValues.ContainsKey("city") ? RequestData.PostFieldValues["city"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["city"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("City"));
			}
		}
		/// <summary>
		/// <para>description</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	个人描述。不超过70个汉字</para>
		/// <para></para>
		/// </summary>
		public string Description
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("description") ? RequestData.PostFieldValues["description"].FirstOrDefault() : null; }
			set
			{
				var oldv=Description;
				var target = RequestData.PostFieldValues.ContainsKey("description") ? RequestData.PostFieldValues["description"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["description"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Description"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>更新用户头像。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/account/update_profile_image.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para>注意事项:</para>
	/// <para>	采用multipart/form-data编码方式提交，可以参考： Form-based File Upload in HTML</para>
	/// <para></para>
	/// </summary>
	public class AccountUpdateProfileImageRequest : MultiPartPostRequest, INotifyPropertyChanged
	{
		public AccountUpdateProfileImageRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>image</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	binary</para>
		/// <para>说明:</para>
		/// <para>	必须为小于700K的有效的GIF, JPG图片. 如果图片大于500像素将按比例缩放。</para>
		/// <para></para>
		/// </summary>
		public FileUploadInfo Image
		{ 
			get { return RequestData.UploadFiles.ContainsKey("image") ? RequestData.UploadFiles["image"] : null; }
			set
			{
				RequestData.UploadFiles["image"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Image"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>验证用户是否已经开通微博服务。 </para>
	/// <para>如果用户的新浪通行证身份验证成功，且用户已经开通微博则返回 http状态为 200，否则返回403错误。 </para>
	/// <para>该接口除source以外，无其他参数。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/account/verify_credentials.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para>注意事项:</para>
	/// <para>	若用户的新浪通行证身份验证成功，但未开通微博服务，则提示：40313:Error: invalid weibo user!。   若用户的新浪通行证身份验证失败，则提示：40302:Error: auth faild!</para>
	/// <para></para>
	/// </summary>
	public class AccountVerifyCredentialsRequest : GetRequest, INotifyPropertyChanged
	{
		public AccountVerifyCredentialsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
	}

				
								

	/// <summary>
	/// <para>分页输出当前登录用户的黑名单列表，包括黑名单内的用户详细信息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/blocks/blocking.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class BlocksBlockingRequest : GetRequest, INotifyPropertyChanged
	{
		public BlocksBlockingRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>page</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	页码。</para>
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
		/// <para>	单页记录数。</para>
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

				
								

	/// <summary>
	/// <para>分页输出当前登录用户黑名单中的用户ID列表。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/blocks/blocking/ids.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class BlocksBlockingIdsRequest : GetRequest, INotifyPropertyChanged
	{
		public BlocksBlockingIdsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>page</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	页码。</para>
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
		/// <para>	单页记录数。</para>
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

				
								

	/// <summary>
	/// <para>将某用户加入登录用户的黑名单 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/blocks/create.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class BlocksCreateRequest : PostRequest, INotifyPropertyChanged
	{
		public BlocksCreateRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要加入黑名单的用户ID</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	要加入黑名单的用户微博昵称</para>
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

				
								

	/// <summary>
	/// <para>将某用户从当前登录用户的黑名单中移除 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/blocks/destroy.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST/DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class BlocksDestroyRequest : PostRequest, INotifyPropertyChanged
	{
		public BlocksDestroyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要移出黑名单的用户ID</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	要移出黑名单的用户微博昵称</para>
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

				
								

	/// <summary>
	/// <para>检测指定用户是否在登录用户的黑名单内。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/blocks/exists.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class BlocksExistsRequest : GetRequest, INotifyPropertyChanged
	{
		public BlocksExistsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要检测的用户ID</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	要检测的用户微博昵称</para>
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

				
								

	/// <summary>
	/// <para>收藏一条微博消息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/favorites/create.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class FavoritesCreateRequest : PostRequest, INotifyPropertyChanged
	{
		public FavoritesCreateRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要收藏的微博消息ID。</para>
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

				
								

	/// <summary>
	/// <para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/favorites/destroy/:id.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST/DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class FavoritesDestroyRequest : PostRequest, INotifyPropertyChanged
	{
		public FavoritesDestroyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要删除的已收藏的微博消息ID。该参数为一个REST风格参数。用法参见注意事项。</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
	}

				
								

	/// <summary>
	/// <para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/favorites/destroy_batch.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST/DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class FavoritesDestroyBatchRequest : PostRequest, INotifyPropertyChanged
	{
		public FavoritesDestroyBatchRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>ids</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要删除的一组已收藏的微博消息ID，用半角逗号隔开，一次提交最多提供20个ID。</para>
		/// <para></para>
		/// </summary>
		public string Ids
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("ids") ? RequestData.PostFieldValues["ids"].FirstOrDefault() : null; }
			set
			{
				var oldv=Ids;
				var target = RequestData.PostFieldValues.ContainsKey("ids") ? RequestData.PostFieldValues["ids"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["ids"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Ids"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>关注一个用户。关注成功则返回关注人的资料，目前的最多关注2000人。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/friendships/create.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class FriendshipsCreateRequest : PostRequest, INotifyPropertyChanged
	{
		public FriendshipsCreateRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64/string</para>
		/// <para>说明:</para>
		/// <para>	要关注的用户ID(int64)或者微博昵称(string)，该参数是一个REST风格的参数。用法见注意事项</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要关注的用户ID，为了避免用户的ID与微博昵称相同而产生混淆的情况，推荐使用该参数。</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	要关注的用户微博昵称，为了避免用户的ID与微博昵称相同而产生混淆的情况，推荐使用该参数。</para>
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

				
								

	/// <summary>
	/// <para>取消对某用户的关注。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/friendships/destroy.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST/DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class FriendshipsDestroyRequest : PostRequest, INotifyPropertyChanged
	{
		public FriendshipsDestroyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64/string</para>
		/// <para>说明:</para>
		/// <para>	要取消关注的用户ID(int64)或者微博昵称(string)，该参数是一个REST风格的参数。用法见注意事项</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要取消关注的用户ID，为了避免用户的ID与微博昵称相同而产生混淆的情况，推荐使用该参数。</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	要取消关注的用户微博昵称，为了避免用户的ID与微博昵称相同而产生混淆的情况，推荐使用该参数。</para>
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

				
								

	/// <summary>
	/// <para>查看用户A是否关注了用户B。如果用户A关注了用户B，则返回true，否则返回false。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/friendships/exists.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class FriendshipsExistsRequest : GetRequest, INotifyPropertyChanged
	{
		public FriendshipsExistsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_a</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	用户A的用户ID</para>
		/// <para></para>
		/// </summary>
		public string UserA
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_a") ? RequestData.QueryStringValues["user_a"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserA;
				var target = RequestData.QueryStringValues.ContainsKey("user_a") ? RequestData.QueryStringValues["user_a"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_a"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserA"));
			}
		}
		/// <summary>
		/// <para>user_b</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	用户B的用户ID</para>
		/// <para></para>
		/// </summary>
		public string UserB
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_b") ? RequestData.QueryStringValues["user_b"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserB;
				var target = RequestData.QueryStringValues.ContainsKey("user_b") ? RequestData.QueryStringValues["user_b"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_b"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserB"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>返回两个用户关注关系的详细情况 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/friendships/show.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class FriendshipsShowRequest : GetRequest, INotifyPropertyChanged
	{
		public FriendshipsShowRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>source_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	源用户UID</para>
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
		/// <para>	源微博昵称</para>
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
		/// <para>	要判断的目标用户ID</para>
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
		/// <para>	要判断的目标用户的微博昵称</para>
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

				
								

	/// <summary>
	/// <para>将一个或多个短链接还原成原始的长链接 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/short_url/expand.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	false  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class ShortUrlExpandRequest : GetRequest, INotifyPropertyChanged
	{
		public ShortUrlExpandRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>url_short</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	需要还原的短链接，需要URLencoded，最多不超过20个</para>
		/// <para></para>
		/// </summary>
		public List<string> UrlShort
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("url_short") ? RequestData.QueryStringValues["url_short"] : null; }
			set
			{
				RequestData.QueryStringValues["url_short"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("UrlShort"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>将一个或多个长链接转换成短链接 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/short_url/shorten.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	false  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class ShortUrlShortenRequest : GetRequest, INotifyPropertyChanged
	{
		public ShortUrlShortenRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>url_long</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	需要转换的长链接，需要URLencoded，最多不超过20个。</para>
		/// <para></para>
		/// </summary>
		public List<string> UrlLong
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("url_long") ? RequestData.QueryStringValues["url_long"] : null; }
			set
			{
				RequestData.QueryStringValues["url_long"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("UrlLong"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>取得包含指定单个短链接的最新微博评论内容 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/short_url/comment/comments.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class ShortUrlCommentCommentsRequest : GetRequest, INotifyPropertyChanged
	{
		public ShortUrlCommentCommentsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>url_short</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	需要取得关联微博评论内容的短链接，需要URLencoded</para>
		/// <para></para>
		/// </summary>
		public string UrlShort
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("url_short") ? RequestData.QueryStringValues["url_short"].FirstOrDefault() : null; }
			set
			{
				var oldv=UrlShort;
				var target = RequestData.QueryStringValues.ContainsKey("url_short") ? RequestData.QueryStringValues["url_short"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["url_short"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UrlShort"));
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
		/// <para>	若指定此参数，则返回ID比since_id大的评论（即比since_id时间晚的评论），默认为0</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的评论，默认为0</para>
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
		/// <para>	可选参数，每次返回的最大记录数（即页面大小），不大于200</para>
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
		/// <para>	可选参数，返回结果的页序号，有分页限制</para>
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

				
								

	/// <summary>
	/// <para>取得一个短链接在微博上的微博评论数 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/short_url/comment/counts.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	false  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class ShortUrlCommentCountsRequest : GetRequest, INotifyPropertyChanged
	{
		public ShortUrlCommentCountsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>url_short</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	需要取得评论数的短链接，需要URLencoded</para>
		/// <para></para>
		/// </summary>
		public string UrlShort
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("url_short") ? RequestData.QueryStringValues["url_short"].FirstOrDefault() : null; }
			set
			{
				var oldv=UrlShort;
				var target = RequestData.QueryStringValues.ContainsKey("url_short") ? RequestData.QueryStringValues["url_short"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["url_short"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UrlShort"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>取得一个短链接在微博上的微博分享数（包含原创和转发的微博） </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/short_url/share/counts.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	false  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class ShortUrlShareCountsRequest : GetRequest, INotifyPropertyChanged
	{
		public ShortUrlShareCountsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>url_short</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	需要取得分享数的短链接，需要URLencoded</para>
		/// <para></para>
		/// </summary>
		public string UrlShort
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("url_short") ? RequestData.QueryStringValues["url_short"].FirstOrDefault() : null; }
			set
			{
				var oldv=UrlShort;
				var target = RequestData.QueryStringValues.ContainsKey("url_short") ? RequestData.QueryStringValues["url_short"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["url_short"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UrlShort"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>取得包含指定单个短链接的最新微博内容 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/short_url/share/statuses.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class ShortUrlShareStatusesRequest : GetRequest, INotifyPropertyChanged
	{
		public ShortUrlShareStatusesRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>url_short</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	需要取得关联微博内容的短链接，需要URLencoded</para>
		/// <para></para>
		/// </summary>
		public string UrlShort
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("url_short") ? RequestData.QueryStringValues["url_short"].FirstOrDefault() : null; }
			set
			{
				var oldv=UrlShort;
				var target = RequestData.QueryStringValues.ContainsKey("url_short") ? RequestData.QueryStringValues["url_short"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["url_short"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UrlShort"));
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
		/// <para>	若指定此参数，则返回ID比since_id大的微博（即比since_id时间晚的微博），默认为0</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的微博，默认为0</para>
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
		/// <para>	可选参数，每次返回的最大记录数（即页面大小），不大于200</para>
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
		/// <para>	可选参数，返回结果的页序号，有分页限制</para>
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

				
								

	/// <summary>
	/// <para>返回用户的粉丝用户ID列表 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/followers/ids.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class SocialgraphFollowsIdsRequest : GetRequest, INotifyPropertyChanged
	{
		public SocialgraphFollowsIdsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64/string</para>
		/// <para>说明:</para>
		/// <para>	用户的ID(int64)或者微博昵称(string)。该参数为REST风格的参数，用法参见注意事项。</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要获取的粉丝列表所属的用户的ID。</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	要获取的粉丝列表所属的用户微博昵称。</para>
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
		/// <para>	int，默认500，最大5000</para>
		/// <para>说明:</para>
		/// <para>	单页记录数。</para>
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
		/// <para>	int，默认-1。</para>
		/// <para>说明:</para>
		/// <para>	游标。单页最多返回5000条记录。通过增加或减少cursor值来获取更多的粉丝列表。如果提供该参数，返回结果中将给出下一页的起始游标。</para>
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

				
								

	/// <summary>
	/// <para>返回用户关注的一组用户的ID列表 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/friends/ids.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class SocialgraphFriendsIdsRequest : GetRequest, INotifyPropertyChanged
	{
		public SocialgraphFriendsIdsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64/string</para>
		/// <para>说明:</para>
		/// <para>	用户的ID(int64)或者微博昵称(string)。该参数为REST风格的参数，用法参见注意事项。</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要获取的好友列表所属的用户的ID。</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	要获取的好友列表所属的用户微博昵称。</para>
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
		/// <para>	int，默认500，最大5000</para>
		/// <para>说明:</para>
		/// <para>	单页记录数。</para>
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
		/// <para>	int，默认-1。</para>
		/// <para>说明:</para>
		/// <para>	游标。单页最多返回5000条记录。通过增加或减少cursor值来获取更多的关注列表。如果提供该参数，返回结果中将给出下一页的起始游标。</para>
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

				
								

	/// <summary>
	/// <para>对一条微博信息进行评论。请求必须用POST方式提交。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/comment.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesCommentRequest : PostRequest, INotifyPropertyChanged
	{
		public StatusesCommentRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要评论的微博消息ID</para>
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
		/// <para>	评论内容。必须做URLEncode,信息内容不超过140个汉字。</para>
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
		/// <para>cid</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要回复的评论ID。</para>
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
		/// <para>without_mention</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	1：回复中不自动加入“回复@用户名”，0：回复中自动加入“回复@用户名”.默认为0.</para>
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
		/// <para>	当评论一条转发微博时，是否评论给原微博。0:不评论给原微博。1：评论给原微博。默认0.</para>
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

				
								

	/// <summary>
	/// <para>根据微博消息ID返回某条微博消息的评论列表 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/comments.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesCommentsRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesCommentsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	指定要获取的评论列表所属的微博消息ID</para>
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
		/// <para>count</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int，默认值20，最大值200。</para>
		/// <para>说明:</para>
		/// <para>	单页返回的记录条数。</para>
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
		/// <para>	int，默认值1。</para>
		/// <para>说明:</para>
		/// <para>	返回结果的页码。</para>
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

				
								

	/// <summary>
	/// <para>获取当前用户发出的评论 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/comments_by_me.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesCommentsByMeRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesCommentsByMeRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>since_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	若指定此参数，则只返回ID比since_id大的评论（比since_id发表时间晚）。</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的评论</para>
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
		/// <para>	int，默认值20，最大值200。</para>
		/// <para>说明:</para>
		/// <para>	单页返回的记录条数。</para>
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
		/// <para>	int，默认值1。</para>
		/// <para>说明:</para>
		/// <para>	返回结果的页码。</para>
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

				
								

	/// <summary>
	/// <para>返回最新n条发送及收到的评论。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/comments_timeline.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesCommentsTimelineRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesCommentsTimelineRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>since_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	若指定此参数，则只返回ID比since_id大的评论（比since_id发表时间晚）。</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的评论</para>
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
		/// <para>	int，默认值20，最大值200。</para>
		/// <para>说明:</para>
		/// <para>	单页返回的记录条数。</para>
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
		/// <para>	int，默认值1。</para>
		/// <para>说明:</para>
		/// <para>	返回结果的页码。注意：有分页限制。</para>
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

				
								

	/// <summary>
	/// <para>返回当前登录用户收到的评论 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/comments_to_me.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesCommentsToMeRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesCommentsToMeRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>since_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	若指定此参数，则只返回ID比since_id大的评论（比since_id发表时间晚）。</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的评论</para>
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
		/// <para>	int，默认值20，最大值200。</para>
		/// <para>说明:</para>
		/// <para>	单页返回的记录条数。</para>
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
		/// <para>	int，默认值1。</para>
		/// <para>说明:</para>
		/// <para>	返回结果的页码。</para>
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

				
								

	/// <summary>
	/// <para>删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/comment_destroy/:id.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST/DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesCommentDestroyRequest : PostRequest, INotifyPropertyChanged
	{
		public StatusesCommentDestroyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	欲删除的评论ID，该参数为一个REST风格参数。</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
	}

				
								

	/// <summary>
	/// <para>批量删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/comment/destroy_batch.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST/DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesCommentDestroyBatchRequest : PostRequest, INotifyPropertyChanged
	{
		public StatusesCommentDestroyBatchRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>ids</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	欲删除的一组评论ID，用半角逗号隔开，最多20个</para>
		/// <para></para>
		/// </summary>
		public string Ids
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("ids") ? RequestData.PostFieldValues["ids"].FirstOrDefault() : null; }
			set
			{
				var oldv=Ids;
				var target = RequestData.PostFieldValues.ContainsKey("ids") ? RequestData.PostFieldValues["ids"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["ids"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Ids"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>批量获取n条微博消息的评论数和转发数。一次请求最多可以获取20条微博消息的评论数和转发数 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/counts.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesCountsRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesCountsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>ids</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要获取评论数和转发数的微博消息ID列表，用逗号隔开</para>
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

				
								

	/// <summary>
	/// <para>根据ID删除微博消息。注意：只能删除自己发布的微博消息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/destroy/:id.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST/DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesDestroyRequest : PostRequest, INotifyPropertyChanged
	{
		public StatusesDestroyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要删除的微博消息ID</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
	}

				
								

	/// <summary>
	/// <para>获取用户粉丝列表及每个粉丝的最新一条微博，返回结果按粉丝的关注时间倒序排列，最新关注的粉丝排在最前面。每次返回20个,通过cursor参数来取得多于20的粉丝。注意目前接口最多只返回5000个粉丝。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/followers.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	false  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesFollowersRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesFollowersRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64/string</para>
		/// <para>说明:</para>
		/// <para>	用户ID(int64)或者昵称(string)。该参数为一个REST风格参数。调用示例见注意事项</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	用户ID，主要是用来区分用户ID跟微博昵称。当微博昵称为数字导致和用户ID产生歧义，特别是当微博昵称和用户ID一样的时候，建议使用该参数</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	微博昵称，主要是用来区分用户UID跟微博昵称，当二者一样而产生歧义的时候，建议使用该参数</para>
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
		/// <para>cursor</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	用于分页请求，请求第1页cursor传-1，在返回的结果中会得到next_cursor字段，表示下一页的cursor。next_cursor为0表示已经到记录末尾。</para>
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
		/// <para>count</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int，默认20，最大200</para>
		/// <para>说明:</para>
		/// <para>	每页返回的最大记录数，最大不能超过200，默认为20。</para>
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

				
								

	/// <summary>
	/// <para>获取用户关注列表及每个关注用户的最新一条微博，返回结果按关注时间倒序排列，最新关注的用户排在最前面。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/friends.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesFriendsRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesFriendsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64/string</para>
		/// <para>说明:</para>
		/// <para>	用户ID(int64)或者昵称(string)。该参数为一个REST风格参数。调用示例见注意事项</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	用户ID，主要是用来区分用户ID跟微博昵称。当微博昵称为数字导致和用户ID产生歧义，特别是当微博昵称和用户ID一样的时候，建议使用该参数</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	微博昵称，主要是用来区分用户UID跟微博昵称，当二者一样而产生歧义的时候，建议使用该参数</para>
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
		/// <para>cursor</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	用于分页请求，请求第1页cursor传-1，在返回的结果中会得到next_cursor字段，表示下一页的cursor。next_cursor为0表示已经到记录末尾。</para>
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
		/// <para>count</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int，默认20，最大200</para>
		/// <para>说明:</para>
		/// <para>	每页返回的最大记录数，最大不能超过200，默认为20。</para>
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

				
								

	/// <summary>
	/// <para>获取当前登录用户及其所关注用户的最新微博消息。和用户登录 http://t.sina.com.cn 后在“我的首页”中看到的内容相同。</para>
	/// <para>别名statuses/home_timeline </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/friends_timeline.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesFriendsTimelineRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesFriendsTimelineRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>since_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	若指定此参数，则只返回ID比since_id大的微博消息（即比since_id发表时间晚的微博消息）。</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的微博消息</para>
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
		/// <para>	int，默认值20，最大值200。</para>
		/// <para>说明:</para>
		/// <para>	指定要返回的记录条数。</para>
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
		/// <para>	int，默认值1。</para>
		/// <para>说明:</para>
		/// <para>	指定返回结果的页码。根据当前登录用户所关注的用户数及这些被关注用户发表的微博数，翻页功能最多能查看的总记录数会有所不同，通常最多能查看1000条左右。</para>
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
		/// <para>	是否基于当前应用来获取数据。1为限制本应用微博，0为不做限制。</para>
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
		/// <para>	微博类型，0全部，1原创，2图片，3视频，4音乐. 返回指定类型的微博信息内容。</para>
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

				
								

	/// <summary>
	/// <para>返回最新n条提到登录用户的微博消息（即包含@username的微博消息） </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/mentions.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesMentionsRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesMentionsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>since_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	若指定此参数，则只返回ID比since_id大的提到当前登录用户的微博消息（比since_id发表时间晚）。</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的提到当前登录用户微博消息</para>
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
		/// <para>	int，默认值20，最大值200。</para>
		/// <para>说明:</para>
		/// <para>	单页返回的记录条数。</para>
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
		/// <para>	int，默认值1。</para>
		/// <para>说明:</para>
		/// <para>	返回结果的页码。注意：有分页限制。</para>
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

				
								

	/// <summary>
	/// <para>返回最新的20条公共微博。返回结果非完全实时，最长会缓存60秒 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/public_timeline.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	false  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesPublicTimelineRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesPublicTimelineRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>count</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int，缺省值20，最大值200</para>
		/// <para>说明:</para>
		/// <para>	每次返回的记录数</para>
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
		/// <para>base_app</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	是否仅获取当前应用发布的信息。0为所有，1为仅本应用。</para>
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
	}

				
								

	/// <summary>
	/// <para>回复评论。请求必须用POST方式提交。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/reply.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesReplyRequest : PostRequest, INotifyPropertyChanged
	{
		public StatusesReplyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>cid</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要回复的评论ID。</para>
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
		/// <para>comment</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	要回复的评论内容。必须做URLEncode,信息内容不超过140个汉字。</para>
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
		/// <para>	要评论的微博消息ID</para>
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
		/// <para>without_mention</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	1：回复中不自动加入“回复@用户名”，0：回复中自动加入“回复@用户名”.默认为0.</para>
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
	}

				
								

	/// <summary>
	/// <para>转发一条微博消息。请求必须用POST方式提交。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/repost.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesRepostRequest : PostRequest, INotifyPropertyChanged
	{
		public StatusesRepostRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要转发的微博ID</para>
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
		/// <para>	添加的转发文本。必须做URLEncode,信息内容不超过140个汉字。如不填则默认为“转发微博”。</para>
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
		/// <para>	是否在转发的同时发表评论。0表示不发表评论，1表示发表评论给当前微博，2表示发表评论给原微博，3是1、2都发表。默认为0。</para>
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

				
								

	/// <summary>
	/// <para>获取用户最新转发的n条微博消息 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/repost_by_me.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesRepostByMeRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesRepostByMeRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要获取转发微博列表的用户ID。</para>
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
		/// <para>	若指定此参数，则只返回ID比since_id大的记录（比since_id发表时间晚）。</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的记录</para>
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
		/// <para>	int，默认值20，最大值200。</para>
		/// <para>说明:</para>
		/// <para>	单页返回的记录条数。</para>
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
		/// <para>	int，默认值1。</para>
		/// <para>说明:</para>
		/// <para>	返回结果的页码。</para>
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

				
								

	/// <summary>
	/// <para>返回一条原创微博消息的最新n条转发微博消息。本接口无法对非原创微博进行查询。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/repost_timeline.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesRepostTimelineRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesRepostTimelineRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要获取转发微博列表的原创微博ID。</para>
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
		/// <para>	若指定此参数，则只返回ID比since_id大的记录（比since_id发表时间晚）。</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的记录</para>
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
		/// <para>	int，默认值20，最大值200。</para>
		/// <para>说明:</para>
		/// <para>	单页返回的记录条数。</para>
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
		/// <para>	int，默认值1。</para>
		/// <para>说明:</para>
		/// <para>	返回结果的页码。</para>
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

				
								

	/// <summary>
	/// <para>将当前登录用户的某种新消息的未读数为0。可以清零的计数类别有：1. 评论数，2. @me数，3. 私信数，4. 关注数 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/reset_count.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	false  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesResetCountRequest : PostRequest, INotifyPropertyChanged
	{
		public StatusesResetCountRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>type</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int, 1~4</para>
		/// <para>说明:</para>
		/// <para>	需要清零的计数类别，值为下列四个之一：1. 评论数，2. @me数，3. 私信数，4. 关注数</para>
		/// <para></para>
		/// </summary>
		public string Type
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("type") ? RequestData.PostFieldValues["type"].FirstOrDefault() : null; }
			set
			{
				var oldv=Type;
				var target = RequestData.PostFieldValues.ContainsKey("type") ? RequestData.PostFieldValues["type"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["type"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Type"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>根据ID获取单条微博消息，以及该微博消息的作者信息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/show/:id.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesShowRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesShowRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要获取的微博消息ID，该参数为REST风格的参数</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
	}

				
								

	/// <summary>
	/// <para>获取当前用户Web主站未读消息数，包括： </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/unread.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesUnreadRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesUnreadRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>with_new_status</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int，默认为0。</para>
		/// <para>说明:</para>
		/// <para>	1表示结果中包含new_status字段，0表示结果不包含new_status字段。new_status字段表示是否有新微博消息，1表示有，0表示没有</para>
		/// <para></para>
		/// </summary>
		public string WithNewStatus
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("with_new_status") ? RequestData.QueryStringValues["with_new_status"].FirstOrDefault() : null; }
			set
			{
				var oldv=WithNewStatus;
				var target = RequestData.QueryStringValues.ContainsKey("with_new_status") ? RequestData.QueryStringValues["with_new_status"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["with_new_status"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("WithNewStatus"));
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
		/// <para>	参数值为微博id。该参数需配合with_new_status参数使用，返回since_id之后，是否有新微博消息产生</para>
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
	}

				
								

	/// <summary>
	/// <para>发布一条微博信息。也可以同时转发某条微博。请求必须用POST方式提交。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/update.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesUpdateRequest : PostRequest, INotifyPropertyChanged
	{
		public StatusesUpdateRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>status</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	要发布的微博消息文本内容</para>
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
		/// <para>in_reply_to_status_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要转发的微博消息ID。</para>
		/// <para></para>
		/// </summary>
		public string InReplyToStatusId
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("in_reply_to_status_id") ? RequestData.PostFieldValues["in_reply_to_status_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=InReplyToStatusId;
				var target = RequestData.PostFieldValues.ContainsKey("in_reply_to_status_id") ? RequestData.PostFieldValues["in_reply_to_status_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["in_reply_to_status_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("InReplyToStatusId"));
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
		/// <para>	纬度。有效范围：-90.0到+90.0，+表示北纬。</para>
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
		/// <para>	经度。有效范围：-180.0到+180.0，+表示东经。</para>
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
		/// <para>	元数据，主要是为了方便第三方应用记录一些适合于自己使用的信息。</para>
		/// <para>每条微博可以包含一个或者多个元数据。请以json字串的形式提交，字串长度不超过512个字符，具体内容可以自定。</para>
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

				
								

	/// <summary>
	/// <para>发表带图片的微博。必须用POST方式提交pic参数，且Content-Type必须设置为multipart/form-data。图片大小<5M。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/upload.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesUploadRequest : MultiPartPostRequest, INotifyPropertyChanged
	{
		public StatusesUploadRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>status</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	要发布的微博文本内容。</para>
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
		/// <para>pic</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	binary</para>
		/// <para>说明:</para>
		/// <para>	要上传的图片数据。仅支持JPEG、GIF、PNG格式，为空返回400错误。图片大小<5M。</para>
		/// <para></para>
		/// </summary>
		public string Pic
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("pic") ? RequestData.PostFieldValues["pic"].FirstOrDefault() : null; }
			set
			{
				var oldv=Pic;
				var target = RequestData.PostFieldValues.ContainsKey("pic") ? RequestData.PostFieldValues["pic"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["pic"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Pic"));
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
		/// <para>	纬度。有效范围：-90.0到+90.0，+表示北纬。</para>
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
		/// <para>	经度。有效范围：-180.0到+180.0，+表示东经。</para>
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
	}

				
								

	/// <summary>
	/// <para>返回用户最新发表的微博消息列表。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/statuses/user_timeline.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class StatusesUserTimelineRequest : GetRequest, INotifyPropertyChanged
	{
		public StatusesUserTimelineRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64/string</para>
		/// <para>说明:</para>
		/// <para>	根据用户ID(int64)或者微博昵称(string)返回指定用户的最新微博消息列表。该参数为REST风格参数，参见注意事项</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	用户ID，主要是用来区分用户ID跟微博昵称。当微博昵称为数字导致和用户ID产生歧义，特别是当微博昵称和用户ID一样的时候，建议使用该参数</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	微博昵称，主要是用来区分用户UID跟微博昵称，当二者一样而产生歧义的时候，建议使用该参数</para>
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
		/// <para>	若指定此参数，则只返回ID比since_id大（即比since_id发表时间晚的）的微博消息。</para>
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
		/// <para>	若指定此参数，则返回ID小于或等于max_id的微博消息</para>
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
		/// <para>	int，默认值20，最大值200。</para>
		/// <para>说明:</para>
		/// <para>	指定每页返回的记录条数。</para>
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
		/// <para>	int，默认值1。</para>
		/// <para>说明:</para>
		/// <para>	页码。注意：最多返回200条分页内容。</para>
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
		/// <para>	是否基于当前应用来获取数据。1为限制本应用微博，0为不做限制。</para>
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
		/// <para>	微博类型，0全部，1原创，2图片，3视频，4音乐. 返回指定类型的微博信息内容。</para>
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

				
								

	/// <summary>
	/// <para>为当前登录用户添加新的用户标签 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/tags/create.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TagsCreateRequest : PostRequest, INotifyPropertyChanged
	{
		public TagsCreateRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>tags</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	要创建的一组标签，用半角逗号隔开。</para>
		/// <para></para>
		/// </summary>
		public string Tags
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("tags") ? RequestData.PostFieldValues["tags"].FirstOrDefault() : null; }
			set
			{
				var oldv=Tags;
				var target = RequestData.PostFieldValues.ContainsKey("tags") ? RequestData.PostFieldValues["tags"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["tags"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Tags"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>删除标签 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/tags/destroy.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST/DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TagsDestroyRequest : PostRequest, INotifyPropertyChanged
	{
		public TagsDestroyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>tag_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要删除的标签ID</para>
		/// <para></para>
		/// </summary>
		public string TagId
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("tag_id") ? RequestData.PostFieldValues["tag_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=TagId;
				var target = RequestData.PostFieldValues.ContainsKey("tag_id") ? RequestData.PostFieldValues["tag_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["tag_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TagId"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>删除一组标签 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/tags/destroy_batch.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST/DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TagsDestroyBatchRequest : PostRequest, INotifyPropertyChanged
	{
		public TagsDestroyBatchRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>ids</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要删除的一组标签ID，以半角逗号隔开，一次最多提交20个ID。</para>
		/// <para></para>
		/// </summary>
		public string Ids
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("ids") ? RequestData.PostFieldValues["ids"].FirstOrDefault() : null; }
			set
			{
				var oldv=Ids;
				var target = RequestData.PostFieldValues.ContainsKey("ids") ? RequestData.PostFieldValues["ids"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["ids"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Ids"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>获取当前登录用户感兴趣的推荐标签列表 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/tags/suggestions.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TagsSuggestionsRequest : GetRequest, INotifyPropertyChanged
	{
		public TagsSuggestionsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>count</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int，默认10，最大10。</para>
		/// <para>说明:</para>
		/// <para>	单页记录数。</para>
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
		/// <para>	int，默认1</para>
		/// <para>说明:</para>
		/// <para>	页码。由于推荐标签是随机返回，故此特性暂不支持。</para>
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

				
								

	/// <summary>
	/// <para>返回指定用户的标签列表 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/tags.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TagsTagsRequest : GetRequest, INotifyPropertyChanged
	{
		public TagsTagsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要获取的标签列表所属的用户ID</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
			}
		}
		/// <summary>
		/// <para>count</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int，默认20，最大200</para>
		/// <para>说明:</para>
		/// <para>	单页记录数。</para>
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
		/// <para>	页码。</para>
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

				
								

	/// <summary>
	/// <para>返回最近一天内的热门话题。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/trends/daily.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TrendsDailyRequest : GetRequest, INotifyPropertyChanged
	{
		public TrendsDailyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>base_app</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	是否基于当前应用来获取数据。1表示基于当前应用来获取数据。</para>
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
	}

				
								

	/// <summary>
	/// <para>取消对某话题的关注。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/trends/destroy.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	DELETE</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TrendsDestroyRequest : DeleteRequest, INotifyPropertyChanged
	{
		public TrendsDestroyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>trend_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	要取消关注的话题ID。</para>
		/// <para></para>
		/// </summary>
		public string TrendId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("trend_id") ? RequestData.QueryStringValues["trend_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=TrendId;
				var target = RequestData.QueryStringValues.ContainsKey("trend_id") ? RequestData.QueryStringValues["trend_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["trend_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrendId"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>关注某话题。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/trends/follow.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TrendsFollowRequest : PostRequest, INotifyPropertyChanged
	{
		public TrendsFollowRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>trend_name</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	要关注的话题关键词。</para>
		/// <para></para>
		/// </summary>
		public string TrendName
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("trend_name") ? RequestData.PostFieldValues["trend_name"].FirstOrDefault() : null; }
			set
			{
				var oldv=TrendName;
				var target = RequestData.PostFieldValues.ContainsKey("trend_name") ? RequestData.PostFieldValues["trend_name"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["trend_name"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrendName"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>返回最近一小时内的热门话题。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/trends/hourly.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TrendsHourlyRequest : GetRequest, INotifyPropertyChanged
	{
		public TrendsHourlyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>base_app</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	是否基于当前应用来获取数据。1表示基于当前应用来获取数据。</para>
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
	}

				
								

	/// <summary>
	/// <para>获取某话题下的微博消息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/trends/statuses.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TrendsStatusesRequest : GetRequest, INotifyPropertyChanged
	{
		public TrendsStatusesRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>trend_name</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	话题关键词。</para>
		/// <para></para>
		/// </summary>
		public string TrendName
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("trend_name") ? RequestData.QueryStringValues["trend_name"].FirstOrDefault() : null; }
			set
			{
				var oldv=TrendName;
				var target = RequestData.QueryStringValues.ContainsKey("trend_name") ? RequestData.QueryStringValues["trend_name"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["trend_name"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("TrendName"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>获取某用户的话题。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/trends.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TrendsTrendsRequest : GetRequest, INotifyPropertyChanged
	{
		public TrendsTrendsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	用户id</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
			}
		}
		/// <summary>
		/// <para>page</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int，缺省值为1</para>
		/// <para>说明:</para>
		/// <para>	页码</para>
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
		/// <para>	int，缺省值为10</para>
		/// <para>说明:</para>
		/// <para>	每页返回的记录数</para>
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

				
								

	/// <summary>
	/// <para>返回最近一周内的热门话题。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/trends/weekly.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class TrendsWeeklyRequest : GetRequest, INotifyPropertyChanged
	{
		public TrendsWeeklyRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>base_app</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	是否基于当前应用来获取数据。1表示基于当前应用来获取数据。</para>
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
	}

				
								

	/// <summary>
	/// <para>更新当前登录用户所关注的某个好友的备注信息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/user/friends/update_remark.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	POST</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class UserFriendsUpdateRemarkRequest : PostRequest, INotifyPropertyChanged
	{
		public UserFriendsUpdateRemarkRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	需要修改备注信息的用户ID。</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.PostFieldValues.ContainsKey("user_id") ? RequestData.PostFieldValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.PostFieldValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	备注信息。需要URL Encode。</para>
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

				
								

	/// <summary>
	/// <para>返回系统推荐的用户列表。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/users/hot.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class UsersHotRequest : GetRequest, INotifyPropertyChanged
	{
		public UsersHotRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>category</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	分类，返回某一类别的推荐用户，默认为default。如果不在以下分类中，返回空列表：default：人气关注、ent：影视名星、music：音乐、fashion：时尚、literature：文学、business：商界、sports：体育、health：健康、auto：汽车、house：房产、trip：旅行、stock：炒股、food：美食、fate：命理、art：艺术、tech：科技、cartoon：动漫、games：游戏。</para>
		/// <para></para>
		/// </summary>
		public string Category
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("category") ? RequestData.QueryStringValues["category"].FirstOrDefault() : null; }
			set
			{
				var oldv=Category;
				var target = RequestData.QueryStringValues.ContainsKey("category") ? RequestData.QueryStringValues["category"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["category"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("Category"));
			}
		}
	}

				
								

	/// <summary>
	/// <para>按用户ID或昵称返回用户资料以及用户的最新发布的一条微博消息。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/users/show.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class UsersShowRequest : GetRequest, INotifyPropertyChanged
	{
		public UsersShowRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>:id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64/string</para>
		/// <para>说明:</para>
		/// <para>	用户ID(int64)或者昵称(string)。该参数为一个REST风格参数。调用示例见注意事项</para>
		/// <para></para>
		/// </summary>
		public string Id
		{ 
			get { return RequestData.UrlTemplateValues.ContainsKey("id") ? RequestData.UrlTemplateValues["id"] : null; }
			set
			{
				RequestData.UrlTemplateValues["id"] = value;
				if( PropertyChanged !=null )PropertyChanged(this , new PropertyChangedEventArgs("Id"));
			}
		}
		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>user_id</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int64</para>
		/// <para>说明:</para>
		/// <para>	用户ID，主要是用来区分用户ID跟微博昵称。当微博昵称为数字导致和用户ID产生歧义，特别是当微博昵称和用户ID一样的时候，建议使用该参数</para>
		/// <para></para>
		/// </summary>
		public string UserId
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"].FirstOrDefault() : null; }
			set
			{
				var oldv=UserId;
				var target = RequestData.QueryStringValues.ContainsKey("user_id") ? RequestData.QueryStringValues["user_id"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["user_id"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("UserId"));
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
		/// <para>	微博昵称，主要是用来区分用户UID跟微博昵称，当二者一样而产生歧义的时候，建议使用该参数</para>
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

				
								

	/// <summary>
	/// <para>返回当前用户可能感兴趣的用户。 </para>
	/// <para>URL:</para>
	/// <para>	http://api.t.sina.com.cn/users/suggestions.(json|xml)</para>
	/// <para>支持格式:</para>
	/// <para>	XML/JSON</para>
	/// <para>HTTP请求方式:</para>
	/// <para>	GET</para>
	/// <para>是否需要登录:</para>
	/// <para>	true  关于授权机制，参见授权机制声明</para>
	/// <para>请求数限制:</para>
	/// <para>	true  关于请求数限制，参见接口访问权限说明</para>
	/// <para></para>
	/// </summary>
	public class UsersSuggestionsRequest : GetRequest, INotifyPropertyChanged
	{
		public UsersSuggestionsRequest()
		{
		}

		public event PropertyChangedEventHandler  PropertyChanged ;

		/// <summary>
		/// <para>source</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	true</para>
		/// <para>类型及范围:</para>
		/// <para>	string</para>
		/// <para>说明:</para>
		/// <para>	申请应用时分配的AppKey，调用接口时候代表应用的唯一身份。（采用OAuth授权方式不需要此参数）</para>
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
		/// <para>with_reason</para>
		/// <para></para>
		/// <para>必选:</para>
		/// <para>	false</para>
		/// <para>类型及范围:</para>
		/// <para>	int</para>
		/// <para>说明:</para>
		/// <para>	是否返回推荐原因，可选值1/0。当值为1，返回结果中增加推荐原因，会大幅改变返回值格式。</para>
		/// <para></para>
		/// </summary>
		public string WithReason
		{ 
			get { return RequestData.QueryStringValues.ContainsKey("with_reason") ? RequestData.QueryStringValues["with_reason"].FirstOrDefault() : null; }
			set
			{
				var oldv=WithReason;
				var target = RequestData.QueryStringValues.ContainsKey("with_reason") ? RequestData.QueryStringValues["with_reason"] : new List<string> () ;
				target.Clear();
				target.Add(value);
				RequestData.QueryStringValues["with_reason"] = target;
				if( PropertyChanged !=null && oldv!=value)PropertyChanged(this , new PropertyChangedEventArgs("WithReason"));
			}
		}
	}

				
					

}
