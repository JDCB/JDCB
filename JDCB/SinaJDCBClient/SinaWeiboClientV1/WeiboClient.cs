 


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





	public partial class WeiboClient:JsonClientBase
	{
		public WeiboClient()
		{
			//TODO: Set BaseUri property Here 在这里指定服务基础地址
			BaseUri = new Uri("http://api.t.sina.com.cn");
					
			_executeEmotionsMethod= new JsonMethod<EmotionsRequest, EmotionsResponse>(this, new Uri("emotions.json", UriKind.Relative));
						
			_executeFavoritesMethod= new JsonMethod<FavoritesRequest, FavoritesResponse>(this, new Uri("favorites.json", UriKind.Relative));
						
			_executeAccountEndSessionMethod= new JsonMethod<AccountEndSessionRequest, AccountEndSessionResponse>(this, new Uri("account/end_session.json", UriKind.Relative));
						
			_executeAccountGetPrivacyMethod= new JsonMethod<AccountGetPrivacyRequest, AccountGetPrivacyResponse>(this, new Uri("account/get_privacy.json", UriKind.Relative));
						
			_executeAccountRateLimitStatusMethod= new JsonMethod<AccountRateLimitStatusRequest, AccountRateLimitStatusResponse>(this, new Uri("account/rate_limit_status.json", UriKind.Relative));
						
			_executeAccountUpdateProfileMethod= new JsonMethod<AccountUpdateProfileRequest, AccountUpdateProfileResponse>(this, new Uri("account/update_profile.json", UriKind.Relative));
						
			_executeAccountUpdateProfileImageMethod= new JsonMethod<AccountUpdateProfileImageRequest, AccountUpdateProfileImageResponse>(this, new Uri("account/update_profile_image.json", UriKind.Relative));
						
			_executeAccountVerifyCredentialsMethod= new JsonMethod<AccountVerifyCredentialsRequest, AccountVerifyCredentialsResponse>(this, new Uri("account/verify_credentials.json", UriKind.Relative));
						
			_executeBlocksBlockingMethod= new JsonMethod<BlocksBlockingRequest, BlocksBlockingResponse>(this, new Uri("blocks/blocking.json", UriKind.Relative));
						
			_executeBlocksCreateMethod= new JsonMethod<BlocksCreateRequest, BlocksCreateResponse>(this, new Uri("blocks/create.json", UriKind.Relative));
						
			_executeBlocksDestroyMethod= new JsonMethod<BlocksDestroyRequest, BlocksDestroyResponse>(this, new Uri("blocks/destroy.json", UriKind.Relative));
						
			_executeBlocksExistsMethod= new JsonMethod<BlocksExistsRequest, BlocksExistsResponse>(this, new Uri("blocks/exists.json", UriKind.Relative));
						
			_executeFavoritesCreateMethod= new JsonMethod<FavoritesCreateRequest, FavoritesCreateResponse>(this, new Uri("favorites/create.json", UriKind.Relative));
						
			_executeFavoritesDestroyMethod= new JsonMethod<FavoritesDestroyRequest, FavoritesDestroyResponse>(this, new Uri("favorites/destroy/{id}.json", UriKind.Relative));
						
			_executeFavoritesDestroyBatchMethod= new JsonMethod<FavoritesDestroyBatchRequest, FavoritesDestroyBatchResponse>(this, new Uri("favorites/destroy_batch.json", UriKind.Relative));
						
			_executeFriendshipsCreateMethod= new JsonMethod<FriendshipsCreateRequest, FriendshipsCreateResponse>(this, new Uri("friendships/create/{id}.json", UriKind.Relative));
						
			_executeFriendshipsDestroyMethod= new JsonMethod<FriendshipsDestroyRequest, FriendshipsDestroyResponse>(this, new Uri("friendships/destroy/{id}.json", UriKind.Relative));
						
			_executeFriendshipsExistsMethod= new JsonMethod<FriendshipsExistsRequest, FriendshipsExistsResponse>(this, new Uri("friendships/exists.json", UriKind.Relative));
						
			_executeFriendshipsShowMethod= new JsonMethod<FriendshipsShowRequest, FriendshipsShowResponse>(this, new Uri("friendships/show.json", UriKind.Relative));
						
			_executeShortUrlExpandMethod= new JsonMethod<ShortUrlExpandRequest, ShortUrlExpandResponse>(this, new Uri("short_url/expand.json", UriKind.Relative));
						
			_executeShortUrlShortenMethod= new JsonMethod<ShortUrlShortenRequest, ShortUrlShortenResponse>(this, new Uri("short_url/shorten.json", UriKind.Relative));
						
			_executeShortUrlCommentCommentsMethod= new JsonMethod<ShortUrlCommentCommentsRequest, ShortUrlCommentCommentsResponse>(this, new Uri("short_url/comment/comments.json", UriKind.Relative));
						
			_executeShortUrlCommentCountsMethod= new JsonMethod<ShortUrlCommentCountsRequest, ShortUrlCommentCountsResponse>(this, new Uri("short_url/comment/counts.json", UriKind.Relative));
						
			_executeShortUrlShareCountsMethod= new JsonMethod<ShortUrlShareCountsRequest, ShortUrlShareCountsResponse>(this, new Uri("short_url/share/counts.json", UriKind.Relative));
						
			_executeShortUrlShareStatusesMethod= new JsonMethod<ShortUrlShareStatusesRequest, ShortUrlShareStatusesResponse>(this, new Uri("short_url/share/statuses.json", UriKind.Relative));
						
			_executeStatusesCommentMethod= new JsonMethod<StatusesCommentRequest, StatusesCommentResponse>(this, new Uri("statuses/comment.json", UriKind.Relative));
						
			_executeStatusesCommentsByMeMethod= new JsonMethod<StatusesCommentsByMeRequest, StatusesCommentsByMeResponse>(this, new Uri("statuses/comments_by_me.json", UriKind.Relative));
						
			_executeStatusesCommentsTimelineMethod= new JsonMethod<StatusesCommentsTimelineRequest, StatusesCommentsTimelineResponse>(this, new Uri("statuses/comments_timeline.json", UriKind.Relative));
						
			_executeStatusesCommentsToMeMethod= new JsonMethod<StatusesCommentsToMeRequest, StatusesCommentsToMeResponse>(this, new Uri("statuses/comments_to_me.json", UriKind.Relative));
						
			_executeStatusesCommentDestroyMethod= new JsonMethod<StatusesCommentDestroyRequest, StatusesCommentDestroyResponse>(this, new Uri("statuses/comment_destroy/{id}.json", UriKind.Relative));
						
			_executeStatusesCommentDestroyBatchMethod= new JsonMethod<StatusesCommentDestroyBatchRequest, StatusesCommentDestroyBatchResponse>(this, new Uri("statuses/comment/destroy_batch.json", UriKind.Relative));
						
			_executeStatusesCountsMethod= new JsonMethod<StatusesCountsRequest, StatusesCountsResponse>(this, new Uri("statuses/counts.json", UriKind.Relative));
						
			_executeStatusesFollowersMethod= new JsonMethod<StatusesFollowersRequest, StatusesFollowersResponse>(this, new Uri("statuses/followers.json", UriKind.Relative));
						
			_executeStatusesFriendsMethod= new JsonMethod<StatusesFriendsRequest, StatusesFriendsResponse>(this, new Uri("statuses/friends.json", UriKind.Relative));
						
			_executeStatusesFriendsTimelineMethod= new JsonMethod<StatusesFriendsTimelineRequest, StatusesFriendsTimelineResponse>(this, new Uri("statuses/friends_timeline.json", UriKind.Relative));
						
			_executeStatusesPublicTimelineMethod= new JsonMethod<StatusesPublicTimelineRequest, StatusesPublicTimelineResponse>(this, new Uri("statuses/public_timeline.json", UriKind.Relative));
						
			_executeStatusesReplyMethod= new JsonMethod<StatusesReplyRequest, StatusesReplyResponse>(this, new Uri("statuses/reply.json", UriKind.Relative));
						
			_executeStatusesRepostMethod= new JsonMethod<StatusesRepostRequest, StatusesRepostResponse>(this, new Uri("statuses/repost.json", UriKind.Relative));
						
			_executeStatusesRepostByMeMethod= new JsonMethod<StatusesRepostByMeRequest, StatusesRepostByMeResponse>(this, new Uri("statuses/repost_by_me.json", UriKind.Relative));
						
			_executeStatusesResetCountMethod= new JsonMethod<StatusesResetCountRequest, StatusesResetCountResponse>(this, new Uri("statuses/reset_count.json", UriKind.Relative));
						
			_executeStatusesShowMethod= new JsonMethod<StatusesShowRequest, StatusesShowResponse>(this, new Uri("statuses/show/{id}.json", UriKind.Relative));
						
			_executeStatusesUnreadMethod= new JsonMethod<StatusesUnreadRequest, StatusesUnreadResponse>(this, new Uri("statuses/unread.json", UriKind.Relative));
						
			_executeStatusesUpdateMethod= new JsonMethod<StatusesUpdateRequest, StatusesUpdateResponse>(this, new Uri("statuses/update.json", UriKind.Relative));
						
			_executeStatusesUploadMethod= new JsonMethod<StatusesUploadRequest, StatusesUploadResponse>(this, new Uri("statuses/upload.json", UriKind.Relative));
						
			_executeStatusesUserTimelineMethod= new JsonMethod<StatusesUserTimelineRequest, StatusesUserTimelineResponse>(this, new Uri("statuses/user_timeline/{id}.json", UriKind.Relative));
						
			_executeTagsCreateMethod= new JsonMethod<TagsCreateRequest, TagsCreateResponse>(this, new Uri("tags/create.json", UriKind.Relative));
						
			_executeTagsSuggestionsMethod= new JsonMethod<TagsSuggestionsRequest, TagsSuggestionsResponse>(this, new Uri("tags/suggestions.json", UriKind.Relative));
						
			_executeTrendsFollowMethod= new JsonMethod<TrendsFollowRequest, TrendsFollowResponse>(this, new Uri("trends/follow.json", UriKind.Relative));
						
			_executeTrendsStatusesMethod= new JsonMethod<TrendsStatusesRequest, TrendsStatusesResponse>(this, new Uri("trends/statuses.json", UriKind.Relative));
						
			_executeTrendsTrendsMethod= new JsonMethod<TrendsTrendsRequest, TrendsTrendsResponse>(this, new Uri("trends.json", UriKind.Relative));
						
			_executeUserFriendsUpdateRemarkMethod= new JsonMethod<UserFriendsUpdateRemarkRequest, UserFriendsUpdateRemarkResponse>(this, new Uri("user/friends/update_remark.json", UriKind.Relative));
						
			_executeUsersHotMethod= new JsonMethod<UsersHotRequest, UsersHotResponse>(this, new Uri("users/hot.json", UriKind.Relative));
						
			_executeUsersShowMethod= new JsonMethod<UsersShowRequest, UsersShowResponse>(this, new Uri("users/show/{id}.json", UriKind.Relative));
						
					
			_requestEmotionsMethod= new JsonMethod<EmotionsRequest, Stream>(this, new Uri("emotions.json", UriKind.Relative));
						
			_requestFavoritesMethod= new JsonMethod<FavoritesRequest, Stream>(this, new Uri("favorites.json", UriKind.Relative));
						
			_requestAccountEndSessionMethod= new JsonMethod<AccountEndSessionRequest, Stream>(this, new Uri("account/end_session.json", UriKind.Relative));
						
			_requestAccountGetPrivacyMethod= new JsonMethod<AccountGetPrivacyRequest, Stream>(this, new Uri("account/get_privacy.json", UriKind.Relative));
						
			_requestAccountRateLimitStatusMethod= new JsonMethod<AccountRateLimitStatusRequest, Stream>(this, new Uri("account/rate_limit_status.json", UriKind.Relative));
						
			_requestAccountUpdatePrivacyMethod= new JsonMethod<AccountUpdatePrivacyRequest, Stream>(this, new Uri("account/update_privacy.json", UriKind.Relative));
						
			_requestAccountUpdateProfileMethod= new JsonMethod<AccountUpdateProfileRequest, Stream>(this, new Uri("account/update_profile.json", UriKind.Relative));
						
			_requestAccountUpdateProfileImageMethod= new JsonMethod<AccountUpdateProfileImageRequest, Stream>(this, new Uri("account/update_profile_image.json", UriKind.Relative));
						
			_requestAccountVerifyCredentialsMethod= new JsonMethod<AccountVerifyCredentialsRequest, Stream>(this, new Uri("account/verify_credentials.json", UriKind.Relative));
						
			_requestBlocksBlockingMethod= new JsonMethod<BlocksBlockingRequest, Stream>(this, new Uri("blocks/blocking.json", UriKind.Relative));
						
			_requestBlocksBlockingIdsMethod= new JsonMethod<BlocksBlockingIdsRequest, Stream>(this, new Uri("blocks/blocking/ids.json", UriKind.Relative));
						
			_requestBlocksCreateMethod= new JsonMethod<BlocksCreateRequest, Stream>(this, new Uri("blocks/create.json", UriKind.Relative));
						
			_requestBlocksDestroyMethod= new JsonMethod<BlocksDestroyRequest, Stream>(this, new Uri("blocks/destroy.json", UriKind.Relative));
						
			_requestBlocksExistsMethod= new JsonMethod<BlocksExistsRequest, Stream>(this, new Uri("blocks/exists.json", UriKind.Relative));
						
			_requestFavoritesCreateMethod= new JsonMethod<FavoritesCreateRequest, Stream>(this, new Uri("favorites/create.json", UriKind.Relative));
						
			_requestFavoritesDestroyMethod= new JsonMethod<FavoritesDestroyRequest, Stream>(this, new Uri("favorites/destroy/{id}.json", UriKind.Relative));
						
			_requestFavoritesDestroyBatchMethod= new JsonMethod<FavoritesDestroyBatchRequest, Stream>(this, new Uri("favorites/destroy_batch.json", UriKind.Relative));
						
			_requestFriendshipsCreateMethod= new JsonMethod<FriendshipsCreateRequest, Stream>(this, new Uri("friendships/create/{id}.json", UriKind.Relative));
						
			_requestFriendshipsDestroyMethod= new JsonMethod<FriendshipsDestroyRequest, Stream>(this, new Uri("friendships/destroy/{id}.json", UriKind.Relative));
						
			_requestFriendshipsExistsMethod= new JsonMethod<FriendshipsExistsRequest, Stream>(this, new Uri("friendships/exists.json", UriKind.Relative));
						
			_requestFriendshipsShowMethod= new JsonMethod<FriendshipsShowRequest, Stream>(this, new Uri("friendships/show.json", UriKind.Relative));
						
			_requestShortUrlExpandMethod= new JsonMethod<ShortUrlExpandRequest, Stream>(this, new Uri("short_url/expand.json", UriKind.Relative));
						
			_requestShortUrlShortenMethod= new JsonMethod<ShortUrlShortenRequest, Stream>(this, new Uri("short_url/shorten.json", UriKind.Relative));
						
			_requestShortUrlCommentCommentsMethod= new JsonMethod<ShortUrlCommentCommentsRequest, Stream>(this, new Uri("short_url/comment/comments.json", UriKind.Relative));
						
			_requestShortUrlCommentCountsMethod= new JsonMethod<ShortUrlCommentCountsRequest, Stream>(this, new Uri("short_url/comment/counts.json", UriKind.Relative));
						
			_requestShortUrlShareCountsMethod= new JsonMethod<ShortUrlShareCountsRequest, Stream>(this, new Uri("short_url/share/counts.json", UriKind.Relative));
						
			_requestShortUrlShareStatusesMethod= new JsonMethod<ShortUrlShareStatusesRequest, Stream>(this, new Uri("short_url/share/statuses.json", UriKind.Relative));
						
			_requestSocialgraphFollowsIdsMethod= new JsonMethod<SocialgraphFollowsIdsRequest, Stream>(this, new Uri("followers/ids/{id}.json", UriKind.Relative));
						
			_requestSocialgraphFriendsIdsMethod= new JsonMethod<SocialgraphFriendsIdsRequest, Stream>(this, new Uri("friends/ids/{id}.json", UriKind.Relative));
						
			_requestStatusesCommentMethod= new JsonMethod<StatusesCommentRequest, Stream>(this, new Uri("statuses/comment.json", UriKind.Relative));
						
			_requestStatusesCommentsMethod= new JsonMethod<StatusesCommentsRequest, Stream>(this, new Uri("statuses/comments.json", UriKind.Relative));
						
			_requestStatusesCommentsByMeMethod= new JsonMethod<StatusesCommentsByMeRequest, Stream>(this, new Uri("statuses/comments_by_me.json", UriKind.Relative));
						
			_requestStatusesCommentsTimelineMethod= new JsonMethod<StatusesCommentsTimelineRequest, Stream>(this, new Uri("statuses/comments_timeline.json", UriKind.Relative));
						
			_requestStatusesCommentsToMeMethod= new JsonMethod<StatusesCommentsToMeRequest, Stream>(this, new Uri("statuses/comments_to_me.json", UriKind.Relative));
						
			_requestStatusesCommentDestroyMethod= new JsonMethod<StatusesCommentDestroyRequest, Stream>(this, new Uri("statuses/comment_destroy/{id}.json", UriKind.Relative));
						
			_requestStatusesCommentDestroyBatchMethod= new JsonMethod<StatusesCommentDestroyBatchRequest, Stream>(this, new Uri("statuses/comment/destroy_batch.json", UriKind.Relative));
						
			_requestStatusesCountsMethod= new JsonMethod<StatusesCountsRequest, Stream>(this, new Uri("statuses/counts.json", UriKind.Relative));
						
			_requestStatusesDestroyMethod= new JsonMethod<StatusesDestroyRequest, Stream>(this, new Uri("statuses/destroy/{id}.json", UriKind.Relative));
						
			_requestStatusesFollowersMethod= new JsonMethod<StatusesFollowersRequest, Stream>(this, new Uri("statuses/followers.json", UriKind.Relative));
						
			_requestStatusesFriendsMethod= new JsonMethod<StatusesFriendsRequest, Stream>(this, new Uri("statuses/friends.json", UriKind.Relative));
						
			_requestStatusesFriendsTimelineMethod= new JsonMethod<StatusesFriendsTimelineRequest, Stream>(this, new Uri("statuses/friends_timeline.json", UriKind.Relative));
						
			_requestStatusesMentionsMethod= new JsonMethod<StatusesMentionsRequest, Stream>(this, new Uri("statuses/mentions.json", UriKind.Relative));
						
			_requestStatusesPublicTimelineMethod= new JsonMethod<StatusesPublicTimelineRequest, Stream>(this, new Uri("statuses/public_timeline.json", UriKind.Relative));
						
			_requestStatusesReplyMethod= new JsonMethod<StatusesReplyRequest, Stream>(this, new Uri("statuses/reply.json", UriKind.Relative));
						
			_requestStatusesRepostMethod= new JsonMethod<StatusesRepostRequest, Stream>(this, new Uri("statuses/repost.json", UriKind.Relative));
						
			_requestStatusesRepostByMeMethod= new JsonMethod<StatusesRepostByMeRequest, Stream>(this, new Uri("statuses/repost_by_me.json", UriKind.Relative));
						
			_requestStatusesRepostTimelineMethod= new JsonMethod<StatusesRepostTimelineRequest, Stream>(this, new Uri("statuses/repost_timeline.json", UriKind.Relative));
						
			_requestStatusesResetCountMethod= new JsonMethod<StatusesResetCountRequest, Stream>(this, new Uri("statuses/reset_count.json", UriKind.Relative));
						
			_requestStatusesShowMethod= new JsonMethod<StatusesShowRequest, Stream>(this, new Uri("statuses/show/{id}.json", UriKind.Relative));
						
			_requestStatusesUnreadMethod= new JsonMethod<StatusesUnreadRequest, Stream>(this, new Uri("statuses/unread.json", UriKind.Relative));
						
			_requestStatusesUpdateMethod= new JsonMethod<StatusesUpdateRequest, Stream>(this, new Uri("statuses/update.json", UriKind.Relative));
						
			_requestStatusesUploadMethod= new JsonMethod<StatusesUploadRequest, Stream>(this, new Uri("statuses/upload.json", UriKind.Relative));
						
			_requestStatusesUserTimelineMethod= new JsonMethod<StatusesUserTimelineRequest, Stream>(this, new Uri("statuses/user_timeline/{id}.json", UriKind.Relative));
						
			_requestTagsCreateMethod= new JsonMethod<TagsCreateRequest, Stream>(this, new Uri("tags/create.json", UriKind.Relative));
						
			_requestTagsDestroyMethod= new JsonMethod<TagsDestroyRequest, Stream>(this, new Uri("tags/destroy.json", UriKind.Relative));
						
			_requestTagsDestroyBatchMethod= new JsonMethod<TagsDestroyBatchRequest, Stream>(this, new Uri("tags/destroy_batch.json", UriKind.Relative));
						
			_requestTagsSuggestionsMethod= new JsonMethod<TagsSuggestionsRequest, Stream>(this, new Uri("tags/suggestions.json", UriKind.Relative));
						
			_requestTagsTagsMethod= new JsonMethod<TagsTagsRequest, Stream>(this, new Uri("tags.json", UriKind.Relative));
						
			_requestTrendsDailyMethod= new JsonMethod<TrendsDailyRequest, Stream>(this, new Uri("trends/daily.json", UriKind.Relative));
						
			_requestTrendsDestroyMethod= new JsonMethod<TrendsDestroyRequest, Stream>(this, new Uri("trends/destroy.json", UriKind.Relative));
						
			_requestTrendsFollowMethod= new JsonMethod<TrendsFollowRequest, Stream>(this, new Uri("trends/follow.json", UriKind.Relative));
						
			_requestTrendsHourlyMethod= new JsonMethod<TrendsHourlyRequest, Stream>(this, new Uri("trends/hourly.json", UriKind.Relative));
						
			_requestTrendsStatusesMethod= new JsonMethod<TrendsStatusesRequest, Stream>(this, new Uri("trends/statuses.json", UriKind.Relative));
						
			_requestTrendsTrendsMethod= new JsonMethod<TrendsTrendsRequest, Stream>(this, new Uri("trends.json", UriKind.Relative));
						
			_requestTrendsWeeklyMethod= new JsonMethod<TrendsWeeklyRequest, Stream>(this, new Uri("trends/weekly.json", UriKind.Relative));
						
			_requestUserFriendsUpdateRemarkMethod= new JsonMethod<UserFriendsUpdateRemarkRequest, Stream>(this, new Uri("user/friends/update_remark.json", UriKind.Relative));
						
			_requestUsersHotMethod= new JsonMethod<UsersHotRequest, Stream>(this, new Uri("users/hot.json", UriKind.Relative));
						
			_requestUsersShowMethod= new JsonMethod<UsersShowRequest, Stream>(this, new Uri("users/show/{id}.json", UriKind.Relative));
						
			_requestUsersSuggestionsMethod= new JsonMethod<UsersSuggestionsRequest, Stream>(this, new Uri("users/suggestions.json", UriKind.Relative));
					}
		
				
		JsonMethod<EmotionsRequest, EmotionsResponse> _executeEmotionsMethod;
		
		/// <summary>
		/// This is a async execution of \emotions rest call. 
		/// It returns JsonResponse&lt;EmotionsResponse&gt;
		/// Here comes request Comments:
		///<para>返回新浪微博官方所有表情、魔法表情的相关信息。包括短语、表情类型、表情分类，是否热门等。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/emotions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<EmotionsResponse>> ExecuteEmotionsAsync (
			EmotionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeEmotionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \emotions rest call. 
		/// It returns JsonResponse&lt;EmotionsResponse&gt;
		/// Here comes request Comments:
		///<para>返回新浪微博官方所有表情、魔法表情的相关信息。包括短语、表情类型、表情分类，是否热门等。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/emotions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<EmotionsResponse> ExecuteEmotions(EmotionsRequest request)
		{
			return ExecuteEmotionsAsync(request).Result;
		}
		
		
				
		JsonMethod<FavoritesRequest, FavoritesResponse> _executeFavoritesMethod;
		
		/// <summary>
		/// This is a async execution of \favorites rest call. 
		/// It returns JsonResponse&lt;FavoritesResponse&gt;
		/// Here comes request Comments:
		///<para>返回登录用户最近收藏的20条微博消息，和用户在主站上“我的收藏”页面看到的内容是一致的。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<FavoritesResponse>> ExecuteFavoritesAsync (
			FavoritesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFavoritesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \favorites rest call. 
		/// It returns JsonResponse&lt;FavoritesResponse&gt;
		/// Here comes request Comments:
		///<para>返回登录用户最近收藏的20条微博消息，和用户在主站上“我的收藏”页面看到的内容是一致的。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<FavoritesResponse> ExecuteFavorites(FavoritesRequest request)
		{
			return ExecuteFavoritesAsync(request).Result;
		}
		
		
				
		JsonMethod<AccountEndSessionRequest, AccountEndSessionResponse> _executeAccountEndSessionMethod;
		
		/// <summary>
		/// This is a async execution of \account\end_session rest call. 
		/// It returns JsonResponse&lt;AccountEndSessionResponse&gt;
		/// Here comes request Comments:
		///<para>      清除已验证用户的session，退出登录，并将cookie设为null。主要用于widget等web应用场合。 </para>
		///<para>                                                                                       </para>
		///<para>URL                                                                                    </para>
		///<para>	http://api.t.sina.com.cn/account/end_session.(json|xml)                              </para>
		///<para>                                                                                       </para>
		///<para>HTTP请求方式                                                                           </para>
		///<para>	POST                                                                                 </para>
		///<para>                                                                                       </para>
		///<para>是否需要登录                                                                            </para>
		///<para>	true                                                                                 </para>
		///<para>关于授权机制，参见授权机制声明                                                           </para>
		///<para>                                                                                       </para>
		///<para>请求数限制                                                                              </para>
		///<para>	true                                                                                 </para>
		///<para>关于请求数限制，参见接口访问权限说明                                                     </para>
		///<para>
		///      
		/// </summary>
		public async Task<JsonResponse<AccountEndSessionResponse>> ExecuteAccountEndSessionAsync (
			AccountEndSessionRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountEndSessionMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\end_session rest call. 
		/// It returns JsonResponse&lt;AccountEndSessionResponse&gt;
		/// Here comes request Comments:
		///<para>      清除已验证用户的session，退出登录，并将cookie设为null。主要用于widget等web应用场合。 </para>
		///<para>                                                                                       </para>
		///<para>URL                                                                                    </para>
		///<para>	http://api.t.sina.com.cn/account/end_session.(json|xml)                              </para>
		///<para>                                                                                       </para>
		///<para>HTTP请求方式                                                                           </para>
		///<para>	POST                                                                                 </para>
		///<para>                                                                                       </para>
		///<para>是否需要登录                                                                            </para>
		///<para>	true                                                                                 </para>
		///<para>关于授权机制，参见授权机制声明                                                           </para>
		///<para>                                                                                       </para>
		///<para>请求数限制                                                                              </para>
		///<para>	true                                                                                 </para>
		///<para>关于请求数限制，参见接口访问权限说明                                                     </para>
		///<para>
		///      
		/// </summary>
		public JsonResponse<AccountEndSessionResponse> ExecuteAccountEndSession(AccountEndSessionRequest request)
		{
			return ExecuteAccountEndSessionAsync(request).Result;
		}
		
		
				
		JsonMethod<AccountGetPrivacyRequest, AccountGetPrivacyResponse> _executeAccountGetPrivacyMethod;
		
		/// <summary>
		/// This is a async execution of \account\get_privacy rest call. 
		/// It returns JsonResponse&lt;AccountGetPrivacyResponse&gt;
		/// Here comes request Comments:
		///<para>获取隐私信息设置情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/get_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<AccountGetPrivacyResponse>> ExecuteAccountGetPrivacyAsync (
			AccountGetPrivacyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountGetPrivacyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\get_privacy rest call. 
		/// It returns JsonResponse&lt;AccountGetPrivacyResponse&gt;
		/// Here comes request Comments:
		///<para>获取隐私信息设置情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/get_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<AccountGetPrivacyResponse> ExecuteAccountGetPrivacy(AccountGetPrivacyRequest request)
		{
			return ExecuteAccountGetPrivacyAsync(request).Result;
		}
		
		
				
		JsonMethod<AccountRateLimitStatusRequest, AccountRateLimitStatusResponse> _executeAccountRateLimitStatusMethod;
		
		/// <summary>
		/// This is a async execution of \account\rate_limit_status rest call. 
		/// It returns JsonResponse&lt;AccountRateLimitStatusResponse&gt;
		/// Here comes request Comments:
		///<para>获取API的访问频率限制。返回当前小时内还能访问的次数。频率限制是根据用户请求来做的限制，具体细节参见：接口访问权限说明。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/rate_limit_status.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<AccountRateLimitStatusResponse>> ExecuteAccountRateLimitStatusAsync (
			AccountRateLimitStatusRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountRateLimitStatusMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\rate_limit_status rest call. 
		/// It returns JsonResponse&lt;AccountRateLimitStatusResponse&gt;
		/// Here comes request Comments:
		///<para>获取API的访问频率限制。返回当前小时内还能访问的次数。频率限制是根据用户请求来做的限制，具体细节参见：接口访问权限说明。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/rate_limit_status.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<AccountRateLimitStatusResponse> ExecuteAccountRateLimitStatus(AccountRateLimitStatusRequest request)
		{
			return ExecuteAccountRateLimitStatusAsync(request).Result;
		}
		
		
				
		JsonMethod<AccountUpdateProfileRequest, AccountUpdateProfileResponse> _executeAccountUpdateProfileMethod;
		
		/// <summary>
		/// This is a async execution of \account\update_profile rest call. 
		/// It returns JsonResponse&lt;AccountUpdateProfileResponse&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户在新浪微博上的基本信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<AccountUpdateProfileResponse>> ExecuteAccountUpdateProfileAsync (
			AccountUpdateProfileRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountUpdateProfileMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\update_profile rest call. 
		/// It returns JsonResponse&lt;AccountUpdateProfileResponse&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户在新浪微博上的基本信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<AccountUpdateProfileResponse> ExecuteAccountUpdateProfile(AccountUpdateProfileRequest request)
		{
			return ExecuteAccountUpdateProfileAsync(request).Result;
		}
		
		
				
		JsonMethod<AccountUpdateProfileImageRequest, AccountUpdateProfileImageResponse> _executeAccountUpdateProfileImageMethod;
		
		/// <summary>
		/// This is a async execution of \account\update_profile_image rest call. 
		/// It returns JsonResponse&lt;AccountUpdateProfileImageResponse&gt;
		/// Here comes request Comments:
		///<para>更新用户头像。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile_image.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	采用multipart/form-data编码方式提交，可以参考： Form-based File Upload in HTML</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<AccountUpdateProfileImageResponse>> ExecuteAccountUpdateProfileImageAsync (
			AccountUpdateProfileImageRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountUpdateProfileImageMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\update_profile_image rest call. 
		/// It returns JsonResponse&lt;AccountUpdateProfileImageResponse&gt;
		/// Here comes request Comments:
		///<para>更新用户头像。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile_image.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	采用multipart/form-data编码方式提交，可以参考： Form-based File Upload in HTML</para>
		///<para></para>
		/// </summary>
		public JsonResponse<AccountUpdateProfileImageResponse> ExecuteAccountUpdateProfileImage(AccountUpdateProfileImageRequest request)
		{
			return ExecuteAccountUpdateProfileImageAsync(request).Result;
		}
		
		
				
		JsonMethod<AccountVerifyCredentialsRequest, AccountVerifyCredentialsResponse> _executeAccountVerifyCredentialsMethod;
		
		/// <summary>
		/// This is a async execution of \account\verify_credentials rest call. 
		/// It returns JsonResponse&lt;AccountVerifyCredentialsResponse&gt;
		/// Here comes request Comments:
		///<para>验证用户是否已经开通微博服务。 </para>
		///<para>如果用户的新浪通行证身份验证成功，且用户已经开通微博则返回 http状态为 200，否则返回403错误。 </para>
		///<para>该接口除source以外，无其他参数。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/verify_credentials.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	若用户的新浪通行证身份验证成功，但未开通微博服务，则提示：40313:Error: invalid weibo user!。   若用户的新浪通行证身份验证失败，则提示：40302:Error: auth faild!</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<AccountVerifyCredentialsResponse>> ExecuteAccountVerifyCredentialsAsync (
			AccountVerifyCredentialsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeAccountVerifyCredentialsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \account\verify_credentials rest call. 
		/// It returns JsonResponse&lt;AccountVerifyCredentialsResponse&gt;
		/// Here comes request Comments:
		///<para>验证用户是否已经开通微博服务。 </para>
		///<para>如果用户的新浪通行证身份验证成功，且用户已经开通微博则返回 http状态为 200，否则返回403错误。 </para>
		///<para>该接口除source以外，无其他参数。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/verify_credentials.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	若用户的新浪通行证身份验证成功，但未开通微博服务，则提示：40313:Error: invalid weibo user!。   若用户的新浪通行证身份验证失败，则提示：40302:Error: auth faild!</para>
		///<para></para>
		/// </summary>
		public JsonResponse<AccountVerifyCredentialsResponse> ExecuteAccountVerifyCredentials(AccountVerifyCredentialsRequest request)
		{
			return ExecuteAccountVerifyCredentialsAsync(request).Result;
		}
		
		
				
		JsonMethod<BlocksBlockingRequest, BlocksBlockingResponse> _executeBlocksBlockingMethod;
		
		/// <summary>
		/// This is a async execution of \blocks\blocking rest call. 
		/// It returns JsonResponse&lt;BlocksBlockingResponse&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户的黑名单列表，包括黑名单内的用户详细信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<BlocksBlockingResponse>> ExecuteBlocksBlockingAsync (
			BlocksBlockingRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeBlocksBlockingMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \blocks\blocking rest call. 
		/// It returns JsonResponse&lt;BlocksBlockingResponse&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户的黑名单列表，包括黑名单内的用户详细信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<BlocksBlockingResponse> ExecuteBlocksBlocking(BlocksBlockingRequest request)
		{
			return ExecuteBlocksBlockingAsync(request).Result;
		}
		
		
				
		JsonMethod<BlocksCreateRequest, BlocksCreateResponse> _executeBlocksCreateMethod;
		
		/// <summary>
		/// This is a async execution of \blocks\create rest call. 
		/// It returns JsonResponse&lt;BlocksCreateResponse&gt;
		/// Here comes request Comments:
		///<para>将某用户加入登录用户的黑名单 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<BlocksCreateResponse>> ExecuteBlocksCreateAsync (
			BlocksCreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeBlocksCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \blocks\create rest call. 
		/// It returns JsonResponse&lt;BlocksCreateResponse&gt;
		/// Here comes request Comments:
		///<para>将某用户加入登录用户的黑名单 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<BlocksCreateResponse> ExecuteBlocksCreate(BlocksCreateRequest request)
		{
			return ExecuteBlocksCreateAsync(request).Result;
		}
		
		
				
		JsonMethod<BlocksDestroyRequest, BlocksDestroyResponse> _executeBlocksDestroyMethod;
		
		/// <summary>
		/// This is a async execution of \blocks\destroy rest call. 
		/// It returns JsonResponse&lt;BlocksDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>将某用户从当前登录用户的黑名单中移除 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<BlocksDestroyResponse>> ExecuteBlocksDestroyAsync (
			BlocksDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeBlocksDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \blocks\destroy rest call. 
		/// It returns JsonResponse&lt;BlocksDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>将某用户从当前登录用户的黑名单中移除 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<BlocksDestroyResponse> ExecuteBlocksDestroy(BlocksDestroyRequest request)
		{
			return ExecuteBlocksDestroyAsync(request).Result;
		}
		
		
				
		JsonMethod<BlocksExistsRequest, BlocksExistsResponse> _executeBlocksExistsMethod;
		
		/// <summary>
		/// This is a async execution of \blocks\exists rest call. 
		/// It returns JsonResponse&lt;BlocksExistsResponse&gt;
		/// Here comes request Comments:
		///<para>检测指定用户是否在登录用户的黑名单内。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<BlocksExistsResponse>> ExecuteBlocksExistsAsync (
			BlocksExistsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeBlocksExistsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \blocks\exists rest call. 
		/// It returns JsonResponse&lt;BlocksExistsResponse&gt;
		/// Here comes request Comments:
		///<para>检测指定用户是否在登录用户的黑名单内。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<BlocksExistsResponse> ExecuteBlocksExists(BlocksExistsRequest request)
		{
			return ExecuteBlocksExistsAsync(request).Result;
		}
		
		
				
		JsonMethod<FavoritesCreateRequest, FavoritesCreateResponse> _executeFavoritesCreateMethod;
		
		/// <summary>
		/// This is a async execution of \favorites\create rest call. 
		/// It returns JsonResponse&lt;FavoritesCreateResponse&gt;
		/// Here comes request Comments:
		///<para>收藏一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<FavoritesCreateResponse>> ExecuteFavoritesCreateAsync (
			FavoritesCreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFavoritesCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \favorites\create rest call. 
		/// It returns JsonResponse&lt;FavoritesCreateResponse&gt;
		/// Here comes request Comments:
		///<para>收藏一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<FavoritesCreateResponse> ExecuteFavoritesCreate(FavoritesCreateRequest request)
		{
			return ExecuteFavoritesCreateAsync(request).Result;
		}
		
		
				
		JsonMethod<FavoritesDestroyRequest, FavoritesDestroyResponse> _executeFavoritesDestroyMethod;
		
		/// <summary>
		/// This is a async execution of \favorites\destroy rest call. 
		/// It returns JsonResponse&lt;FavoritesDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<FavoritesDestroyResponse>> ExecuteFavoritesDestroyAsync (
			FavoritesDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFavoritesDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \favorites\destroy rest call. 
		/// It returns JsonResponse&lt;FavoritesDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<FavoritesDestroyResponse> ExecuteFavoritesDestroy(FavoritesDestroyRequest request)
		{
			return ExecuteFavoritesDestroyAsync(request).Result;
		}
		
		
				
		JsonMethod<FavoritesDestroyBatchRequest, FavoritesDestroyBatchResponse> _executeFavoritesDestroyBatchMethod;
		
		/// <summary>
		/// This is a async execution of \favorites\destroy_batch rest call. 
		/// It returns JsonResponse&lt;FavoritesDestroyBatchResponse&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<FavoritesDestroyBatchResponse>> ExecuteFavoritesDestroyBatchAsync (
			FavoritesDestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFavoritesDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \favorites\destroy_batch rest call. 
		/// It returns JsonResponse&lt;FavoritesDestroyBatchResponse&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<FavoritesDestroyBatchResponse> ExecuteFavoritesDestroyBatch(FavoritesDestroyBatchRequest request)
		{
			return ExecuteFavoritesDestroyBatchAsync(request).Result;
		}
		
		
				
		JsonMethod<FriendshipsCreateRequest, FriendshipsCreateResponse> _executeFriendshipsCreateMethod;
		
		/// <summary>
		/// This is a async execution of \friendships\create rest call. 
		/// It returns JsonResponse&lt;FriendshipsCreateResponse&gt;
		/// Here comes request Comments:
		///<para>关注一个用户。关注成功则返回关注人的资料，目前的最多关注2000人。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<FriendshipsCreateResponse>> ExecuteFriendshipsCreateAsync (
			FriendshipsCreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFriendshipsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \friendships\create rest call. 
		/// It returns JsonResponse&lt;FriendshipsCreateResponse&gt;
		/// Here comes request Comments:
		///<para>关注一个用户。关注成功则返回关注人的资料，目前的最多关注2000人。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<FriendshipsCreateResponse> ExecuteFriendshipsCreate(FriendshipsCreateRequest request)
		{
			return ExecuteFriendshipsCreateAsync(request).Result;
		}
		
		
				
		JsonMethod<FriendshipsDestroyRequest, FriendshipsDestroyResponse> _executeFriendshipsDestroyMethod;
		
		/// <summary>
		/// This is a async execution of \friendships\destroy rest call. 
		/// It returns JsonResponse&lt;FriendshipsDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>取消对某用户的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<FriendshipsDestroyResponse>> ExecuteFriendshipsDestroyAsync (
			FriendshipsDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFriendshipsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \friendships\destroy rest call. 
		/// It returns JsonResponse&lt;FriendshipsDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>取消对某用户的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<FriendshipsDestroyResponse> ExecuteFriendshipsDestroy(FriendshipsDestroyRequest request)
		{
			return ExecuteFriendshipsDestroyAsync(request).Result;
		}
		
		
				
		JsonMethod<FriendshipsExistsRequest, FriendshipsExistsResponse> _executeFriendshipsExistsMethod;
		
		/// <summary>
		/// This is a async execution of \friendships\exists rest call. 
		/// It returns JsonResponse&lt;FriendshipsExistsResponse&gt;
		/// Here comes request Comments:
		///<para>查看用户A是否关注了用户B。如果用户A关注了用户B，则返回true，否则返回false。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<FriendshipsExistsResponse>> ExecuteFriendshipsExistsAsync (
			FriendshipsExistsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFriendshipsExistsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \friendships\exists rest call. 
		/// It returns JsonResponse&lt;FriendshipsExistsResponse&gt;
		/// Here comes request Comments:
		///<para>查看用户A是否关注了用户B。如果用户A关注了用户B，则返回true，否则返回false。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<FriendshipsExistsResponse> ExecuteFriendshipsExists(FriendshipsExistsRequest request)
		{
			return ExecuteFriendshipsExistsAsync(request).Result;
		}
		
		
				
		JsonMethod<FriendshipsShowRequest, FriendshipsShowResponse> _executeFriendshipsShowMethod;
		
		/// <summary>
		/// This is a async execution of \friendships\show rest call. 
		/// It returns JsonResponse&lt;FriendshipsShowResponse&gt;
		/// Here comes request Comments:
		///<para>返回两个用户关注关系的详细情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<FriendshipsShowResponse>> ExecuteFriendshipsShowAsync (
			FriendshipsShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeFriendshipsShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \friendships\show rest call. 
		/// It returns JsonResponse&lt;FriendshipsShowResponse&gt;
		/// Here comes request Comments:
		///<para>返回两个用户关注关系的详细情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<FriendshipsShowResponse> ExecuteFriendshipsShow(FriendshipsShowRequest request)
		{
			return ExecuteFriendshipsShowAsync(request).Result;
		}
		
		
				
		JsonMethod<ShortUrlExpandRequest, ShortUrlExpandResponse> _executeShortUrlExpandMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\expand rest call. 
		/// It returns JsonResponse&lt;ShortUrlExpandResponse&gt;
		/// Here comes request Comments:
		///<para>将一个或多个短链接还原成原始的长链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/expand.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrlExpandResponse>> ExecuteShortUrlExpandAsync (
			ShortUrlExpandRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlExpandMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\expand rest call. 
		/// It returns JsonResponse&lt;ShortUrlExpandResponse&gt;
		/// Here comes request Comments:
		///<para>将一个或多个短链接还原成原始的长链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/expand.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrlExpandResponse> ExecuteShortUrlExpand(ShortUrlExpandRequest request)
		{
			return ExecuteShortUrlExpandAsync(request).Result;
		}
		
		
				
		JsonMethod<ShortUrlShortenRequest, ShortUrlShortenResponse> _executeShortUrlShortenMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\shorten rest call. 
		/// It returns JsonResponse&lt;ShortUrlShortenResponse&gt;
		/// Here comes request Comments:
		///<para>将一个或多个长链接转换成短链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/shorten.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrlShortenResponse>> ExecuteShortUrlShortenAsync (
			ShortUrlShortenRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlShortenMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\shorten rest call. 
		/// It returns JsonResponse&lt;ShortUrlShortenResponse&gt;
		/// Here comes request Comments:
		///<para>将一个或多个长链接转换成短链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/shorten.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrlShortenResponse> ExecuteShortUrlShorten(ShortUrlShortenRequest request)
		{
			return ExecuteShortUrlShortenAsync(request).Result;
		}
		
		
				
		JsonMethod<ShortUrlCommentCommentsRequest, ShortUrlCommentCommentsResponse> _executeShortUrlCommentCommentsMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\comment\comments rest call. 
		/// It returns JsonResponse&lt;ShortUrlCommentCommentsResponse&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博评论内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrlCommentCommentsResponse>> ExecuteShortUrlCommentCommentsAsync (
			ShortUrlCommentCommentsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlCommentCommentsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\comment\comments rest call. 
		/// It returns JsonResponse&lt;ShortUrlCommentCommentsResponse&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博评论内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrlCommentCommentsResponse> ExecuteShortUrlCommentComments(ShortUrlCommentCommentsRequest request)
		{
			return ExecuteShortUrlCommentCommentsAsync(request).Result;
		}
		
		
				
		JsonMethod<ShortUrlCommentCountsRequest, ShortUrlCommentCountsResponse> _executeShortUrlCommentCountsMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\comment\counts rest call. 
		/// It returns JsonResponse&lt;ShortUrlCommentCountsResponse&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博评论数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrlCommentCountsResponse>> ExecuteShortUrlCommentCountsAsync (
			ShortUrlCommentCountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlCommentCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\comment\counts rest call. 
		/// It returns JsonResponse&lt;ShortUrlCommentCountsResponse&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博评论数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrlCommentCountsResponse> ExecuteShortUrlCommentCounts(ShortUrlCommentCountsRequest request)
		{
			return ExecuteShortUrlCommentCountsAsync(request).Result;
		}
		
		
				
		JsonMethod<ShortUrlShareCountsRequest, ShortUrlShareCountsResponse> _executeShortUrlShareCountsMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\share\counts rest call. 
		/// It returns JsonResponse&lt;ShortUrlShareCountsResponse&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博分享数（包含原创和转发的微博） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrlShareCountsResponse>> ExecuteShortUrlShareCountsAsync (
			ShortUrlShareCountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlShareCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\share\counts rest call. 
		/// It returns JsonResponse&lt;ShortUrlShareCountsResponse&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博分享数（包含原创和转发的微博） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrlShareCountsResponse> ExecuteShortUrlShareCounts(ShortUrlShareCountsRequest request)
		{
			return ExecuteShortUrlShareCountsAsync(request).Result;
		}
		
		
				
		JsonMethod<ShortUrlShareStatusesRequest, ShortUrlShareStatusesResponse> _executeShortUrlShareStatusesMethod;
		
		/// <summary>
		/// This is a async execution of \short_url\share\statuses rest call. 
		/// It returns JsonResponse&lt;ShortUrlShareStatusesResponse&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<ShortUrlShareStatusesResponse>> ExecuteShortUrlShareStatusesAsync (
			ShortUrlShareStatusesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeShortUrlShareStatusesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \short_url\share\statuses rest call. 
		/// It returns JsonResponse&lt;ShortUrlShareStatusesResponse&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<ShortUrlShareStatusesResponse> ExecuteShortUrlShareStatuses(ShortUrlShareStatusesRequest request)
		{
			return ExecuteShortUrlShareStatusesAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesCommentRequest, StatusesCommentResponse> _executeStatusesCommentMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comment rest call. 
		/// It returns JsonResponse&lt;StatusesCommentResponse&gt;
		/// Here comes request Comments:
		///<para>对一条微博信息进行评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesCommentResponse>> ExecuteStatusesCommentAsync (
			StatusesCommentRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comment rest call. 
		/// It returns JsonResponse&lt;StatusesCommentResponse&gt;
		/// Here comes request Comments:
		///<para>对一条微博信息进行评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesCommentResponse> ExecuteStatusesComment(StatusesCommentRequest request)
		{
			return ExecuteStatusesCommentAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesCommentsByMeRequest, StatusesCommentsByMeResponse> _executeStatusesCommentsByMeMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comments_by_me rest call. 
		/// It returns JsonResponse&lt;StatusesCommentsByMeResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前用户发出的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesCommentsByMeResponse>> ExecuteStatusesCommentsByMeAsync (
			StatusesCommentsByMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentsByMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comments_by_me rest call. 
		/// It returns JsonResponse&lt;StatusesCommentsByMeResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前用户发出的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesCommentsByMeResponse> ExecuteStatusesCommentsByMe(StatusesCommentsByMeRequest request)
		{
			return ExecuteStatusesCommentsByMeAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesCommentsTimelineRequest, StatusesCommentsTimelineResponse> _executeStatusesCommentsTimelineMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comments_timeline rest call. 
		/// It returns JsonResponse&lt;StatusesCommentsTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回最新n条发送及收到的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesCommentsTimelineResponse>> ExecuteStatusesCommentsTimelineAsync (
			StatusesCommentsTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comments_timeline rest call. 
		/// It returns JsonResponse&lt;StatusesCommentsTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回最新n条发送及收到的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesCommentsTimelineResponse> ExecuteStatusesCommentsTimeline(StatusesCommentsTimelineRequest request)
		{
			return ExecuteStatusesCommentsTimelineAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesCommentsToMeRequest, StatusesCommentsToMeResponse> _executeStatusesCommentsToMeMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comments_to_me rest call. 
		/// It returns JsonResponse&lt;StatusesCommentsToMeResponse&gt;
		/// Here comes request Comments:
		///<para>返回当前登录用户收到的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_to_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesCommentsToMeResponse>> ExecuteStatusesCommentsToMeAsync (
			StatusesCommentsToMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentsToMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comments_to_me rest call. 
		/// It returns JsonResponse&lt;StatusesCommentsToMeResponse&gt;
		/// Here comes request Comments:
		///<para>返回当前登录用户收到的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_to_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesCommentsToMeResponse> ExecuteStatusesCommentsToMe(StatusesCommentsToMeRequest request)
		{
			return ExecuteStatusesCommentsToMeAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesCommentDestroyRequest, StatusesCommentDestroyResponse> _executeStatusesCommentDestroyMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comment_destroy rest call. 
		/// It returns JsonResponse&lt;StatusesCommentDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment_destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesCommentDestroyResponse>> ExecuteStatusesCommentDestroyAsync (
			StatusesCommentDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comment_destroy rest call. 
		/// It returns JsonResponse&lt;StatusesCommentDestroyResponse&gt;
		/// Here comes request Comments:
		///<para>删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment_destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesCommentDestroyResponse> ExecuteStatusesCommentDestroy(StatusesCommentDestroyRequest request)
		{
			return ExecuteStatusesCommentDestroyAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesCommentDestroyBatchRequest, StatusesCommentDestroyBatchResponse> _executeStatusesCommentDestroyBatchMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\comment_destroy_batch rest call. 
		/// It returns JsonResponse&lt;StatusesCommentDestroyBatchResponse&gt;
		/// Here comes request Comments:
		///<para>批量删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesCommentDestroyBatchResponse>> ExecuteStatusesCommentDestroyBatchAsync (
			StatusesCommentDestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCommentDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\comment_destroy_batch rest call. 
		/// It returns JsonResponse&lt;StatusesCommentDestroyBatchResponse&gt;
		/// Here comes request Comments:
		///<para>批量删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesCommentDestroyBatchResponse> ExecuteStatusesCommentDestroyBatch(StatusesCommentDestroyBatchRequest request)
		{
			return ExecuteStatusesCommentDestroyBatchAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesCountsRequest, StatusesCountsResponse> _executeStatusesCountsMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\counts rest call. 
		/// It returns JsonResponse&lt;StatusesCountsResponse&gt;
		/// Here comes request Comments:
		///<para>批量获取n条微博消息的评论数和转发数。一次请求最多可以获取20条微博消息的评论数和转发数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesCountsResponse>> ExecuteStatusesCountsAsync (
			StatusesCountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\counts rest call. 
		/// It returns JsonResponse&lt;StatusesCountsResponse&gt;
		/// Here comes request Comments:
		///<para>批量获取n条微博消息的评论数和转发数。一次请求最多可以获取20条微博消息的评论数和转发数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesCountsResponse> ExecuteStatusesCounts(StatusesCountsRequest request)
		{
			return ExecuteStatusesCountsAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesFollowersRequest, StatusesFollowersResponse> _executeStatusesFollowersMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\followers rest call. 
		/// It returns JsonResponse&lt;StatusesFollowersResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝列表及每个粉丝的最新一条微博，返回结果按粉丝的关注时间倒序排列，最新关注的粉丝排在最前面。每次返回20个,通过cursor参数来取得多于20的粉丝。注意目前接口最多只返回5000个粉丝。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/followers.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesFollowersResponse>> ExecuteStatusesFollowersAsync (
			StatusesFollowersRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesFollowersMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\followers rest call. 
		/// It returns JsonResponse&lt;StatusesFollowersResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝列表及每个粉丝的最新一条微博，返回结果按粉丝的关注时间倒序排列，最新关注的粉丝排在最前面。每次返回20个,通过cursor参数来取得多于20的粉丝。注意目前接口最多只返回5000个粉丝。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/followers.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesFollowersResponse> ExecuteStatusesFollowers(StatusesFollowersRequest request)
		{
			return ExecuteStatusesFollowersAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesFriendsRequest, StatusesFriendsResponse> _executeStatusesFriendsMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\friends rest call. 
		/// It returns JsonResponse&lt;StatusesFriendsResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户关注列表及每个关注用户的最新一条微博，返回结果按关注时间倒序排列，最新关注的用户排在最前面。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesFriendsResponse>> ExecuteStatusesFriendsAsync (
			StatusesFriendsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesFriendsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\friends rest call. 
		/// It returns JsonResponse&lt;StatusesFriendsResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户关注列表及每个关注用户的最新一条微博，返回结果按关注时间倒序排列，最新关注的用户排在最前面。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesFriendsResponse> ExecuteStatusesFriends(StatusesFriendsRequest request)
		{
			return ExecuteStatusesFriendsAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesFriendsTimelineRequest, StatusesFriendsTimelineResponse> _executeStatusesFriendsTimelineMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\friends_timeline rest call. 
		/// It returns JsonResponse&lt;StatusesFriendsTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博消息。和用户登录 http://t.sina.com.cn 后在“我的首页”中看到的内容相同。</para>
		///<para>别名statuses/home_timeline </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesFriendsTimelineResponse>> ExecuteStatusesFriendsTimelineAsync (
			StatusesFriendsTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesFriendsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\friends_timeline rest call. 
		/// It returns JsonResponse&lt;StatusesFriendsTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博消息。和用户登录 http://t.sina.com.cn 后在“我的首页”中看到的内容相同。</para>
		///<para>别名statuses/home_timeline </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesFriendsTimelineResponse> ExecuteStatusesFriendsTimeline(StatusesFriendsTimelineRequest request)
		{
			return ExecuteStatusesFriendsTimelineAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesPublicTimelineRequest, StatusesPublicTimelineResponse> _executeStatusesPublicTimelineMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\public_timeline rest call. 
		/// It returns JsonResponse&lt;StatusesPublicTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回最新的20条公共微博。返回结果非完全实时，最长会缓存60秒 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/public_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesPublicTimelineResponse>> ExecuteStatusesPublicTimelineAsync (
			StatusesPublicTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesPublicTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\public_timeline rest call. 
		/// It returns JsonResponse&lt;StatusesPublicTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回最新的20条公共微博。返回结果非完全实时，最长会缓存60秒 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/public_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesPublicTimelineResponse> ExecuteStatusesPublicTimeline(StatusesPublicTimelineRequest request)
		{
			return ExecuteStatusesPublicTimelineAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesReplyRequest, StatusesReplyResponse> _executeStatusesReplyMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\reply rest call. 
		/// It returns JsonResponse&lt;StatusesReplyResponse&gt;
		/// Here comes request Comments:
		///<para>回复评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reply.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesReplyResponse>> ExecuteStatusesReplyAsync (
			StatusesReplyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesReplyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\reply rest call. 
		/// It returns JsonResponse&lt;StatusesReplyResponse&gt;
		/// Here comes request Comments:
		///<para>回复评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reply.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesReplyResponse> ExecuteStatusesReply(StatusesReplyRequest request)
		{
			return ExecuteStatusesReplyAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesRepostRequest, StatusesRepostResponse> _executeStatusesRepostMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\repost rest call. 
		/// It returns JsonResponse&lt;StatusesRepostResponse&gt;
		/// Here comes request Comments:
		///<para>转发一条微博消息。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesRepostResponse>> ExecuteStatusesRepostAsync (
			StatusesRepostRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesRepostMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\repost rest call. 
		/// It returns JsonResponse&lt;StatusesRepostResponse&gt;
		/// Here comes request Comments:
		///<para>转发一条微博消息。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesRepostResponse> ExecuteStatusesRepost(StatusesRepostRequest request)
		{
			return ExecuteStatusesRepostAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesRepostByMeRequest, StatusesRepostByMeResponse> _executeStatusesRepostByMeMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\repost_by_me rest call. 
		/// It returns JsonResponse&lt;StatusesRepostByMeResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户最新转发的n条微博消息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesRepostByMeResponse>> ExecuteStatusesRepostByMeAsync (
			StatusesRepostByMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesRepostByMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\repost_by_me rest call. 
		/// It returns JsonResponse&lt;StatusesRepostByMeResponse&gt;
		/// Here comes request Comments:
		///<para>获取用户最新转发的n条微博消息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesRepostByMeResponse> ExecuteStatusesRepostByMe(StatusesRepostByMeRequest request)
		{
			return ExecuteStatusesRepostByMeAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesResetCountRequest, StatusesResetCountResponse> _executeStatusesResetCountMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\reset_count rest call. 
		/// It returns JsonResponse&lt;StatusesResetCountResponse&gt;
		/// Here comes request Comments:
		///<para>将当前登录用户的某种新消息的未读数为0。可以清零的计数类别有：1. 评论数，2. @me数，3. 私信数，4. 关注数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reset_count.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesResetCountResponse>> ExecuteStatusesResetCountAsync (
			StatusesResetCountRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesResetCountMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\reset_count rest call. 
		/// It returns JsonResponse&lt;StatusesResetCountResponse&gt;
		/// Here comes request Comments:
		///<para>将当前登录用户的某种新消息的未读数为0。可以清零的计数类别有：1. 评论数，2. @me数，3. 私信数，4. 关注数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reset_count.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesResetCountResponse> ExecuteStatusesResetCount(StatusesResetCountRequest request)
		{
			return ExecuteStatusesResetCountAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesShowRequest, StatusesShowResponse> _executeStatusesShowMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\show rest call. 
		/// It returns JsonResponse&lt;StatusesShowResponse&gt;
		/// Here comes request Comments:
		///<para>根据ID获取单条微博消息，以及该微博消息的作者信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/show/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesShowResponse>> ExecuteStatusesShowAsync (
			StatusesShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\show rest call. 
		/// It returns JsonResponse&lt;StatusesShowResponse&gt;
		/// Here comes request Comments:
		///<para>根据ID获取单条微博消息，以及该微博消息的作者信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/show/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesShowResponse> ExecuteStatusesShow(StatusesShowRequest request)
		{
			return ExecuteStatusesShowAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesUnreadRequest, StatusesUnreadResponse> _executeStatusesUnreadMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\unread rest call. 
		/// It returns JsonResponse&lt;StatusesUnreadResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前用户Web主站未读消息数，包括： </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/unread.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesUnreadResponse>> ExecuteStatusesUnreadAsync (
			StatusesUnreadRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesUnreadMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\unread rest call. 
		/// It returns JsonResponse&lt;StatusesUnreadResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前用户Web主站未读消息数，包括： </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/unread.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesUnreadResponse> ExecuteStatusesUnread(StatusesUnreadRequest request)
		{
			return ExecuteStatusesUnreadAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesUpdateRequest, StatusesUpdateResponse> _executeStatusesUpdateMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\update rest call. 
		/// It returns JsonResponse&lt;StatusesUpdateResponse&gt;
		/// Here comes request Comments:
		///<para>发布一条微博信息。也可以同时转发某条微博。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/update.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesUpdateResponse>> ExecuteStatusesUpdateAsync (
			StatusesUpdateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesUpdateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\update rest call. 
		/// It returns JsonResponse&lt;StatusesUpdateResponse&gt;
		/// Here comes request Comments:
		///<para>发布一条微博信息。也可以同时转发某条微博。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/update.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesUpdateResponse> ExecuteStatusesUpdate(StatusesUpdateRequest request)
		{
			return ExecuteStatusesUpdateAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesUploadRequest, StatusesUploadResponse> _executeStatusesUploadMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\upload rest call. 
		/// It returns JsonResponse&lt;StatusesUploadResponse&gt;
		/// Here comes request Comments:
		///<para>发表带图片的微博。必须用POST方式提交pic参数，且Content-Type必须设置为multipart/form-data。图片大小<5M。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/upload.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesUploadResponse>> ExecuteStatusesUploadAsync (
			StatusesUploadRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesUploadMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\upload rest call. 
		/// It returns JsonResponse&lt;StatusesUploadResponse&gt;
		/// Here comes request Comments:
		///<para>发表带图片的微博。必须用POST方式提交pic参数，且Content-Type必须设置为multipart/form-data。图片大小<5M。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/upload.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesUploadResponse> ExecuteStatusesUpload(StatusesUploadRequest request)
		{
			return ExecuteStatusesUploadAsync(request).Result;
		}
		
		
				
		JsonMethod<StatusesUserTimelineRequest, StatusesUserTimelineResponse> _executeStatusesUserTimelineMethod;
		
		/// <summary>
		/// This is a async execution of \statuses\user_timeline rest call. 
		/// It returns JsonResponse&lt;StatusesUserTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回用户最新发表的微博消息列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/user_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<StatusesUserTimelineResponse>> ExecuteStatusesUserTimelineAsync (
			StatusesUserTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeStatusesUserTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \statuses\user_timeline rest call. 
		/// It returns JsonResponse&lt;StatusesUserTimelineResponse&gt;
		/// Here comes request Comments:
		///<para>返回用户最新发表的微博消息列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/user_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<StatusesUserTimelineResponse> ExecuteStatusesUserTimeline(StatusesUserTimelineRequest request)
		{
			return ExecuteStatusesUserTimelineAsync(request).Result;
		}
		
		
				
		JsonMethod<TagsCreateRequest, TagsCreateResponse> _executeTagsCreateMethod;
		
		/// <summary>
		/// This is a async execution of \tags\create rest call. 
		/// It returns JsonResponse&lt;TagsCreateResponse&gt;
		/// Here comes request Comments:
		///<para>为当前登录用户添加新的用户标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<TagsCreateResponse>> ExecuteTagsCreateAsync (
			TagsCreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTagsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \tags\create rest call. 
		/// It returns JsonResponse&lt;TagsCreateResponse&gt;
		/// Here comes request Comments:
		///<para>为当前登录用户添加新的用户标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<TagsCreateResponse> ExecuteTagsCreate(TagsCreateRequest request)
		{
			return ExecuteTagsCreateAsync(request).Result;
		}
		
		
				
		JsonMethod<TagsSuggestionsRequest, TagsSuggestionsResponse> _executeTagsSuggestionsMethod;
		
		/// <summary>
		/// This is a async execution of \tags\suggestions rest call. 
		/// It returns JsonResponse&lt;TagsSuggestionsResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户感兴趣的推荐标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<TagsSuggestionsResponse>> ExecuteTagsSuggestionsAsync (
			TagsSuggestionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTagsSuggestionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \tags\suggestions rest call. 
		/// It returns JsonResponse&lt;TagsSuggestionsResponse&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户感兴趣的推荐标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<TagsSuggestionsResponse> ExecuteTagsSuggestions(TagsSuggestionsRequest request)
		{
			return ExecuteTagsSuggestionsAsync(request).Result;
		}
		
		
				
		JsonMethod<TrendsFollowRequest, TrendsFollowResponse> _executeTrendsFollowMethod;
		
		/// <summary>
		/// This is a async execution of \trends\follow rest call. 
		/// It returns JsonResponse&lt;TrendsFollowResponse&gt;
		/// Here comes request Comments:
		///<para>关注某话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/follow.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<TrendsFollowResponse>> ExecuteTrendsFollowAsync (
			TrendsFollowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTrendsFollowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \trends\follow rest call. 
		/// It returns JsonResponse&lt;TrendsFollowResponse&gt;
		/// Here comes request Comments:
		///<para>关注某话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/follow.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<TrendsFollowResponse> ExecuteTrendsFollow(TrendsFollowRequest request)
		{
			return ExecuteTrendsFollowAsync(request).Result;
		}
		
		
				
		JsonMethod<TrendsStatusesRequest, TrendsStatusesResponse> _executeTrendsStatusesMethod;
		
		/// <summary>
		/// This is a async execution of \trends\statuses rest call. 
		/// It returns JsonResponse&lt;TrendsStatusesResponse&gt;
		/// Here comes request Comments:
		///<para>获取某话题下的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<TrendsStatusesResponse>> ExecuteTrendsStatusesAsync (
			TrendsStatusesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTrendsStatusesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \trends\statuses rest call. 
		/// It returns JsonResponse&lt;TrendsStatusesResponse&gt;
		/// Here comes request Comments:
		///<para>获取某话题下的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<TrendsStatusesResponse> ExecuteTrendsStatuses(TrendsStatusesRequest request)
		{
			return ExecuteTrendsStatusesAsync(request).Result;
		}
		
		
				
		JsonMethod<TrendsTrendsRequest, TrendsTrendsResponse> _executeTrendsTrendsMethod;
		
		/// <summary>
		/// This is a async execution of \trends\trends rest call. 
		/// It returns JsonResponse&lt;TrendsTrendsResponse&gt;
		/// Here comes request Comments:
		///<para>获取某用户的话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<TrendsTrendsResponse>> ExecuteTrendsTrendsAsync (
			TrendsTrendsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeTrendsTrendsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \trends\trends rest call. 
		/// It returns JsonResponse&lt;TrendsTrendsResponse&gt;
		/// Here comes request Comments:
		///<para>获取某用户的话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<TrendsTrendsResponse> ExecuteTrendsTrends(TrendsTrendsRequest request)
		{
			return ExecuteTrendsTrendsAsync(request).Result;
		}
		
		
				
		JsonMethod<UserFriendsUpdateRemarkRequest, UserFriendsUpdateRemarkResponse> _executeUserFriendsUpdateRemarkMethod;
		
		/// <summary>
		/// This is a async execution of \user\friends\update_remark rest call. 
		/// It returns JsonResponse&lt;UserFriendsUpdateRemarkResponse&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/user/friends/update_remark.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<UserFriendsUpdateRemarkResponse>> ExecuteUserFriendsUpdateRemarkAsync (
			UserFriendsUpdateRemarkRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeUserFriendsUpdateRemarkMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \user\friends\update_remark rest call. 
		/// It returns JsonResponse&lt;UserFriendsUpdateRemarkResponse&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/user/friends/update_remark.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<UserFriendsUpdateRemarkResponse> ExecuteUserFriendsUpdateRemark(UserFriendsUpdateRemarkRequest request)
		{
			return ExecuteUserFriendsUpdateRemarkAsync(request).Result;
		}
		
		
				
		JsonMethod<UsersHotRequest, UsersHotResponse> _executeUsersHotMethod;
		
		/// <summary>
		/// This is a async execution of \users\hot rest call. 
		/// It returns JsonResponse&lt;UsersHotResponse&gt;
		/// Here comes request Comments:
		///<para>返回系统推荐的用户列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/hot.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<UsersHotResponse>> ExecuteUsersHotAsync (
			UsersHotRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeUsersHotMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \users\hot rest call. 
		/// It returns JsonResponse&lt;UsersHotResponse&gt;
		/// Here comes request Comments:
		///<para>返回系统推荐的用户列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/hot.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<UsersHotResponse> ExecuteUsersHot(UsersHotRequest request)
		{
			return ExecuteUsersHotAsync(request).Result;
		}
		
		
				
		JsonMethod<UsersShowRequest, UsersShowResponse> _executeUsersShowMethod;
		
		/// <summary>
		/// This is a async execution of \users\show rest call. 
		/// It returns JsonResponse&lt;UsersShowResponse&gt;
		/// Here comes request Comments:
		///<para>按用户ID或昵称返回用户资料以及用户的最新发布的一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<UsersShowResponse>> ExecuteUsersShowAsync (
			UsersShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _executeUsersShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		
		/// <summary>
		/// This is a sync execution of \users\show rest call. 
		/// It returns JsonResponse&lt;UsersShowResponse&gt;
		/// Here comes request Comments:
		///<para>按用户ID或昵称返回用户资料以及用户的最新发布的一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<UsersShowResponse> ExecuteUsersShow(UsersShowRequest request)
		{
			return ExecuteUsersShowAsync(request).Result;
		}
		
		
						
		JsonMethod<EmotionsRequest, Stream> _requestEmotionsMethod;
		/// <summary>
		/// This is a async request of \emotions rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回新浪微博官方所有表情、魔法表情的相关信息。包括短语、表情类型、表情分类，是否热门等。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/emotions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestEmotionsAsync (
			EmotionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestEmotionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \emotions rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回新浪微博官方所有表情、魔法表情的相关信息。包括短语、表情类型、表情分类，是否热门等。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/emotions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestEmotions(EmotionsRequest request)
		{
			return RequestEmotionsAsync(request).Result;
		}
		
				
		JsonMethod<FavoritesRequest, Stream> _requestFavoritesMethod;
		/// <summary>
		/// This is a async request of \favorites rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回登录用户最近收藏的20条微博消息，和用户在主站上“我的收藏”页面看到的内容是一致的。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFavoritesAsync (
			FavoritesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFavoritesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \favorites rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回登录用户最近收藏的20条微博消息，和用户在主站上“我的收藏”页面看到的内容是一致的。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFavorites(FavoritesRequest request)
		{
			return RequestFavoritesAsync(request).Result;
		}
		
				
		JsonMethod<AccountEndSessionRequest, Stream> _requestAccountEndSessionMethod;
		/// <summary>
		/// This is a async request of \account\end_session rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>      清除已验证用户的session，退出登录，并将cookie设为null。主要用于widget等web应用场合。 </para>
		///<para>                                                                                       </para>
		///<para>URL                                                                                    </para>
		///<para>	http://api.t.sina.com.cn/account/end_session.(json|xml)                              </para>
		///<para>                                                                                       </para>
		///<para>HTTP请求方式                                                                           </para>
		///<para>	POST                                                                                 </para>
		///<para>                                                                                       </para>
		///<para>是否需要登录                                                                            </para>
		///<para>	true                                                                                 </para>
		///<para>关于授权机制，参见授权机制声明                                                           </para>
		///<para>                                                                                       </para>
		///<para>请求数限制                                                                              </para>
		///<para>	true                                                                                 </para>
		///<para>关于请求数限制，参见接口访问权限说明                                                     </para>
		///<para>
		///      
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountEndSessionAsync (
			AccountEndSessionRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountEndSessionMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\end_session rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>      清除已验证用户的session，退出登录，并将cookie设为null。主要用于widget等web应用场合。 </para>
		///<para>                                                                                       </para>
		///<para>URL                                                                                    </para>
		///<para>	http://api.t.sina.com.cn/account/end_session.(json|xml)                              </para>
		///<para>                                                                                       </para>
		///<para>HTTP请求方式                                                                           </para>
		///<para>	POST                                                                                 </para>
		///<para>                                                                                       </para>
		///<para>是否需要登录                                                                            </para>
		///<para>	true                                                                                 </para>
		///<para>关于授权机制，参见授权机制声明                                                           </para>
		///<para>                                                                                       </para>
		///<para>请求数限制                                                                              </para>
		///<para>	true                                                                                 </para>
		///<para>关于请求数限制，参见接口访问权限说明                                                     </para>
		///<para>
		///      
		/// </summary>
		public JsonResponse<Stream> RequestAccountEndSession(AccountEndSessionRequest request)
		{
			return RequestAccountEndSessionAsync(request).Result;
		}
		
				
		JsonMethod<AccountGetPrivacyRequest, Stream> _requestAccountGetPrivacyMethod;
		/// <summary>
		/// This is a async request of \account\get_privacy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取隐私信息设置情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/get_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountGetPrivacyAsync (
			AccountGetPrivacyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountGetPrivacyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\get_privacy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取隐私信息设置情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/get_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountGetPrivacy(AccountGetPrivacyRequest request)
		{
			return RequestAccountGetPrivacyAsync(request).Result;
		}
		
				
		JsonMethod<AccountRateLimitStatusRequest, Stream> _requestAccountRateLimitStatusMethod;
		/// <summary>
		/// This is a async request of \account\rate_limit_status rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取API的访问频率限制。返回当前小时内还能访问的次数。频率限制是根据用户请求来做的限制，具体细节参见：接口访问权限说明。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/rate_limit_status.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountRateLimitStatusAsync (
			AccountRateLimitStatusRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountRateLimitStatusMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\rate_limit_status rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取API的访问频率限制。返回当前小时内还能访问的次数。频率限制是根据用户请求来做的限制，具体细节参见：接口访问权限说明。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/rate_limit_status.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountRateLimitStatus(AccountRateLimitStatusRequest request)
		{
			return RequestAccountRateLimitStatusAsync(request).Result;
		}
		
				
		JsonMethod<AccountUpdatePrivacyRequest, Stream> _requestAccountUpdatePrivacyMethod;
		/// <summary>
		/// This is a async request of \account\update_privacy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>设置隐私信息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountUpdatePrivacyAsync (
			AccountUpdatePrivacyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountUpdatePrivacyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\update_privacy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>设置隐私信息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_privacy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountUpdatePrivacy(AccountUpdatePrivacyRequest request)
		{
			return RequestAccountUpdatePrivacyAsync(request).Result;
		}
		
				
		JsonMethod<AccountUpdateProfileRequest, Stream> _requestAccountUpdateProfileMethod;
		/// <summary>
		/// This is a async request of \account\update_profile rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户在新浪微博上的基本信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountUpdateProfileAsync (
			AccountUpdateProfileRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountUpdateProfileMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\update_profile rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户在新浪微博上的基本信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountUpdateProfile(AccountUpdateProfileRequest request)
		{
			return RequestAccountUpdateProfileAsync(request).Result;
		}
		
				
		JsonMethod<AccountUpdateProfileImageRequest, Stream> _requestAccountUpdateProfileImageMethod;
		/// <summary>
		/// This is a async request of \account\update_profile_image rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新用户头像。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile_image.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	采用multipart/form-data编码方式提交，可以参考： Form-based File Upload in HTML</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountUpdateProfileImageAsync (
			AccountUpdateProfileImageRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountUpdateProfileImageMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\update_profile_image rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新用户头像。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/update_profile_image.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	采用multipart/form-data编码方式提交，可以参考： Form-based File Upload in HTML</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountUpdateProfileImage(AccountUpdateProfileImageRequest request)
		{
			return RequestAccountUpdateProfileImageAsync(request).Result;
		}
		
				
		JsonMethod<AccountVerifyCredentialsRequest, Stream> _requestAccountVerifyCredentialsMethod;
		/// <summary>
		/// This is a async request of \account\verify_credentials rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>验证用户是否已经开通微博服务。 </para>
		///<para>如果用户的新浪通行证身份验证成功，且用户已经开通微博则返回 http状态为 200，否则返回403错误。 </para>
		///<para>该接口除source以外，无其他参数。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/verify_credentials.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	若用户的新浪通行证身份验证成功，但未开通微博服务，则提示：40313:Error: invalid weibo user!。   若用户的新浪通行证身份验证失败，则提示：40302:Error: auth faild!</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestAccountVerifyCredentialsAsync (
			AccountVerifyCredentialsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestAccountVerifyCredentialsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \account\verify_credentials rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>验证用户是否已经开通微博服务。 </para>
		///<para>如果用户的新浪通行证身份验证成功，且用户已经开通微博则返回 http状态为 200，否则返回403错误。 </para>
		///<para>该接口除source以外，无其他参数。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/account/verify_credentials.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	若用户的新浪通行证身份验证成功，但未开通微博服务，则提示：40313:Error: invalid weibo user!。   若用户的新浪通行证身份验证失败，则提示：40302:Error: auth faild!</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestAccountVerifyCredentials(AccountVerifyCredentialsRequest request)
		{
			return RequestAccountVerifyCredentialsAsync(request).Result;
		}
		
				
		JsonMethod<BlocksBlockingRequest, Stream> _requestBlocksBlockingMethod;
		/// <summary>
		/// This is a async request of \blocks\blocking rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户的黑名单列表，包括黑名单内的用户详细信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksBlockingAsync (
			BlocksBlockingRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksBlockingMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\blocking rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户的黑名单列表，包括黑名单内的用户详细信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksBlocking(BlocksBlockingRequest request)
		{
			return RequestBlocksBlockingAsync(request).Result;
		}
		
				
		JsonMethod<BlocksBlockingIdsRequest, Stream> _requestBlocksBlockingIdsMethod;
		/// <summary>
		/// This is a async request of \blocks\blockingIds rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户黑名单中的用户ID列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksBlockingIdsAsync (
			BlocksBlockingIdsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksBlockingIdsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\blockingIds rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>分页输出当前登录用户黑名单中的用户ID列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/blocking/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksBlockingIds(BlocksBlockingIdsRequest request)
		{
			return RequestBlocksBlockingIdsAsync(request).Result;
		}
		
				
		JsonMethod<BlocksCreateRequest, Stream> _requestBlocksCreateMethod;
		/// <summary>
		/// This is a async request of \blocks\create rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将某用户加入登录用户的黑名单 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksCreateAsync (
			BlocksCreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\create rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将某用户加入登录用户的黑名单 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksCreate(BlocksCreateRequest request)
		{
			return RequestBlocksCreateAsync(request).Result;
		}
		
				
		JsonMethod<BlocksDestroyRequest, Stream> _requestBlocksDestroyMethod;
		/// <summary>
		/// This is a async request of \blocks\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将某用户从当前登录用户的黑名单中移除 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksDestroyAsync (
			BlocksDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将某用户从当前登录用户的黑名单中移除 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksDestroy(BlocksDestroyRequest request)
		{
			return RequestBlocksDestroyAsync(request).Result;
		}
		
				
		JsonMethod<BlocksExistsRequest, Stream> _requestBlocksExistsMethod;
		/// <summary>
		/// This is a async request of \blocks\exists rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>检测指定用户是否在登录用户的黑名单内。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestBlocksExistsAsync (
			BlocksExistsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestBlocksExistsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \blocks\exists rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>检测指定用户是否在登录用户的黑名单内。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/blocks/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestBlocksExists(BlocksExistsRequest request)
		{
			return RequestBlocksExistsAsync(request).Result;
		}
		
				
		JsonMethod<FavoritesCreateRequest, Stream> _requestFavoritesCreateMethod;
		/// <summary>
		/// This is a async request of \favorites\create rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>收藏一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFavoritesCreateAsync (
			FavoritesCreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFavoritesCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \favorites\create rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>收藏一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFavoritesCreate(FavoritesCreateRequest request)
		{
			return RequestFavoritesCreateAsync(request).Result;
		}
		
				
		JsonMethod<FavoritesDestroyRequest, Stream> _requestFavoritesDestroyMethod;
		/// <summary>
		/// This is a async request of \favorites\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFavoritesDestroyAsync (
			FavoritesDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFavoritesDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \favorites\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFavoritesDestroy(FavoritesDestroyRequest request)
		{
			return RequestFavoritesDestroyAsync(request).Result;
		}
		
				
		JsonMethod<FavoritesDestroyBatchRequest, Stream> _requestFavoritesDestroyBatchMethod;
		/// <summary>
		/// This is a async request of \favorites\destroy_batch rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFavoritesDestroyBatchAsync (
			FavoritesDestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFavoritesDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \favorites\destroy_batch rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除微博收藏。注意：只能删除自己收藏的信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/favorites/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFavoritesDestroyBatch(FavoritesDestroyBatchRequest request)
		{
			return RequestFavoritesDestroyBatchAsync(request).Result;
		}
		
				
		JsonMethod<FriendshipsCreateRequest, Stream> _requestFriendshipsCreateMethod;
		/// <summary>
		/// This is a async request of \friendships\create rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注一个用户。关注成功则返回关注人的资料，目前的最多关注2000人。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFriendshipsCreateAsync (
			FriendshipsCreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFriendshipsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \friendships\create rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注一个用户。关注成功则返回关注人的资料，目前的最多关注2000人。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFriendshipsCreate(FriendshipsCreateRequest request)
		{
			return RequestFriendshipsCreateAsync(request).Result;
		}
		
				
		JsonMethod<FriendshipsDestroyRequest, Stream> _requestFriendshipsDestroyMethod;
		/// <summary>
		/// This is a async request of \friendships\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消对某用户的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFriendshipsDestroyAsync (
			FriendshipsDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFriendshipsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \friendships\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消对某用户的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFriendshipsDestroy(FriendshipsDestroyRequest request)
		{
			return RequestFriendshipsDestroyAsync(request).Result;
		}
		
				
		JsonMethod<FriendshipsExistsRequest, Stream> _requestFriendshipsExistsMethod;
		/// <summary>
		/// This is a async request of \friendships\exists rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>查看用户A是否关注了用户B。如果用户A关注了用户B，则返回true，否则返回false。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFriendshipsExistsAsync (
			FriendshipsExistsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFriendshipsExistsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \friendships\exists rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>查看用户A是否关注了用户B。如果用户A关注了用户B，则返回true，否则返回false。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/exists.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFriendshipsExists(FriendshipsExistsRequest request)
		{
			return RequestFriendshipsExistsAsync(request).Result;
		}
		
				
		JsonMethod<FriendshipsShowRequest, Stream> _requestFriendshipsShowMethod;
		/// <summary>
		/// This is a async request of \friendships\show rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回两个用户关注关系的详细情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestFriendshipsShowAsync (
			FriendshipsShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestFriendshipsShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \friendships\show rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回两个用户关注关系的详细情况 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friendships/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestFriendshipsShow(FriendshipsShowRequest request)
		{
			return RequestFriendshipsShowAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrlExpandRequest, Stream> _requestShortUrlExpandMethod;
		/// <summary>
		/// This is a async request of \short_url\expand rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将一个或多个短链接还原成原始的长链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/expand.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlExpandAsync (
			ShortUrlExpandRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlExpandMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\expand rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将一个或多个短链接还原成原始的长链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/expand.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlExpand(ShortUrlExpandRequest request)
		{
			return RequestShortUrlExpandAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrlShortenRequest, Stream> _requestShortUrlShortenMethod;
		/// <summary>
		/// This is a async request of \short_url\shorten rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将一个或多个长链接转换成短链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/shorten.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlShortenAsync (
			ShortUrlShortenRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlShortenMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\shorten rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将一个或多个长链接转换成短链接 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/shorten.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlShorten(ShortUrlShortenRequest request)
		{
			return RequestShortUrlShortenAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrlCommentCommentsRequest, Stream> _requestShortUrlCommentCommentsMethod;
		/// <summary>
		/// This is a async request of \short_url\comment\comments rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博评论内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlCommentCommentsAsync (
			ShortUrlCommentCommentsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlCommentCommentsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\comment\comments rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博评论内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlCommentComments(ShortUrlCommentCommentsRequest request)
		{
			return RequestShortUrlCommentCommentsAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrlCommentCountsRequest, Stream> _requestShortUrlCommentCountsMethod;
		/// <summary>
		/// This is a async request of \short_url\comment\counts rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博评论数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlCommentCountsAsync (
			ShortUrlCommentCountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlCommentCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\comment\counts rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博评论数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/comment/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlCommentCounts(ShortUrlCommentCountsRequest request)
		{
			return RequestShortUrlCommentCountsAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrlShareCountsRequest, Stream> _requestShortUrlShareCountsMethod;
		/// <summary>
		/// This is a async request of \short_url\share\counts rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博分享数（包含原创和转发的微博） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlShareCountsAsync (
			ShortUrlShareCountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlShareCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\share\counts rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得一个短链接在微博上的微博分享数（包含原创和转发的微博） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlShareCounts(ShortUrlShareCountsRequest request)
		{
			return RequestShortUrlShareCountsAsync(request).Result;
		}
		
				
		JsonMethod<ShortUrlShareStatusesRequest, Stream> _requestShortUrlShareStatusesMethod;
		/// <summary>
		/// This is a async request of \short_url\share\statuses rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestShortUrlShareStatusesAsync (
			ShortUrlShareStatusesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestShortUrlShareStatusesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \short_url\share\statuses rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取得包含指定单个短链接的最新微博内容 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/short_url/share/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestShortUrlShareStatuses(ShortUrlShareStatusesRequest request)
		{
			return RequestShortUrlShareStatusesAsync(request).Result;
		}
		
				
		JsonMethod<SocialgraphFollowsIdsRequest, Stream> _requestSocialgraphFollowsIdsMethod;
		/// <summary>
		/// This is a async request of \socialgraph\followsIds rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户的粉丝用户ID列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/followers/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestSocialgraphFollowsIdsAsync (
			SocialgraphFollowsIdsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestSocialgraphFollowsIdsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \socialgraph\followsIds rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户的粉丝用户ID列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/followers/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestSocialgraphFollowsIds(SocialgraphFollowsIdsRequest request)
		{
			return RequestSocialgraphFollowsIdsAsync(request).Result;
		}
		
				
		JsonMethod<SocialgraphFriendsIdsRequest, Stream> _requestSocialgraphFriendsIdsMethod;
		/// <summary>
		/// This is a async request of \socialgraph\friendsIds rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户关注的一组用户的ID列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friends/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestSocialgraphFriendsIdsAsync (
			SocialgraphFriendsIdsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestSocialgraphFriendsIdsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \socialgraph\friendsIds rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户关注的一组用户的ID列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/friends/ids.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestSocialgraphFriendsIds(SocialgraphFriendsIdsRequest request)
		{
			return RequestSocialgraphFriendsIdsAsync(request).Result;
		}
		
				
		JsonMethod<StatusesCommentRequest, Stream> _requestStatusesCommentMethod;
		/// <summary>
		/// This is a async request of \statuses\comment rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>对一条微博信息进行评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentAsync (
			StatusesCommentRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comment rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>对一条微博信息进行评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesComment(StatusesCommentRequest request)
		{
			return RequestStatusesCommentAsync(request).Result;
		}
		
				
		JsonMethod<StatusesCommentsRequest, Stream> _requestStatusesCommentsMethod;
		/// <summary>
		/// This is a async request of \statuses\comments rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博消息ID返回某条微博消息的评论列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentsAsync (
			StatusesCommentsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comments rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博消息ID返回某条微博消息的评论列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesComments(StatusesCommentsRequest request)
		{
			return RequestStatusesCommentsAsync(request).Result;
		}
		
				
		JsonMethod<StatusesCommentsByMeRequest, Stream> _requestStatusesCommentsByMeMethod;
		/// <summary>
		/// This is a async request of \statuses\comments_by_me rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户发出的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentsByMeAsync (
			StatusesCommentsByMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentsByMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comments_by_me rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户发出的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentsByMe(StatusesCommentsByMeRequest request)
		{
			return RequestStatusesCommentsByMeAsync(request).Result;
		}
		
				
		JsonMethod<StatusesCommentsTimelineRequest, Stream> _requestStatusesCommentsTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\comments_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新n条发送及收到的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentsTimelineAsync (
			StatusesCommentsTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comments_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新n条发送及收到的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentsTimeline(StatusesCommentsTimelineRequest request)
		{
			return RequestStatusesCommentsTimelineAsync(request).Result;
		}
		
				
		JsonMethod<StatusesCommentsToMeRequest, Stream> _requestStatusesCommentsToMeMethod;
		/// <summary>
		/// This is a async request of \statuses\comments_to_me rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回当前登录用户收到的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_to_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentsToMeAsync (
			StatusesCommentsToMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentsToMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comments_to_me rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回当前登录用户收到的评论 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comments_to_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentsToMe(StatusesCommentsToMeRequest request)
		{
			return RequestStatusesCommentsToMeAsync(request).Result;
		}
		
				
		JsonMethod<StatusesCommentDestroyRequest, Stream> _requestStatusesCommentDestroyMethod;
		/// <summary>
		/// This is a async request of \statuses\comment_destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment_destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentDestroyAsync (
			StatusesCommentDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comment_destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment_destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentDestroy(StatusesCommentDestroyRequest request)
		{
			return RequestStatusesCommentDestroyAsync(request).Result;
		}
		
				
		JsonMethod<StatusesCommentDestroyBatchRequest, Stream> _requestStatusesCommentDestroyBatchMethod;
		/// <summary>
		/// This is a async request of \statuses\comment_destroy_batch rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCommentDestroyBatchAsync (
			StatusesCommentDestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCommentDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\comment_destroy_batch rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量删除评论。注意：只能删除登录用户自己发布的评论，不可以删除其他人的评论。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/comment/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCommentDestroyBatch(StatusesCommentDestroyBatchRequest request)
		{
			return RequestStatusesCommentDestroyBatchAsync(request).Result;
		}
		
				
		JsonMethod<StatusesCountsRequest, Stream> _requestStatusesCountsMethod;
		/// <summary>
		/// This is a async request of \statuses\counts rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量获取n条微博消息的评论数和转发数。一次请求最多可以获取20条微博消息的评论数和转发数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesCountsAsync (
			StatusesCountsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesCountsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\counts rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量获取n条微博消息的评论数和转发数。一次请求最多可以获取20条微博消息的评论数和转发数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/counts.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesCounts(StatusesCountsRequest request)
		{
			return RequestStatusesCountsAsync(request).Result;
		}
		
				
		JsonMethod<StatusesDestroyRequest, Stream> _requestStatusesDestroyMethod;
		/// <summary>
		/// This is a async request of \statuses\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据ID删除微博消息。注意：只能删除自己发布的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesDestroyAsync (
			StatusesDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据ID删除微博消息。注意：只能删除自己发布的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/destroy/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesDestroy(StatusesDestroyRequest request)
		{
			return RequestStatusesDestroyAsync(request).Result;
		}
		
				
		JsonMethod<StatusesFollowersRequest, Stream> _requestStatusesFollowersMethod;
		/// <summary>
		/// This is a async request of \statuses\followers rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝列表及每个粉丝的最新一条微博，返回结果按粉丝的关注时间倒序排列，最新关注的粉丝排在最前面。每次返回20个,通过cursor参数来取得多于20的粉丝。注意目前接口最多只返回5000个粉丝。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/followers.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesFollowersAsync (
			StatusesFollowersRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesFollowersMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\followers rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝列表及每个粉丝的最新一条微博，返回结果按粉丝的关注时间倒序排列，最新关注的粉丝排在最前面。每次返回20个,通过cursor参数来取得多于20的粉丝。注意目前接口最多只返回5000个粉丝。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/followers.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesFollowers(StatusesFollowersRequest request)
		{
			return RequestStatusesFollowersAsync(request).Result;
		}
		
				
		JsonMethod<StatusesFriendsRequest, Stream> _requestStatusesFriendsMethod;
		/// <summary>
		/// This is a async request of \statuses\friends rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户关注列表及每个关注用户的最新一条微博，返回结果按关注时间倒序排列，最新关注的用户排在最前面。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesFriendsAsync (
			StatusesFriendsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesFriendsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\friends rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户关注列表及每个关注用户的最新一条微博，返回结果按关注时间倒序排列，最新关注的用户排在最前面。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesFriends(StatusesFriendsRequest request)
		{
			return RequestStatusesFriendsAsync(request).Result;
		}
		
				
		JsonMethod<StatusesFriendsTimelineRequest, Stream> _requestStatusesFriendsTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\friends_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博消息。和用户登录 http://t.sina.com.cn 后在“我的首页”中看到的内容相同。</para>
		///<para>别名statuses/home_timeline </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesFriendsTimelineAsync (
			StatusesFriendsTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesFriendsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\friends_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博消息。和用户登录 http://t.sina.com.cn 后在“我的首页”中看到的内容相同。</para>
		///<para>别名statuses/home_timeline </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/friends_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesFriendsTimeline(StatusesFriendsTimelineRequest request)
		{
			return RequestStatusesFriendsTimelineAsync(request).Result;
		}
		
				
		JsonMethod<StatusesMentionsRequest, Stream> _requestStatusesMentionsMethod;
		/// <summary>
		/// This is a async request of \statuses\mentions rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新n条提到登录用户的微博消息（即包含@username的微博消息） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/mentions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesMentionsAsync (
			StatusesMentionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesMentionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\mentions rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新n条提到登录用户的微博消息（即包含@username的微博消息） </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/mentions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesMentions(StatusesMentionsRequest request)
		{
			return RequestStatusesMentionsAsync(request).Result;
		}
		
				
		JsonMethod<StatusesPublicTimelineRequest, Stream> _requestStatusesPublicTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\public_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新的20条公共微博。返回结果非完全实时，最长会缓存60秒 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/public_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesPublicTimelineAsync (
			StatusesPublicTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesPublicTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\public_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新的20条公共微博。返回结果非完全实时，最长会缓存60秒 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/public_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	false  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesPublicTimeline(StatusesPublicTimelineRequest request)
		{
			return RequestStatusesPublicTimelineAsync(request).Result;
		}
		
				
		JsonMethod<StatusesReplyRequest, Stream> _requestStatusesReplyMethod;
		/// <summary>
		/// This is a async request of \statuses\reply rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>回复评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reply.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesReplyAsync (
			StatusesReplyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesReplyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\reply rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>回复评论。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reply.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesReply(StatusesReplyRequest request)
		{
			return RequestStatusesReplyAsync(request).Result;
		}
		
				
		JsonMethod<StatusesRepostRequest, Stream> _requestStatusesRepostMethod;
		/// <summary>
		/// This is a async request of \statuses\repost rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>转发一条微博消息。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesRepostAsync (
			StatusesRepostRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesRepostMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\repost rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>转发一条微博消息。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesRepost(StatusesRepostRequest request)
		{
			return RequestStatusesRepostAsync(request).Result;
		}
		
				
		JsonMethod<StatusesRepostByMeRequest, Stream> _requestStatusesRepostByMeMethod;
		/// <summary>
		/// This is a async request of \statuses\repost_by_me rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户最新转发的n条微博消息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesRepostByMeAsync (
			StatusesRepostByMeRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesRepostByMeMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\repost_by_me rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户最新转发的n条微博消息 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_by_me.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesRepostByMe(StatusesRepostByMeRequest request)
		{
			return RequestStatusesRepostByMeAsync(request).Result;
		}
		
				
		JsonMethod<StatusesRepostTimelineRequest, Stream> _requestStatusesRepostTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\repost_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回一条原创微博消息的最新n条转发微博消息。本接口无法对非原创微博进行查询。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesRepostTimelineAsync (
			StatusesRepostTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesRepostTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\repost_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回一条原创微博消息的最新n条转发微博消息。本接口无法对非原创微博进行查询。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/repost_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesRepostTimeline(StatusesRepostTimelineRequest request)
		{
			return RequestStatusesRepostTimelineAsync(request).Result;
		}
		
				
		JsonMethod<StatusesResetCountRequest, Stream> _requestStatusesResetCountMethod;
		/// <summary>
		/// This is a async request of \statuses\reset_count rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将当前登录用户的某种新消息的未读数为0。可以清零的计数类别有：1. 评论数，2. @me数，3. 私信数，4. 关注数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reset_count.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesResetCountAsync (
			StatusesResetCountRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesResetCountMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\reset_count rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>将当前登录用户的某种新消息的未读数为0。可以清零的计数类别有：1. 评论数，2. @me数，3. 私信数，4. 关注数 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/reset_count.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	false  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesResetCount(StatusesResetCountRequest request)
		{
			return RequestStatusesResetCountAsync(request).Result;
		}
		
				
		JsonMethod<StatusesShowRequest, Stream> _requestStatusesShowMethod;
		/// <summary>
		/// This is a async request of \statuses\show rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据ID获取单条微博消息，以及该微博消息的作者信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/show/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesShowAsync (
			StatusesShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\show rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据ID获取单条微博消息，以及该微博消息的作者信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/show/:id.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesShow(StatusesShowRequest request)
		{
			return RequestStatusesShowAsync(request).Result;
		}
		
				
		JsonMethod<StatusesUnreadRequest, Stream> _requestStatusesUnreadMethod;
		/// <summary>
		/// This is a async request of \statuses\unread rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户Web主站未读消息数，包括： </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/unread.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesUnreadAsync (
			StatusesUnreadRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesUnreadMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\unread rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户Web主站未读消息数，包括： </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/unread.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesUnread(StatusesUnreadRequest request)
		{
			return RequestStatusesUnreadAsync(request).Result;
		}
		
				
		JsonMethod<StatusesUpdateRequest, Stream> _requestStatusesUpdateMethod;
		/// <summary>
		/// This is a async request of \statuses\update rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发布一条微博信息。也可以同时转发某条微博。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/update.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesUpdateAsync (
			StatusesUpdateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesUpdateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\update rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发布一条微博信息。也可以同时转发某条微博。请求必须用POST方式提交。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/update.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesUpdate(StatusesUpdateRequest request)
		{
			return RequestStatusesUpdateAsync(request).Result;
		}
		
				
		JsonMethod<StatusesUploadRequest, Stream> _requestStatusesUploadMethod;
		/// <summary>
		/// This is a async request of \statuses\upload rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发表带图片的微博。必须用POST方式提交pic参数，且Content-Type必须设置为multipart/form-data。图片大小<5M。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/upload.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesUploadAsync (
			StatusesUploadRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesUploadMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\upload rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发表带图片的微博。必须用POST方式提交pic参数，且Content-Type必须设置为multipart/form-data。图片大小<5M。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/upload.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesUpload(StatusesUploadRequest request)
		{
			return RequestStatusesUploadAsync(request).Result;
		}
		
				
		JsonMethod<StatusesUserTimelineRequest, Stream> _requestStatusesUserTimelineMethod;
		/// <summary>
		/// This is a async request of \statuses\user_timeline rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户最新发表的微博消息列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/user_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestStatusesUserTimelineAsync (
			StatusesUserTimelineRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestStatusesUserTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \statuses\user_timeline rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回用户最新发表的微博消息列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/statuses/user_timeline.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestStatusesUserTimeline(StatusesUserTimelineRequest request)
		{
			return RequestStatusesUserTimelineAsync(request).Result;
		}
		
				
		JsonMethod<TagsCreateRequest, Stream> _requestTagsCreateMethod;
		/// <summary>
		/// This is a async request of \tags\create rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>为当前登录用户添加新的用户标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsCreateAsync (
			TagsCreateRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\create rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>为当前登录用户添加新的用户标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/create.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsCreate(TagsCreateRequest request)
		{
			return RequestTagsCreateAsync(request).Result;
		}
		
				
		JsonMethod<TagsDestroyRequest, Stream> _requestTagsDestroyMethod;
		/// <summary>
		/// This is a async request of \tags\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsDestroyAsync (
			TagsDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsDestroy(TagsDestroyRequest request)
		{
			return RequestTagsDestroyAsync(request).Result;
		}
		
				
		JsonMethod<TagsDestroyBatchRequest, Stream> _requestTagsDestroyBatchMethod;
		/// <summary>
		/// This is a async request of \tags\destroy_batch rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除一组标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsDestroyBatchAsync (
			TagsDestroyBatchRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\destroy_batch rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除一组标签 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/destroy_batch.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST/DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsDestroyBatch(TagsDestroyBatchRequest request)
		{
			return RequestTagsDestroyBatchAsync(request).Result;
		}
		
				
		JsonMethod<TagsSuggestionsRequest, Stream> _requestTagsSuggestionsMethod;
		/// <summary>
		/// This is a async request of \tags\suggestions rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户感兴趣的推荐标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsSuggestionsAsync (
			TagsSuggestionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsSuggestionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\suggestions rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户感兴趣的推荐标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsSuggestions(TagsSuggestionsRequest request)
		{
			return RequestTagsSuggestionsAsync(request).Result;
		}
		
				
		JsonMethod<TagsTagsRequest, Stream> _requestTagsTagsMethod;
		/// <summary>
		/// This is a async request of \tags\tags rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回指定用户的标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTagsTagsAsync (
			TagsTagsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTagsTagsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \tags\tags rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回指定用户的标签列表 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/tags.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTagsTags(TagsTagsRequest request)
		{
			return RequestTagsTagsAsync(request).Result;
		}
		
				
		JsonMethod<TrendsDailyRequest, Stream> _requestTrendsDailyMethod;
		/// <summary>
		/// This is a async request of \trends\daily rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一天内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/daily.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsDailyAsync (
			TrendsDailyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsDailyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\daily rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一天内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/daily.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsDaily(TrendsDailyRequest request)
		{
			return RequestTrendsDailyAsync(request).Result;
		}
		
				
		JsonMethod<TrendsDestroyRequest, Stream> _requestTrendsDestroyMethod;
		/// <summary>
		/// This is a async request of \trends\destroy rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消对某话题的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsDestroyAsync (
			TrendsDestroyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\destroy rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消对某话题的关注。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/destroy.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	DELETE</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsDestroy(TrendsDestroyRequest request)
		{
			return RequestTrendsDestroyAsync(request).Result;
		}
		
				
		JsonMethod<TrendsFollowRequest, Stream> _requestTrendsFollowMethod;
		/// <summary>
		/// This is a async request of \trends\follow rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注某话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/follow.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsFollowAsync (
			TrendsFollowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsFollowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\follow rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注某话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/follow.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsFollow(TrendsFollowRequest request)
		{
			return RequestTrendsFollowAsync(request).Result;
		}
		
				
		JsonMethod<TrendsHourlyRequest, Stream> _requestTrendsHourlyMethod;
		/// <summary>
		/// This is a async request of \trends\hourly rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一小时内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/hourly.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsHourlyAsync (
			TrendsHourlyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsHourlyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\hourly rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一小时内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/hourly.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsHourly(TrendsHourlyRequest request)
		{
			return RequestTrendsHourlyAsync(request).Result;
		}
		
				
		JsonMethod<TrendsStatusesRequest, Stream> _requestTrendsStatusesMethod;
		/// <summary>
		/// This is a async request of \trends\statuses rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某话题下的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsStatusesAsync (
			TrendsStatusesRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsStatusesMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\statuses rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某话题下的微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/statuses.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsStatuses(TrendsStatusesRequest request)
		{
			return RequestTrendsStatusesAsync(request).Result;
		}
		
				
		JsonMethod<TrendsTrendsRequest, Stream> _requestTrendsTrendsMethod;
		/// <summary>
		/// This is a async request of \trends\trends rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某用户的话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsTrendsAsync (
			TrendsTrendsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsTrendsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\trends rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某用户的话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsTrends(TrendsTrendsRequest request)
		{
			return RequestTrendsTrendsAsync(request).Result;
		}
		
				
		JsonMethod<TrendsWeeklyRequest, Stream> _requestTrendsWeeklyMethod;
		/// <summary>
		/// This is a async request of \trends\weekly rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一周内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/weekly.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestTrendsWeeklyAsync (
			TrendsWeeklyRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestTrendsWeeklyMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \trends\weekly rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最近一周内的热门话题。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/trends/weekly.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestTrendsWeekly(TrendsWeeklyRequest request)
		{
			return RequestTrendsWeeklyAsync(request).Result;
		}
		
				
		JsonMethod<UserFriendsUpdateRemarkRequest, Stream> _requestUserFriendsUpdateRemarkMethod;
		/// <summary>
		/// This is a async request of \user\friends\update_remark rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/user/friends/update_remark.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestUserFriendsUpdateRemarkAsync (
			UserFriendsUpdateRemarkRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestUserFriendsUpdateRemarkMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \user\friends\update_remark rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/user/friends/update_remark.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestUserFriendsUpdateRemark(UserFriendsUpdateRemarkRequest request)
		{
			return RequestUserFriendsUpdateRemarkAsync(request).Result;
		}
		
				
		JsonMethod<UsersHotRequest, Stream> _requestUsersHotMethod;
		/// <summary>
		/// This is a async request of \users\hot rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回系统推荐的用户列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/hot.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestUsersHotAsync (
			UsersHotRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestUsersHotMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \users\hot rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回系统推荐的用户列表。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/hot.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestUsersHot(UsersHotRequest request)
		{
			return RequestUsersHotAsync(request).Result;
		}
		
				
		JsonMethod<UsersShowRequest, Stream> _requestUsersShowMethod;
		/// <summary>
		/// This is a async request of \users\show rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>按用户ID或昵称返回用户资料以及用户的最新发布的一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestUsersShowAsync (
			UsersShowRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestUsersShowMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \users\show rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>按用户ID或昵称返回用户资料以及用户的最新发布的一条微博消息。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/show.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestUsersShow(UsersShowRequest request)
		{
			return RequestUsersShowAsync(request).Result;
		}
		
				
		JsonMethod<UsersSuggestionsRequest, Stream> _requestUsersSuggestionsMethod;
		/// <summary>
		/// This is a async request of \users\suggestions rest call. 
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回当前用户可能感兴趣的用户。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public async Task<JsonResponse<Stream>> RequestUsersSuggestionsAsync (
			UsersSuggestionsRequest request,
			CancellationToken cancellationToken =default(CancellationToken),
			IProgress<ProgressReport> progress=null 
			)			
		{
			return await _requestUsersSuggestionsMethod.GetResponseAsync(request, cancellationToken, progress);
		}
		/// <summary>
		/// This is a sync request of \users\suggestions rest call.
		///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回当前用户可能感兴趣的用户。 </para>
		///<para>URL:</para>
		///<para>	http://api.t.sina.com.cn/users/suggestions.(json|xml)</para>
		///<para>支持格式:</para>
		///<para>	XML/JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	true  关于授权机制，参见授权机制声明</para>
		///<para>请求数限制:</para>
		///<para>	true  关于请求数限制，参见接口访问权限说明</para>
		///<para></para>
		/// </summary>
		public JsonResponse<Stream> RequestUsersSuggestions(UsersSuggestionsRequest request)
		{
			return RequestUsersSuggestionsAsync(request).Result;
		}
		
				
	}

}

 