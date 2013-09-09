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



	
				
	[DataContract]
	public class EmotionsResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _phrase;
		[DataMember(Name = "phrase")]
		public string Phrase
		{ 
			get { return _phrase;} 
			set 
			{ 
				_phrase = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Phrase"));
			}
		}

		string _type;
		[DataMember(Name = "type")]
		public string Type
		{ 
			get { return _type;} 
			set 
			{ 
				_type = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Type"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		bool _is_hot;
		[DataMember(Name = "is_hot")]
		public bool IsHot
		{ 
			get { return _is_hot;} 
			set 
			{ 
				_is_hot = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("IsHot"));
			}
		}

		bool _is_common;
		[DataMember(Name = "is_common")]
		public bool IsCommon
		{ 
			get { return _is_common;} 
			set 
			{ 
				_is_common = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("IsCommon"));
			}
		}

		double _order_number;
		[DataMember(Name = "order_number")]
		public double OrderNumber
		{ 
			get { return _order_number;} 
			set 
			{ 
				_order_number = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("OrderNumber"));
			}
		}

		string _category;
		[DataMember(Name = "category")]
		public string Category
		{ 
			get { return _category;} 
			set 
			{ 
				_category = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Category"));
			}
		}

	}
	[CollectionDataContract]
	public class EmotionsResponse : ObservableCollection<EmotionsResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class FavoritesResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class FavoritesResponse : ObservableCollection<FavoritesResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class AccountEndSessionResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}

				
				
	[DataContract]
	public class AccountGetPrivacyResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _comment;
		[DataMember(Name = "comment")]
		public string Comment
		{ 
			get { return _comment;} 
			set 
			{ 
				_comment = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Comment"));
			}
		}

		string _dm;
		[DataMember(Name = "dm")]
		public string Dm
		{ 
			get { return _dm;} 
			set 
			{ 
				_dm = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Dm"));
			}
		}

		string _real_name;
		[DataMember(Name = "real_name")]
		public string RealName
		{ 
			get { return _real_name;} 
			set 
			{ 
				_real_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("RealName"));
			}
		}

		string _geo;
		[DataMember(Name = "geo")]
		public string Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _badge;
		[DataMember(Name = "badge")]
		public string Badge
		{ 
			get { return _badge;} 
			set 
			{ 
				_badge = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Badge"));
			}
		}

	}

				
				
	[DataContract]
	public class AccountRateLimitStatusResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _hourly_limit;
		[DataMember(Name = "hourly_limit")]
		public double HourlyLimit
		{ 
			get { return _hourly_limit;} 
			set 
			{ 
				_hourly_limit = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("HourlyLimit"));
			}
		}

		double _reset_time_in_seconds;
		[DataMember(Name = "reset_time_in_seconds")]
		public double ResetTimeInSeconds
		{ 
			get { return _reset_time_in_seconds;} 
			set 
			{ 
				_reset_time_in_seconds = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ResetTimeInSeconds"));
			}
		}

		string _reset_time;
		[DataMember(Name = "reset_time")]
		public string ResetTime
		{ 
			get { return _reset_time;} 
			set 
			{ 
				_reset_time = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ResetTime"));
			}
		}

		double _remaining_hits;
		[DataMember(Name = "remaining_hits")]
		public double RemainingHits
		{ 
			get { return _remaining_hits;} 
			set 
			{ 
				_remaining_hits = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("RemainingHits"));
			}
		}

	}

				
				
	[DataContract]
	public class AccountUpdateProfileResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}

				
				
	[DataContract]
	public class AccountUpdateProfileImageResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}

				
				
	[DataContract]
	public class AccountVerifyCredentialsResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}

				
				
	[DataContract]
	public class BlocksBlockingResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}
	[CollectionDataContract]
	public class BlocksBlockingResponse : ObservableCollection<BlocksBlockingResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class BlocksCreateResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}

				
				
	[DataContract]
	public class BlocksDestroyResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}

				
				
	[DataContract]
	public class BlocksExistsResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		bool _result;
		[DataMember(Name = "result")]
		public bool Result
		{ 
			get { return _result;} 
			set 
			{ 
				_result = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Result"));
			}
		}

	}

				
				
	[DataContract]
	public class FavoritesCreateResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class FavoritesDestroyResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class FavoritesDestroyBatchResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

	}
	[CollectionDataContract]
	public class FavoritesDestroyBatchResponse : ObservableCollection<FavoritesDestroyBatchResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class FriendshipsCreateResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}

				
				
	[DataContract]
	public class FriendshipsDestoryResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}

				
				
	[DataContract]
	public class FriendshipsDestroyResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

	}

				
				
	[DataContract]
	public class FriendshipsExistsResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		bool _friends;
		[DataMember(Name = "friends")]
		public bool Friends
		{ 
			get { return _friends;} 
			set 
			{ 
				_friends = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Friends"));
			}
		}

	}

				
				
	[DataContract]
	public class FriendshipsShowResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

	}

				
				
	[DataContract]
	public class ShortUrlExpandResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _url_short;
		[DataMember(Name = "url_short")]
		public string UrlShort
		{ 
			get { return _url_short;} 
			set 
			{ 
				_url_short = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
			}
		}

		string _url_long;
		[DataMember(Name = "url_long")]
		public string UrlLong
		{ 
			get { return _url_long;} 
			set 
			{ 
				_url_long = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlLong"));
			}
		}

		double _type;
		[DataMember(Name = "type")]
		public double Type
		{ 
			get { return _type;} 
			set 
			{ 
				_type = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Type"));
			}
		}

	}
	[CollectionDataContract]
	public class ShortUrlExpandResponse : ObservableCollection<ShortUrlExpandResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class ShortUrlShortenResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _url_short;
		[DataMember(Name = "url_short")]
		public string UrlShort
		{ 
			get { return _url_short;} 
			set 
			{ 
				_url_short = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
			}
		}

		string _url_long;
		[DataMember(Name = "url_long")]
		public string UrlLong
		{ 
			get { return _url_long;} 
			set 
			{ 
				_url_long = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlLong"));
			}
		}

		double _type;
		[DataMember(Name = "type")]
		public double Type
		{ 
			get { return _type;} 
			set 
			{ 
				_type = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Type"));
			}
		}

	}
	[CollectionDataContract]
	public class ShortUrlShortenResponse : ObservableCollection<ShortUrlShortenResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class ShortUrlCommentCommentsResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _url_short;
		[DataMember(Name = "url_short")]
		public string UrlShort
		{ 
			get { return _url_short;} 
			set 
			{ 
				_url_short = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
			}
		}

	}

				
				
	[DataContract]
	public class ShortUrlCommentCountsResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _url_short;
		[DataMember(Name = "url_short")]
		public string UrlShort
		{ 
			get { return _url_short;} 
			set 
			{ 
				_url_short = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
			}
		}

		string _comment_counts;
		[DataMember(Name = "comment_counts")]
		public string CommentCounts
		{ 
			get { return _comment_counts;} 
			set 
			{ 
				_comment_counts = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CommentCounts"));
			}
		}

	}
	[CollectionDataContract]
	public class ShortUrlCommentCountsResponse : ObservableCollection<ShortUrlCommentCountsResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class ShortUrlShareCountsResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _url_short;
		[DataMember(Name = "url_short")]
		public string UrlShort
		{ 
			get { return _url_short;} 
			set 
			{ 
				_url_short = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
			}
		}

		string _share_counts;
		[DataMember(Name = "share_counts")]
		public string ShareCounts
		{ 
			get { return _share_counts;} 
			set 
			{ 
				_share_counts = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ShareCounts"));
			}
		}

	}
	[CollectionDataContract]
	public class ShortUrlShareCountsResponse : ObservableCollection<ShortUrlShareCountsResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class ShortUrlShareStatusesResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _url_short;
		[DataMember(Name = "url_short")]
		public string UrlShort
		{ 
			get { return _url_short;} 
			set 
			{ 
				_url_short = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("UrlShort"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesCommentResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesCommentsByMeResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesCommentsByMeResponse : ObservableCollection<StatusesCommentsByMeResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesCommentsTimelineResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesCommentsTimelineResponse : ObservableCollection<StatusesCommentsTimelineResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesCommentsToMeResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesCommentsToMeResponse : ObservableCollection<StatusesCommentsToMeResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesCommentDestroyResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesCommentDestroyBatchResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesCommentDestroyBatchResponse : ObservableCollection<StatusesCommentDestroyBatchResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesCountsResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		double _comments;
		[DataMember(Name = "comments")]
		public double Comments
		{ 
			get { return _comments;} 
			set 
			{ 
				_comments = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Comments"));
			}
		}

		double _rt;
		[DataMember(Name = "rt")]
		public double Rt
		{ 
			get { return _rt;} 
			set 
			{ 
				_rt = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Rt"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesCountsResponse : ObservableCollection<StatusesCountsResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesDestoryResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesFollowersResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesFollowersResponse : ObservableCollection<StatusesFollowersResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesFriendsResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

		string _remark;
		[DataMember(Name = "remark")]
		public string Remark
		{ 
			get { return _remark;} 
			set 
			{ 
				_remark = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Remark"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesFriendsResponse : ObservableCollection<StatusesFriendsResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesFriendsTimelineResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		string _thumbnail_pic;
		[DataMember(Name = "thumbnail_pic")]
		public string ThumbnailPic
		{ 
			get { return _thumbnail_pic;} 
			set 
			{ 
				_thumbnail_pic = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
			}
		}

		string _bmiddle_pic;
		[DataMember(Name = "bmiddle_pic")]
		public string BmiddlePic
		{ 
			get { return _bmiddle_pic;} 
			set 
			{ 
				_bmiddle_pic = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
			}
		}

		string _original_pic;
		[DataMember(Name = "original_pic")]
		public string OriginalPic
		{ 
			get { return _original_pic;} 
			set 
			{ 
				_original_pic = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

		double _reposts_count;
		[DataMember(Name = "reposts_count")]
		public double RepostsCount
		{ 
			get { return _reposts_count;} 
			set 
			{ 
				_reposts_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("RepostsCount"));
			}
		}

		double _comments_count;
		[DataMember(Name = "comments_count")]
		public double CommentsCount
		{ 
			get { return _comments_count;} 
			set 
			{ 
				_comments_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CommentsCount"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesFriendsTimelineResponse : ObservableCollection<StatusesFriendsTimelineResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesPublicTimelineResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesPublicTimelineResponse : ObservableCollection<StatusesPublicTimelineResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesReplyResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesRepostResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesRepostByMeResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesRepostByMeResponse : ObservableCollection<StatusesRepostByMeResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesRepostTimelineReponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesRepostTimelineReponse : ObservableCollection<StatusesRepostTimelineReponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class StatusesResetCountResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		bool _result;
		[DataMember(Name = "result")]
		public bool Result
		{ 
			get { return _result;} 
			set 
			{ 
				_result = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Result"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesShowResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesUnreadResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _new_status;
		[DataMember(Name = "new_status")]
		public double NewStatus
		{ 
			get { return _new_status;} 
			set 
			{ 
				_new_status = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("NewStatus"));
			}
		}

		double _followers;
		[DataMember(Name = "followers")]
		public double Followers
		{ 
			get { return _followers;} 
			set 
			{ 
				_followers = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Followers"));
			}
		}

		double _status;
		[DataMember(Name = "status")]
		public double Status
		{ 
			get { return _status;} 
			set 
			{ 
				_status = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Status"));
			}
		}

		double _dm;
		[DataMember(Name = "dm")]
		public double Dm
		{ 
			get { return _dm;} 
			set 
			{ 
				_dm = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Dm"));
			}
		}

		double _mentions;
		[DataMember(Name = "mentions")]
		public double Mentions
		{ 
			get { return _mentions;} 
			set 
			{ 
				_mentions = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mentions"));
			}
		}

		double _comments;
		[DataMember(Name = "comments")]
		public double Comments
		{ 
			get { return _comments;} 
			set 
			{ 
				_comments = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Comments"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesUpdateResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesUploadResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		string _thumbnail_pic;
		[DataMember(Name = "thumbnail_pic")]
		public string ThumbnailPic
		{ 
			get { return _thumbnail_pic;} 
			set 
			{ 
				_thumbnail_pic = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
			}
		}

		string _bmiddle_pic;
		[DataMember(Name = "bmiddle_pic")]
		public string BmiddlePic
		{ 
			get { return _bmiddle_pic;} 
			set 
			{ 
				_bmiddle_pic = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
			}
		}

		string _original_pic;
		[DataMember(Name = "original_pic")]
		public string OriginalPic
		{ 
			get { return _original_pic;} 
			set 
			{ 
				_original_pic = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}

				
				
	[DataContract]
	public class StatusesUserTimelineResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class StatusesUserTimelineResponse : ObservableCollection<StatusesUserTimelineResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class TagsCreateResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _tagid;
		[DataMember(Name = "tagid")]
		public string Tagid
		{ 
			get { return _tagid;} 
			set 
			{ 
				_tagid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Tagid"));
			}
		}

	}
	[CollectionDataContract]
	public class TagsCreateResponse : ObservableCollection<TagsCreateResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class TagsDestoryBatchResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _tagid;
		[DataMember(Name = "tagid")]
		public string Tagid
		{ 
			get { return _tagid;} 
			set 
			{ 
				_tagid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Tagid"));
			}
		}

	}
	[CollectionDataContract]
	public class TagsDestoryBatchResponse : ObservableCollection<TagsDestoryBatchResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class TagsSuggestionsResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _id;
		[DataMember(Name = "id")]
		public string Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _value;
		[DataMember(Name = "value")]
		public string Value
		{ 
			get { return _value;} 
			set 
			{ 
				_value = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Value"));
			}
		}

	}
	[CollectionDataContract]
	public class TagsSuggestionsResponse : ObservableCollection<TagsSuggestionsResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class TrendsDestoryResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		bool _result;
		[DataMember(Name = "result")]
		public bool Result
		{ 
			get { return _result;} 
			set 
			{ 
				_result = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Result"));
			}
		}

	}

				
				
	[DataContract]
	public class TrendsFollowResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _topicid;
		[DataMember(Name = "topicid")]
		public string Topicid
		{ 
			get { return _topicid;} 
			set 
			{ 
				_topicid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Topicid"));
			}
		}

	}

				
				
	[DataContract]
	public class TrendsStatusesResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _text;
		[DataMember(Name = "text")]
		public string Text
		{ 
			get { return _text;} 
			set 
			{ 
				_text = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Text"));
			}
		}

		string _source;
		[DataMember(Name = "source")]
		public string Source
		{ 
			get { return _source;} 
			set 
			{ 
				_source = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Source"));
			}
		}

		bool _favorited;
		[DataMember(Name = "favorited")]
		public bool Favorited
		{ 
			get { return _favorited;} 
			set 
			{ 
				_favorited = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Favorited"));
			}
		}

		bool _truncated;
		[DataMember(Name = "truncated")]
		public bool Truncated
		{ 
			get { return _truncated;} 
			set 
			{ 
				_truncated = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Truncated"));
			}
		}

		string _in_reply_to_status_id;
		[DataMember(Name = "in_reply_to_status_id")]
		public string InReplyToStatusId
		{ 
			get { return _in_reply_to_status_id;} 
			set 
			{ 
				_in_reply_to_status_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToStatusId"));
			}
		}

		string _in_reply_to_user_id;
		[DataMember(Name = "in_reply_to_user_id")]
		public string InReplyToUserId
		{ 
			get { return _in_reply_to_user_id;} 
			set 
			{ 
				_in_reply_to_user_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToUserId"));
			}
		}

		string _in_reply_to_screen_name;
		[DataMember(Name = "in_reply_to_screen_name")]
		public string InReplyToScreenName
		{ 
			get { return _in_reply_to_screen_name;} 
			set 
			{ 
				_in_reply_to_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("InReplyToScreenName"));
			}
		}

		string _thumbnail_pic;
		[DataMember(Name = "thumbnail_pic")]
		public string ThumbnailPic
		{ 
			get { return _thumbnail_pic;} 
			set 
			{ 
				_thumbnail_pic = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ThumbnailPic"));
			}
		}

		string _bmiddle_pic;
		[DataMember(Name = "bmiddle_pic")]
		public string BmiddlePic
		{ 
			get { return _bmiddle_pic;} 
			set 
			{ 
				_bmiddle_pic = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("BmiddlePic"));
			}
		}

		string _original_pic;
		[DataMember(Name = "original_pic")]
		public string OriginalPic
		{ 
			get { return _original_pic;} 
			set 
			{ 
				_original_pic = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("OriginalPic"));
			}
		}

		Object _geo;
		[DataMember(Name = "geo")]
		public Object Geo
		{ 
			get { return _geo;} 
			set 
			{ 
				_geo = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Geo"));
			}
		}

		string _mid;
		[DataMember(Name = "mid")]
		public string Mid
		{ 
			get { return _mid;} 
			set 
			{ 
				_mid = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Mid"));
			}
		}

	}
	[CollectionDataContract]
	public class TrendsStatusesResponse : ObservableCollection<TrendsStatusesResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class TrendsTrendsResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _num;
		[DataMember(Name = "num")]
		public string Num
		{ 
			get { return _num;} 
			set 
			{ 
				_num = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Num"));
			}
		}

		string _trend_id;
		[DataMember(Name = "trend_id")]
		public string TrendId
		{ 
			get { return _trend_id;} 
			set 
			{ 
				_trend_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("TrendId"));
			}
		}

		string _hotword;
		[DataMember(Name = "hotword")]
		public string Hotword
		{ 
			get { return _hotword;} 
			set 
			{ 
				_hotword = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Hotword"));
			}
		}

	}
	[CollectionDataContract]
	public class TrendsTrendsResponse : ObservableCollection<TrendsTrendsResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class UserFriendsUpdateRemarkResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

	}

				
				
	[DataContract]
	public class UsersHotResponseArrayItem: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}
	[CollectionDataContract]
	public class UsersHotResponse : ObservableCollection<UsersHotResponseArrayItem>
	{
	}

				
				
	[DataContract]
	public class UsersShowResponse: INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler  PropertyChanged ;

		double _id;
		[DataMember(Name = "id")]
		public double Id
		{ 
			get { return _id;} 
			set 
			{ 
				_id = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Id"));
			}
		}

		string _screen_name;
		[DataMember(Name = "screen_name")]
		public string ScreenName
		{ 
			get { return _screen_name;} 
			set 
			{ 
				_screen_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ScreenName"));
			}
		}

		string _name;
		[DataMember(Name = "name")]
		public string Name
		{ 
			get { return _name;} 
			set 
			{ 
				_name = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Name"));
			}
		}

		string _province;
		[DataMember(Name = "province")]
		public string Province
		{ 
			get { return _province;} 
			set 
			{ 
				_province = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Province"));
			}
		}

		string _city;
		[DataMember(Name = "city")]
		public string City
		{ 
			get { return _city;} 
			set 
			{ 
				_city = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("City"));
			}
		}

		string _location;
		[DataMember(Name = "location")]
		public string Location
		{ 
			get { return _location;} 
			set 
			{ 
				_location = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Location"));
			}
		}

		string _description;
		[DataMember(Name = "description")]
		public string Description
		{ 
			get { return _description;} 
			set 
			{ 
				_description = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Description"));
			}
		}

		string _url;
		[DataMember(Name = "url")]
		public string Url
		{ 
			get { return _url;} 
			set 
			{ 
				_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Url"));
			}
		}

		string _profile_image_url;
		[DataMember(Name = "profile_image_url")]
		public string ProfileImageUrl
		{ 
			get { return _profile_image_url;} 
			set 
			{ 
				_profile_image_url = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("ProfileImageUrl"));
			}
		}

		string _domain;
		[DataMember(Name = "domain")]
		public string Domain
		{ 
			get { return _domain;} 
			set 
			{ 
				_domain = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Domain"));
			}
		}

		string _gender;
		[DataMember(Name = "gender")]
		public string Gender
		{ 
			get { return _gender;} 
			set 
			{ 
				_gender = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Gender"));
			}
		}

		double _followers_count;
		[DataMember(Name = "followers_count")]
		public double FollowersCount
		{ 
			get { return _followers_count;} 
			set 
			{ 
				_followers_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FollowersCount"));
			}
		}

		double _friends_count;
		[DataMember(Name = "friends_count")]
		public double FriendsCount
		{ 
			get { return _friends_count;} 
			set 
			{ 
				_friends_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FriendsCount"));
			}
		}

		double _statuses_count;
		[DataMember(Name = "statuses_count")]
		public double StatusesCount
		{ 
			get { return _statuses_count;} 
			set 
			{ 
				_statuses_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("StatusesCount"));
			}
		}

		double _favourites_count;
		[DataMember(Name = "favourites_count")]
		public double FavouritesCount
		{ 
			get { return _favourites_count;} 
			set 
			{ 
				_favourites_count = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("FavouritesCount"));
			}
		}

		string _created_at;
		[DataMember(Name = "created_at")]
		public string CreatedAt
		{ 
			get { return _created_at;} 
			set 
			{ 
				_created_at = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("CreatedAt"));
			}
		}

		bool _following;
		[DataMember(Name = "following")]
		public bool Following
		{ 
			get { return _following;} 
			set 
			{ 
				_following = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Following"));
			}
		}

		bool _allow_all_act_msg;
		[DataMember(Name = "allow_all_act_msg")]
		public bool AllowAllActMsg
		{ 
			get { return _allow_all_act_msg;} 
			set 
			{ 
				_allow_all_act_msg = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("AllowAllActMsg"));
			}
		}

		bool _geo_enabled;
		[DataMember(Name = "geo_enabled")]
		public bool GeoEnabled
		{ 
			get { return _geo_enabled;} 
			set 
			{ 
				_geo_enabled = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("GeoEnabled"));
			}
		}

		bool _verified;
		[DataMember(Name = "verified")]
		public bool Verified
		{ 
			get { return _verified;} 
			set 
			{ 
				_verified = value;
				if ( this.PropertyChanged != null )
					this.PropertyChanged (this,new PropertyChangedEventArgs ("Verified"));
			}
		}

	}

				
}
