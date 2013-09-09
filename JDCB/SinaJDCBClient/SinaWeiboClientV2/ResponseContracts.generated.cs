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

		[DataContract]
		public class ResponseArrayItem : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _category;
			[DataMember(Name = "category")]
			public string Category
			{ 
				get { return _category;} 
				set 
				{ 
					_category = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Category"));
				}
			}

			bool _common;
			[DataMember(Name = "common")]
			public bool Common
			{ 
				get { return _common;} 
				set 
				{ 
					_common = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Common"));
				}
			}

			bool _hot;
			[DataMember(Name = "hot")]
			public bool Hot
			{ 
				get { return _hot;} 
				set 
				{ 
					_hot = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Hot"));
				}
			}

			string _icon;
			[DataMember(Name = "icon")]
			public string Icon
			{ 
				get { return _icon;} 
				set 
				{ 
					_icon = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Icon"));
				}
			}

			string _phrase;
			[DataMember(Name = "phrase")]
			public string Phrase
			{ 
				get { return _phrase;} 
				set 
				{ 
					_phrase = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Phrase"));
				}
			}

			Object _picid;
			[DataMember(Name = "picid")]
			public Object Picid
			{ 
				get { return _picid;} 
				set 
				{ 
					_picid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Picid"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Value"));
				}
			}

		}

		[CollectionDataContract]
		public class Response : ObservableCollection<ResponseArrayItem>
		{
		}

	}


                
	namespace CommentsByMe
	{

					[DataContract]
					public class User : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
							}
						}

						string _idstr;
						[DataMember(Name = "idstr")]
						public string Idstr
						{ 
							get { return _idstr;} 
							set 
							{ 
								_idstr = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
							}
						}

						string _profile_url;
						[DataMember(Name = "profile_url")]
						public string ProfileUrl
						{ 
							get { return _profile_url;} 
							set 
							{ 
								_profile_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
							}
						}

						string _weihao;
						[DataMember(Name = "weihao")]
						public string Weihao
						{ 
							get { return _weihao;} 
							set 
							{ 
								_weihao = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
							}
						}

						double _verified_type;
						[DataMember(Name = "verified_type")]
						public double VerifiedType
						{ 
							get { return _verified_type;} 
							set 
							{ 
								_verified_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
							}
						}

						bool _allow_all_comment;
						[DataMember(Name = "allow_all_comment")]
						public bool AllowAllComment
						{ 
							get { return _allow_all_comment;} 
							set 
							{ 
								_allow_all_comment = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
							}
						}

						string _avatar_large;
						[DataMember(Name = "avatar_large")]
						public string AvatarLarge
						{ 
							get { return _avatar_large;} 
							set 
							{ 
								_avatar_large = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
							}
						}

						string _verified_reason;
						[DataMember(Name = "verified_reason")]
						public string VerifiedReason
						{ 
							get { return _verified_reason;} 
							set 
							{ 
								_verified_reason = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
							}
						}

						bool _follow_me;
						[DataMember(Name = "follow_me")]
						public bool FollowMe
						{ 
							get { return _follow_me;} 
							set 
							{ 
								_follow_me = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
							}
						}

						double _online_status;
						[DataMember(Name = "online_status")]
						public double OnlineStatus
						{ 
							get { return _online_status;} 
							set 
							{ 
								_online_status = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
							}
						}

						double _bi_followers_count;
						[DataMember(Name = "bi_followers_count")]
						public double BiFollowersCount
						{ 
							get { return _bi_followers_count;} 
							set 
							{ 
								_bi_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
							}
						}

						string _lang;
						[DataMember(Name = "lang")]
						public string Lang
						{ 
							get { return _lang;} 
							set 
							{ 
								_lang = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
							}
						}

						double _star;
						[DataMember(Name = "star")]
						public double Star
						{ 
							get { return _star;} 
							set 
							{ 
								_star = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
							}
						}

						double _mbtype;
						[DataMember(Name = "mbtype")]
						public double Mbtype
						{ 
							get { return _mbtype;} 
							set 
							{ 
								_mbtype = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
							}
						}

						double _mbrank;
						[DataMember(Name = "mbrank")]
						public double Mbrank
						{ 
							get { return _mbrank;} 
							set 
							{ 
								_mbrank = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
							}
						}

						double _block_word;
						[DataMember(Name = "block_word")]
						public double BlockWord
						{ 
							get { return _block_word;} 
							set 
							{ 
								_block_word = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
							}
						}

					}

					[DataContract]
					public class Visible : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _type;
						[DataMember(Name = "type")]
						public double Type
						{ 
							get { return _type;} 
							set 
							{ 
								_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
							}
						}

						double _list_id;
						[DataMember(Name = "list_id")]
						public double ListId
						{ 
							get { return _list_id;} 
							set 
							{ 
								_list_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
							}
						}

					}

				[DataContract]
				public class Status : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					double _attitudes_count;
					[DataMember(Name = "attitudes_count")]
					public double AttitudesCount
					{ 
						get { return _attitudes_count;} 
						set 
						{ 
							_attitudes_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
						}
					}

					double _mlevel;
					[DataMember(Name = "mlevel")]
					public double Mlevel
					{ 
						get { return _mlevel;} 
						set 
						{ 
							_mlevel = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
						}
					}

					Visible _visible;
					[DataMember(Name = "visible")]
					public Visible Visible
					{ 
						get { return _visible;} 
						set 
						{ 
							_visible = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
						}
					}

				}

			[DataContract]
			public class CommentsArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
					}
				}

				Status _status;
				[DataMember(Name = "status")]
				public Status Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			CommentsArrayItem[] _comments;
			[DataMember(Name = "comments")]
			public CommentsArrayItem[] Comments
			{ 
				get { return _comments;} 
				set 
				{ 
					_comments = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Comments"));
				}
			}

			bool _hasvisible;
			[DataMember(Name = "hasvisible")]
			public bool Hasvisible
			{ 
				get { return _hasvisible;} 
				set 
				{ 
					_hasvisible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Hasvisible"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace CommentsCreate
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
						}
					}

					string _profile_url;
					[DataMember(Name = "profile_url")]
					public string ProfileUrl
					{ 
						get { return _profile_url;} 
						set 
						{ 
							_profile_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
						}
					}

					string _weihao;
					[DataMember(Name = "weihao")]
					public string Weihao
					{ 
						get { return _weihao;} 
						set 
						{ 
							_weihao = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					double _verified_type;
					[DataMember(Name = "verified_type")]
					public double VerifiedType
					{ 
						get { return _verified_type;} 
						set 
						{ 
							_verified_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

					string _lang;
					[DataMember(Name = "lang")]
					public string Lang
					{ 
						get { return _lang;} 
						set 
						{ 
							_lang = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
						}
					}

					double _star;
					[DataMember(Name = "star")]
					public double Star
					{ 
						get { return _star;} 
						set 
						{ 
							_star = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
						}
					}

					double _mbtype;
					[DataMember(Name = "mbtype")]
					public double Mbtype
					{ 
						get { return _mbtype;} 
						set 
						{ 
							_mbtype = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
						}
					}

					double _mbrank;
					[DataMember(Name = "mbrank")]
					public double Mbrank
					{ 
						get { return _mbrank;} 
						set 
						{ 
							_mbrank = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
						}
					}

					double _block_word;
					[DataMember(Name = "block_word")]
					public double BlockWord
					{ 
						get { return _block_word;} 
						set 
						{ 
							_block_word = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
						}
					}

				}

				[DataContract]
				public class Visible : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _type;
					[DataMember(Name = "type")]
					public double Type
					{ 
						get { return _type;} 
						set 
						{ 
							_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
						}
					}

					double _list_id;
					[DataMember(Name = "list_id")]
					public double ListId
					{ 
						get { return _list_id;} 
						set 
						{ 
							_list_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
						}
					}

				}

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				double _attitudes_count;
				[DataMember(Name = "attitudes_count")]
				public double AttitudesCount
				{ 
					get { return _attitudes_count;} 
					set 
					{ 
						_attitudes_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
					}
				}

				double _mlevel;
				[DataMember(Name = "mlevel")]
				public double Mlevel
				{ 
					get { return _mlevel;} 
					set 
					{ 
						_mlevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
					}
				}

				Visible _visible;
				[DataMember(Name = "visible")]
				public Visible Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

		}

	}


                
	namespace CommentsDestroy
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
						}
					}

					string _profile_url;
					[DataMember(Name = "profile_url")]
					public string ProfileUrl
					{ 
						get { return _profile_url;} 
						set 
						{ 
							_profile_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
						}
					}

					string _weihao;
					[DataMember(Name = "weihao")]
					public string Weihao
					{ 
						get { return _weihao;} 
						set 
						{ 
							_weihao = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					double _verified_type;
					[DataMember(Name = "verified_type")]
					public double VerifiedType
					{ 
						get { return _verified_type;} 
						set 
						{ 
							_verified_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

					string _lang;
					[DataMember(Name = "lang")]
					public string Lang
					{ 
						get { return _lang;} 
						set 
						{ 
							_lang = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
						}
					}

					double _star;
					[DataMember(Name = "star")]
					public double Star
					{ 
						get { return _star;} 
						set 
						{ 
							_star = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
						}
					}

					double _mbtype;
					[DataMember(Name = "mbtype")]
					public double Mbtype
					{ 
						get { return _mbtype;} 
						set 
						{ 
							_mbtype = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
						}
					}

					double _mbrank;
					[DataMember(Name = "mbrank")]
					public double Mbrank
					{ 
						get { return _mbrank;} 
						set 
						{ 
							_mbrank = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
						}
					}

					double _block_word;
					[DataMember(Name = "block_word")]
					public double BlockWord
					{ 
						get { return _block_word;} 
						set 
						{ 
							_block_word = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
						}
					}

				}

				[DataContract]
				public class Visible : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _type;
					[DataMember(Name = "type")]
					public double Type
					{ 
						get { return _type;} 
						set 
						{ 
							_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
						}
					}

					double _list_id;
					[DataMember(Name = "list_id")]
					public double ListId
					{ 
						get { return _list_id;} 
						set 
						{ 
							_list_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
						}
					}

				}

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				double _attitudes_count;
				[DataMember(Name = "attitudes_count")]
				public double AttitudesCount
				{ 
					get { return _attitudes_count;} 
					set 
					{ 
						_attitudes_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
					}
				}

				double _mlevel;
				[DataMember(Name = "mlevel")]
				public double Mlevel
				{ 
					get { return _mlevel;} 
					set 
					{ 
						_mlevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
					}
				}

				Visible _visible;
				[DataMember(Name = "visible")]
				public Visible Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

		}

	}


                
	namespace CommentsDestroyBatch
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
						}
					}

					string _profile_url;
					[DataMember(Name = "profile_url")]
					public string ProfileUrl
					{ 
						get { return _profile_url;} 
						set 
						{ 
							_profile_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
						}
					}

					string _weihao;
					[DataMember(Name = "weihao")]
					public string Weihao
					{ 
						get { return _weihao;} 
						set 
						{ 
							_weihao = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					double _verified_type;
					[DataMember(Name = "verified_type")]
					public double VerifiedType
					{ 
						get { return _verified_type;} 
						set 
						{ 
							_verified_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

					string _lang;
					[DataMember(Name = "lang")]
					public string Lang
					{ 
						get { return _lang;} 
						set 
						{ 
							_lang = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
						}
					}

					double _star;
					[DataMember(Name = "star")]
					public double Star
					{ 
						get { return _star;} 
						set 
						{ 
							_star = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
						}
					}

					double _mbtype;
					[DataMember(Name = "mbtype")]
					public double Mbtype
					{ 
						get { return _mbtype;} 
						set 
						{ 
							_mbtype = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
						}
					}

					double _mbrank;
					[DataMember(Name = "mbrank")]
					public double Mbrank
					{ 
						get { return _mbrank;} 
						set 
						{ 
							_mbrank = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
						}
					}

					double _block_word;
					[DataMember(Name = "block_word")]
					public double BlockWord
					{ 
						get { return _block_word;} 
						set 
						{ 
							_block_word = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
						}
					}

				}

				[DataContract]
				public class Visible : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _type;
					[DataMember(Name = "type")]
					public double Type
					{ 
						get { return _type;} 
						set 
						{ 
							_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
						}
					}

					double _list_id;
					[DataMember(Name = "list_id")]
					public double ListId
					{ 
						get { return _list_id;} 
						set 
						{ 
							_list_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
						}
					}

				}

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				double _attitudes_count;
				[DataMember(Name = "attitudes_count")]
				public double AttitudesCount
				{ 
					get { return _attitudes_count;} 
					set 
					{ 
						_attitudes_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
					}
				}

				double _mlevel;
				[DataMember(Name = "mlevel")]
				public double Mlevel
				{ 
					get { return _mlevel;} 
					set 
					{ 
						_mlevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
					}
				}

				Visible _visible;
				[DataMember(Name = "visible")]
				public Visible Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

			}

		[DataContract]
		public class ResponseArrayItem : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

		}

		[CollectionDataContract]
		public class Response : ObservableCollection<ResponseArrayItem>
		{
		}

	}


                
	namespace CommentsMentions
	{

						[DataContract]
						public class User : INotifyPropertyChanged
						{
							public event PropertyChangedEventHandler PropertyChanged;

							double _id;
							[DataMember(Name = "id")]
							public double Id
							{ 
								get { return _id;} 
								set 
								{ 
									_id = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
								}
							}

							string _idstr;
							[DataMember(Name = "idstr")]
							public string Idstr
							{ 
								get { return _idstr;} 
								set 
								{ 
									_idstr = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
								}
							}

							string _cover_image;
							[DataMember(Name = "cover_image")]
							public string CoverImage
							{ 
								get { return _cover_image;} 
								set 
								{ 
									_cover_image = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("CoverImage"));
								}
							}

							string _profile_url;
							[DataMember(Name = "profile_url")]
							public string ProfileUrl
							{ 
								get { return _profile_url;} 
								set 
								{ 
									_profile_url = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
								}
							}

							string _weihao;
							[DataMember(Name = "weihao")]
							public string Weihao
							{ 
								get { return _weihao;} 
								set 
								{ 
									_weihao = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
								}
							}

							double _verified_type;
							[DataMember(Name = "verified_type")]
							public double VerifiedType
							{ 
								get { return _verified_type;} 
								set 
								{ 
									_verified_type = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
								}
							}

							bool _allow_all_comment;
							[DataMember(Name = "allow_all_comment")]
							public bool AllowAllComment
							{ 
								get { return _allow_all_comment;} 
								set 
								{ 
									_allow_all_comment = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
								}
							}

							string _avatar_large;
							[DataMember(Name = "avatar_large")]
							public string AvatarLarge
							{ 
								get { return _avatar_large;} 
								set 
								{ 
									_avatar_large = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
								}
							}

							string _verified_reason;
							[DataMember(Name = "verified_reason")]
							public string VerifiedReason
							{ 
								get { return _verified_reason;} 
								set 
								{ 
									_verified_reason = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
								}
							}

							bool _follow_me;
							[DataMember(Name = "follow_me")]
							public bool FollowMe
							{ 
								get { return _follow_me;} 
								set 
								{ 
									_follow_me = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
								}
							}

							double _online_status;
							[DataMember(Name = "online_status")]
							public double OnlineStatus
							{ 
								get { return _online_status;} 
								set 
								{ 
									_online_status = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
								}
							}

							double _bi_followers_count;
							[DataMember(Name = "bi_followers_count")]
							public double BiFollowersCount
							{ 
								get { return _bi_followers_count;} 
								set 
								{ 
									_bi_followers_count = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
								}
							}

							string _lang;
							[DataMember(Name = "lang")]
							public string Lang
							{ 
								get { return _lang;} 
								set 
								{ 
									_lang = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
								}
							}

							double _star;
							[DataMember(Name = "star")]
							public double Star
							{ 
								get { return _star;} 
								set 
								{ 
									_star = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
								}
							}

							double _mbtype;
							[DataMember(Name = "mbtype")]
							public double Mbtype
							{ 
								get { return _mbtype;} 
								set 
								{ 
									_mbtype = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
								}
							}

							double _mbrank;
							[DataMember(Name = "mbrank")]
							public double Mbrank
							{ 
								get { return _mbrank;} 
								set 
								{ 
									_mbrank = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
								}
							}

							double _block_word;
							[DataMember(Name = "block_word")]
							public double BlockWord
							{ 
								get { return _block_word;} 
								set 
								{ 
									_block_word = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
								}
							}

						}

					[DataContract]
					public class Visible : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _type;
						[DataMember(Name = "type")]
						public double Type
						{ 
							get { return _type;} 
							set 
							{ 
								_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
							}
						}

						double _list_id;
						[DataMember(Name = "list_id")]
						public double ListId
						{ 
							get { return _list_id;} 
							set 
							{ 
								_list_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
							}
						}

					}

					[DataContract]
					public class RetweetedStatus : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
							}
						}

						string _idstr;
						[DataMember(Name = "idstr")]
						public string Idstr
						{ 
							get { return _idstr;} 
							set 
							{ 
								_idstr = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
							}
						}

						User _user;
						[DataMember(Name = "user")]
						public User User
						{ 
							get { return _user;} 
							set 
							{ 
								_user = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
							}
						}

						double _attitudes_count;
						[DataMember(Name = "attitudes_count")]
						public double AttitudesCount
						{ 
							get { return _attitudes_count;} 
							set 
							{ 
								_attitudes_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
							}
						}

						double _mlevel;
						[DataMember(Name = "mlevel")]
						public double Mlevel
						{ 
							get { return _mlevel;} 
							set 
							{ 
								_mlevel = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
							}
						}

						Visible _visible;
						[DataMember(Name = "visible")]
						public Visible Visible
						{ 
							get { return _visible;} 
							set 
							{ 
								_visible = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
							}
						}

					}

				[DataContract]
				public class Status : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
						}
					}

					RetweetedStatus _retweeted_status;
					[DataMember(Name = "retweeted_status")]
					public RetweetedStatus RetweetedStatus
					{ 
						get { return _retweeted_status;} 
						set 
						{ 
							_retweeted_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("RetweetedStatus"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					double _attitudes_count;
					[DataMember(Name = "attitudes_count")]
					public double AttitudesCount
					{ 
						get { return _attitudes_count;} 
						set 
						{ 
							_attitudes_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
						}
					}

					double _mlevel;
					[DataMember(Name = "mlevel")]
					public double Mlevel
					{ 
						get { return _mlevel;} 
						set 
						{ 
							_mlevel = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
						}
					}

					Visible _visible;
					[DataMember(Name = "visible")]
					public Visible Visible
					{ 
						get { return _visible;} 
						set 
						{ 
							_visible = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
						}
					}

				}

			[DataContract]
			public class CommentsArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
					}
				}

				Status _status;
				[DataMember(Name = "status")]
				public Status Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			CommentsArrayItem[] _comments;
			[DataMember(Name = "comments")]
			public CommentsArrayItem[] Comments
			{ 
				get { return _comments;} 
				set 
				{ 
					_comments = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Comments"));
				}
			}

			bool _hasvisible;
			[DataMember(Name = "hasvisible")]
			public bool Hasvisible
			{ 
				get { return _hasvisible;} 
				set 
				{ 
					_hasvisible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Hasvisible"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace CommentsReply
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
						}
					}

					string _profile_url;
					[DataMember(Name = "profile_url")]
					public string ProfileUrl
					{ 
						get { return _profile_url;} 
						set 
						{ 
							_profile_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
						}
					}

					string _weihao;
					[DataMember(Name = "weihao")]
					public string Weihao
					{ 
						get { return _weihao;} 
						set 
						{ 
							_weihao = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					double _verified_type;
					[DataMember(Name = "verified_type")]
					public double VerifiedType
					{ 
						get { return _verified_type;} 
						set 
						{ 
							_verified_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

					string _lang;
					[DataMember(Name = "lang")]
					public string Lang
					{ 
						get { return _lang;} 
						set 
						{ 
							_lang = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
						}
					}

					double _star;
					[DataMember(Name = "star")]
					public double Star
					{ 
						get { return _star;} 
						set 
						{ 
							_star = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
						}
					}

					double _mbtype;
					[DataMember(Name = "mbtype")]
					public double Mbtype
					{ 
						get { return _mbtype;} 
						set 
						{ 
							_mbtype = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
						}
					}

					double _mbrank;
					[DataMember(Name = "mbrank")]
					public double Mbrank
					{ 
						get { return _mbrank;} 
						set 
						{ 
							_mbrank = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
						}
					}

					double _block_word;
					[DataMember(Name = "block_word")]
					public double BlockWord
					{ 
						get { return _block_word;} 
						set 
						{ 
							_block_word = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
						}
					}

				}

				[DataContract]
				public class Visible : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _type;
					[DataMember(Name = "type")]
					public double Type
					{ 
						get { return _type;} 
						set 
						{ 
							_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
						}
					}

					double _list_id;
					[DataMember(Name = "list_id")]
					public double ListId
					{ 
						get { return _list_id;} 
						set 
						{ 
							_list_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
						}
					}

				}

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				double _attitudes_count;
				[DataMember(Name = "attitudes_count")]
				public double AttitudesCount
				{ 
					get { return _attitudes_count;} 
					set 
					{ 
						_attitudes_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
					}
				}

				double _mlevel;
				[DataMember(Name = "mlevel")]
				public double Mlevel
				{ 
					get { return _mlevel;} 
					set 
					{ 
						_mlevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
					}
				}

				Visible _visible;
				[DataMember(Name = "visible")]
				public Visible Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

			}

			[DataContract]
			public class ReplyComment : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

			ReplyComment _reply_comment;
			[DataMember(Name = "reply_comment")]
			public ReplyComment ReplyComment
			{ 
				get { return _reply_comment;} 
				set 
				{ 
					_reply_comment = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("ReplyComment"));
				}
			}

		}

	}


                
	namespace CommentsShow
	{

					[DataContract]
					public class User : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
							}
						}

						string _idstr;
						[DataMember(Name = "idstr")]
						public string Idstr
						{ 
							get { return _idstr;} 
							set 
							{ 
								_idstr = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
							}
						}

						string _profile_url;
						[DataMember(Name = "profile_url")]
						public string ProfileUrl
						{ 
							get { return _profile_url;} 
							set 
							{ 
								_profile_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
							}
						}

						string _weihao;
						[DataMember(Name = "weihao")]
						public string Weihao
						{ 
							get { return _weihao;} 
							set 
							{ 
								_weihao = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
							}
						}

						double _verified_type;
						[DataMember(Name = "verified_type")]
						public double VerifiedType
						{ 
							get { return _verified_type;} 
							set 
							{ 
								_verified_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
							}
						}

						bool _allow_all_comment;
						[DataMember(Name = "allow_all_comment")]
						public bool AllowAllComment
						{ 
							get { return _allow_all_comment;} 
							set 
							{ 
								_allow_all_comment = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
							}
						}

						string _avatar_large;
						[DataMember(Name = "avatar_large")]
						public string AvatarLarge
						{ 
							get { return _avatar_large;} 
							set 
							{ 
								_avatar_large = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
							}
						}

						string _verified_reason;
						[DataMember(Name = "verified_reason")]
						public string VerifiedReason
						{ 
							get { return _verified_reason;} 
							set 
							{ 
								_verified_reason = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
							}
						}

						bool _follow_me;
						[DataMember(Name = "follow_me")]
						public bool FollowMe
						{ 
							get { return _follow_me;} 
							set 
							{ 
								_follow_me = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
							}
						}

						double _online_status;
						[DataMember(Name = "online_status")]
						public double OnlineStatus
						{ 
							get { return _online_status;} 
							set 
							{ 
								_online_status = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
							}
						}

						double _bi_followers_count;
						[DataMember(Name = "bi_followers_count")]
						public double BiFollowersCount
						{ 
							get { return _bi_followers_count;} 
							set 
							{ 
								_bi_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
							}
						}

						string _lang;
						[DataMember(Name = "lang")]
						public string Lang
						{ 
							get { return _lang;} 
							set 
							{ 
								_lang = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
							}
						}

						double _star;
						[DataMember(Name = "star")]
						public double Star
						{ 
							get { return _star;} 
							set 
							{ 
								_star = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
							}
						}

						double _mbtype;
						[DataMember(Name = "mbtype")]
						public double Mbtype
						{ 
							get { return _mbtype;} 
							set 
							{ 
								_mbtype = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
							}
						}

						double _mbrank;
						[DataMember(Name = "mbrank")]
						public double Mbrank
						{ 
							get { return _mbrank;} 
							set 
							{ 
								_mbrank = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
							}
						}

						double _block_word;
						[DataMember(Name = "block_word")]
						public double BlockWord
						{ 
							get { return _block_word;} 
							set 
							{ 
								_block_word = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
							}
						}

					}

					[DataContract]
					public class Visible : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _type;
						[DataMember(Name = "type")]
						public double Type
						{ 
							get { return _type;} 
							set 
							{ 
								_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
							}
						}

						double _list_id;
						[DataMember(Name = "list_id")]
						public double ListId
						{ 
							get { return _list_id;} 
							set 
							{ 
								_list_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
							}
						}

					}

				[DataContract]
				public class Status : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					double _attitudes_count;
					[DataMember(Name = "attitudes_count")]
					public double AttitudesCount
					{ 
						get { return _attitudes_count;} 
						set 
						{ 
							_attitudes_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
						}
					}

					double _mlevel;
					[DataMember(Name = "mlevel")]
					public double Mlevel
					{ 
						get { return _mlevel;} 
						set 
						{ 
							_mlevel = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
						}
					}

					Visible _visible;
					[DataMember(Name = "visible")]
					public Visible Visible
					{ 
						get { return _visible;} 
						set 
						{ 
							_visible = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
						}
					}

				}

			[DataContract]
			public class CommentsArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
					}
				}

				Status _status;
				[DataMember(Name = "status")]
				public Status Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			CommentsArrayItem[] _comments;
			[DataMember(Name = "comments")]
			public CommentsArrayItem[] Comments
			{ 
				get { return _comments;} 
				set 
				{ 
					_comments = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Comments"));
				}
			}

			Object[] _marks;
			[DataMember(Name = "marks")]
			public Object[] Marks
			{ 
				get { return _marks;} 
				set 
				{ 
					_marks = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Marks"));
				}
			}

			bool _hasvisible;
			[DataMember(Name = "hasvisible")]
			public bool Hasvisible
			{ 
				get { return _hasvisible;} 
				set 
				{ 
					_hasvisible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Hasvisible"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace CommentsShowBatch
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
						}
					}

					string _profile_url;
					[DataMember(Name = "profile_url")]
					public string ProfileUrl
					{ 
						get { return _profile_url;} 
						set 
						{ 
							_profile_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
						}
					}

					string _weihao;
					[DataMember(Name = "weihao")]
					public string Weihao
					{ 
						get { return _weihao;} 
						set 
						{ 
							_weihao = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					double _verified_type;
					[DataMember(Name = "verified_type")]
					public double VerifiedType
					{ 
						get { return _verified_type;} 
						set 
						{ 
							_verified_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

					string _lang;
					[DataMember(Name = "lang")]
					public string Lang
					{ 
						get { return _lang;} 
						set 
						{ 
							_lang = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
						}
					}

					double _star;
					[DataMember(Name = "star")]
					public double Star
					{ 
						get { return _star;} 
						set 
						{ 
							_star = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
						}
					}

					double _mbtype;
					[DataMember(Name = "mbtype")]
					public double Mbtype
					{ 
						get { return _mbtype;} 
						set 
						{ 
							_mbtype = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
						}
					}

					double _mbrank;
					[DataMember(Name = "mbrank")]
					public double Mbrank
					{ 
						get { return _mbrank;} 
						set 
						{ 
							_mbrank = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
						}
					}

					double _block_word;
					[DataMember(Name = "block_word")]
					public double BlockWord
					{ 
						get { return _block_word;} 
						set 
						{ 
							_block_word = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
						}
					}

				}

				[DataContract]
				public class Visible : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _type;
					[DataMember(Name = "type")]
					public double Type
					{ 
						get { return _type;} 
						set 
						{ 
							_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
						}
					}

					double _list_id;
					[DataMember(Name = "list_id")]
					public double ListId
					{ 
						get { return _list_id;} 
						set 
						{ 
							_list_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
						}
					}

				}

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				double _attitudes_count;
				[DataMember(Name = "attitudes_count")]
				public double AttitudesCount
				{ 
					get { return _attitudes_count;} 
					set 
					{ 
						_attitudes_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
					}
				}

				double _mlevel;
				[DataMember(Name = "mlevel")]
				public double Mlevel
				{ 
					get { return _mlevel;} 
					set 
					{ 
						_mlevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
					}
				}

				Visible _visible;
				[DataMember(Name = "visible")]
				public Visible Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

			}

		[DataContract]
		public class ResponseArrayItem : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

		}

		[CollectionDataContract]
		public class Response : ObservableCollection<ResponseArrayItem>
		{
		}

	}


                
	namespace CommentsTimeline
	{

					[DataContract]
					public class User : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
							}
						}

						string _idstr;
						[DataMember(Name = "idstr")]
						public string Idstr
						{ 
							get { return _idstr;} 
							set 
							{ 
								_idstr = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
							}
						}

						string _profile_url;
						[DataMember(Name = "profile_url")]
						public string ProfileUrl
						{ 
							get { return _profile_url;} 
							set 
							{ 
								_profile_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
							}
						}

						string _weihao;
						[DataMember(Name = "weihao")]
						public string Weihao
						{ 
							get { return _weihao;} 
							set 
							{ 
								_weihao = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
							}
						}

						double _verified_type;
						[DataMember(Name = "verified_type")]
						public double VerifiedType
						{ 
							get { return _verified_type;} 
							set 
							{ 
								_verified_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
							}
						}

						bool _allow_all_comment;
						[DataMember(Name = "allow_all_comment")]
						public bool AllowAllComment
						{ 
							get { return _allow_all_comment;} 
							set 
							{ 
								_allow_all_comment = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
							}
						}

						string _avatar_large;
						[DataMember(Name = "avatar_large")]
						public string AvatarLarge
						{ 
							get { return _avatar_large;} 
							set 
							{ 
								_avatar_large = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
							}
						}

						string _verified_reason;
						[DataMember(Name = "verified_reason")]
						public string VerifiedReason
						{ 
							get { return _verified_reason;} 
							set 
							{ 
								_verified_reason = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
							}
						}

						bool _follow_me;
						[DataMember(Name = "follow_me")]
						public bool FollowMe
						{ 
							get { return _follow_me;} 
							set 
							{ 
								_follow_me = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
							}
						}

						double _online_status;
						[DataMember(Name = "online_status")]
						public double OnlineStatus
						{ 
							get { return _online_status;} 
							set 
							{ 
								_online_status = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
							}
						}

						double _bi_followers_count;
						[DataMember(Name = "bi_followers_count")]
						public double BiFollowersCount
						{ 
							get { return _bi_followers_count;} 
							set 
							{ 
								_bi_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
							}
						}

						string _lang;
						[DataMember(Name = "lang")]
						public string Lang
						{ 
							get { return _lang;} 
							set 
							{ 
								_lang = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
							}
						}

						double _star;
						[DataMember(Name = "star")]
						public double Star
						{ 
							get { return _star;} 
							set 
							{ 
								_star = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
							}
						}

						double _mbtype;
						[DataMember(Name = "mbtype")]
						public double Mbtype
						{ 
							get { return _mbtype;} 
							set 
							{ 
								_mbtype = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
							}
						}

						double _mbrank;
						[DataMember(Name = "mbrank")]
						public double Mbrank
						{ 
							get { return _mbrank;} 
							set 
							{ 
								_mbrank = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
							}
						}

						double _block_word;
						[DataMember(Name = "block_word")]
						public double BlockWord
						{ 
							get { return _block_word;} 
							set 
							{ 
								_block_word = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
							}
						}

					}

					[DataContract]
					public class Visible : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _type;
						[DataMember(Name = "type")]
						public double Type
						{ 
							get { return _type;} 
							set 
							{ 
								_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
							}
						}

						double _list_id;
						[DataMember(Name = "list_id")]
						public double ListId
						{ 
							get { return _list_id;} 
							set 
							{ 
								_list_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
							}
						}

					}

				[DataContract]
				public class Status : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					double _attitudes_count;
					[DataMember(Name = "attitudes_count")]
					public double AttitudesCount
					{ 
						get { return _attitudes_count;} 
						set 
						{ 
							_attitudes_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
						}
					}

					double _mlevel;
					[DataMember(Name = "mlevel")]
					public double Mlevel
					{ 
						get { return _mlevel;} 
						set 
						{ 
							_mlevel = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
						}
					}

					Visible _visible;
					[DataMember(Name = "visible")]
					public Visible Visible
					{ 
						get { return _visible;} 
						set 
						{ 
							_visible = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
						}
					}

				}

				[DataContract]
				public class ReplyComment : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
						}
					}

				}

			[DataContract]
			public class CommentsArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
					}
				}

				Status _status;
				[DataMember(Name = "status")]
				public Status Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
					}
				}

				ReplyComment _reply_comment;
				[DataMember(Name = "reply_comment")]
				public ReplyComment ReplyComment
				{ 
					get { return _reply_comment;} 
					set 
					{ 
						_reply_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ReplyComment"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			CommentsArrayItem[] _comments;
			[DataMember(Name = "comments")]
			public CommentsArrayItem[] Comments
			{ 
				get { return _comments;} 
				set 
				{ 
					_comments = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Comments"));
				}
			}

			bool _hasvisible;
			[DataMember(Name = "hasvisible")]
			public bool Hasvisible
			{ 
				get { return _hasvisible;} 
				set 
				{ 
					_hasvisible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Hasvisible"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace CommentsToMe
	{

					[DataContract]
					public class User : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
							}
						}

						string _idstr;
						[DataMember(Name = "idstr")]
						public string Idstr
						{ 
							get { return _idstr;} 
							set 
							{ 
								_idstr = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
							}
						}

						string _profile_url;
						[DataMember(Name = "profile_url")]
						public string ProfileUrl
						{ 
							get { return _profile_url;} 
							set 
							{ 
								_profile_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
							}
						}

						string _weihao;
						[DataMember(Name = "weihao")]
						public string Weihao
						{ 
							get { return _weihao;} 
							set 
							{ 
								_weihao = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
							}
						}

						double _verified_type;
						[DataMember(Name = "verified_type")]
						public double VerifiedType
						{ 
							get { return _verified_type;} 
							set 
							{ 
								_verified_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
							}
						}

						bool _allow_all_comment;
						[DataMember(Name = "allow_all_comment")]
						public bool AllowAllComment
						{ 
							get { return _allow_all_comment;} 
							set 
							{ 
								_allow_all_comment = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
							}
						}

						string _avatar_large;
						[DataMember(Name = "avatar_large")]
						public string AvatarLarge
						{ 
							get { return _avatar_large;} 
							set 
							{ 
								_avatar_large = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
							}
						}

						string _verified_reason;
						[DataMember(Name = "verified_reason")]
						public string VerifiedReason
						{ 
							get { return _verified_reason;} 
							set 
							{ 
								_verified_reason = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
							}
						}

						bool _follow_me;
						[DataMember(Name = "follow_me")]
						public bool FollowMe
						{ 
							get { return _follow_me;} 
							set 
							{ 
								_follow_me = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
							}
						}

						double _online_status;
						[DataMember(Name = "online_status")]
						public double OnlineStatus
						{ 
							get { return _online_status;} 
							set 
							{ 
								_online_status = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
							}
						}

						double _bi_followers_count;
						[DataMember(Name = "bi_followers_count")]
						public double BiFollowersCount
						{ 
							get { return _bi_followers_count;} 
							set 
							{ 
								_bi_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
							}
						}

						string _lang;
						[DataMember(Name = "lang")]
						public string Lang
						{ 
							get { return _lang;} 
							set 
							{ 
								_lang = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
							}
						}

						double _star;
						[DataMember(Name = "star")]
						public double Star
						{ 
							get { return _star;} 
							set 
							{ 
								_star = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
							}
						}

						double _mbtype;
						[DataMember(Name = "mbtype")]
						public double Mbtype
						{ 
							get { return _mbtype;} 
							set 
							{ 
								_mbtype = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
							}
						}

						double _mbrank;
						[DataMember(Name = "mbrank")]
						public double Mbrank
						{ 
							get { return _mbrank;} 
							set 
							{ 
								_mbrank = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
							}
						}

						double _block_word;
						[DataMember(Name = "block_word")]
						public double BlockWord
						{ 
							get { return _block_word;} 
							set 
							{ 
								_block_word = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
							}
						}

					}

					[DataContract]
					public class Geo : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						string _type;
						[DataMember(Name = "type")]
						public string Type
						{ 
							get { return _type;} 
							set 
							{ 
								_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
							}
						}

						Double[] _coordinates;
						[DataMember(Name = "coordinates")]
						public Double[] Coordinates
						{ 
							get { return _coordinates;} 
							set 
							{ 
								_coordinates = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Coordinates"));
							}
						}

					}

					[DataContract]
					public class Visible : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _type;
						[DataMember(Name = "type")]
						public double Type
						{ 
							get { return _type;} 
							set 
							{ 
								_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
							}
						}

						double _list_id;
						[DataMember(Name = "list_id")]
						public double ListId
						{ 
							get { return _list_id;} 
							set 
							{ 
								_list_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
							}
						}

					}

				[DataContract]
				public class Status : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
						}
					}

					Geo _geo;
					[DataMember(Name = "geo")]
					public Geo Geo
					{ 
						get { return _geo;} 
						set 
						{ 
							_geo = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					double _attitudes_count;
					[DataMember(Name = "attitudes_count")]
					public double AttitudesCount
					{ 
						get { return _attitudes_count;} 
						set 
						{ 
							_attitudes_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
						}
					}

					double _mlevel;
					[DataMember(Name = "mlevel")]
					public double Mlevel
					{ 
						get { return _mlevel;} 
						set 
						{ 
							_mlevel = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
						}
					}

					Visible _visible;
					[DataMember(Name = "visible")]
					public Visible Visible
					{ 
						get { return _visible;} 
						set 
						{ 
							_visible = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
						}
					}

				}

				[DataContract]
				public class ReplyComment : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
						}
					}

				}

			[DataContract]
			public class CommentsArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
					}
				}

				Status _status;
				[DataMember(Name = "status")]
				public Status Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
					}
				}

				ReplyComment _reply_comment;
				[DataMember(Name = "reply_comment")]
				public ReplyComment ReplyComment
				{ 
					get { return _reply_comment;} 
					set 
					{ 
						_reply_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ReplyComment"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			CommentsArrayItem[] _comments;
			[DataMember(Name = "comments")]
			public CommentsArrayItem[] Comments
			{ 
				get { return _comments;} 
				set 
				{ 
					_comments = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Comments"));
				}
			}

			bool _hasvisible;
			[DataMember(Name = "hasvisible")]
			public bool Hasvisible
			{ 
				get { return _hasvisible;} 
				set 
				{ 
					_hasvisible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Hasvisible"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsCreate
	{

				[DataContract]
				public class Visible : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _type;
					[DataMember(Name = "type")]
					public double Type
					{ 
						get { return _type;} 
						set 
						{ 
							_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
						}
					}

					double _list_id;
					[DataMember(Name = "list_id")]
					public double ListId
					{ 
						get { return _list_id;} 
						set 
						{ 
							_list_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
						}
					}

				}

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				double _attitudes_count;
				[DataMember(Name = "attitudes_count")]
				public double AttitudesCount
				{ 
					get { return _attitudes_count;} 
					set 
					{ 
						_attitudes_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
					}
				}

				double _mlevel;
				[DataMember(Name = "mlevel")]
				public double Mlevel
				{ 
					get { return _mlevel;} 
					set 
					{ 
						_mlevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
					}
				}

				Visible _visible;
				[DataMember(Name = "visible")]
				public Visible Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
				}
			}

			string _profile_url;
			[DataMember(Name = "profile_url")]
			public string ProfileUrl
			{ 
				get { return _profile_url;} 
				set 
				{ 
					_profile_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
				}
			}

			string _weihao;
			[DataMember(Name = "weihao")]
			public string Weihao
			{ 
				get { return _weihao;} 
				set 
				{ 
					_weihao = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
				}
			}

			double _verified_type;
			[DataMember(Name = "verified_type")]
			public double VerifiedType
			{ 
				get { return _verified_type;} 
				set 
				{ 
					_verified_type = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

			bool _allow_all_comment;
			[DataMember(Name = "allow_all_comment")]
			public bool AllowAllComment
			{ 
				get { return _allow_all_comment;} 
				set 
				{ 
					_allow_all_comment = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
				}
			}

			string _avatar_large;
			[DataMember(Name = "avatar_large")]
			public string AvatarLarge
			{ 
				get { return _avatar_large;} 
				set 
				{ 
					_avatar_large = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
				}
			}

			string _verified_reason;
			[DataMember(Name = "verified_reason")]
			public string VerifiedReason
			{ 
				get { return _verified_reason;} 
				set 
				{ 
					_verified_reason = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
				}
			}

			bool _follow_me;
			[DataMember(Name = "follow_me")]
			public bool FollowMe
			{ 
				get { return _follow_me;} 
				set 
				{ 
					_follow_me = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
				}
			}

			double _online_status;
			[DataMember(Name = "online_status")]
			public double OnlineStatus
			{ 
				get { return _online_status;} 
				set 
				{ 
					_online_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
				}
			}

			double _bi_followers_count;
			[DataMember(Name = "bi_followers_count")]
			public double BiFollowersCount
			{ 
				get { return _bi_followers_count;} 
				set 
				{ 
					_bi_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
				}
			}

			string _lang;
			[DataMember(Name = "lang")]
			public string Lang
			{ 
				get { return _lang;} 
				set 
				{ 
					_lang = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
				}
			}

			double _star;
			[DataMember(Name = "star")]
			public double Star
			{ 
				get { return _star;} 
				set 
				{ 
					_star = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
				}
			}

			double _mbtype;
			[DataMember(Name = "mbtype")]
			public double Mbtype
			{ 
				get { return _mbtype;} 
				set 
				{ 
					_mbtype = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
				}
			}

			double _mbrank;
			[DataMember(Name = "mbrank")]
			public double Mbrank
			{ 
				get { return _mbrank;} 
				set 
				{ 
					_mbrank = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
				}
			}

			double _block_word;
			[DataMember(Name = "block_word")]
			public double BlockWord
			{ 
				get { return _block_word;} 
				set 
				{ 
					_block_word = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
				}
			}

		}

	}


                
	namespace FriendshipsDestroy
	{

				[DataContract]
				public class Visible : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _type;
					[DataMember(Name = "type")]
					public double Type
					{ 
						get { return _type;} 
						set 
						{ 
							_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
						}
					}

					double _list_id;
					[DataMember(Name = "list_id")]
					public double ListId
					{ 
						get { return _list_id;} 
						set 
						{ 
							_list_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
						}
					}

				}

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				double _attitudes_count;
				[DataMember(Name = "attitudes_count")]
				public double AttitudesCount
				{ 
					get { return _attitudes_count;} 
					set 
					{ 
						_attitudes_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
					}
				}

				double _mlevel;
				[DataMember(Name = "mlevel")]
				public double Mlevel
				{ 
					get { return _mlevel;} 
					set 
					{ 
						_mlevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
					}
				}

				Visible _visible;
				[DataMember(Name = "visible")]
				public Visible Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
				}
			}

			string _profile_url;
			[DataMember(Name = "profile_url")]
			public string ProfileUrl
			{ 
				get { return _profile_url;} 
				set 
				{ 
					_profile_url = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
				}
			}

			string _weihao;
			[DataMember(Name = "weihao")]
			public string Weihao
			{ 
				get { return _weihao;} 
				set 
				{ 
					_weihao = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
				}
			}

			double _verified_type;
			[DataMember(Name = "verified_type")]
			public double VerifiedType
			{ 
				get { return _verified_type;} 
				set 
				{ 
					_verified_type = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

			bool _allow_all_comment;
			[DataMember(Name = "allow_all_comment")]
			public bool AllowAllComment
			{ 
				get { return _allow_all_comment;} 
				set 
				{ 
					_allow_all_comment = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
				}
			}

			string _avatar_large;
			[DataMember(Name = "avatar_large")]
			public string AvatarLarge
			{ 
				get { return _avatar_large;} 
				set 
				{ 
					_avatar_large = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
				}
			}

			string _verified_reason;
			[DataMember(Name = "verified_reason")]
			public string VerifiedReason
			{ 
				get { return _verified_reason;} 
				set 
				{ 
					_verified_reason = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
				}
			}

			bool _follow_me;
			[DataMember(Name = "follow_me")]
			public bool FollowMe
			{ 
				get { return _follow_me;} 
				set 
				{ 
					_follow_me = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
				}
			}

			double _online_status;
			[DataMember(Name = "online_status")]
			public double OnlineStatus
			{ 
				get { return _online_status;} 
				set 
				{ 
					_online_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
				}
			}

			double _bi_followers_count;
			[DataMember(Name = "bi_followers_count")]
			public double BiFollowersCount
			{ 
				get { return _bi_followers_count;} 
				set 
				{ 
					_bi_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
				}
			}

			string _lang;
			[DataMember(Name = "lang")]
			public string Lang
			{ 
				get { return _lang;} 
				set 
				{ 
					_lang = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
				}
			}

			double _star;
			[DataMember(Name = "star")]
			public double Star
			{ 
				get { return _star;} 
				set 
				{ 
					_star = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
				}
			}

			double _mbtype;
			[DataMember(Name = "mbtype")]
			public double Mbtype
			{ 
				get { return _mbtype;} 
				set 
				{ 
					_mbtype = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
				}
			}

			double _mbrank;
			[DataMember(Name = "mbrank")]
			public double Mbrank
			{ 
				get { return _mbrank;} 
				set 
				{ 
					_mbrank = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
				}
			}

			double _block_word;
			[DataMember(Name = "block_word")]
			public double BlockWord
			{ 
				get { return _block_word;} 
				set 
				{ 
					_block_word = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
				}
			}

		}

	}


                
	namespace FriendshipsFollowers
	{

			[DataContract]
			public class UsersArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				double _status_id;
				[DataMember(Name = "status_id")]
				public double StatusId
				{ 
					get { return _status_id;} 
					set 
					{ 
						_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusId"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _star;
				[DataMember(Name = "star")]
				public double Star
				{ 
					get { return _star;} 
					set 
					{ 
						_star = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
					}
				}

				double _mbtype;
				[DataMember(Name = "mbtype")]
				public double Mbtype
				{ 
					get { return _mbtype;} 
					set 
					{ 
						_mbtype = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
					}
				}

				double _mbrank;
				[DataMember(Name = "mbrank")]
				public double Mbrank
				{ 
					get { return _mbrank;} 
					set 
					{ 
						_mbrank = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
					}
				}

				double _block_word;
				[DataMember(Name = "block_word")]
				public double BlockWord
				{ 
					get { return _block_word;} 
					set 
					{ 
						_block_word = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			UsersArrayItem[] _users;
			[DataMember(Name = "users")]
			public UsersArrayItem[] Users
			{ 
				get { return _users;} 
				set 
				{ 
					_users = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Users"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsFriends
	{

			[DataContract]
			public class UsersArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				double _status_id;
				[DataMember(Name = "status_id")]
				public double StatusId
				{ 
					get { return _status_id;} 
					set 
					{ 
						_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusId"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _star;
				[DataMember(Name = "star")]
				public double Star
				{ 
					get { return _star;} 
					set 
					{ 
						_star = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
					}
				}

				double _mbtype;
				[DataMember(Name = "mbtype")]
				public double Mbtype
				{ 
					get { return _mbtype;} 
					set 
					{ 
						_mbtype = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
					}
				}

				double _mbrank;
				[DataMember(Name = "mbrank")]
				public double Mbrank
				{ 
					get { return _mbrank;} 
					set 
					{ 
						_mbrank = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
					}
				}

				double _block_word;
				[DataMember(Name = "block_word")]
				public double BlockWord
				{ 
					get { return _block_word;} 
					set 
					{ 
						_block_word = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			UsersArrayItem[] _users;
			[DataMember(Name = "users")]
			public UsersArrayItem[] Users
			{ 
				get { return _users;} 
				set 
				{ 
					_users = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Users"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsGroups
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
						}
					}

					string _profile_url;
					[DataMember(Name = "profile_url")]
					public string ProfileUrl
					{ 
						get { return _profile_url;} 
						set 
						{ 
							_profile_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
						}
					}

					string _weihao;
					[DataMember(Name = "weihao")]
					public string Weihao
					{ 
						get { return _weihao;} 
						set 
						{ 
							_weihao = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					double _verified_type;
					[DataMember(Name = "verified_type")]
					public double VerifiedType
					{ 
						get { return _verified_type;} 
						set 
						{ 
							_verified_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

					string _lang;
					[DataMember(Name = "lang")]
					public string Lang
					{ 
						get { return _lang;} 
						set 
						{ 
							_lang = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
						}
					}

				}

			[DataContract]
			public class ListsArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
					}
				}

				string _mode;
				[DataMember(Name = "mode")]
				public string Mode
				{ 
					get { return _mode;} 
					set 
					{ 
						_mode = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mode"));
					}
				}

				double _visible;
				[DataMember(Name = "visible")]
				public double Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

				double _like_count;
				[DataMember(Name = "like_count")]
				public double LikeCount
				{ 
					get { return _like_count;} 
					set 
					{ 
						_like_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("LikeCount"));
					}
				}

				double _member_count;
				[DataMember(Name = "member_count")]
				public double MemberCount
				{ 
					get { return _member_count;} 
					set 
					{ 
						_member_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("MemberCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
					}
				}

				Object[] _tags;
				[DataMember(Name = "tags")]
				public Object[] Tags
				{ 
					get { return _tags;} 
					set 
					{ 
						_tags = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Tags"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			ListsArrayItem[] _lists;
			[DataMember(Name = "lists")]
			public ListsArrayItem[] Lists
			{ 
				get { return _lists;} 
				set 
				{ 
					_lists = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Lists"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsShow
	{

			[DataContract]
			public class Source : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				bool _followed_by;
				[DataMember(Name = "followed_by")]
				public bool FollowedBy
				{ 
					get { return _followed_by;} 
					set 
					{ 
						_followed_by = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowedBy"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				bool _notifications_enabled;
				[DataMember(Name = "notifications_enabled")]
				public bool NotificationsEnabled
				{ 
					get { return _notifications_enabled;} 
					set 
					{ 
						_notifications_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("NotificationsEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
					}
				}

			}

			[DataContract]
			public class Target : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				bool _followed_by;
				[DataMember(Name = "followed_by")]
				public bool FollowedBy
				{ 
					get { return _followed_by;} 
					set 
					{ 
						_followed_by = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowedBy"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				bool _notifications_enabled;
				[DataMember(Name = "notifications_enabled")]
				public bool NotificationsEnabled
				{ 
					get { return _notifications_enabled;} 
					set 
					{ 
						_notifications_enabled = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("NotificationsEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			Source _source;
			[DataMember(Name = "source")]
			public Source Source
			{ 
				get { return _source;} 
				set 
				{ 
					_source = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
				}
			}

			Target _target;
			[DataMember(Name = "target")]
			public Target Target
			{ 
				get { return _target;} 
				set 
				{ 
					_target = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Target"));
				}
			}

		}

	}


                
	namespace FriendshipsFollowersActive
	{

					[DataContract]
					public class Visible : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _type;
						[DataMember(Name = "type")]
						public double Type
						{ 
							get { return _type;} 
							set 
							{ 
								_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
							}
						}

						double _list_id;
						[DataMember(Name = "list_id")]
						public double ListId
						{ 
							get { return _list_id;} 
							set 
							{ 
								_list_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
							}
						}

					}

				[DataContract]
				public class Status : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					double _attitudes_count;
					[DataMember(Name = "attitudes_count")]
					public double AttitudesCount
					{ 
						get { return _attitudes_count;} 
						set 
						{ 
							_attitudes_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
						}
					}

					double _mlevel;
					[DataMember(Name = "mlevel")]
					public double Mlevel
					{ 
						get { return _mlevel;} 
						set 
						{ 
							_mlevel = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
						}
					}

					Visible _visible;
					[DataMember(Name = "visible")]
					public Visible Visible
					{ 
						get { return _visible;} 
						set 
						{ 
							_visible = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
						}
					}

				}

			[DataContract]
			public class UsersArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _cover_image;
				[DataMember(Name = "cover_image")]
				public string CoverImage
				{ 
					get { return _cover_image;} 
					set 
					{ 
						_cover_image = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CoverImage"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				Status _status;
				[DataMember(Name = "status")]
				public Status Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _star;
				[DataMember(Name = "star")]
				public double Star
				{ 
					get { return _star;} 
					set 
					{ 
						_star = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
					}
				}

				double _mbtype;
				[DataMember(Name = "mbtype")]
				public double Mbtype
				{ 
					get { return _mbtype;} 
					set 
					{ 
						_mbtype = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
					}
				}

				double _mbrank;
				[DataMember(Name = "mbrank")]
				public double Mbrank
				{ 
					get { return _mbrank;} 
					set 
					{ 
						_mbrank = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
					}
				}

				double _block_word;
				[DataMember(Name = "block_word")]
				public double BlockWord
				{ 
					get { return _block_word;} 
					set 
					{ 
						_block_word = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			UsersArrayItem[] _users;
			[DataMember(Name = "users")]
			public UsersArrayItem[] Users
			{ 
				get { return _users;} 
				set 
				{ 
					_users = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Users"));
				}
			}

		}

	}


                
	namespace FriendshipsFollowersIds
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			Double[] _ids;
			[DataMember(Name = "ids")]
			public Double[] Ids
			{ 
				get { return _ids;} 
				set 
				{ 
					_ids = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Ids"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsFriendsBilateral
	{

					[DataContract]
					public class Visible : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _type;
						[DataMember(Name = "type")]
						public double Type
						{ 
							get { return _type;} 
							set 
							{ 
								_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
							}
						}

						double _list_id;
						[DataMember(Name = "list_id")]
						public double ListId
						{ 
							get { return _list_id;} 
							set 
							{ 
								_list_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
							}
						}

					}

				[DataContract]
				public class Status : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					double _attitudes_count;
					[DataMember(Name = "attitudes_count")]
					public double AttitudesCount
					{ 
						get { return _attitudes_count;} 
						set 
						{ 
							_attitudes_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
						}
					}

					double _mlevel;
					[DataMember(Name = "mlevel")]
					public double Mlevel
					{ 
						get { return _mlevel;} 
						set 
						{ 
							_mlevel = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
						}
					}

					Visible _visible;
					[DataMember(Name = "visible")]
					public Visible Visible
					{ 
						get { return _visible;} 
						set 
						{ 
							_visible = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
						}
					}

				}

			[DataContract]
			public class UsersArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				Status _status;
				[DataMember(Name = "status")]
				public Status Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _star;
				[DataMember(Name = "star")]
				public double Star
				{ 
					get { return _star;} 
					set 
					{ 
						_star = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
					}
				}

				double _mbtype;
				[DataMember(Name = "mbtype")]
				public double Mbtype
				{ 
					get { return _mbtype;} 
					set 
					{ 
						_mbtype = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
					}
				}

				double _mbrank;
				[DataMember(Name = "mbrank")]
				public double Mbrank
				{ 
					get { return _mbrank;} 
					set 
					{ 
						_mbrank = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
					}
				}

				double _block_word;
				[DataMember(Name = "block_word")]
				public double BlockWord
				{ 
					get { return _block_word;} 
					set 
					{ 
						_block_word = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			UsersArrayItem[] _users;
			[DataMember(Name = "users")]
			public UsersArrayItem[] Users
			{ 
				get { return _users;} 
				set 
				{ 
					_users = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Users"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsFriendsIds
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			Double[] _ids;
			[DataMember(Name = "ids")]
			public Double[] Ids
			{ 
				get { return _ids;} 
				set 
				{ 
					_ids = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Ids"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsFriendsInCommon
	{

			[DataContract]
			public class UsersArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				double _status_id;
				[DataMember(Name = "status_id")]
				public double StatusId
				{ 
					get { return _status_id;} 
					set 
					{ 
						_status_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusId"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _star;
				[DataMember(Name = "star")]
				public double Star
				{ 
					get { return _star;} 
					set 
					{ 
						_star = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
					}
				}

				double _mbtype;
				[DataMember(Name = "mbtype")]
				public double Mbtype
				{ 
					get { return _mbtype;} 
					set 
					{ 
						_mbtype = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
					}
				}

				double _mbrank;
				[DataMember(Name = "mbrank")]
				public double Mbrank
				{ 
					get { return _mbrank;} 
					set 
					{ 
						_mbrank = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
					}
				}

				double _block_word;
				[DataMember(Name = "block_word")]
				public double BlockWord
				{ 
					get { return _block_word;} 
					set 
					{ 
						_block_word = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			UsersArrayItem[] _users;
			[DataMember(Name = "users")]
			public UsersArrayItem[] Users
			{ 
				get { return _users;} 
				set 
				{ 
					_users = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Users"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsFriendsBilateralIds
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			Double[] _ids;
			[DataMember(Name = "ids")]
			public Double[] Ids
			{ 
				get { return _ids;} 
				set 
				{ 
					_ids = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Ids"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsFriendsChainFollowers
	{

						[DataContract]
						public class User : INotifyPropertyChanged
						{
							public event PropertyChangedEventHandler PropertyChanged;

							double _id;
							[DataMember(Name = "id")]
							public double Id
							{ 
								get { return _id;} 
								set 
								{ 
									_id = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
								}
							}

							string _idstr;
							[DataMember(Name = "idstr")]
							public string Idstr
							{ 
								get { return _idstr;} 
								set 
								{ 
									_idstr = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
								}
							}

							string _profile_url;
							[DataMember(Name = "profile_url")]
							public string ProfileUrl
							{ 
								get { return _profile_url;} 
								set 
								{ 
									_profile_url = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
								}
							}

							string _weihao;
							[DataMember(Name = "weihao")]
							public string Weihao
							{ 
								get { return _weihao;} 
								set 
								{ 
									_weihao = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
										this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
								}
							}

							double _verified_type;
							[DataMember(Name = "verified_type")]
							public double VerifiedType
							{ 
								get { return _verified_type;} 
								set 
								{ 
									_verified_type = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
								}
							}

							bool _allow_all_comment;
							[DataMember(Name = "allow_all_comment")]
							public bool AllowAllComment
							{ 
								get { return _allow_all_comment;} 
								set 
								{ 
									_allow_all_comment = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
								}
							}

							string _avatar_large;
							[DataMember(Name = "avatar_large")]
							public string AvatarLarge
							{ 
								get { return _avatar_large;} 
								set 
								{ 
									_avatar_large = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
								}
							}

							string _verified_reason;
							[DataMember(Name = "verified_reason")]
							public string VerifiedReason
							{ 
								get { return _verified_reason;} 
								set 
								{ 
									_verified_reason = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
								}
							}

							bool _follow_me;
							[DataMember(Name = "follow_me")]
							public bool FollowMe
							{ 
								get { return _follow_me;} 
								set 
								{ 
									_follow_me = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
								}
							}

							double _online_status;
							[DataMember(Name = "online_status")]
							public double OnlineStatus
							{ 
								get { return _online_status;} 
								set 
								{ 
									_online_status = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
								}
							}

							double _bi_followers_count;
							[DataMember(Name = "bi_followers_count")]
							public double BiFollowersCount
							{ 
								get { return _bi_followers_count;} 
								set 
								{ 
									_bi_followers_count = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
								}
							}

							string _lang;
							[DataMember(Name = "lang")]
							public string Lang
							{ 
								get { return _lang;} 
								set 
								{ 
									_lang = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
								}
							}

							double _star;
							[DataMember(Name = "star")]
							public double Star
							{ 
								get { return _star;} 
								set 
								{ 
									_star = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
								}
							}

							double _mbtype;
							[DataMember(Name = "mbtype")]
							public double Mbtype
							{ 
								get { return _mbtype;} 
								set 
								{ 
									_mbtype = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
								}
							}

							double _mbrank;
							[DataMember(Name = "mbrank")]
							public double Mbrank
							{ 
								get { return _mbrank;} 
								set 
								{ 
									_mbrank = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
								}
							}

							double _block_word;
							[DataMember(Name = "block_word")]
							public double BlockWord
							{ 
								get { return _block_word;} 
								set 
								{ 
									_block_word = value;
									if ( this.PropertyChanged != null )
										this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
								}
							}

						}

					[DataContract]
					public class Visible : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _type;
						[DataMember(Name = "type")]
						public double Type
						{ 
							get { return _type;} 
							set 
							{ 
								_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
							}
						}

						double _list_id;
						[DataMember(Name = "list_id")]
						public double ListId
						{ 
							get { return _list_id;} 
							set 
							{ 
								_list_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
							}
						}

					}

					[DataContract]
					public class RetweetedStatus : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						string _created_at;
						[DataMember(Name = "created_at")]
						public string CreatedAt
						{ 
							get { return _created_at;} 
							set 
							{ 
								_created_at = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
							}
						}

						string _idstr;
						[DataMember(Name = "idstr")]
						public string Idstr
						{ 
							get { return _idstr;} 
							set 
							{ 
								_idstr = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
							}
						}

						User _user;
						[DataMember(Name = "user")]
						public User User
						{ 
							get { return _user;} 
							set 
							{ 
								_user = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
							}
						}

						double _attitudes_count;
						[DataMember(Name = "attitudes_count")]
						public double AttitudesCount
						{ 
							get { return _attitudes_count;} 
							set 
							{ 
								_attitudes_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
							}
						}

						double _mlevel;
						[DataMember(Name = "mlevel")]
						public double Mlevel
						{ 
							get { return _mlevel;} 
							set 
							{ 
								_mlevel = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
							}
						}

						Visible _visible;
						[DataMember(Name = "visible")]
						public Visible Visible
						{ 
							get { return _visible;} 
							set 
							{ 
								_visible = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
							}
						}

					}

				[DataContract]
				public class Status : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
						}
					}

					RetweetedStatus _retweeted_status;
					[DataMember(Name = "retweeted_status")]
					public RetweetedStatus RetweetedStatus
					{ 
						get { return _retweeted_status;} 
						set 
						{ 
							_retweeted_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("RetweetedStatus"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					double _attitudes_count;
					[DataMember(Name = "attitudes_count")]
					public double AttitudesCount
					{ 
						get { return _attitudes_count;} 
						set 
						{ 
							_attitudes_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
						}
					}

					double _mlevel;
					[DataMember(Name = "mlevel")]
					public double Mlevel
					{ 
						get { return _mlevel;} 
						set 
						{ 
							_mlevel = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
						}
					}

					Visible _visible;
					[DataMember(Name = "visible")]
					public Visible Visible
					{ 
						get { return _visible;} 
						set 
						{ 
							_visible = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
						}
					}

				}

			[DataContract]
			public class UsersArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				Status _status;
				[DataMember(Name = "status")]
				public Status Status
				{ 
					get { return _status;} 
					set 
					{ 
						_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _star;
				[DataMember(Name = "star")]
				public double Star
				{ 
					get { return _star;} 
					set 
					{ 
						_star = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
					}
				}

				double _mbtype;
				[DataMember(Name = "mbtype")]
				public double Mbtype
				{ 
					get { return _mbtype;} 
					set 
					{ 
						_mbtype = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
					}
				}

				double _mbrank;
				[DataMember(Name = "mbrank")]
				public double Mbrank
				{ 
					get { return _mbrank;} 
					set 
					{ 
						_mbrank = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
					}
				}

				double _block_word;
				[DataMember(Name = "block_word")]
				public double BlockWord
				{ 
					get { return _block_word;} 
					set 
					{ 
						_block_word = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			UsersArrayItem[] _users;
			[DataMember(Name = "users")]
			public UsersArrayItem[] Users
			{ 
				get { return _users;} 
				set 
				{ 
					_users = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Users"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace FriendshipsRemarkUpdate
	{

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

			bool _allow_all_comment;
			[DataMember(Name = "allow_all_comment")]
			public bool AllowAllComment
			{ 
				get { return _allow_all_comment;} 
				set 
				{ 
					_allow_all_comment = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
				}
			}

			string _avatar_large;
			[DataMember(Name = "avatar_large")]
			public string AvatarLarge
			{ 
				get { return _avatar_large;} 
				set 
				{ 
					_avatar_large = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
				}
			}

			string _verified_reason;
			[DataMember(Name = "verified_reason")]
			public string VerifiedReason
			{ 
				get { return _verified_reason;} 
				set 
				{ 
					_verified_reason = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
				}
			}

			bool _follow_me;
			[DataMember(Name = "follow_me")]
			public bool FollowMe
			{ 
				get { return _follow_me;} 
				set 
				{ 
					_follow_me = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
				}
			}

			double _online_status;
			[DataMember(Name = "online_status")]
			public double OnlineStatus
			{ 
				get { return _online_status;} 
				set 
				{ 
					_online_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
				}
			}

			double _bi_followers_count;
			[DataMember(Name = "bi_followers_count")]
			public double BiFollowersCount
			{ 
				get { return _bi_followers_count;} 
				set 
				{ 
					_bi_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
				}
			}

		}

	}


                
	namespace StatusesBilateralTimeline
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

				}

			[DataContract]
			public class StatusesArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			StatusesArrayItem[] _statuses;
			[DataMember(Name = "statuses")]
			public StatusesArrayItem[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesCount
	{

		[DataContract]
		public class ResponseArrayItem : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _id;
			[DataMember(Name = "id")]
			public string Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
				}
			}

			string _comments;
			[DataMember(Name = "comments")]
			public string Comments
			{ 
				get { return _comments;} 
				set 
				{ 
					_comments = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Comments"));
				}
			}

			string _reposts;
			[DataMember(Name = "reposts")]
			public string Reposts
			{ 
				get { return _reposts;} 
				set 
				{ 
					_reposts = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Reposts"));
				}
			}

		}

		[CollectionDataContract]
		public class Response : ObservableCollection<ResponseArrayItem>
		{
		}

	}


                
	namespace StatusesDestroy
	{

			[DataContract]
			public class User : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
				}
			}

			Object[] _annotations;
			[DataMember(Name = "annotations")]
			public Object[] Annotations
			{ 
				get { return _annotations;} 
				set 
				{ 
					_annotations = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
				}
			}

		}

	}


                
	namespace StatusesFriendsTimeline
	{

					[DataContract]
					public class User : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
							}
						}

						string _idstr;
						[DataMember(Name = "idstr")]
						public string Idstr
						{ 
							get { return _idstr;} 
							set 
							{ 
								_idstr = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
							}
						}

						string _profile_url;
						[DataMember(Name = "profile_url")]
						public string ProfileUrl
						{ 
							get { return _profile_url;} 
							set 
							{ 
								_profile_url = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
							}
						}

						string _weihao;
						[DataMember(Name = "weihao")]
						public string Weihao
						{ 
							get { return _weihao;} 
							set 
							{ 
								_weihao = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
							}
						}

						double _verified_type;
						[DataMember(Name = "verified_type")]
						public double VerifiedType
						{ 
							get { return _verified_type;} 
							set 
							{ 
								_verified_type = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
							}
						}

						bool _allow_all_comment;
						[DataMember(Name = "allow_all_comment")]
						public bool AllowAllComment
						{ 
							get { return _allow_all_comment;} 
							set 
							{ 
								_allow_all_comment = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
							}
						}

						string _avatar_large;
						[DataMember(Name = "avatar_large")]
						public string AvatarLarge
						{ 
							get { return _avatar_large;} 
							set 
							{ 
								_avatar_large = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
							}
						}

						string _verified_reason;
						[DataMember(Name = "verified_reason")]
						public string VerifiedReason
						{ 
							get { return _verified_reason;} 
							set 
							{ 
								_verified_reason = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
							}
						}

						bool _follow_me;
						[DataMember(Name = "follow_me")]
						public bool FollowMe
						{ 
							get { return _follow_me;} 
							set 
							{ 
								_follow_me = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
							}
						}

						double _online_status;
						[DataMember(Name = "online_status")]
						public double OnlineStatus
						{ 
							get { return _online_status;} 
							set 
							{ 
								_online_status = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
							}
						}

						double _bi_followers_count;
						[DataMember(Name = "bi_followers_count")]
						public double BiFollowersCount
						{ 
							get { return _bi_followers_count;} 
							set 
							{ 
								_bi_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
							}
						}

						string _lang;
						[DataMember(Name = "lang")]
						public string Lang
						{ 
							get { return _lang;} 
							set 
							{ 
								_lang = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
							}
						}

						double _star;
						[DataMember(Name = "star")]
						public double Star
						{ 
							get { return _star;} 
							set 
							{ 
								_star = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
							}
						}

						double _mbtype;
						[DataMember(Name = "mbtype")]
						public double Mbtype
						{ 
							get { return _mbtype;} 
							set 
							{ 
								_mbtype = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
							}
						}

						double _mbrank;
						[DataMember(Name = "mbrank")]
						public double Mbrank
						{ 
							get { return _mbrank;} 
							set 
							{ 
								_mbrank = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
							}
						}

						double _block_word;
						[DataMember(Name = "block_word")]
						public double BlockWord
						{ 
							get { return _block_word;} 
							set 
							{ 
								_block_word = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
							}
						}

					}

				[DataContract]
				public class Visible : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _type;
					[DataMember(Name = "type")]
					public double Type
					{ 
						get { return _type;} 
						set 
						{ 
							_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
						}
					}

					double _list_id;
					[DataMember(Name = "list_id")]
					public double ListId
					{ 
						get { return _list_id;} 
						set 
						{ 
							_list_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
						}
					}

				}

				[DataContract]
				public class RetweetedStatus : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					double _attitudes_count;
					[DataMember(Name = "attitudes_count")]
					public double AttitudesCount
					{ 
						get { return _attitudes_count;} 
						set 
						{ 
							_attitudes_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
						}
					}

					double _mlevel;
					[DataMember(Name = "mlevel")]
					public double Mlevel
					{ 
						get { return _mlevel;} 
						set 
						{ 
							_mlevel = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
						}
					}

					Visible _visible;
					[DataMember(Name = "visible")]
					public Visible Visible
					{ 
						get { return _visible;} 
						set 
						{ 
							_visible = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
						}
					}

				}

			[DataContract]
			public class StatusesArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
					}
				}

				RetweetedStatus _retweeted_status;
				[DataMember(Name = "retweeted_status")]
				public RetweetedStatus RetweetedStatus
				{ 
					get { return _retweeted_status;} 
					set 
					{ 
						_retweeted_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("RetweetedStatus"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				double _attitudes_count;
				[DataMember(Name = "attitudes_count")]
				public double AttitudesCount
				{ 
					get { return _attitudes_count;} 
					set 
					{ 
						_attitudes_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
					}
				}

				double _mlevel;
				[DataMember(Name = "mlevel")]
				public double Mlevel
				{ 
					get { return _mlevel;} 
					set 
					{ 
						_mlevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
					}
				}

				Visible _visible;
				[DataMember(Name = "visible")]
				public Visible Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			StatusesArrayItem[] _statuses;
			[DataMember(Name = "statuses")]
			public StatusesArrayItem[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			Object[] _advertises;
			[DataMember(Name = "advertises")]
			public Object[] Advertises
			{ 
				get { return _advertises;} 
				set 
				{ 
					_advertises = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Advertises"));
				}
			}

			Object[] _ad;
			[DataMember(Name = "ad")]
			public Object[] Ad
			{ 
				get { return _ad;} 
				set 
				{ 
					_ad = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Ad"));
				}
			}

			bool _hasvisible;
			[DataMember(Name = "hasvisible")]
			public bool Hasvisible
			{ 
				get { return _hasvisible;} 
				set 
				{ 
					_hasvisible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Hasvisible"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesHomeTimeline
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

				}

			[DataContract]
			public class StatusesArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			StatusesArrayItem[] _statuses;
			[DataMember(Name = "statuses")]
			public StatusesArrayItem[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesMentions
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

				}

			[DataContract]
			public class StatusesArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			StatusesArrayItem[] _statuses;
			[DataMember(Name = "statuses")]
			public StatusesArrayItem[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesPublicTimeline
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
						}
					}

					string _idstr;
					[DataMember(Name = "idstr")]
					public string Idstr
					{ 
						get { return _idstr;} 
						set 
						{ 
							_idstr = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
						}
					}

					string _profile_url;
					[DataMember(Name = "profile_url")]
					public string ProfileUrl
					{ 
						get { return _profile_url;} 
						set 
						{ 
							_profile_url = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
						}
					}

					string _weihao;
					[DataMember(Name = "weihao")]
					public string Weihao
					{ 
						get { return _weihao;} 
						set 
						{ 
							_weihao = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					double _verified_type;
					[DataMember(Name = "verified_type")]
					public double VerifiedType
					{ 
						get { return _verified_type;} 
						set 
						{ 
							_verified_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

					string _lang;
					[DataMember(Name = "lang")]
					public string Lang
					{ 
						get { return _lang;} 
						set 
						{ 
							_lang = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
						}
					}

					double _star;
					[DataMember(Name = "star")]
					public double Star
					{ 
						get { return _star;} 
						set 
						{ 
							_star = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Star"));
						}
					}

					double _mbtype;
					[DataMember(Name = "mbtype")]
					public double Mbtype
					{ 
						get { return _mbtype;} 
						set 
						{ 
							_mbtype = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbtype"));
						}
					}

					double _mbrank;
					[DataMember(Name = "mbrank")]
					public double Mbrank
					{ 
						get { return _mbrank;} 
						set 
						{ 
							_mbrank = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mbrank"));
						}
					}

					double _block_word;
					[DataMember(Name = "block_word")]
					public double BlockWord
					{ 
						get { return _block_word;} 
						set 
						{ 
							_block_word = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BlockWord"));
						}
					}

				}

				[DataContract]
				public class Visible : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _type;
					[DataMember(Name = "type")]
					public double Type
					{ 
						get { return _type;} 
						set 
						{ 
							_type = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
						}
					}

					double _list_id;
					[DataMember(Name = "list_id")]
					public double ListId
					{ 
						get { return _list_id;} 
						set 
						{ 
							_list_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
						}
					}

				}

			[DataContract]
			public class StatusesArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				double _attitudes_count;
				[DataMember(Name = "attitudes_count")]
				public double AttitudesCount
				{ 
					get { return _attitudes_count;} 
					set 
					{ 
						_attitudes_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
					}
				}

				double _mlevel;
				[DataMember(Name = "mlevel")]
				public double Mlevel
				{ 
					get { return _mlevel;} 
					set 
					{ 
						_mlevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
					}
				}

				Visible _visible;
				[DataMember(Name = "visible")]
				public Visible Visible
				{ 
					get { return _visible;} 
					set 
					{ 
						_visible = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			StatusesArrayItem[] _statuses;
			[DataMember(Name = "statuses")]
			public StatusesArrayItem[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			bool _hasvisible;
			[DataMember(Name = "hasvisible")]
			public bool Hasvisible
			{ 
				get { return _hasvisible;} 
				set 
				{ 
					_hasvisible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Hasvisible"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesQueryid
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _id;
			[DataMember(Name = "id")]
			public string Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
				}
			}

		}

	}


                
	namespace StatusesQuerymid
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _mid;
			[DataMember(Name = "mid")]
			public string Mid
			{ 
				get { return _mid;} 
				set 
				{ 
					_mid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

		}

	}


                
	namespace StatusesRepost
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

				}

			[DataContract]
			public class RetweetedStatus : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
				}
			}

			Object[] _annotations;
			[DataMember(Name = "annotations")]
			public Object[] Annotations
			{ 
				get { return _annotations;} 
				set 
				{ 
					_annotations = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
				}
			}

			RetweetedStatus _retweeted_status;
			[DataMember(Name = "retweeted_status")]
			public RetweetedStatus RetweetedStatus
			{ 
				get { return _retweeted_status;} 
				set 
				{ 
					_retweeted_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("RetweetedStatus"));
				}
			}

		}

	}


                
	namespace StatusesRepostByMe
	{

					[DataContract]
					public class User : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
							}
						}

						bool _allow_all_comment;
						[DataMember(Name = "allow_all_comment")]
						public bool AllowAllComment
						{ 
							get { return _allow_all_comment;} 
							set 
							{ 
								_allow_all_comment = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
							}
						}

						string _avatar_large;
						[DataMember(Name = "avatar_large")]
						public string AvatarLarge
						{ 
							get { return _avatar_large;} 
							set 
							{ 
								_avatar_large = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
							}
						}

						string _verified_reason;
						[DataMember(Name = "verified_reason")]
						public string VerifiedReason
						{ 
							get { return _verified_reason;} 
							set 
							{ 
								_verified_reason = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
							}
						}

						bool _follow_me;
						[DataMember(Name = "follow_me")]
						public bool FollowMe
						{ 
							get { return _follow_me;} 
							set 
							{ 
								_follow_me = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
							}
						}

						double _online_status;
						[DataMember(Name = "online_status")]
						public double OnlineStatus
						{ 
							get { return _online_status;} 
							set 
							{ 
								_online_status = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
							}
						}

						double _bi_followers_count;
						[DataMember(Name = "bi_followers_count")]
						public double BiFollowersCount
						{ 
							get { return _bi_followers_count;} 
							set 
							{ 
								_bi_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
							}
						}

					}

				[DataContract]
				public class RetweetedStatus : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					Object[] _annotations;
					[DataMember(Name = "annotations")]
					public Object[] Annotations
					{ 
						get { return _annotations;} 
						set 
						{ 
							_annotations = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
						}
					}

				}

			[DataContract]
			public class RepostsArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
					}
				}

				RetweetedStatus _retweeted_status;
				[DataMember(Name = "retweeted_status")]
				public RetweetedStatus RetweetedStatus
				{ 
					get { return _retweeted_status;} 
					set 
					{ 
						_retweeted_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("RetweetedStatus"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			RepostsArrayItem[] _reposts;
			[DataMember(Name = "reposts")]
			public RepostsArrayItem[] Reposts
			{ 
				get { return _reposts;} 
				set 
				{ 
					_reposts = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Reposts"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesRepostTimeline
	{

					[DataContract]
					public class User : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _id;
						[DataMember(Name = "id")]
						public double Id
						{ 
							get { return _id;} 
							set 
							{ 
								_id = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
									this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
							}
						}

						bool _allow_all_comment;
						[DataMember(Name = "allow_all_comment")]
						public bool AllowAllComment
						{ 
							get { return _allow_all_comment;} 
							set 
							{ 
								_allow_all_comment = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
							}
						}

						string _avatar_large;
						[DataMember(Name = "avatar_large")]
						public string AvatarLarge
						{ 
							get { return _avatar_large;} 
							set 
							{ 
								_avatar_large = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
							}
						}

						string _verified_reason;
						[DataMember(Name = "verified_reason")]
						public string VerifiedReason
						{ 
							get { return _verified_reason;} 
							set 
							{ 
								_verified_reason = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
							}
						}

						bool _follow_me;
						[DataMember(Name = "follow_me")]
						public bool FollowMe
						{ 
							get { return _follow_me;} 
							set 
							{ 
								_follow_me = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
							}
						}

						double _online_status;
						[DataMember(Name = "online_status")]
						public double OnlineStatus
						{ 
							get { return _online_status;} 
							set 
							{ 
								_online_status = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
							}
						}

						double _bi_followers_count;
						[DataMember(Name = "bi_followers_count")]
						public double BiFollowersCount
						{ 
							get { return _bi_followers_count;} 
							set 
							{ 
								_bi_followers_count = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
							}
						}

					}

				[DataContract]
				public class RetweetedStatus : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					string _created_at;
					[DataMember(Name = "created_at")]
					public string CreatedAt
					{ 
						get { return _created_at;} 
						set 
						{ 
							_created_at = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
						}
					}

					Object[] _annotations;
					[DataMember(Name = "annotations")]
					public Object[] Annotations
					{ 
						get { return _annotations;} 
						set 
						{ 
							_annotations = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
						}
					}

					User _user;
					[DataMember(Name = "user")]
					public User User
					{ 
						get { return _user;} 
						set 
						{ 
							_user = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
						}
					}

				}

			[DataContract]
			public class RepostsArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
					}
				}

				RetweetedStatus _retweeted_status;
				[DataMember(Name = "retweeted_status")]
				public RetweetedStatus RetweetedStatus
				{ 
					get { return _retweeted_status;} 
					set 
					{ 
						_retweeted_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("RetweetedStatus"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			RepostsArrayItem[] _reposts;
			[DataMember(Name = "reposts")]
			public RepostsArrayItem[] Reposts
			{ 
				get { return _reposts;} 
				set 
				{ 
					_reposts = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Reposts"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesShow
	{

			[DataContract]
			public class User : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
				}
			}

			Object[] _annotations;
			[DataMember(Name = "annotations")]
			public Object[] Annotations
			{ 
				get { return _annotations;} 
				set 
				{ 
					_annotations = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
				}
			}

		}

	}


                
	namespace StatusesUpdate
	{

			[DataContract]
			public class Geo : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _type;
				[DataMember(Name = "type")]
				public string Type
				{ 
					get { return _type;} 
					set 
					{ 
						_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				Double[] _coordinates;
				[DataMember(Name = "coordinates")]
				public Double[] Coordinates
				{ 
					get { return _coordinates;} 
					set 
					{ 
						_coordinates = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Coordinates"));
					}
				}

			}

					[DataContract]
					public class Kuainv : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _level;
						[DataMember(Name = "level")]
						public double Level
						{ 
							get { return _level;} 
							set 
							{ 
								_level = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Level"));
							}
						}

					}

				[DataContract]
				public class Badge : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					Kuainv _kuainv;
					[DataMember(Name = "kuainv")]
					public Kuainv Kuainv
					{ 
						get { return _kuainv;} 
						set 
						{ 
							_kuainv = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Kuainv"));
						}
					}

					double _uc_domain;
					[DataMember(Name = "uc_domain")]
					public double UcDomain
					{ 
						get { return _uc_domain;} 
						set 
						{ 
							_uc_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("UcDomain"));
						}
					}

					double _enterprise;
					[DataMember(Name = "enterprise")]
					public double Enterprise
					{ 
						get { return _enterprise;} 
						set 
						{ 
							_enterprise = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Enterprise"));
						}
					}

					double _anniversary;
					[DataMember(Name = "anniversary")]
					public double Anniversary
					{ 
						get { return _anniversary;} 
						set 
						{ 
							_anniversary = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Anniversary"));
						}
					}

				}

			[DataContract]
			public class User : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _level;
				[DataMember(Name = "level")]
				public double Level
				{ 
					get { return _level;} 
					set 
					{ 
						_level = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Level"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				double _ulevel;
				[DataMember(Name = "ulevel")]
				public double Ulevel
				{ 
					get { return _ulevel;} 
					set 
					{ 
						_ulevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Ulevel"));
					}
				}

				Badge _badge;
				[DataMember(Name = "badge")]
				public Badge Badge
				{ 
					get { return _badge;} 
					set 
					{ 
						_badge = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Badge"));
					}
				}

			}

			[DataContract]
			public class AnnotationsArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _aa;
				[DataMember(Name = "aa")]
				public string Aa
				{ 
					get { return _aa;} 
					set 
					{ 
						_aa = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Aa"));
					}
				}

			}

			[DataContract]
			public class Visible : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _type;
				[DataMember(Name = "type")]
				public double Type
				{ 
					get { return _type;} 
					set 
					{ 
						_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				double _list_id;
				[DataMember(Name = "list_id")]
				public double ListId
				{ 
					get { return _list_id;} 
					set 
					{ 
						_list_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
				}
			}

			Geo _geo;
			[DataMember(Name = "geo")]
			public Geo Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
				}
			}

			AnnotationsArrayItem[] _annotations;
			[DataMember(Name = "annotations")]
			public AnnotationsArrayItem[] Annotations
			{ 
				get { return _annotations;} 
				set 
				{ 
					_annotations = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
				}
			}

			double _attitudes_count;
			[DataMember(Name = "attitudes_count")]
			public double AttitudesCount
			{ 
				get { return _attitudes_count;} 
				set 
				{ 
					_attitudes_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
				}
			}

			double _mlevel;
			[DataMember(Name = "mlevel")]
			public double Mlevel
			{ 
				get { return _mlevel;} 
				set 
				{ 
					_mlevel = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
				}
			}

			Visible _visible;
			[DataMember(Name = "visible")]
			public Visible Visible
			{ 
				get { return _visible;} 
				set 
				{ 
					_visible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
				}
			}

		}

	}


                
	namespace StatusesUpload
	{

			[DataContract]
			public class Geo : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _type;
				[DataMember(Name = "type")]
				public string Type
				{ 
					get { return _type;} 
					set 
					{ 
						_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				Double[] _coordinates;
				[DataMember(Name = "coordinates")]
				public Double[] Coordinates
				{ 
					get { return _coordinates;} 
					set 
					{ 
						_coordinates = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Coordinates"));
					}
				}

			}

					[DataContract]
					public class Kuainv : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _level;
						[DataMember(Name = "level")]
						public double Level
						{ 
							get { return _level;} 
							set 
							{ 
								_level = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Level"));
							}
						}

					}

				[DataContract]
				public class Badge : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					Kuainv _kuainv;
					[DataMember(Name = "kuainv")]
					public Kuainv Kuainv
					{ 
						get { return _kuainv;} 
						set 
						{ 
							_kuainv = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Kuainv"));
						}
					}

					double _uc_domain;
					[DataMember(Name = "uc_domain")]
					public double UcDomain
					{ 
						get { return _uc_domain;} 
						set 
						{ 
							_uc_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("UcDomain"));
						}
					}

					double _enterprise;
					[DataMember(Name = "enterprise")]
					public double Enterprise
					{ 
						get { return _enterprise;} 
						set 
						{ 
							_enterprise = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Enterprise"));
						}
					}

					double _anniversary;
					[DataMember(Name = "anniversary")]
					public double Anniversary
					{ 
						get { return _anniversary;} 
						set 
						{ 
							_anniversary = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Anniversary"));
						}
					}

				}

			[DataContract]
			public class User : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _level;
				[DataMember(Name = "level")]
				public double Level
				{ 
					get { return _level;} 
					set 
					{ 
						_level = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Level"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				double _ulevel;
				[DataMember(Name = "ulevel")]
				public double Ulevel
				{ 
					get { return _ulevel;} 
					set 
					{ 
						_ulevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Ulevel"));
					}
				}

				Badge _badge;
				[DataMember(Name = "badge")]
				public Badge Badge
				{ 
					get { return _badge;} 
					set 
					{ 
						_badge = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Badge"));
					}
				}

			}

			[DataContract]
			public class Visible : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _type;
				[DataMember(Name = "type")]
				public double Type
				{ 
					get { return _type;} 
					set 
					{ 
						_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				double _list_id;
				[DataMember(Name = "list_id")]
				public double ListId
				{ 
					get { return _list_id;} 
					set 
					{ 
						_list_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
				}
			}

			Geo _geo;
			[DataMember(Name = "geo")]
			public Geo Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
				}
			}

			double _attitudes_count;
			[DataMember(Name = "attitudes_count")]
			public double AttitudesCount
			{ 
				get { return _attitudes_count;} 
				set 
				{ 
					_attitudes_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
				}
			}

			double _mlevel;
			[DataMember(Name = "mlevel")]
			public double Mlevel
			{ 
				get { return _mlevel;} 
				set 
				{ 
					_mlevel = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
				}
			}

			Visible _visible;
			[DataMember(Name = "visible")]
			public Visible Visible
			{ 
				get { return _visible;} 
				set 
				{ 
					_visible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
				}
			}

		}

	}


                
	namespace StatusesUploadUrlText
	{

			[DataContract]
			public class Geo : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _type;
				[DataMember(Name = "type")]
				public string Type
				{ 
					get { return _type;} 
					set 
					{ 
						_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				Double[] _coordinates;
				[DataMember(Name = "coordinates")]
				public Double[] Coordinates
				{ 
					get { return _coordinates;} 
					set 
					{ 
						_coordinates = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Coordinates"));
					}
				}

			}

					[DataContract]
					public class Kuainv : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _level;
						[DataMember(Name = "level")]
						public double Level
						{ 
							get { return _level;} 
							set 
							{ 
								_level = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Level"));
							}
						}

					}

				[DataContract]
				public class Badge : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					Kuainv _kuainv;
					[DataMember(Name = "kuainv")]
					public Kuainv Kuainv
					{ 
						get { return _kuainv;} 
						set 
						{ 
							_kuainv = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Kuainv"));
						}
					}

					double _uc_domain;
					[DataMember(Name = "uc_domain")]
					public double UcDomain
					{ 
						get { return _uc_domain;} 
						set 
						{ 
							_uc_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("UcDomain"));
						}
					}

					double _enterprise;
					[DataMember(Name = "enterprise")]
					public double Enterprise
					{ 
						get { return _enterprise;} 
						set 
						{ 
							_enterprise = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Enterprise"));
						}
					}

					double _anniversary;
					[DataMember(Name = "anniversary")]
					public double Anniversary
					{ 
						get { return _anniversary;} 
						set 
						{ 
							_anniversary = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Anniversary"));
						}
					}

				}

			[DataContract]
			public class User : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _level;
				[DataMember(Name = "level")]
				public double Level
				{ 
					get { return _level;} 
					set 
					{ 
						_level = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Level"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				double _ulevel;
				[DataMember(Name = "ulevel")]
				public double Ulevel
				{ 
					get { return _ulevel;} 
					set 
					{ 
						_ulevel = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Ulevel"));
					}
				}

				Badge _badge;
				[DataMember(Name = "badge")]
				public Badge Badge
				{ 
					get { return _badge;} 
					set 
					{ 
						_badge = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Badge"));
					}
				}

			}

			[DataContract]
			public class Visible : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _type;
				[DataMember(Name = "type")]
				public double Type
				{ 
					get { return _type;} 
					set 
					{ 
						_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				double _list_id;
				[DataMember(Name = "list_id")]
				public double ListId
				{ 
					get { return _list_id;} 
					set 
					{ 
						_list_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
				}
			}

			Geo _geo;
			[DataMember(Name = "geo")]
			public Geo Geo
			{ 
				get { return _geo;} 
				set 
				{ 
					_geo = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
				}
			}

			double _attitudes_count;
			[DataMember(Name = "attitudes_count")]
			public double AttitudesCount
			{ 
				get { return _attitudes_count;} 
				set 
				{ 
					_attitudes_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AttitudesCount"));
				}
			}

			double _mlevel;
			[DataMember(Name = "mlevel")]
			public double Mlevel
			{ 
				get { return _mlevel;} 
				set 
				{ 
					_mlevel = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
				}
			}

			Visible _visible;
			[DataMember(Name = "visible")]
			public Visible Visible
			{ 
				get { return _visible;} 
				set 
				{ 
					_visible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
				}
			}

		}

	}


                
	namespace StatusesUserTimeline
	{

				[DataContract]
				public class User : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					double _id;
					[DataMember(Name = "id")]
					public double Id
					{ 
						get { return _id;} 
						set 
						{ 
							_id = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Remark"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
								this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
						}
					}

					bool _allow_all_comment;
					[DataMember(Name = "allow_all_comment")]
					public bool AllowAllComment
					{ 
						get { return _allow_all_comment;} 
						set 
						{ 
							_allow_all_comment = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
						}
					}

					string _avatar_large;
					[DataMember(Name = "avatar_large")]
					public string AvatarLarge
					{ 
						get { return _avatar_large;} 
						set 
						{ 
							_avatar_large = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
						}
					}

					string _verified_reason;
					[DataMember(Name = "verified_reason")]
					public string VerifiedReason
					{ 
						get { return _verified_reason;} 
						set 
						{ 
							_verified_reason = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
						}
					}

					bool _follow_me;
					[DataMember(Name = "follow_me")]
					public bool FollowMe
					{ 
						get { return _follow_me;} 
						set 
						{ 
							_follow_me = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
						}
					}

					double _online_status;
					[DataMember(Name = "online_status")]
					public double OnlineStatus
					{ 
						get { return _online_status;} 
						set 
						{ 
							_online_status = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
						}
					}

					double _bi_followers_count;
					[DataMember(Name = "bi_followers_count")]
					public double BiFollowersCount
					{ 
						get { return _bi_followers_count;} 
						set 
						{ 
							_bi_followers_count = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
						}
					}

				}

			[DataContract]
			public class StatusesArrayItem : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
					}
				}

				User _user;
				[DataMember(Name = "user")]
				public User User
				{ 
					get { return _user;} 
					set 
					{ 
						_user = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			StatusesArrayItem[] _statuses;
			[DataMember(Name = "statuses")]
			public StatusesArrayItem[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesFilterCreate
	{

					[DataContract]
					public class Kuainv : INotifyPropertyChanged
					{
						public event PropertyChangedEventHandler PropertyChanged;

						double _level;
						[DataMember(Name = "level")]
						public double Level
						{ 
							get { return _level;} 
							set 
							{ 
								_level = value;
								if ( this.PropertyChanged != null )
									this.PropertyChanged(this, new PropertyChangedEventArgs("Level"));
							}
						}

					}

				[DataContract]
				public class Badge : INotifyPropertyChanged
				{
					public event PropertyChangedEventHandler PropertyChanged;

					Kuainv _kuainv;
					[DataMember(Name = "kuainv")]
					public Kuainv Kuainv
					{ 
						get { return _kuainv;} 
						set 
						{ 
							_kuainv = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Kuainv"));
						}
					}

					double _uc_domain;
					[DataMember(Name = "uc_domain")]
					public double UcDomain
					{ 
						get { return _uc_domain;} 
						set 
						{ 
							_uc_domain = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("UcDomain"));
						}
					}

					double _enterprise;
					[DataMember(Name = "enterprise")]
					public double Enterprise
					{ 
						get { return _enterprise;} 
						set 
						{ 
							_enterprise = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Enterprise"));
						}
					}

					double _anniversary;
					[DataMember(Name = "anniversary")]
					public double Anniversary
					{ 
						get { return _anniversary;} 
						set 
						{ 
							_anniversary = value;
							if ( this.PropertyChanged != null )
								this.PropertyChanged(this, new PropertyChangedEventArgs("Anniversary"));
						}
					}

				}

			[DataContract]
			public class User : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _id;
				[DataMember(Name = "id")]
				public double Id
				{ 
					get { return _id;} 
					set 
					{ 
						_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
					}
				}

				string _idstr;
				[DataMember(Name = "idstr")]
				public string Idstr
				{ 
					get { return _idstr;} 
					set 
					{ 
						_idstr = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
					}
				}

				string _profile_url;
				[DataMember(Name = "profile_url")]
				public string ProfileUrl
				{ 
					get { return _profile_url;} 
					set 
					{ 
						_profile_url = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileUrl"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
					}
				}

				string _weihao;
				[DataMember(Name = "weihao")]
				public string Weihao
				{ 
					get { return _weihao;} 
					set 
					{ 
						_weihao = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Weihao"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
					}
				}

				double _verified_type;
				[DataMember(Name = "verified_type")]
				public double VerifiedType
				{ 
					get { return _verified_type;} 
					set 
					{ 
						_verified_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedType"));
					}
				}

				bool _allow_all_comment;
				[DataMember(Name = "allow_all_comment")]
				public bool AllowAllComment
				{ 
					get { return _allow_all_comment;} 
					set 
					{ 
						_allow_all_comment = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
					}
				}

				string _avatar_large;
				[DataMember(Name = "avatar_large")]
				public string AvatarLarge
				{ 
					get { return _avatar_large;} 
					set 
					{ 
						_avatar_large = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
					}
				}

				string _verified_reason;
				[DataMember(Name = "verified_reason")]
				public string VerifiedReason
				{ 
					get { return _verified_reason;} 
					set 
					{ 
						_verified_reason = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
					}
				}

				bool _follow_me;
				[DataMember(Name = "follow_me")]
				public bool FollowMe
				{ 
					get { return _follow_me;} 
					set 
					{ 
						_follow_me = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
					}
				}

				double _online_status;
				[DataMember(Name = "online_status")]
				public double OnlineStatus
				{ 
					get { return _online_status;} 
					set 
					{ 
						_online_status = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
					}
				}

				double _bi_followers_count;
				[DataMember(Name = "bi_followers_count")]
				public double BiFollowersCount
				{ 
					get { return _bi_followers_count;} 
					set 
					{ 
						_bi_followers_count = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
					}
				}

				string _lang;
				[DataMember(Name = "lang")]
				public string Lang
				{ 
					get { return _lang;} 
					set 
					{ 
						_lang = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Lang"));
					}
				}

				double _level;
				[DataMember(Name = "level")]
				public double Level
				{ 
					get { return _level;} 
					set 
					{ 
						_level = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Level"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				Badge _badge;
				[DataMember(Name = "badge")]
				public Badge Badge
				{ 
					get { return _badge;} 
					set 
					{ 
						_badge = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Badge"));
					}
				}

			}

			[DataContract]
			public class Visible : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				double _type;
				[DataMember(Name = "type")]
				public double Type
				{ 
					get { return _type;} 
					set 
					{ 
						_type = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Type"));
					}
				}

				double _list_id;
				[DataMember(Name = "list_id")]
				public double ListId
				{ 
					get { return _list_id;} 
					set 
					{ 
						_list_id = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("ListId"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _created_at;
			[DataMember(Name = "created_at")]
			public string CreatedAt
			{ 
				get { return _created_at;} 
				set 
				{ 
					_created_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			string _idstr;
			[DataMember(Name = "idstr")]
			public string Idstr
			{ 
				get { return _idstr;} 
				set 
				{ 
					_idstr = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Idstr"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ThumbnailPic"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("BmiddlePic"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("OriginalPic"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
				}
			}

			User _user;
			[DataMember(Name = "user")]
			public User User
			{ 
				get { return _user;} 
				set 
				{ 
					_user = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("User"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
				}
			}

			double _mlevel;
			[DataMember(Name = "mlevel")]
			public double Mlevel
			{ 
				get { return _mlevel;} 
				set 
				{ 
					_mlevel = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mlevel"));
				}
			}

			Visible _visible;
			[DataMember(Name = "visible")]
			public Visible Visible
			{ 
				get { return _visible;} 
				set 
				{ 
					_visible = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Visible"));
				}
			}

		}

	}


                
	namespace StatusesFriendsTimelineIds
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			String[] _statuses;
			[DataMember(Name = "statuses")]
			public String[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesMentionsIds
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			String[] _statuses;
			[DataMember(Name = "statuses")]
			public String[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesMentionsShield
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			bool _result;
			[DataMember(Name = "result")]
			public bool Result
			{ 
				get { return _result;} 
				set 
				{ 
					_result = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Result"));
				}
			}

		}

	}


                
	namespace StatusesRepostTimelineIds
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			String[] _statuses;
			[DataMember(Name = "statuses")]
			public String[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesToMeIds
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			String[] _statuses;
			[DataMember(Name = "statuses")]
			public String[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace StatusesUserTimelineIds
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			String[] _statuses;
			[DataMember(Name = "statuses")]
			public String[] Statuses
			{ 
				get { return _statuses;} 
				set 
				{ 
					_statuses = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Statuses"));
				}
			}

			double _previous_cursor;
			[DataMember(Name = "previous_cursor")]
			public double PreviousCursor
			{ 
				get { return _previous_cursor;} 
				set 
				{ 
					_previous_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("PreviousCursor"));
				}
			}

			double _next_cursor;
			[DataMember(Name = "next_cursor")]
			public double NextCursor
			{ 
				get { return _next_cursor;} 
				set 
				{ 
					_next_cursor = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("NextCursor"));
				}
			}

			double _total_number;
			[DataMember(Name = "total_number")]
			public double TotalNumber
			{ 
				get { return _total_number;} 
				set 
				{ 
					_total_number = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("TotalNumber"));
				}
			}

		}

	}


                
	namespace UsersCancelTopStatus
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			bool _result;
			[DataMember(Name = "result")]
			public bool Result
			{ 
				get { return _result;} 
				set 
				{ 
					_result = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Result"));
				}
			}

		}

	}


                
	namespace UsersCounts
	{

		[DataContract]
		public class ResponseArrayItem : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _id;
			[DataMember(Name = "id")]
			public string Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
				}
			}

			string _followers_count;
			[DataMember(Name = "followers_count")]
			public string FollowersCount
			{ 
				get { return _followers_count;} 
				set 
				{ 
					_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
				}
			}

			string _friends_count;
			[DataMember(Name = "friends_count")]
			public string FriendsCount
			{ 
				get { return _friends_count;} 
				set 
				{ 
					_friends_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
				}
			}

			string _statuses_count;
			[DataMember(Name = "statuses_count")]
			public string StatusesCount
			{ 
				get { return _statuses_count;} 
				set 
				{ 
					_statuses_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
				}
			}

		}

		[CollectionDataContract]
		public class Response : ObservableCollection<ResponseArrayItem>
		{
		}

	}


                
	namespace UsersDomainShow
	{

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

			bool _allow_all_comment;
			[DataMember(Name = "allow_all_comment")]
			public bool AllowAllComment
			{ 
				get { return _allow_all_comment;} 
				set 
				{ 
					_allow_all_comment = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
				}
			}

			string _avatar_large;
			[DataMember(Name = "avatar_large")]
			public string AvatarLarge
			{ 
				get { return _avatar_large;} 
				set 
				{ 
					_avatar_large = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
				}
			}

			string _verified_reason;
			[DataMember(Name = "verified_reason")]
			public string VerifiedReason
			{ 
				get { return _verified_reason;} 
				set 
				{ 
					_verified_reason = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
				}
			}

			bool _follow_me;
			[DataMember(Name = "follow_me")]
			public bool FollowMe
			{ 
				get { return _follow_me;} 
				set 
				{ 
					_follow_me = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
				}
			}

			double _online_status;
			[DataMember(Name = "online_status")]
			public double OnlineStatus
			{ 
				get { return _online_status;} 
				set 
				{ 
					_online_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
				}
			}

			double _bi_followers_count;
			[DataMember(Name = "bi_followers_count")]
			public double BiFollowersCount
			{ 
				get { return _bi_followers_count;} 
				set 
				{ 
					_bi_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
				}
			}

		}

	}


                
	namespace UsersGetTopStatus
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			string _uid;
			[DataMember(Name = "uid")]
			public string Uid
			{ 
				get { return _uid;} 
				set 
				{ 
					_uid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Uid"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
				}
			}

			bool _is_use;
			[DataMember(Name = "is_use")]
			public bool IsUse
			{ 
				get { return _is_use;} 
				set 
				{ 
					_is_use = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("IsUse"));
				}
			}

			string _create_at;
			[DataMember(Name = "create_at")]
			public string CreateAt
			{ 
				get { return _create_at;} 
				set 
				{ 
					_create_at = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreateAt"));
				}
			}

		}

	}


                
	namespace UsersSetTopStatus
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			bool _result;
			[DataMember(Name = "result")]
			public bool Result
			{ 
				get { return _result;} 
				set 
				{ 
					_result = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Result"));
				}
			}

		}

	}


                
	namespace UsersShow
	{

			[DataContract]
			public class Status : INotifyPropertyChanged
			{
				public event PropertyChangedEventHandler PropertyChanged;

				string _created_at;
				[DataMember(Name = "created_at")]
				public string CreatedAt
				{ 
					get { return _created_at;} 
					set 
					{ 
						_created_at = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Text"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Source"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Favorited"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Truncated"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToStatusId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToUserId"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("InReplyToScreenName"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Geo"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("Mid"));
					}
				}

				Object[] _annotations;
				[DataMember(Name = "annotations")]
				public Object[] Annotations
				{ 
					get { return _annotations;} 
					set 
					{ 
						_annotations = value;
						if ( this.PropertyChanged != null )
							this.PropertyChanged(this, new PropertyChangedEventArgs("Annotations"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("RepostsCount"));
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
							this.PropertyChanged(this, new PropertyChangedEventArgs("CommentsCount"));
					}
				}

			}

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			double _id;
			[DataMember(Name = "id")]
			public double Id
			{ 
				get { return _id;} 
				set 
				{ 
					_id = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Id"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ScreenName"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Name"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Province"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("City"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Location"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Description"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Url"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("ProfileImageUrl"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Domain"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Gender"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowersCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FriendsCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("StatusesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("FavouritesCount"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("CreatedAt"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Following"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllActMsg"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("GeoEnabled"));
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
						this.PropertyChanged(this, new PropertyChangedEventArgs("Verified"));
				}
			}

			Status _status;
			[DataMember(Name = "status")]
			public Status Status
			{ 
				get { return _status;} 
				set 
				{ 
					_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Status"));
				}
			}

			bool _allow_all_comment;
			[DataMember(Name = "allow_all_comment")]
			public bool AllowAllComment
			{ 
				get { return _allow_all_comment;} 
				set 
				{ 
					_allow_all_comment = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AllowAllComment"));
				}
			}

			string _avatar_large;
			[DataMember(Name = "avatar_large")]
			public string AvatarLarge
			{ 
				get { return _avatar_large;} 
				set 
				{ 
					_avatar_large = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("AvatarLarge"));
				}
			}

			string _verified_reason;
			[DataMember(Name = "verified_reason")]
			public string VerifiedReason
			{ 
				get { return _verified_reason;} 
				set 
				{ 
					_verified_reason = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("VerifiedReason"));
				}
			}

			bool _follow_me;
			[DataMember(Name = "follow_me")]
			public bool FollowMe
			{ 
				get { return _follow_me;} 
				set 
				{ 
					_follow_me = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("FollowMe"));
				}
			}

			double _online_status;
			[DataMember(Name = "online_status")]
			public double OnlineStatus
			{ 
				get { return _online_status;} 
				set 
				{ 
					_online_status = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("OnlineStatus"));
				}
			}

			double _bi_followers_count;
			[DataMember(Name = "bi_followers_count")]
			public double BiFollowersCount
			{ 
				get { return _bi_followers_count;} 
				set 
				{ 
					_bi_followers_count = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("BiFollowersCount"));
				}
			}

		}

	}


                
	namespace UsersShowRank
	{

		[DataContract]
		public class Response : INotifyPropertyChanged
		{
			public event PropertyChangedEventHandler PropertyChanged;

			double _uid;
			[DataMember(Name = "uid")]
			public double Uid
			{ 
				get { return _uid;} 
				set 
				{ 
					_uid = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Uid"));
				}
			}

			double _rank;
			[DataMember(Name = "rank")]
			public double Rank
			{ 
				get { return _rank;} 
				set 
				{ 
					_rank = value;
					if ( this.PropertyChanged != null )
						this.PropertyChanged(this, new PropertyChangedEventArgs("Rank"));
				}
			}

		}

	}


                
}
