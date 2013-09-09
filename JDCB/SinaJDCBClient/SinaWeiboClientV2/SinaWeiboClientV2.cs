 


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





	public partial class SinaWeiboClientV2:JsonClientBase
	{
		public SinaWeiboClientV2()
		{
			//TODO: Set BaseUri property Here 在这里指定服务基础地址
			BaseUri = new Uri("http://api.weibo.com/");
					
				}
		
						
	}

}

 