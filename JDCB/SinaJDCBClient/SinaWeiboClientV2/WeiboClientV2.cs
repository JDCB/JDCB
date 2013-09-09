 


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

    public partial class WeiboClientV2 : JsonClientBase
    {
        public WeiboClientV2()
        {
            //TODO: Set BaseUri property Here 在这里指定服务基础地址
            BaseUri = new Uri("https://api.weibo.com/2");
                    
        _executeEmotionsMethod = new JsonMethod<Emotions.Request, Emotions.Response>(this, new Uri("emotions.json", UriKind.Relative));
                    
        _executeCommentsByMeMethod = new JsonMethod<CommentsByMe.Request, CommentsByMe.Response>(this, new Uri("comments/by_me.json", UriKind.Relative));
                    
        _executeCommentsCreateMethod = new JsonMethod<CommentsCreate.Request, CommentsCreate.Response>(this, new Uri("comments/create.json", UriKind.Relative));
                    
        _executeCommentsDestroyMethod = new JsonMethod<CommentsDestroy.Request, CommentsDestroy.Response>(this, new Uri("comments/destroy.json", UriKind.Relative));
                    
        _executeCommentsDestroyBatchMethod = new JsonMethod<CommentsDestroyBatch.Request, CommentsDestroyBatch.Response>(this, new Uri("comments/destroy_batch.json", UriKind.Relative));
                    
        _executeCommentsMentionsMethod = new JsonMethod<CommentsMentions.Request, CommentsMentions.Response>(this, new Uri("comments/mentions.json", UriKind.Relative));
                    
        _executeCommentsReplyMethod = new JsonMethod<CommentsReply.Request, CommentsReply.Response>(this, new Uri("comments/reply.json", UriKind.Relative));
                    
        _executeCommentsShowMethod = new JsonMethod<CommentsShow.Request, CommentsShow.Response>(this, new Uri("comments/show.json", UriKind.Relative));
                    
        _executeCommentsShowBatchMethod = new JsonMethod<CommentsShowBatch.Request, CommentsShowBatch.Response>(this, new Uri("comments/show_batch.json", UriKind.Relative));
                    
        _executeCommentsTimelineMethod = new JsonMethod<CommentsTimeline.Request, CommentsTimeline.Response>(this, new Uri("comments/timeline.json", UriKind.Relative));
                    
        _executeCommentsToMeMethod = new JsonMethod<CommentsToMe.Request, CommentsToMe.Response>(this, new Uri("comments/to_me.json", UriKind.Relative));
                    
        _executeFriendshipsCreateMethod = new JsonMethod<FriendshipsCreate.Request, FriendshipsCreate.Response>(this, new Uri("friendships/create.json", UriKind.Relative));
                    
        _executeFriendshipsDestroyMethod = new JsonMethod<FriendshipsDestroy.Request, FriendshipsDestroy.Response>(this, new Uri("friendships/destroy.json", UriKind.Relative));
                    
        _executeFriendshipsFollowersMethod = new JsonMethod<FriendshipsFollowers.Request, FriendshipsFollowers.Response>(this, new Uri("friendships/followers.json", UriKind.Relative));
                    
        _executeFriendshipsFriendsMethod = new JsonMethod<FriendshipsFriends.Request, FriendshipsFriends.Response>(this, new Uri("friendships/friends.json", UriKind.Relative));
                    
        _executeFriendshipsGroupsMethod = new JsonMethod<FriendshipsGroups.Request, FriendshipsGroups.Response>(this, new Uri("friendships/groups.json", UriKind.Relative));
                    
        _executeFriendshipsShowMethod = new JsonMethod<FriendshipsShow.Request, FriendshipsShow.Response>(this, new Uri("friendships/show.json", UriKind.Relative));
                    
        _executeFriendshipsFollowersActiveMethod = new JsonMethod<FriendshipsFollowersActive.Request, FriendshipsFollowersActive.Response>(this, new Uri("friendships/followers/active.json", UriKind.Relative));
                    
        _executeFriendshipsFollowersIdsMethod = new JsonMethod<FriendshipsFollowersIds.Request, FriendshipsFollowersIds.Response>(this, new Uri("friendships/followers/ids.json", UriKind.Relative));
                    
        _executeFriendshipsFriendsBilateralMethod = new JsonMethod<FriendshipsFriendsBilateral.Request, FriendshipsFriendsBilateral.Response>(this, new Uri("friendships/friends/bilateral.json", UriKind.Relative));
                    
        _executeFriendshipsFriendsIdsMethod = new JsonMethod<FriendshipsFriendsIds.Request, FriendshipsFriendsIds.Response>(this, new Uri("friendships/friends/ids.json", UriKind.Relative));
                    
        _executeFriendshipsFriendsInCommonMethod = new JsonMethod<FriendshipsFriendsInCommon.Request, FriendshipsFriendsInCommon.Response>(this, new Uri("friendships/friends/in_common.json", UriKind.Relative));
                    
        _executeFriendshipsFriendsBilateralIdsMethod = new JsonMethod<FriendshipsFriendsBilateralIds.Request, FriendshipsFriendsBilateralIds.Response>(this, new Uri("friendships/friends/bilateral/ids.json", UriKind.Relative));
                    
        _executeFriendshipsFriendsChainFollowersMethod = new JsonMethod<FriendshipsFriendsChainFollowers.Request, FriendshipsFriendsChainFollowers.Response>(this, new Uri("friendships/friends_chain/followers.json", UriKind.Relative));
                    
        _executeFriendshipsRemarkUpdateMethod = new JsonMethod<FriendshipsRemarkUpdate.Request, FriendshipsRemarkUpdate.Response>(this, new Uri("friendships/remark/update.json", UriKind.Relative));
                    
        _executeStatusesBilateralTimelineMethod = new JsonMethod<StatusesBilateralTimeline.Request, StatusesBilateralTimeline.Response>(this, new Uri("statuses/bilateral_timeline.json", UriKind.Relative));
                    
        _executeStatusesCountMethod = new JsonMethod<StatusesCount.Request, StatusesCount.Response>(this, new Uri("statuses/count.json", UriKind.Relative));
                    
        _executeStatusesDestroyMethod = new JsonMethod<StatusesDestroy.Request, StatusesDestroy.Response>(this, new Uri("statuses/destroy.json", UriKind.Relative));
                    
        _executeStatusesFriendsTimelineMethod = new JsonMethod<StatusesFriendsTimeline.Request, StatusesFriendsTimeline.Response>(this, new Uri("statuses/friends_timeline.json", UriKind.Relative));
                    
        _executeStatusesHomeTimelineMethod = new JsonMethod<StatusesHomeTimeline.Request, StatusesHomeTimeline.Response>(this, new Uri("statuses/home_timeline.json", UriKind.Relative));
                    
        _executeStatusesMentionsMethod = new JsonMethod<StatusesMentions.Request, StatusesMentions.Response>(this, new Uri("statuses/mentions.json", UriKind.Relative));
                    
        _executeStatusesPublicTimelineMethod = new JsonMethod<StatusesPublicTimeline.Request, StatusesPublicTimeline.Response>(this, new Uri("statuses/public_timeline.json", UriKind.Relative));
                    
        _executeStatusesQueryidMethod = new JsonMethod<StatusesQueryid.Request, StatusesQueryid.Response>(this, new Uri("statuses/queryid.json", UriKind.Relative));
                    
        _executeStatusesQuerymidMethod = new JsonMethod<StatusesQuerymid.Request, StatusesQuerymid.Response>(this, new Uri("statuses/querymid.json", UriKind.Relative));
                    
        _executeStatusesRepostMethod = new JsonMethod<StatusesRepost.Request, StatusesRepost.Response>(this, new Uri("statuses/repost.json", UriKind.Relative));
                    
        _executeStatusesRepostByMeMethod = new JsonMethod<StatusesRepostByMe.Request, StatusesRepostByMe.Response>(this, new Uri("statuses/repost_by_me.json", UriKind.Relative));
                    
        _executeStatusesRepostTimelineMethod = new JsonMethod<StatusesRepostTimeline.Request, StatusesRepostTimeline.Response>(this, new Uri("statuses/repost_timeline.json", UriKind.Relative));
                    
        _executeStatusesShowMethod = new JsonMethod<StatusesShow.Request, StatusesShow.Response>(this, new Uri("statuses/show.json", UriKind.Relative));
                    
        _executeStatusesUpdateMethod = new JsonMethod<StatusesUpdate.Request, StatusesUpdate.Response>(this, new Uri("statuses/update.json", UriKind.Relative));
                    
        _executeStatusesUploadMethod = new JsonMethod<StatusesUpload.Request, StatusesUpload.Response>(this, new Uri("statuses/upload.json", UriKind.Relative));
                    
        _executeStatusesUploadUrlTextMethod = new JsonMethod<StatusesUploadUrlText.Request, StatusesUploadUrlText.Response>(this, new Uri("statuses/upload_url_text.json", UriKind.Relative));
                    
        _executeStatusesUserTimelineMethod = new JsonMethod<StatusesUserTimeline.Request, StatusesUserTimeline.Response>(this, new Uri("statuses/user_timeline.json", UriKind.Relative));
                    
        _executeStatusesFilterCreateMethod = new JsonMethod<StatusesFilterCreate.Request, StatusesFilterCreate.Response>(this, new Uri("statuses/filter/create.json", UriKind.Relative));
                    
        _executeStatusesFriendsTimelineIdsMethod = new JsonMethod<StatusesFriendsTimelineIds.Request, StatusesFriendsTimelineIds.Response>(this, new Uri("statuses/friends_timeline/ids.json", UriKind.Relative));
                    
        _executeStatusesMentionsIdsMethod = new JsonMethod<StatusesMentionsIds.Request, StatusesMentionsIds.Response>(this, new Uri("statuses/mentions/ids.json", UriKind.Relative));
                    
        _executeStatusesMentionsShieldMethod = new JsonMethod<StatusesMentionsShield.Request, StatusesMentionsShield.Response>(this, new Uri("statuses/mentions/shield.json", UriKind.Relative));
                    
        _executeStatusesRepostTimelineIdsMethod = new JsonMethod<StatusesRepostTimelineIds.Request, StatusesRepostTimelineIds.Response>(this, new Uri("statuses/repost_timeline/ids.json", UriKind.Relative));
                    
        _executeStatusesToMeIdsMethod = new JsonMethod<StatusesToMeIds.Request, StatusesToMeIds.Response>(this, new Uri("statuses/to_me/ids.json", UriKind.Relative));
                    
        _executeStatusesUserTimelineIdsMethod = new JsonMethod<StatusesUserTimelineIds.Request, StatusesUserTimelineIds.Response>(this, new Uri("statuses/user_timeline/ids.json", UriKind.Relative));
                    
        _executeUsersCancelTopStatusMethod = new JsonMethod<UsersCancelTopStatus.Request, UsersCancelTopStatus.Response>(this, new Uri("users/cancel_top_status.json", UriKind.Relative));
                    
        _executeUsersCountsMethod = new JsonMethod<UsersCounts.Request, UsersCounts.Response>(this, new Uri("users/counts.json", UriKind.Relative));
                    
        _executeUsersDomainShowMethod = new JsonMethod<UsersDomainShow.Request, UsersDomainShow.Response>(this, new Uri("users/domain_show.json", UriKind.Relative));
                    
        _executeUsersGetTopStatusMethod = new JsonMethod<UsersGetTopStatus.Request, UsersGetTopStatus.Response>(this, new Uri("users/get_top_status.json", UriKind.Relative));
                    
        _executeUsersSetTopStatusMethod = new JsonMethod<UsersSetTopStatus.Request, UsersSetTopStatus.Response>(this, new Uri("users/set_top_status.json", UriKind.Relative));
                    
        _executeUsersShowMethod = new JsonMethod<UsersShow.Request, UsersShow.Response>(this, new Uri("users/show.json", UriKind.Relative));
                    
        _executeUsersShowRankMethod = new JsonMethod<UsersShowRank.Request, UsersShowRank.Response>(this, new Uri("users/show_rank.json", UriKind.Relative));
                    
                _requestEmotionsMethod = new JsonMethod<Emotions.Request, Stream>(this, new Uri("emotions.json", UriKind.Relative));
                _requestCommentsByMeMethod = new JsonMethod<CommentsByMe.Request, Stream>(this, new Uri("comments/by_me.json", UriKind.Relative));
                _requestCommentsCreateMethod = new JsonMethod<CommentsCreate.Request, Stream>(this, new Uri("comments/create.json", UriKind.Relative));
                _requestCommentsDestroyMethod = new JsonMethod<CommentsDestroy.Request, Stream>(this, new Uri("comments/destroy.json", UriKind.Relative));
                _requestCommentsDestroyBatchMethod = new JsonMethod<CommentsDestroyBatch.Request, Stream>(this, new Uri("comments/destroy_batch.json", UriKind.Relative));
                _requestCommentsMentionsMethod = new JsonMethod<CommentsMentions.Request, Stream>(this, new Uri("comments/mentions.json", UriKind.Relative));
                _requestCommentsReplyMethod = new JsonMethod<CommentsReply.Request, Stream>(this, new Uri("comments/reply.json", UriKind.Relative));
                _requestCommentsShowMethod = new JsonMethod<CommentsShow.Request, Stream>(this, new Uri("comments/show.json", UriKind.Relative));
                _requestCommentsShowBatchMethod = new JsonMethod<CommentsShowBatch.Request, Stream>(this, new Uri("comments/show_batch.json", UriKind.Relative));
                _requestCommentsTimelineMethod = new JsonMethod<CommentsTimeline.Request, Stream>(this, new Uri("comments/timeline.json", UriKind.Relative));
                _requestCommentsToMeMethod = new JsonMethod<CommentsToMe.Request, Stream>(this, new Uri("comments/to_me.json", UriKind.Relative));
                _requestFriendshipsCreateMethod = new JsonMethod<FriendshipsCreate.Request, Stream>(this, new Uri("friendships/create.json", UriKind.Relative));
                _requestFriendshipsDestroyMethod = new JsonMethod<FriendshipsDestroy.Request, Stream>(this, new Uri("friendships/destroy.json", UriKind.Relative));
                _requestFriendshipsFollowersMethod = new JsonMethod<FriendshipsFollowers.Request, Stream>(this, new Uri("friendships/followers.json", UriKind.Relative));
                _requestFriendshipsFriendsMethod = new JsonMethod<FriendshipsFriends.Request, Stream>(this, new Uri("friendships/friends.json", UriKind.Relative));
                _requestFriendshipsGroupsMethod = new JsonMethod<FriendshipsGroups.Request, Stream>(this, new Uri("friendships/groups.json", UriKind.Relative));
                _requestFriendshipsShowMethod = new JsonMethod<FriendshipsShow.Request, Stream>(this, new Uri("friendships/show.json", UriKind.Relative));
                _requestFriendshipsFollowersActiveMethod = new JsonMethod<FriendshipsFollowersActive.Request, Stream>(this, new Uri("friendships/followers/active.json", UriKind.Relative));
                _requestFriendshipsFollowersIdsMethod = new JsonMethod<FriendshipsFollowersIds.Request, Stream>(this, new Uri("friendships/followers/ids.json", UriKind.Relative));
                _requestFriendshipsFriendsBilateralMethod = new JsonMethod<FriendshipsFriendsBilateral.Request, Stream>(this, new Uri("friendships/friends/bilateral.json", UriKind.Relative));
                _requestFriendshipsFriendsIdsMethod = new JsonMethod<FriendshipsFriendsIds.Request, Stream>(this, new Uri("friendships/friends/ids.json", UriKind.Relative));
                _requestFriendshipsFriendsInCommonMethod = new JsonMethod<FriendshipsFriendsInCommon.Request, Stream>(this, new Uri("friendships/friends/in_common.json", UriKind.Relative));
                _requestFriendshipsFriendsBilateralIdsMethod = new JsonMethod<FriendshipsFriendsBilateralIds.Request, Stream>(this, new Uri("friendships/friends/bilateral/ids.json", UriKind.Relative));
                _requestFriendshipsFriendsChainFollowersMethod = new JsonMethod<FriendshipsFriendsChainFollowers.Request, Stream>(this, new Uri("friendships/friends_chain/followers.json", UriKind.Relative));
                _requestFriendshipsRemarkUpdateMethod = new JsonMethod<FriendshipsRemarkUpdate.Request, Stream>(this, new Uri("friendships/remark/update.json", UriKind.Relative));
                _requestStatusesBilateralTimelineMethod = new JsonMethod<StatusesBilateralTimeline.Request, Stream>(this, new Uri("statuses/bilateral_timeline.json", UriKind.Relative));
                _requestStatusesCountMethod = new JsonMethod<StatusesCount.Request, Stream>(this, new Uri("statuses/count.json", UriKind.Relative));
                _requestStatusesDestroyMethod = new JsonMethod<StatusesDestroy.Request, Stream>(this, new Uri("statuses/destroy.json", UriKind.Relative));
                _requestStatusesFriendsTimelineMethod = new JsonMethod<StatusesFriendsTimeline.Request, Stream>(this, new Uri("statuses/friends_timeline.json", UriKind.Relative));
                _requestStatusesHomeTimelineMethod = new JsonMethod<StatusesHomeTimeline.Request, Stream>(this, new Uri("statuses/home_timeline.json", UriKind.Relative));
                _requestStatusesMentionsMethod = new JsonMethod<StatusesMentions.Request, Stream>(this, new Uri("statuses/mentions.json", UriKind.Relative));
                _requestStatusesPublicTimelineMethod = new JsonMethod<StatusesPublicTimeline.Request, Stream>(this, new Uri("statuses/public_timeline.json", UriKind.Relative));
                _requestStatusesQueryidMethod = new JsonMethod<StatusesQueryid.Request, Stream>(this, new Uri("statuses/queryid.json", UriKind.Relative));
                _requestStatusesQuerymidMethod = new JsonMethod<StatusesQuerymid.Request, Stream>(this, new Uri("statuses/querymid.json", UriKind.Relative));
                _requestStatusesRepostMethod = new JsonMethod<StatusesRepost.Request, Stream>(this, new Uri("statuses/repost.json", UriKind.Relative));
                _requestStatusesRepostByMeMethod = new JsonMethod<StatusesRepostByMe.Request, Stream>(this, new Uri("statuses/repost_by_me.json", UriKind.Relative));
                _requestStatusesRepostTimelineMethod = new JsonMethod<StatusesRepostTimeline.Request, Stream>(this, new Uri("statuses/repost_timeline.json", UriKind.Relative));
                _requestStatusesShowMethod = new JsonMethod<StatusesShow.Request, Stream>(this, new Uri("statuses/show.json", UriKind.Relative));
                _requestStatusesUpdateMethod = new JsonMethod<StatusesUpdate.Request, Stream>(this, new Uri("statuses/update.json", UriKind.Relative));
                _requestStatusesUploadMethod = new JsonMethod<StatusesUpload.Request, Stream>(this, new Uri("statuses/upload.json", UriKind.Relative));
                _requestStatusesUploadUrlTextMethod = new JsonMethod<StatusesUploadUrlText.Request, Stream>(this, new Uri("statuses/upload_url_text.json", UriKind.Relative));
                _requestStatusesUserTimelineMethod = new JsonMethod<StatusesUserTimeline.Request, Stream>(this, new Uri("statuses/user_timeline.json", UriKind.Relative));
                _requestStatusesFilterCreateMethod = new JsonMethod<StatusesFilterCreate.Request, Stream>(this, new Uri("statuses/filter/create.json", UriKind.Relative));
                _requestStatusesFriendsTimelineIdsMethod = new JsonMethod<StatusesFriendsTimelineIds.Request, Stream>(this, new Uri("statuses/friends_timeline/ids.json", UriKind.Relative));
                _requestStatusesMentionsIdsMethod = new JsonMethod<StatusesMentionsIds.Request, Stream>(this, new Uri("statuses/mentions/ids.json", UriKind.Relative));
                _requestStatusesMentionsShieldMethod = new JsonMethod<StatusesMentionsShield.Request, Stream>(this, new Uri("statuses/mentions/shield.json", UriKind.Relative));
                _requestStatusesRepostTimelineIdsMethod = new JsonMethod<StatusesRepostTimelineIds.Request, Stream>(this, new Uri("statuses/repost_timeline/ids.json", UriKind.Relative));
                _requestStatusesToMeIdsMethod = new JsonMethod<StatusesToMeIds.Request, Stream>(this, new Uri("statuses/to_me/ids.json", UriKind.Relative));
                _requestStatusesUserTimelineIdsMethod = new JsonMethod<StatusesUserTimelineIds.Request, Stream>(this, new Uri("statuses/user_timeline/ids.json", UriKind.Relative));
                _requestUsersCancelTopStatusMethod = new JsonMethod<UsersCancelTopStatus.Request, Stream>(this, new Uri("users/cancel_top_status.json", UriKind.Relative));
                _requestUsersCountsMethod = new JsonMethod<UsersCounts.Request, Stream>(this, new Uri("users/counts.json", UriKind.Relative));
                _requestUsersDomainShowMethod = new JsonMethod<UsersDomainShow.Request, Stream>(this, new Uri("users/domain_show.json", UriKind.Relative));
                _requestUsersGetTopStatusMethod = new JsonMethod<UsersGetTopStatus.Request, Stream>(this, new Uri("users/get_top_status.json", UriKind.Relative));
                _requestUsersSetTopStatusMethod = new JsonMethod<UsersSetTopStatus.Request, Stream>(this, new Uri("users/set_top_status.json", UriKind.Relative));
                _requestUsersShowMethod = new JsonMethod<UsersShow.Request, Stream>(this, new Uri("users/show.json", UriKind.Relative));
                _requestUsersShowRankMethod = new JsonMethod<UsersShowRank.Request, Stream>(this, new Uri("users/show_rank.json", UriKind.Relative));
            }
        
                
        /// <summary>
        /// Path\emotions
        /// </summary>
        JsonMethod<Emotions.Request, Emotions.Response> _executeEmotionsMethod;
        
        /// <summary>
        /// This is a async execution of \emotions rest call. 
        /// It returns JsonResponse&lt;Emotions.Response&gt;
		/// Here comes request Comments:
		///<para>获取微博官方表情的详细信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/emotions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：否  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Emotions.Response>> ExecuteEmotionsAsync (
            Emotions.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeEmotionsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \emotions rest call. 
        /// It returns JsonResponse&lt;Emotions.Response&gt;
		/// Here comes request Comments:
		///<para>获取微博官方表情的详细信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/emotions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：否  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Emotions.Response> ExecuteEmotions(Emotions.Request request)
        {
            return ExecuteEmotionsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\by_me
        /// </summary>
        JsonMethod<CommentsByMe.Request, CommentsByMe.Response> _executeCommentsByMeMethod;
        
        /// <summary>
        /// This is a async execution of \comments\by_me rest call. 
        /// It returns JsonResponse&lt;CommentsByMe.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户所发出的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/by_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsByMe.Response>> ExecuteCommentsByMeAsync (
            CommentsByMe.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsByMeMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\by_me rest call. 
        /// It returns JsonResponse&lt;CommentsByMe.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户所发出的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/by_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsByMe.Response> ExecuteCommentsByMe(CommentsByMe.Request request)
        {
            return ExecuteCommentsByMeAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\create
        /// </summary>
        JsonMethod<CommentsCreate.Request, CommentsCreate.Response> _executeCommentsCreateMethod;
        
        /// <summary>
        /// This is a async execution of \comments\create rest call. 
        /// It returns JsonResponse&lt;CommentsCreate.Response&gt;
		/// Here comes request Comments:
		///<para>对一条微博进行评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsCreate.Response>> ExecuteCommentsCreateAsync (
            CommentsCreate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\create rest call. 
        /// It returns JsonResponse&lt;CommentsCreate.Response&gt;
		/// Here comes request Comments:
		///<para>对一条微博进行评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsCreate.Response> ExecuteCommentsCreate(CommentsCreate.Request request)
        {
            return ExecuteCommentsCreateAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\destroy
        /// </summary>
        JsonMethod<CommentsDestroy.Request, CommentsDestroy.Response> _executeCommentsDestroyMethod;
        
        /// <summary>
        /// This is a async execution of \comments\destroy rest call. 
        /// It returns JsonResponse&lt;CommentsDestroy.Response&gt;
		/// Here comes request Comments:
		///<para>删除一条评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsDestroy.Response>> ExecuteCommentsDestroyAsync (
            CommentsDestroy.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\destroy rest call. 
        /// It returns JsonResponse&lt;CommentsDestroy.Response&gt;
		/// Here comes request Comments:
		///<para>删除一条评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsDestroy.Response> ExecuteCommentsDestroy(CommentsDestroy.Request request)
        {
            return ExecuteCommentsDestroyAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\destroy_batch
        /// </summary>
        JsonMethod<CommentsDestroyBatch.Request, CommentsDestroyBatch.Response> _executeCommentsDestroyBatchMethod;
        
        /// <summary>
        /// This is a async execution of \comments\destroy_batch rest call. 
        /// It returns JsonResponse&lt;CommentsDestroyBatch.Response&gt;
		/// Here comes request Comments:
		///<para>根据评论ID批量删除评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/destroy_batch.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsDestroyBatch.Response>> ExecuteCommentsDestroyBatchAsync (
            CommentsDestroyBatch.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\destroy_batch rest call. 
        /// It returns JsonResponse&lt;CommentsDestroyBatch.Response&gt;
		/// Here comes request Comments:
		///<para>根据评论ID批量删除评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/destroy_batch.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsDestroyBatch.Response> ExecuteCommentsDestroyBatch(CommentsDestroyBatch.Request request)
        {
            return ExecuteCommentsDestroyBatchAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\mentions
        /// </summary>
        JsonMethod<CommentsMentions.Request, CommentsMentions.Response> _executeCommentsMentionsMethod;
        
        /// <summary>
        /// This is a async execution of \comments\mentions rest call. 
        /// It returns JsonResponse&lt;CommentsMentions.Response&gt;
		/// Here comes request Comments:
		///<para>获取最新的提到当前登录用户的评论，即@我的评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/mentions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsMentions.Response>> ExecuteCommentsMentionsAsync (
            CommentsMentions.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsMentionsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\mentions rest call. 
        /// It returns JsonResponse&lt;CommentsMentions.Response&gt;
		/// Here comes request Comments:
		///<para>获取最新的提到当前登录用户的评论，即@我的评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/mentions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsMentions.Response> ExecuteCommentsMentions(CommentsMentions.Request request)
        {
            return ExecuteCommentsMentionsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\reply
        /// </summary>
        JsonMethod<CommentsReply.Request, CommentsReply.Response> _executeCommentsReplyMethod;
        
        /// <summary>
        /// This is a async execution of \comments\reply rest call. 
        /// It returns JsonResponse&lt;CommentsReply.Response&gt;
		/// Here comes request Comments:
		///<para>回复一条评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/reply.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsReply.Response>> ExecuteCommentsReplyAsync (
            CommentsReply.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsReplyMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\reply rest call. 
        /// It returns JsonResponse&lt;CommentsReply.Response&gt;
		/// Here comes request Comments:
		///<para>回复一条评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/reply.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsReply.Response> ExecuteCommentsReply(CommentsReply.Request request)
        {
            return ExecuteCommentsReplyAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\show
        /// </summary>
        JsonMethod<CommentsShow.Request, CommentsShow.Response> _executeCommentsShowMethod;
        
        /// <summary>
        /// This is a async execution of \comments\show rest call. 
        /// It returns JsonResponse&lt;CommentsShow.Response&gt;
		/// Here comes request Comments:
		///<para>根据微博ID返回某条微博的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsShow.Response>> ExecuteCommentsShowAsync (
            CommentsShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\show rest call. 
        /// It returns JsonResponse&lt;CommentsShow.Response&gt;
		/// Here comes request Comments:
		///<para>根据微博ID返回某条微博的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsShow.Response> ExecuteCommentsShow(CommentsShow.Request request)
        {
            return ExecuteCommentsShowAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\show_batch
        /// </summary>
        JsonMethod<CommentsShowBatch.Request, CommentsShowBatch.Response> _executeCommentsShowBatchMethod;
        
        /// <summary>
        /// This is a async execution of \comments\show_batch rest call. 
        /// It returns JsonResponse&lt;CommentsShowBatch.Response&gt;
		/// Here comes request Comments:
		///<para>根据评论ID批量返回评论信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/show_batch.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsShowBatch.Response>> ExecuteCommentsShowBatchAsync (
            CommentsShowBatch.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsShowBatchMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\show_batch rest call. 
        /// It returns JsonResponse&lt;CommentsShowBatch.Response&gt;
		/// Here comes request Comments:
		///<para>根据评论ID批量返回评论信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/show_batch.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsShowBatch.Response> ExecuteCommentsShowBatch(CommentsShowBatch.Request request)
        {
            return ExecuteCommentsShowBatchAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\timeline
        /// </summary>
        JsonMethod<CommentsTimeline.Request, CommentsTimeline.Response> _executeCommentsTimelineMethod;
        
        /// <summary>
        /// This is a async execution of \comments\timeline rest call. 
        /// It returns JsonResponse&lt;CommentsTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户的最新评论包括接收到的与发出的 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsTimeline.Response>> ExecuteCommentsTimelineAsync (
            CommentsTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\timeline rest call. 
        /// It returns JsonResponse&lt;CommentsTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户的最新评论包括接收到的与发出的 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsTimeline.Response> ExecuteCommentsTimeline(CommentsTimeline.Request request)
        {
            return ExecuteCommentsTimelineAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\comments\to_me
        /// </summary>
        JsonMethod<CommentsToMe.Request, CommentsToMe.Response> _executeCommentsToMeMethod;
        
        /// <summary>
        /// This is a async execution of \comments\to_me rest call. 
        /// It returns JsonResponse&lt;CommentsToMe.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户所接收到的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/to_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<CommentsToMe.Response>> ExecuteCommentsToMeAsync (
            CommentsToMe.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeCommentsToMeMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \comments\to_me rest call. 
        /// It returns JsonResponse&lt;CommentsToMe.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户所接收到的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/to_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<CommentsToMe.Response> ExecuteCommentsToMe(CommentsToMe.Request request)
        {
            return ExecuteCommentsToMeAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\create
        /// </summary>
        JsonMethod<FriendshipsCreate.Request, FriendshipsCreate.Response> _executeFriendshipsCreateMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\create rest call. 
        /// It returns JsonResponse&lt;FriendshipsCreate.Response&gt;
		/// Here comes request Comments:
		///<para>关注一个用户 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsCreate.Response>> ExecuteFriendshipsCreateAsync (
            FriendshipsCreate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\create rest call. 
        /// It returns JsonResponse&lt;FriendshipsCreate.Response&gt;
		/// Here comes request Comments:
		///<para>关注一个用户 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsCreate.Response> ExecuteFriendshipsCreate(FriendshipsCreate.Request request)
        {
            return ExecuteFriendshipsCreateAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\destroy
        /// </summary>
        JsonMethod<FriendshipsDestroy.Request, FriendshipsDestroy.Response> _executeFriendshipsDestroyMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\destroy rest call. 
        /// It returns JsonResponse&lt;FriendshipsDestroy.Response&gt;
		/// Here comes request Comments:
		///<para>取消关注一个用户 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsDestroy.Response>> ExecuteFriendshipsDestroyAsync (
            FriendshipsDestroy.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\destroy rest call. 
        /// It returns JsonResponse&lt;FriendshipsDestroy.Response&gt;
		/// Here comes request Comments:
		///<para>取消关注一个用户 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsDestroy.Response> ExecuteFriendshipsDestroy(FriendshipsDestroy.Request request)
        {
            return ExecuteFriendshipsDestroyAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\followers
        /// </summary>
        JsonMethod<FriendshipsFollowers.Request, FriendshipsFollowers.Response> _executeFriendshipsFollowersMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\followers rest call. 
        /// It returns JsonResponse&lt;FriendshipsFollowers.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户的粉丝列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一；最多返回5000条数据</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsFollowers.Response>> ExecuteFriendshipsFollowersAsync (
            FriendshipsFollowers.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsFollowersMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\followers rest call. 
        /// It returns JsonResponse&lt;FriendshipsFollowers.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户的粉丝列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一；最多返回5000条数据</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsFollowers.Response> ExecuteFriendshipsFollowers(FriendshipsFollowers.Request request)
        {
            return ExecuteFriendshipsFollowersAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\friends
        /// </summary>
        JsonMethod<FriendshipsFriends.Request, FriendshipsFriends.Response> _executeFriendshipsFriendsMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\friends rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriends.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户的关注列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsFriends.Response>> ExecuteFriendshipsFriendsAsync (
            FriendshipsFriends.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsFriendsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\friends rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriends.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户的关注列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsFriends.Response> ExecuteFriendshipsFriends(FriendshipsFriends.Request request)
        {
            return ExecuteFriendshipsFriendsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\groups
        /// </summary>
        JsonMethod<FriendshipsGroups.Request, FriendshipsGroups.Response> _executeFriendshipsGroupsMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\groups rest call. 
        /// It returns JsonResponse&lt;FriendshipsGroups.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登陆用户好友分组列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/groups.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	返回的数据按设置的分组顺序排序；   好友分组上限为20，“未分组”不计入上限；   "未分组"的分组ID为0，此接口不返回“未分组”；</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsGroups.Response>> ExecuteFriendshipsGroupsAsync (
            FriendshipsGroups.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsGroupsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\groups rest call. 
        /// It returns JsonResponse&lt;FriendshipsGroups.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登陆用户好友分组列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/groups.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	返回的数据按设置的分组顺序排序；   好友分组上限为20，“未分组”不计入上限；   "未分组"的分组ID为0，此接口不返回“未分组”；</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsGroups.Response> ExecuteFriendshipsGroups(FriendshipsGroups.Request request)
        {
            return ExecuteFriendshipsGroupsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\show
        /// </summary>
        JsonMethod<FriendshipsShow.Request, FriendshipsShow.Response> _executeFriendshipsShowMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\show rest call. 
        /// It returns JsonResponse&lt;FriendshipsShow.Response&gt;
		/// Here comes request Comments:
		///<para>获取两个用户之间的详细关注关系情况 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数source_id与source_screen_name二者必选其一，且只能选其一   参数target_id与target_screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsShow.Response>> ExecuteFriendshipsShowAsync (
            FriendshipsShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\show rest call. 
        /// It returns JsonResponse&lt;FriendshipsShow.Response&gt;
		/// Here comes request Comments:
		///<para>获取两个用户之间的详细关注关系情况 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数source_id与source_screen_name二者必选其一，且只能选其一   参数target_id与target_screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsShow.Response> ExecuteFriendshipsShow(FriendshipsShow.Request request)
        {
            return ExecuteFriendshipsShowAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\followers\active
        /// </summary>
        JsonMethod<FriendshipsFollowersActive.Request, FriendshipsFollowersActive.Response> _executeFriendshipsFollowersActiveMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\followers\active rest call. 
        /// It returns JsonResponse&lt;FriendshipsFollowersActive.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户的活跃粉丝列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers/active.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsFollowersActive.Response>> ExecuteFriendshipsFollowersActiveAsync (
            FriendshipsFollowersActive.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsFollowersActiveMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\followers\active rest call. 
        /// It returns JsonResponse&lt;FriendshipsFollowersActive.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户的活跃粉丝列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers/active.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsFollowersActive.Response> ExecuteFriendshipsFollowersActive(FriendshipsFollowersActive.Request request)
        {
            return ExecuteFriendshipsFollowersActiveAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\followers\ids
        /// </summary>
        JsonMethod<FriendshipsFollowersIds.Request, FriendshipsFollowersIds.Response> _executeFriendshipsFollowersIdsMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\followers\ids rest call. 
        /// It returns JsonResponse&lt;FriendshipsFollowersIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝的用户UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsFollowersIds.Response>> ExecuteFriendshipsFollowersIdsAsync (
            FriendshipsFollowersIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsFollowersIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\followers\ids rest call. 
        /// It returns JsonResponse&lt;FriendshipsFollowersIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝的用户UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsFollowersIds.Response> ExecuteFriendshipsFollowersIds(FriendshipsFollowersIds.Request request)
        {
            return ExecuteFriendshipsFollowersIdsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\friends\bilateral
        /// </summary>
        JsonMethod<FriendshipsFriendsBilateral.Request, FriendshipsFriendsBilateral.Response> _executeFriendshipsFriendsBilateralMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\friends\bilateral rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsBilateral.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户的双向关注列表，即互粉列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/bilateral.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	排序功能目前只支持一种</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsFriendsBilateral.Response>> ExecuteFriendshipsFriendsBilateralAsync (
            FriendshipsFriendsBilateral.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsFriendsBilateralMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\friends\bilateral rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsBilateral.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户的双向关注列表，即互粉列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/bilateral.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	排序功能目前只支持一种</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsFriendsBilateral.Response> ExecuteFriendshipsFriendsBilateral(FriendshipsFriendsBilateral.Request request)
        {
            return ExecuteFriendshipsFriendsBilateralAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\friends\ids
        /// </summary>
        JsonMethod<FriendshipsFriendsIds.Request, FriendshipsFriendsIds.Response> _executeFriendshipsFriendsIdsMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\friends\ids rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户关注的用户UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsFriendsIds.Response>> ExecuteFriendshipsFriendsIdsAsync (
            FriendshipsFriendsIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsFriendsIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\friends\ids rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户关注的用户UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsFriendsIds.Response> ExecuteFriendshipsFriendsIds(FriendshipsFriendsIds.Request request)
        {
            return ExecuteFriendshipsFriendsIdsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\friends\in_common
        /// </summary>
        JsonMethod<FriendshipsFriendsInCommon.Request, FriendshipsFriendsInCommon.Response> _executeFriendshipsFriendsInCommonMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\friends\in_common rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsInCommon.Response&gt;
		/// Here comes request Comments:
		///<para>获取两个用户之间的共同关注人列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/in_common.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsFriendsInCommon.Response>> ExecuteFriendshipsFriendsInCommonAsync (
            FriendshipsFriendsInCommon.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsFriendsInCommonMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\friends\in_common rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsInCommon.Response&gt;
		/// Here comes request Comments:
		///<para>获取两个用户之间的共同关注人列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/in_common.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsFriendsInCommon.Response> ExecuteFriendshipsFriendsInCommon(FriendshipsFriendsInCommon.Request request)
        {
            return ExecuteFriendshipsFriendsInCommonAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\friends\bilateral\ids
        /// </summary>
        JsonMethod<FriendshipsFriendsBilateralIds.Request, FriendshipsFriendsBilateralIds.Response> _executeFriendshipsFriendsBilateralIdsMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\friends\bilateral\ids rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsBilateralIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户双向关注的用户ID列表，即互粉UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/bilateral/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	排序功能目前只支持一种</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsFriendsBilateralIds.Response>> ExecuteFriendshipsFriendsBilateralIdsAsync (
            FriendshipsFriendsBilateralIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsFriendsBilateralIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\friends\bilateral\ids rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsBilateralIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户双向关注的用户ID列表，即互粉UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/bilateral/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	排序功能目前只支持一种</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsFriendsBilateralIds.Response> ExecuteFriendshipsFriendsBilateralIds(FriendshipsFriendsBilateralIds.Request request)
        {
            return ExecuteFriendshipsFriendsBilateralIdsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\friends_chain\followers
        /// </summary>
        JsonMethod<FriendshipsFriendsChainFollowers.Request, FriendshipsFriendsChainFollowers.Response> _executeFriendshipsFriendsChainFollowersMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\friends_chain\followers rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsChainFollowers.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户的关注人中又关注了指定用户的用户列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends_chain/followers.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsFriendsChainFollowers.Response>> ExecuteFriendshipsFriendsChainFollowersAsync (
            FriendshipsFriendsChainFollowers.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsFriendsChainFollowersMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\friends_chain\followers rest call. 
        /// It returns JsonResponse&lt;FriendshipsFriendsChainFollowers.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户的关注人中又关注了指定用户的用户列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends_chain/followers.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsFriendsChainFollowers.Response> ExecuteFriendshipsFriendsChainFollowers(FriendshipsFriendsChainFollowers.Request request)
        {
            return ExecuteFriendshipsFriendsChainFollowersAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\friendships\remark\update
        /// </summary>
        JsonMethod<FriendshipsRemarkUpdate.Request, FriendshipsRemarkUpdate.Response> _executeFriendshipsRemarkUpdateMethod;
        
        /// <summary>
        /// This is a async execution of \friendships\remark\update rest call. 
        /// It returns JsonResponse&lt;FriendshipsRemarkUpdate.Response&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/remark/update.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<FriendshipsRemarkUpdate.Response>> ExecuteFriendshipsRemarkUpdateAsync (
            FriendshipsRemarkUpdate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeFriendshipsRemarkUpdateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \friendships\remark\update rest call. 
        /// It returns JsonResponse&lt;FriendshipsRemarkUpdate.Response&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/remark/update.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<FriendshipsRemarkUpdate.Response> ExecuteFriendshipsRemarkUpdate(FriendshipsRemarkUpdate.Request request)
        {
            return ExecuteFriendshipsRemarkUpdateAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\bilateral_timeline
        /// </summary>
        JsonMethod<StatusesBilateralTimeline.Request, StatusesBilateralTimeline.Response> _executeStatusesBilateralTimelineMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\bilateral_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesBilateralTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取双向关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/bilateral_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesBilateralTimeline.Response>> ExecuteStatusesBilateralTimelineAsync (
            StatusesBilateralTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesBilateralTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\bilateral_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesBilateralTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取双向关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/bilateral_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesBilateralTimeline.Response> ExecuteStatusesBilateralTimeline(StatusesBilateralTimeline.Request request)
        {
            return ExecuteStatusesBilateralTimelineAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\count
        /// </summary>
        JsonMethod<StatusesCount.Request, StatusesCount.Response> _executeStatusesCountMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\count rest call. 
        /// It returns JsonResponse&lt;StatusesCount.Response&gt;
		/// Here comes request Comments:
		///<para>批量获取指定微博的转发数评论数 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/count.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesCount.Response>> ExecuteStatusesCountAsync (
            StatusesCount.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesCountMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\count rest call. 
        /// It returns JsonResponse&lt;StatusesCount.Response&gt;
		/// Here comes request Comments:
		///<para>批量获取指定微博的转发数评论数 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/count.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesCount.Response> ExecuteStatusesCount(StatusesCount.Request request)
        {
            return ExecuteStatusesCountAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\destroy
        /// </summary>
        JsonMethod<StatusesDestroy.Request, StatusesDestroy.Response> _executeStatusesDestroyMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\destroy rest call. 
        /// It returns JsonResponse&lt;StatusesDestroy.Response&gt;
		/// Here comes request Comments:
		///<para>根据微博ID删除指定微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	只能删除自己发布的微博</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesDestroy.Response>> ExecuteStatusesDestroyAsync (
            StatusesDestroy.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\destroy rest call. 
        /// It returns JsonResponse&lt;StatusesDestroy.Response&gt;
		/// Here comes request Comments:
		///<para>根据微博ID删除指定微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	只能删除自己发布的微博</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesDestroy.Response> ExecuteStatusesDestroy(StatusesDestroy.Request request)
        {
            return ExecuteStatusesDestroyAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\friends_timeline
        /// </summary>
        JsonMethod<StatusesFriendsTimeline.Request, StatusesFriendsTimeline.Response> _executeStatusesFriendsTimelineMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\friends_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesFriendsTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/friends_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesFriendsTimeline.Response>> ExecuteStatusesFriendsTimelineAsync (
            StatusesFriendsTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesFriendsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\friends_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesFriendsTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/friends_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesFriendsTimeline.Response> ExecuteStatusesFriendsTimeline(StatusesFriendsTimeline.Request request)
        {
            return ExecuteStatusesFriendsTimelineAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\home_timeline
        /// </summary>
        JsonMethod<StatusesHomeTimeline.Request, StatusesHomeTimeline.Response> _executeStatusesHomeTimelineMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\home_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesHomeTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/home_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesHomeTimeline.Response>> ExecuteStatusesHomeTimelineAsync (
            StatusesHomeTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesHomeTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\home_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesHomeTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/home_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesHomeTimeline.Response> ExecuteStatusesHomeTimeline(StatusesHomeTimeline.Request request)
        {
            return ExecuteStatusesHomeTimelineAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\mentions
        /// </summary>
        JsonMethod<StatusesMentions.Request, StatusesMentions.Response> _executeStatusesMentionsMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\mentions rest call. 
        /// It returns JsonResponse&lt;StatusesMentions.Response&gt;
		/// Here comes request Comments:
		///<para>获取最新的提到登录用户的微博列表，即@我的微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesMentions.Response>> ExecuteStatusesMentionsAsync (
            StatusesMentions.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesMentionsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\mentions rest call. 
        /// It returns JsonResponse&lt;StatusesMentions.Response&gt;
		/// Here comes request Comments:
		///<para>获取最新的提到登录用户的微博列表，即@我的微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesMentions.Response> ExecuteStatusesMentions(StatusesMentions.Request request)
        {
            return ExecuteStatusesMentionsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\public_timeline
        /// </summary>
        JsonMethod<StatusesPublicTimeline.Request, StatusesPublicTimeline.Response> _executeStatusesPublicTimelineMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\public_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesPublicTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>返回最新的200条公共微博，返回结果非完全实时 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/public_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesPublicTimeline.Response>> ExecuteStatusesPublicTimelineAsync (
            StatusesPublicTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesPublicTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\public_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesPublicTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>返回最新的200条公共微博，返回结果非完全实时 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/public_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesPublicTimeline.Response> ExecuteStatusesPublicTimeline(StatusesPublicTimeline.Request request)
        {
            return ExecuteStatusesPublicTimelineAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\queryid
        /// </summary>
        JsonMethod<StatusesQueryid.Request, StatusesQueryid.Response> _executeStatusesQueryidMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\queryid rest call. 
        /// It returns JsonResponse&lt;StatusesQueryid.Response&gt;
		/// Here comes request Comments:
		///<para>通过微博（评论、私信）MID获取其ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/queryid.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	否  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	形如“3z4efAo4lk”的MID即为经过base62转换的MID</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesQueryid.Response>> ExecuteStatusesQueryidAsync (
            StatusesQueryid.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesQueryidMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\queryid rest call. 
        /// It returns JsonResponse&lt;StatusesQueryid.Response&gt;
		/// Here comes request Comments:
		///<para>通过微博（评论、私信）MID获取其ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/queryid.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	否  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	形如“3z4efAo4lk”的MID即为经过base62转换的MID</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesQueryid.Response> ExecuteStatusesQueryid(StatusesQueryid.Request request)
        {
            return ExecuteStatusesQueryidAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\querymid
        /// </summary>
        JsonMethod<StatusesQuerymid.Request, StatusesQuerymid.Response> _executeStatusesQuerymidMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\querymid rest call. 
        /// It returns JsonResponse&lt;StatusesQuerymid.Response&gt;
		/// Here comes request Comments:
		///<para>通过微博（评论、私信）ID获取其MID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/querymid.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	否  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesQuerymid.Response>> ExecuteStatusesQuerymidAsync (
            StatusesQuerymid.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesQuerymidMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\querymid rest call. 
        /// It returns JsonResponse&lt;StatusesQuerymid.Response&gt;
		/// Here comes request Comments:
		///<para>通过微博（评论、私信）ID获取其MID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/querymid.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	否  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesQuerymid.Response> ExecuteStatusesQuerymid(StatusesQuerymid.Request request)
        {
            return ExecuteStatusesQuerymidAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\repost
        /// </summary>
        JsonMethod<StatusesRepost.Request, StatusesRepost.Response> _executeStatusesRepostMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\repost rest call. 
        /// It returns JsonResponse&lt;StatusesRepost.Response&gt;
		/// Here comes request Comments:
		///<para>转发一条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesRepost.Response>> ExecuteStatusesRepostAsync (
            StatusesRepost.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesRepostMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\repost rest call. 
        /// It returns JsonResponse&lt;StatusesRepost.Response&gt;
		/// Here comes request Comments:
		///<para>转发一条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesRepost.Response> ExecuteStatusesRepost(StatusesRepost.Request request)
        {
            return ExecuteStatusesRepostAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\repost_by_me
        /// </summary>
        JsonMethod<StatusesRepostByMe.Request, StatusesRepostByMe.Response> _executeStatusesRepostByMeMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\repost_by_me rest call. 
        /// It returns JsonResponse&lt;StatusesRepostByMe.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前用户最新转发的微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_by_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesRepostByMe.Response>> ExecuteStatusesRepostByMeAsync (
            StatusesRepostByMe.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesRepostByMeMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\repost_by_me rest call. 
        /// It returns JsonResponse&lt;StatusesRepostByMe.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前用户最新转发的微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_by_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesRepostByMe.Response> ExecuteStatusesRepostByMe(StatusesRepostByMe.Request request)
        {
            return ExecuteStatusesRepostByMeAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\repost_timeline
        /// </summary>
        JsonMethod<StatusesRepostTimeline.Request, StatusesRepostTimeline.Response> _executeStatusesRepostTimelineMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\repost_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesRepostTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取指定微博的转发微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesRepostTimeline.Response>> ExecuteStatusesRepostTimelineAsync (
            StatusesRepostTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesRepostTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\repost_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesRepostTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取指定微博的转发微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesRepostTimeline.Response> ExecuteStatusesRepostTimeline(StatusesRepostTimeline.Request request)
        {
            return ExecuteStatusesRepostTimelineAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\show
        /// </summary>
        JsonMethod<StatusesShow.Request, StatusesShow.Response> _executeStatusesShowMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\show rest call. 
        /// It returns JsonResponse&lt;StatusesShow.Response&gt;
		/// Here comes request Comments:
		///<para>根据微博ID获取单条微博内容 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesShow.Response>> ExecuteStatusesShowAsync (
            StatusesShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\show rest call. 
        /// It returns JsonResponse&lt;StatusesShow.Response&gt;
		/// Here comes request Comments:
		///<para>根据微博ID获取单条微博内容 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesShow.Response> ExecuteStatusesShow(StatusesShow.Request request)
        {
            return ExecuteStatusesShowAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\update
        /// </summary>
        JsonMethod<StatusesUpdate.Request, StatusesUpdate.Response> _executeStatusesUpdateMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\update rest call. 
        /// It returns JsonResponse&lt;StatusesUpdate.Response&gt;
		/// Here comes request Comments:
		///<para>发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/update.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesUpdate.Response>> ExecuteStatusesUpdateAsync (
            StatusesUpdate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesUpdateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\update rest call. 
        /// It returns JsonResponse&lt;StatusesUpdate.Response&gt;
		/// Here comes request Comments:
		///<para>发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/update.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesUpdate.Response> ExecuteStatusesUpdate(StatusesUpdate.Request request)
        {
            return ExecuteStatusesUpdateAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\upload
        /// </summary>
        JsonMethod<StatusesUpload.Request, StatusesUpload.Response> _executeStatusesUploadMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\upload rest call. 
        /// It returns JsonResponse&lt;StatusesUpload.Response&gt;
		/// Here comes request Comments:
		///<para>上传图片并发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://upload.api.weibo.com/2/statuses/upload.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	请求必须用POST方式提交，并且注意采用multipart/form-data编码方式；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesUpload.Response>> ExecuteStatusesUploadAsync (
            StatusesUpload.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesUploadMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\upload rest call. 
        /// It returns JsonResponse&lt;StatusesUpload.Response&gt;
		/// Here comes request Comments:
		///<para>上传图片并发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://upload.api.weibo.com/2/statuses/upload.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	请求必须用POST方式提交，并且注意采用multipart/form-data编码方式；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesUpload.Response> ExecuteStatusesUpload(StatusesUpload.Request request)
        {
            return ExecuteStatusesUploadAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\upload_url_text
        /// </summary>
        JsonMethod<StatusesUploadUrlText.Request, StatusesUploadUrlText.Response> _executeStatusesUploadUrlTextMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\upload_url_text rest call. 
        /// It returns JsonResponse&lt;StatusesUploadUrlText.Response&gt;
		/// Here comes request Comments:
		///<para>指定一个图片URL地址抓取后上传并同时发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/upload_url_text.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesUploadUrlText.Response>> ExecuteStatusesUploadUrlTextAsync (
            StatusesUploadUrlText.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesUploadUrlTextMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\upload_url_text rest call. 
        /// It returns JsonResponse&lt;StatusesUploadUrlText.Response&gt;
		/// Here comes request Comments:
		///<para>指定一个图片URL地址抓取后上传并同时发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/upload_url_text.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesUploadUrlText.Response> ExecuteStatusesUploadUrlText(StatusesUploadUrlText.Request request)
        {
            return ExecuteStatusesUploadUrlTextAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\user_timeline
        /// </summary>
        JsonMethod<StatusesUserTimeline.Request, StatusesUserTimeline.Response> _executeStatusesUserTimelineMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\user_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesUserTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取某个用户最新发表的微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/user_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesUserTimeline.Response>> ExecuteStatusesUserTimelineAsync (
            StatusesUserTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesUserTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\user_timeline rest call. 
        /// It returns JsonResponse&lt;StatusesUserTimeline.Response&gt;
		/// Here comes request Comments:
		///<para>获取某个用户最新发表的微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/user_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesUserTimeline.Response> ExecuteStatusesUserTimeline(StatusesUserTimeline.Request request)
        {
            return ExecuteStatusesUserTimelineAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\filter\create
        /// </summary>
        JsonMethod<StatusesFilterCreate.Request, StatusesFilterCreate.Response> _executeStatusesFilterCreateMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\filter\create rest call. 
        /// It returns JsonResponse&lt;StatusesFilterCreate.Response&gt;
		/// Here comes request Comments:
		///<para>屏蔽某条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/filter/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesFilterCreate.Response>> ExecuteStatusesFilterCreateAsync (
            StatusesFilterCreate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesFilterCreateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\filter\create rest call. 
        /// It returns JsonResponse&lt;StatusesFilterCreate.Response&gt;
		/// Here comes request Comments:
		///<para>屏蔽某条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/filter/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesFilterCreate.Response> ExecuteStatusesFilterCreate(StatusesFilterCreate.Request request)
        {
            return ExecuteStatusesFilterCreateAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\friends_timeline\ids
        /// </summary>
        JsonMethod<StatusesFriendsTimelineIds.Request, StatusesFriendsTimelineIds.Response> _executeStatusesFriendsTimelineIdsMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\friends_timeline\ids rest call. 
        /// It returns JsonResponse&lt;StatusesFriendsTimelineIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/friends_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesFriendsTimelineIds.Response>> ExecuteStatusesFriendsTimelineIdsAsync (
            StatusesFriendsTimelineIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesFriendsTimelineIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\friends_timeline\ids rest call. 
        /// It returns JsonResponse&lt;StatusesFriendsTimelineIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/friends_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesFriendsTimelineIds.Response> ExecuteStatusesFriendsTimelineIds(StatusesFriendsTimelineIds.Request request)
        {
            return ExecuteStatusesFriendsTimelineIdsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\mentions\ids
        /// </summary>
        JsonMethod<StatusesMentionsIds.Request, StatusesMentionsIds.Response> _executeStatusesMentionsIdsMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\mentions\ids rest call. 
        /// It returns JsonResponse&lt;StatusesMentionsIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取@当前用户的最新微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesMentionsIds.Response>> ExecuteStatusesMentionsIdsAsync (
            StatusesMentionsIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesMentionsIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\mentions\ids rest call. 
        /// It returns JsonResponse&lt;StatusesMentionsIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取@当前用户的最新微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesMentionsIds.Response> ExecuteStatusesMentionsIds(StatusesMentionsIds.Request request)
        {
            return ExecuteStatusesMentionsIdsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\mentions\shield
        /// </summary>
        JsonMethod<StatusesMentionsShield.Request, StatusesMentionsShield.Response> _executeStatusesMentionsShieldMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\mentions\shield rest call. 
        /// It returns JsonResponse&lt;StatusesMentionsShield.Response&gt;
		/// Here comes request Comments:
		///<para>屏蔽某个@到我的微博以及后续由对其转发引起的@提及 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions/shield.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesMentionsShield.Response>> ExecuteStatusesMentionsShieldAsync (
            StatusesMentionsShield.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesMentionsShieldMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\mentions\shield rest call. 
        /// It returns JsonResponse&lt;StatusesMentionsShield.Response&gt;
		/// Here comes request Comments:
		///<para>屏蔽某个@到我的微博以及后续由对其转发引起的@提及 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions/shield.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesMentionsShield.Response> ExecuteStatusesMentionsShield(StatusesMentionsShield.Request request)
        {
            return ExecuteStatusesMentionsShieldAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\repost_timeline\ids
        /// </summary>
        JsonMethod<StatusesRepostTimelineIds.Request, StatusesRepostTimelineIds.Response> _executeStatusesRepostTimelineIdsMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\repost_timeline\ids rest call. 
        /// It returns JsonResponse&lt;StatusesRepostTimelineIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取一条原创微博的最新转发微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesRepostTimelineIds.Response>> ExecuteStatusesRepostTimelineIdsAsync (
            StatusesRepostTimelineIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesRepostTimelineIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\repost_timeline\ids rest call. 
        /// It returns JsonResponse&lt;StatusesRepostTimelineIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取一条原创微博的最新转发微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesRepostTimelineIds.Response> ExecuteStatusesRepostTimelineIds(StatusesRepostTimelineIds.Request request)
        {
            return ExecuteStatusesRepostTimelineIdsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\to_me\ids
        /// </summary>
        JsonMethod<StatusesToMeIds.Request, StatusesToMeIds.Response> _executeStatusesToMeIdsMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\to_me\ids rest call. 
        /// It returns JsonResponse&lt;StatusesToMeIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户关注的人发给其的定向微博ID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/to_me/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	A与B互相关注，B在A的分组G中，A发送定向微博S到G，则，在B的【发给我的微博中】会包括S这条微博；</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesToMeIds.Response>> ExecuteStatusesToMeIdsAsync (
            StatusesToMeIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesToMeIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\to_me\ids rest call. 
        /// It returns JsonResponse&lt;StatusesToMeIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户关注的人发给其的定向微博ID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/to_me/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	A与B互相关注，B在A的分组G中，A发送定向微博S到G，则，在B的【发给我的微博中】会包括S这条微博；</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesToMeIds.Response> ExecuteStatusesToMeIds(StatusesToMeIds.Request request)
        {
            return ExecuteStatusesToMeIdsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\statuses\user_timeline\ids
        /// </summary>
        JsonMethod<StatusesUserTimelineIds.Request, StatusesUserTimelineIds.Response> _executeStatusesUserTimelineIdsMethod;
        
        /// <summary>
        /// This is a async execution of \statuses\user_timeline\ids rest call. 
        /// It returns JsonResponse&lt;StatusesUserTimelineIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户发布的微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/user_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一，uid优先   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<StatusesUserTimelineIds.Response>> ExecuteStatusesUserTimelineIdsAsync (
            StatusesUserTimelineIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeStatusesUserTimelineIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \statuses\user_timeline\ids rest call. 
        /// It returns JsonResponse&lt;StatusesUserTimelineIds.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户发布的微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/user_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一，uid优先   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		///<para></para>
        /// </summary>
        public JsonResponse<StatusesUserTimelineIds.Response> ExecuteStatusesUserTimelineIds(StatusesUserTimelineIds.Request request)
        {
            return ExecuteStatusesUserTimelineIdsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\users\cancel_top_status
        /// </summary>
        JsonMethod<UsersCancelTopStatus.Request, UsersCancelTopStatus.Response> _executeUsersCancelTopStatusMethod;
        
        /// <summary>
        /// This is a async execution of \users\cancel_top_status rest call. 
        /// It returns JsonResponse&lt;UsersCancelTopStatus.Response&gt;
		/// Here comes request Comments:
		///<para>取消当前用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/cancel_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<UsersCancelTopStatus.Response>> ExecuteUsersCancelTopStatusAsync (
            UsersCancelTopStatus.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeUsersCancelTopStatusMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \users\cancel_top_status rest call. 
        /// It returns JsonResponse&lt;UsersCancelTopStatus.Response&gt;
		/// Here comes request Comments:
		///<para>取消当前用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/cancel_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		///<para></para>
        /// </summary>
        public JsonResponse<UsersCancelTopStatus.Response> ExecuteUsersCancelTopStatus(UsersCancelTopStatus.Request request)
        {
            return ExecuteUsersCancelTopStatusAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\users\counts
        /// </summary>
        JsonMethod<UsersCounts.Request, UsersCounts.Response> _executeUsersCountsMethod;
        
        /// <summary>
        /// This is a async execution of \users\counts rest call. 
        /// It returns JsonResponse&lt;UsersCounts.Response&gt;
		/// Here comes request Comments:
		///<para>批量获取用户的粉丝数、关注数、微博数 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/counts.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<UsersCounts.Response>> ExecuteUsersCountsAsync (
            UsersCounts.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeUsersCountsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \users\counts rest call. 
        /// It returns JsonResponse&lt;UsersCounts.Response&gt;
		/// Here comes request Comments:
		///<para>批量获取用户的粉丝数、关注数、微博数 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/counts.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<UsersCounts.Response> ExecuteUsersCounts(UsersCounts.Request request)
        {
            return ExecuteUsersCountsAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\users\domain_show
        /// </summary>
        JsonMethod<UsersDomainShow.Request, UsersDomainShow.Response> _executeUsersDomainShowMethod;
        
        /// <summary>
        /// This is a async execution of \users\domain_show rest call. 
        /// It returns JsonResponse&lt;UsersDomainShow.Response&gt;
		/// Here comes request Comments:
		///<para>通过个性化域名获取用户资料以及用户最新的一条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/domain_show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<UsersDomainShow.Response>> ExecuteUsersDomainShowAsync (
            UsersDomainShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeUsersDomainShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \users\domain_show rest call. 
        /// It returns JsonResponse&lt;UsersDomainShow.Response&gt;
		/// Here comes request Comments:
		///<para>通过个性化域名获取用户资料以及用户最新的一条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/domain_show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<UsersDomainShow.Response> ExecuteUsersDomainShow(UsersDomainShow.Request request)
        {
            return ExecuteUsersDomainShowAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\users\get_top_status
        /// </summary>
        JsonMethod<UsersGetTopStatus.Request, UsersGetTopStatus.Response> _executeUsersGetTopStatusMethod;
        
        /// <summary>
        /// This is a async execution of \users\get_top_status rest call. 
        /// It returns JsonResponse&lt;UsersGetTopStatus.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/get_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<UsersGetTopStatus.Response>> ExecuteUsersGetTopStatusAsync (
            UsersGetTopStatus.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeUsersGetTopStatusMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \users\get_top_status rest call. 
        /// It returns JsonResponse&lt;UsersGetTopStatus.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/get_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<UsersGetTopStatus.Response> ExecuteUsersGetTopStatus(UsersGetTopStatus.Request request)
        {
            return ExecuteUsersGetTopStatusAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\users\set_top_status
        /// </summary>
        JsonMethod<UsersSetTopStatus.Request, UsersSetTopStatus.Response> _executeUsersSetTopStatusMethod;
        
        /// <summary>
        /// This is a async execution of \users\set_top_status rest call. 
        /// It returns JsonResponse&lt;UsersSetTopStatus.Response&gt;
		/// Here comes request Comments:
		///<para>设置当前用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/set_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<UsersSetTopStatus.Response>> ExecuteUsersSetTopStatusAsync (
            UsersSetTopStatus.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeUsersSetTopStatusMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \users\set_top_status rest call. 
        /// It returns JsonResponse&lt;UsersSetTopStatus.Response&gt;
		/// Here comes request Comments:
		///<para>设置当前用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/set_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		///<para></para>
        /// </summary>
        public JsonResponse<UsersSetTopStatus.Response> ExecuteUsersSetTopStatus(UsersSetTopStatus.Request request)
        {
            return ExecuteUsersSetTopStatusAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\users\show
        /// </summary>
        JsonMethod<UsersShow.Request, UsersShow.Response> _executeUsersShowMethod;
        
        /// <summary>
        /// This is a async execution of \users\show rest call. 
        /// It returns JsonResponse&lt;UsersShow.Response&gt;
		/// Here comes request Comments:
		///<para>根据用户ID获取用户信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<UsersShow.Response>> ExecuteUsersShowAsync (
            UsersShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeUsersShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \users\show rest call. 
        /// It returns JsonResponse&lt;UsersShow.Response&gt;
		/// Here comes request Comments:
		///<para>根据用户ID获取用户信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<UsersShow.Response> ExecuteUsersShow(UsersShow.Request request)
        {
            return ExecuteUsersShowAsync(request).Result;
        }
        
                
        /// <summary>
        /// Path\users\show_rank
        /// </summary>
        JsonMethod<UsersShowRank.Request, UsersShowRank.Response> _executeUsersShowRankMethod;
        
        /// <summary>
        /// This is a async execution of \users\show_rank rest call. 
        /// It returns JsonResponse&lt;UsersShowRank.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户等级信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/show_rank.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<UsersShowRank.Response>> ExecuteUsersShowRankAsync (
            UsersShowRank.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _executeUsersShowRankMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        
        /// <summary>
        /// This is a sync execution of \users\show_rank rest call. 
        /// It returns JsonResponse&lt;UsersShowRank.Response&gt;
		/// Here comes request Comments:
		///<para>获取用户等级信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/show_rank.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<UsersShowRank.Response> ExecuteUsersShowRank(UsersShowRank.Request request)
        {
            return ExecuteUsersShowRankAsync(request).Result;
        }
        
                        
        JsonMethod<Emotions.Request, Stream> _requestEmotionsMethod;
        /// <summary>
        /// This is a async request of \emotions rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取微博官方表情的详细信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/emotions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：否  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestEmotionsAsync (
            Emotions.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestEmotionsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \emotions rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取微博官方表情的详细信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/emotions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：否  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestEmotions(Emotions.Request request)
        {
            return RequestEmotionsAsync(request).Result;
        }        
                
        JsonMethod<CommentsByMe.Request, Stream> _requestCommentsByMeMethod;
        /// <summary>
        /// This is a async request of \comments\by_me rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户所发出的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/by_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsByMeAsync (
            CommentsByMe.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsByMeMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\by_me rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户所发出的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/by_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsByMe(CommentsByMe.Request request)
        {
            return RequestCommentsByMeAsync(request).Result;
        }        
                
        JsonMethod<CommentsCreate.Request, Stream> _requestCommentsCreateMethod;
        /// <summary>
        /// This is a async request of \comments\create rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>对一条微博进行评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsCreateAsync (
            CommentsCreate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\create rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>对一条微博进行评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsCreate(CommentsCreate.Request request)
        {
            return RequestCommentsCreateAsync(request).Result;
        }        
                
        JsonMethod<CommentsDestroy.Request, Stream> _requestCommentsDestroyMethod;
        /// <summary>
        /// This is a async request of \comments\destroy rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除一条评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsDestroyAsync (
            CommentsDestroy.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\destroy rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>删除一条评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsDestroy(CommentsDestroy.Request request)
        {
            return RequestCommentsDestroyAsync(request).Result;
        }        
                
        JsonMethod<CommentsDestroyBatch.Request, Stream> _requestCommentsDestroyBatchMethod;
        /// <summary>
        /// This is a async request of \comments\destroy_batch rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据评论ID批量删除评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/destroy_batch.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsDestroyBatchAsync (
            CommentsDestroyBatch.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsDestroyBatchMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\destroy_batch rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据评论ID批量删除评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/destroy_batch.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsDestroyBatch(CommentsDestroyBatch.Request request)
        {
            return RequestCommentsDestroyBatchAsync(request).Result;
        }        
                
        JsonMethod<CommentsMentions.Request, Stream> _requestCommentsMentionsMethod;
        /// <summary>
        /// This is a async request of \comments\mentions rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取最新的提到当前登录用户的评论，即@我的评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/mentions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsMentionsAsync (
            CommentsMentions.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsMentionsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\mentions rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取最新的提到当前登录用户的评论，即@我的评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/mentions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsMentions(CommentsMentions.Request request)
        {
            return RequestCommentsMentionsAsync(request).Result;
        }        
                
        JsonMethod<CommentsReply.Request, Stream> _requestCommentsReplyMethod;
        /// <summary>
        /// This is a async request of \comments\reply rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>回复一条评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/reply.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsReplyAsync (
            CommentsReply.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsReplyMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\reply rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>回复一条评论 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/reply.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsReply(CommentsReply.Request request)
        {
            return RequestCommentsReplyAsync(request).Result;
        }        
                
        JsonMethod<CommentsShow.Request, Stream> _requestCommentsShowMethod;
        /// <summary>
        /// This is a async request of \comments\show rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博ID返回某条微博的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsShowAsync (
            CommentsShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\show rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博ID返回某条微博的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsShow(CommentsShow.Request request)
        {
            return RequestCommentsShowAsync(request).Result;
        }        
                
        JsonMethod<CommentsShowBatch.Request, Stream> _requestCommentsShowBatchMethod;
        /// <summary>
        /// This is a async request of \comments\show_batch rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据评论ID批量返回评论信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/show_batch.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsShowBatchAsync (
            CommentsShowBatch.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsShowBatchMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\show_batch rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据评论ID批量返回评论信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/show_batch.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsShowBatch(CommentsShowBatch.Request request)
        {
            return RequestCommentsShowBatchAsync(request).Result;
        }        
                
        JsonMethod<CommentsTimeline.Request, Stream> _requestCommentsTimelineMethod;
        /// <summary>
        /// This is a async request of \comments\timeline rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户的最新评论包括接收到的与发出的 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsTimelineAsync (
            CommentsTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\timeline rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户的最新评论包括接收到的与发出的 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsTimeline(CommentsTimeline.Request request)
        {
            return RequestCommentsTimelineAsync(request).Result;
        }        
                
        JsonMethod<CommentsToMe.Request, Stream> _requestCommentsToMeMethod;
        /// <summary>
        /// This is a async request of \comments\to_me rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户所接收到的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/to_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestCommentsToMeAsync (
            CommentsToMe.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestCommentsToMeMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \comments\to_me rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户所接收到的评论列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/comments/to_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestCommentsToMe(CommentsToMe.Request request)
        {
            return RequestCommentsToMeAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsCreate.Request, Stream> _requestFriendshipsCreateMethod;
        /// <summary>
        /// This is a async request of \friendships\create rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注一个用户 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsCreateAsync (
            FriendshipsCreate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsCreateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\create rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>关注一个用户 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsCreate(FriendshipsCreate.Request request)
        {
            return RequestFriendshipsCreateAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsDestroy.Request, Stream> _requestFriendshipsDestroyMethod;
        /// <summary>
        /// This is a async request of \friendships\destroy rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消关注一个用户 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsDestroyAsync (
            FriendshipsDestroy.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\destroy rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消关注一个用户 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsDestroy(FriendshipsDestroy.Request request)
        {
            return RequestFriendshipsDestroyAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsFollowers.Request, Stream> _requestFriendshipsFollowersMethod;
        /// <summary>
        /// This is a async request of \friendships\followers rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户的粉丝列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一；最多返回5000条数据</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsFollowersAsync (
            FriendshipsFollowers.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsFollowersMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\followers rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户的粉丝列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一；最多返回5000条数据</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsFollowers(FriendshipsFollowers.Request request)
        {
            return RequestFriendshipsFollowersAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsFriends.Request, Stream> _requestFriendshipsFriendsMethod;
        /// <summary>
        /// This is a async request of \friendships\friends rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户的关注列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsFriendsAsync (
            FriendshipsFriends.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsFriendsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\friends rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户的关注列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsFriends(FriendshipsFriends.Request request)
        {
            return RequestFriendshipsFriendsAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsGroups.Request, Stream> _requestFriendshipsGroupsMethod;
        /// <summary>
        /// This is a async request of \friendships\groups rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登陆用户好友分组列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/groups.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	返回的数据按设置的分组顺序排序；   好友分组上限为20，“未分组”不计入上限；   "未分组"的分组ID为0，此接口不返回“未分组”；</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsGroupsAsync (
            FriendshipsGroups.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsGroupsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\groups rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登陆用户好友分组列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/groups.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	返回的数据按设置的分组顺序排序；   好友分组上限为20，“未分组”不计入上限；   "未分组"的分组ID为0，此接口不返回“未分组”；</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsGroups(FriendshipsGroups.Request request)
        {
            return RequestFriendshipsGroupsAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsShow.Request, Stream> _requestFriendshipsShowMethod;
        /// <summary>
        /// This is a async request of \friendships\show rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取两个用户之间的详细关注关系情况 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数source_id与source_screen_name二者必选其一，且只能选其一   参数target_id与target_screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsShowAsync (
            FriendshipsShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\show rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取两个用户之间的详细关注关系情况 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数source_id与source_screen_name二者必选其一，且只能选其一   参数target_id与target_screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsShow(FriendshipsShow.Request request)
        {
            return RequestFriendshipsShowAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsFollowersActive.Request, Stream> _requestFriendshipsFollowersActiveMethod;
        /// <summary>
        /// This is a async request of \friendships\followers\active rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户的活跃粉丝列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers/active.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsFollowersActiveAsync (
            FriendshipsFollowersActive.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsFollowersActiveMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\followers\active rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户的活跃粉丝列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers/active.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsFollowersActive(FriendshipsFollowersActive.Request request)
        {
            return RequestFriendshipsFollowersActiveAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsFollowersIds.Request, Stream> _requestFriendshipsFollowersIdsMethod;
        /// <summary>
        /// This is a async request of \friendships\followers\ids rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝的用户UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsFollowersIdsAsync (
            FriendshipsFollowersIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsFollowersIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\followers\ids rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户粉丝的用户UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/followers/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsFollowersIds(FriendshipsFollowersIds.Request request)
        {
            return RequestFriendshipsFollowersIdsAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsFriendsBilateral.Request, Stream> _requestFriendshipsFriendsBilateralMethod;
        /// <summary>
        /// This is a async request of \friendships\friends\bilateral rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户的双向关注列表，即互粉列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/bilateral.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	排序功能目前只支持一种</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsFriendsBilateralAsync (
            FriendshipsFriendsBilateral.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsFriendsBilateralMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\friends\bilateral rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户的双向关注列表，即互粉列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/bilateral.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	排序功能目前只支持一种</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsFriendsBilateral(FriendshipsFriendsBilateral.Request request)
        {
            return RequestFriendshipsFriendsBilateralAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsFriendsIds.Request, Stream> _requestFriendshipsFriendsIdsMethod;
        /// <summary>
        /// This is a async request of \friendships\friends\ids rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户关注的用户UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsFriendsIdsAsync (
            FriendshipsFriendsIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsFriendsIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\friends\ids rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户关注的用户UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsFriendsIds(FriendshipsFriendsIds.Request request)
        {
            return RequestFriendshipsFriendsIdsAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsFriendsInCommon.Request, Stream> _requestFriendshipsFriendsInCommonMethod;
        /// <summary>
        /// This is a async request of \friendships\friends\in_common rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取两个用户之间的共同关注人列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/in_common.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsFriendsInCommonAsync (
            FriendshipsFriendsInCommon.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsFriendsInCommonMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\friends\in_common rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取两个用户之间的共同关注人列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/in_common.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsFriendsInCommon(FriendshipsFriendsInCommon.Request request)
        {
            return RequestFriendshipsFriendsInCommonAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsFriendsBilateralIds.Request, Stream> _requestFriendshipsFriendsBilateralIdsMethod;
        /// <summary>
        /// This is a async request of \friendships\friends\bilateral\ids rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户双向关注的用户ID列表，即互粉UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/bilateral/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	排序功能目前只支持一种</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsFriendsBilateralIdsAsync (
            FriendshipsFriendsBilateralIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsFriendsBilateralIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\friends\bilateral\ids rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户双向关注的用户ID列表，即互粉UID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends/bilateral/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	排序功能目前只支持一种</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsFriendsBilateralIds(FriendshipsFriendsBilateralIds.Request request)
        {
            return RequestFriendshipsFriendsBilateralIdsAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsFriendsChainFollowers.Request, Stream> _requestFriendshipsFriendsChainFollowersMethod;
        /// <summary>
        /// This is a async request of \friendships\friends_chain\followers rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户的关注人中又关注了指定用户的用户列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends_chain/followers.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsFriendsChainFollowersAsync (
            FriendshipsFriendsChainFollowers.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsFriendsChainFollowersMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\friends_chain\followers rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户的关注人中又关注了指定用户的用户列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/friends_chain/followers.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsFriendsChainFollowers(FriendshipsFriendsChainFollowers.Request request)
        {
            return RequestFriendshipsFriendsChainFollowersAsync(request).Result;
        }        
                
        JsonMethod<FriendshipsRemarkUpdate.Request, Stream> _requestFriendshipsRemarkUpdateMethod;
        /// <summary>
        /// This is a async request of \friendships\remark\update rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/remark/update.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestFriendshipsRemarkUpdateAsync (
            FriendshipsRemarkUpdate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestFriendshipsRemarkUpdateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \friendships\remark\update rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>更新当前登录用户所关注的某个好友的备注信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/friendships/remark/update.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestFriendshipsRemarkUpdate(FriendshipsRemarkUpdate.Request request)
        {
            return RequestFriendshipsRemarkUpdateAsync(request).Result;
        }        
                
        JsonMethod<StatusesBilateralTimeline.Request, Stream> _requestStatusesBilateralTimelineMethod;
        /// <summary>
        /// This is a async request of \statuses\bilateral_timeline rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取双向关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/bilateral_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesBilateralTimelineAsync (
            StatusesBilateralTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesBilateralTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\bilateral_timeline rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取双向关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/bilateral_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesBilateralTimeline(StatusesBilateralTimeline.Request request)
        {
            return RequestStatusesBilateralTimelineAsync(request).Result;
        }        
                
        JsonMethod<StatusesCount.Request, Stream> _requestStatusesCountMethod;
        /// <summary>
        /// This is a async request of \statuses\count rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量获取指定微博的转发数评论数 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/count.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesCountAsync (
            StatusesCount.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesCountMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\count rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量获取指定微博的转发数评论数 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/count.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesCount(StatusesCount.Request request)
        {
            return RequestStatusesCountAsync(request).Result;
        }        
                
        JsonMethod<StatusesDestroy.Request, Stream> _requestStatusesDestroyMethod;
        /// <summary>
        /// This is a async request of \statuses\destroy rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博ID删除指定微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	只能删除自己发布的微博</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesDestroyAsync (
            StatusesDestroy.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesDestroyMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\destroy rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博ID删除指定微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/destroy.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	只能删除自己发布的微博</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesDestroy(StatusesDestroy.Request request)
        {
            return RequestStatusesDestroyAsync(request).Result;
        }        
                
        JsonMethod<StatusesFriendsTimeline.Request, Stream> _requestStatusesFriendsTimelineMethod;
        /// <summary>
        /// This is a async request of \statuses\friends_timeline rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/friends_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesFriendsTimelineAsync (
            StatusesFriendsTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesFriendsTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\friends_timeline rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/friends_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesFriendsTimeline(StatusesFriendsTimeline.Request request)
        {
            return RequestStatusesFriendsTimelineAsync(request).Result;
        }        
                
        JsonMethod<StatusesHomeTimeline.Request, Stream> _requestStatusesHomeTimelineMethod;
        /// <summary>
        /// This is a async request of \statuses\home_timeline rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/home_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesHomeTimelineAsync (
            StatusesHomeTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesHomeTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\home_timeline rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/home_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesHomeTimeline(StatusesHomeTimeline.Request request)
        {
            return RequestStatusesHomeTimelineAsync(request).Result;
        }        
                
        JsonMethod<StatusesMentions.Request, Stream> _requestStatusesMentionsMethod;
        /// <summary>
        /// This is a async request of \statuses\mentions rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取最新的提到登录用户的微博列表，即@我的微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesMentionsAsync (
            StatusesMentions.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesMentionsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\mentions rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取最新的提到登录用户的微博列表，即@我的微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesMentions(StatusesMentions.Request request)
        {
            return RequestStatusesMentionsAsync(request).Result;
        }        
                
        JsonMethod<StatusesPublicTimeline.Request, Stream> _requestStatusesPublicTimelineMethod;
        /// <summary>
        /// This is a async request of \statuses\public_timeline rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新的200条公共微博，返回结果非完全实时 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/public_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesPublicTimelineAsync (
            StatusesPublicTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesPublicTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\public_timeline rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>返回最新的200条公共微博，返回结果非完全实时 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/public_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesPublicTimeline(StatusesPublicTimeline.Request request)
        {
            return RequestStatusesPublicTimelineAsync(request).Result;
        }        
                
        JsonMethod<StatusesQueryid.Request, Stream> _requestStatusesQueryidMethod;
        /// <summary>
        /// This is a async request of \statuses\queryid rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>通过微博（评论、私信）MID获取其ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/queryid.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	否  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	形如“3z4efAo4lk”的MID即为经过base62转换的MID</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesQueryidAsync (
            StatusesQueryid.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesQueryidMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\queryid rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>通过微博（评论、私信）MID获取其ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/queryid.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	否  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	形如“3z4efAo4lk”的MID即为经过base62转换的MID</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesQueryid(StatusesQueryid.Request request)
        {
            return RequestStatusesQueryidAsync(request).Result;
        }        
                
        JsonMethod<StatusesQuerymid.Request, Stream> _requestStatusesQuerymidMethod;
        /// <summary>
        /// This is a async request of \statuses\querymid rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>通过微博（评论、私信）ID获取其MID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/querymid.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	否  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesQuerymidAsync (
            StatusesQuerymid.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesQuerymidMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\querymid rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>通过微博（评论、私信）ID获取其MID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/querymid.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	否  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesQuerymid(StatusesQuerymid.Request request)
        {
            return RequestStatusesQuerymidAsync(request).Result;
        }        
                
        JsonMethod<StatusesRepost.Request, Stream> _requestStatusesRepostMethod;
        /// <summary>
        /// This is a async request of \statuses\repost rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>转发一条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesRepostAsync (
            StatusesRepost.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesRepostMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\repost rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>转发一条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesRepost(StatusesRepost.Request request)
        {
            return RequestStatusesRepostAsync(request).Result;
        }        
                
        JsonMethod<StatusesRepostByMe.Request, Stream> _requestStatusesRepostByMeMethod;
        /// <summary>
        /// This is a async request of \statuses\repost_by_me rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户最新转发的微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_by_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesRepostByMeAsync (
            StatusesRepostByMe.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesRepostByMeMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\repost_by_me rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前用户最新转发的微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_by_me.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesRepostByMe(StatusesRepostByMe.Request request)
        {
            return RequestStatusesRepostByMeAsync(request).Result;
        }        
                
        JsonMethod<StatusesRepostTimeline.Request, Stream> _requestStatusesRepostTimelineMethod;
        /// <summary>
        /// This is a async request of \statuses\repost_timeline rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取指定微博的转发微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesRepostTimelineAsync (
            StatusesRepostTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesRepostTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\repost_timeline rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取指定微博的转发微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesRepostTimeline(StatusesRepostTimeline.Request request)
        {
            return RequestStatusesRepostTimelineAsync(request).Result;
        }        
                
        JsonMethod<StatusesShow.Request, Stream> _requestStatusesShowMethod;
        /// <summary>
        /// This is a async request of \statuses\show rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博ID获取单条微博内容 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesShowAsync (
            StatusesShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\show rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据微博ID获取单条微博内容 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesShow(StatusesShow.Request request)
        {
            return RequestStatusesShowAsync(request).Result;
        }        
                
        JsonMethod<StatusesUpdate.Request, Stream> _requestStatusesUpdateMethod;
        /// <summary>
        /// This is a async request of \statuses\update rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/update.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesUpdateAsync (
            StatusesUpdate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesUpdateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\update rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/update.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesUpdate(StatusesUpdate.Request request)
        {
            return RequestStatusesUpdateAsync(request).Result;
        }        
                
        JsonMethod<StatusesUpload.Request, Stream> _requestStatusesUploadMethod;
        /// <summary>
        /// This is a async request of \statuses\upload rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>上传图片并发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://upload.api.weibo.com/2/statuses/upload.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	请求必须用POST方式提交，并且注意采用multipart/form-data编码方式；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesUploadAsync (
            StatusesUpload.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesUploadMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\upload rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>上传图片并发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://upload.api.weibo.com/2/statuses/upload.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	请求必须用POST方式提交，并且注意采用multipart/form-data编码方式；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesUpload(StatusesUpload.Request request)
        {
            return RequestStatusesUploadAsync(request).Result;
        }        
                
        JsonMethod<StatusesUploadUrlText.Request, Stream> _requestStatusesUploadUrlTextMethod;
        /// <summary>
        /// This is a async request of \statuses\upload_url_text rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>指定一个图片URL地址抓取后上传并同时发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/upload_url_text.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesUploadUrlTextAsync (
            StatusesUploadUrlText.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesUploadUrlTextMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\upload_url_text rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>指定一个图片URL地址抓取后上传并同时发布一条新微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/upload_url_text.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	连续两次发布的微博不可以重复；   非会员发表定向微博，分组成员数最多200。</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesUploadUrlText(StatusesUploadUrlText.Request request)
        {
            return RequestStatusesUploadUrlTextAsync(request).Result;
        }        
                
        JsonMethod<StatusesUserTimeline.Request, Stream> _requestStatusesUserTimelineMethod;
        /// <summary>
        /// This is a async request of \statuses\user_timeline rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某个用户最新发表的微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/user_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesUserTimelineAsync (
            StatusesUserTimeline.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesUserTimelineMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\user_timeline rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取某个用户最新发表的微博列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/user_timeline.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesUserTimeline(StatusesUserTimeline.Request request)
        {
            return RequestStatusesUserTimelineAsync(request).Result;
        }        
                
        JsonMethod<StatusesFilterCreate.Request, Stream> _requestStatusesFilterCreateMethod;
        /// <summary>
        /// This is a async request of \statuses\filter\create rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>屏蔽某条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/filter/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesFilterCreateAsync (
            StatusesFilterCreate.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesFilterCreateMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\filter\create rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>屏蔽某条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/filter/create.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesFilterCreate(StatusesFilterCreate.Request request)
        {
            return RequestStatusesFilterCreateAsync(request).Result;
        }        
                
        JsonMethod<StatusesFriendsTimelineIds.Request, Stream> _requestStatusesFriendsTimelineIdsMethod;
        /// <summary>
        /// This is a async request of \statuses\friends_timeline\ids rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/friends_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesFriendsTimelineIdsAsync (
            StatusesFriendsTimelineIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesFriendsTimelineIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\friends_timeline\ids rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户及其所关注用户的最新微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/friends_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesFriendsTimelineIds(StatusesFriendsTimelineIds.Request request)
        {
            return RequestStatusesFriendsTimelineIdsAsync(request).Result;
        }        
                
        JsonMethod<StatusesMentionsIds.Request, Stream> _requestStatusesMentionsIdsMethod;
        /// <summary>
        /// This is a async request of \statuses\mentions\ids rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取@当前用户的最新微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesMentionsIdsAsync (
            StatusesMentionsIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesMentionsIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\mentions\ids rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取@当前用户的最新微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesMentionsIds(StatusesMentionsIds.Request request)
        {
            return RequestStatusesMentionsIdsAsync(request).Result;
        }        
                
        JsonMethod<StatusesMentionsShield.Request, Stream> _requestStatusesMentionsShieldMethod;
        /// <summary>
        /// This is a async request of \statuses\mentions\shield rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>屏蔽某个@到我的微博以及后续由对其转发引起的@提及 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions/shield.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesMentionsShieldAsync (
            StatusesMentionsShield.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesMentionsShieldMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\mentions\shield rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>屏蔽某个@到我的微博以及后续由对其转发引起的@提及 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/mentions/shield.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesMentionsShield(StatusesMentionsShield.Request request)
        {
            return RequestStatusesMentionsShieldAsync(request).Result;
        }        
                
        JsonMethod<StatusesRepostTimelineIds.Request, Stream> _requestStatusesRepostTimelineIdsMethod;
        /// <summary>
        /// This is a async request of \statuses\repost_timeline\ids rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取一条原创微博的最新转发微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesRepostTimelineIdsAsync (
            StatusesRepostTimelineIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesRepostTimelineIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\repost_timeline\ids rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取一条原创微博的最新转发微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/repost_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesRepostTimelineIds(StatusesRepostTimelineIds.Request request)
        {
            return RequestStatusesRepostTimelineIdsAsync(request).Result;
        }        
                
        JsonMethod<StatusesToMeIds.Request, Stream> _requestStatusesToMeIdsMethod;
        /// <summary>
        /// This is a async request of \statuses\to_me\ids rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户关注的人发给其的定向微博ID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/to_me/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	A与B互相关注，B在A的分组G中，A发送定向微博S到G，则，在B的【发给我的微博中】会包括S这条微博；</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesToMeIdsAsync (
            StatusesToMeIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesToMeIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\to_me\ids rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取当前登录用户关注的人发给其的定向微博ID列表 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/to_me/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	A与B互相关注，B在A的分组G中，A发送定向微博S到G，则，在B的【发给我的微博中】会包括S这条微博；</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesToMeIds(StatusesToMeIds.Request request)
        {
            return RequestStatusesToMeIdsAsync(request).Result;
        }        
                
        JsonMethod<StatusesUserTimelineIds.Request, Stream> _requestStatusesUserTimelineIdsMethod;
        /// <summary>
        /// This is a async request of \statuses\user_timeline\ids rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户发布的微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/user_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一，uid优先   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestStatusesUserTimelineIdsAsync (
            StatusesUserTimelineIds.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestStatusesUserTimelineIdsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \statuses\user_timeline\ids rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户发布的微博的ID </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/statuses/user_timeline/ids.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一，uid优先   参数uid与screen_name都没有或错误，则默认返回当前登录用户的数据</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestStatusesUserTimelineIds(StatusesUserTimelineIds.Request request)
        {
            return RequestStatusesUserTimelineIdsAsync(request).Result;
        }        
                
        JsonMethod<UsersCancelTopStatus.Request, Stream> _requestUsersCancelTopStatusMethod;
        /// <summary>
        /// This is a async request of \users\cancel_top_status rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消当前用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/cancel_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestUsersCancelTopStatusAsync (
            UsersCancelTopStatus.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestUsersCancelTopStatusMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \users\cancel_top_status rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>取消当前用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/cancel_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestUsersCancelTopStatus(UsersCancelTopStatus.Request request)
        {
            return RequestUsersCancelTopStatusAsync(request).Result;
        }        
                
        JsonMethod<UsersCounts.Request, Stream> _requestUsersCountsMethod;
        /// <summary>
        /// This is a async request of \users\counts rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量获取用户的粉丝数、关注数、微博数 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/counts.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestUsersCountsAsync (
            UsersCounts.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestUsersCountsMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \users\counts rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>批量获取用户的粉丝数、关注数、微博数 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/counts.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestUsersCounts(UsersCounts.Request request)
        {
            return RequestUsersCountsAsync(request).Result;
        }        
                
        JsonMethod<UsersDomainShow.Request, Stream> _requestUsersDomainShowMethod;
        /// <summary>
        /// This is a async request of \users\domain_show rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>通过个性化域名获取用户资料以及用户最新的一条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/domain_show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestUsersDomainShowAsync (
            UsersDomainShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestUsersDomainShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \users\domain_show rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>通过个性化域名获取用户资料以及用户最新的一条微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/domain_show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestUsersDomainShow(UsersDomainShow.Request request)
        {
            return RequestUsersDomainShowAsync(request).Result;
        }        
                
        JsonMethod<UsersGetTopStatus.Request, Stream> _requestUsersGetTopStatusMethod;
        /// <summary>
        /// This is a async request of \users\get_top_status rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/get_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestUsersGetTopStatusAsync (
            UsersGetTopStatus.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestUsersGetTopStatusMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \users\get_top_status rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/get_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestUsersGetTopStatus(UsersGetTopStatus.Request request)
        {
            return RequestUsersGetTopStatusAsync(request).Result;
        }        
                
        JsonMethod<UsersSetTopStatus.Request, Stream> _requestUsersSetTopStatusMethod;
        /// <summary>
        /// This is a async request of \users\set_top_status rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>设置当前用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/set_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestUsersSetTopStatusAsync (
            UsersSetTopStatus.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestUsersSetTopStatusMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \users\set_top_status rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>设置当前用户主页置顶微博 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/set_top_status.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	POST</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：高级接口（需要授权）  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	由于weibo.com个人页有1天缓存原因，导致调用成功后界面仍看不到效果，后期会去掉此缓存；   只能操作当前登录用户；   一个用户同时只能置顶一条微博；   普通用户有且仅有一次可置顶的试用机会，置顶时长为24小时；   当用户状态为会员时，使用置顶功能，不受次数、时间限制；</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestUsersSetTopStatus(UsersSetTopStatus.Request request)
        {
            return RequestUsersSetTopStatusAsync(request).Result;
        }        
                
        JsonMethod<UsersShow.Request, Stream> _requestUsersShowMethod;
        /// <summary>
        /// This is a async request of \users\show rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据用户ID获取用户信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestUsersShowAsync (
            UsersShow.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestUsersShowMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \users\show rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>根据用户ID获取用户信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/show.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	参数uid与screen_name二者必选其一，且只能选其一</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestUsersShow(UsersShow.Request request)
        {
            return RequestUsersShowAsync(request).Result;
        }        
                
        JsonMethod<UsersShowRank.Request, Stream> _requestUsersShowRankMethod;
        /// <summary>
        /// This is a async request of \users\show_rank rest call. 
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户等级信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/show_rank.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public async Task<JsonResponse<Stream>> RequestUsersShowRankAsync (
            UsersShowRank.Request request,
            CancellationToken cancellationToken=default(CancellationToken),
            IProgress<ProgressReport> progress=null)			
        {
            return await _requestUsersShowRankMethod.GetResponseAsync(request, cancellationToken, progress);
        }
        /// <summary>
        /// This is a sync request of \users\show_rank rest call.
        ///It returns JsonResponse&lt;Stream&gt;
		/// Here comes request Comments:
		///<para>获取用户等级信息 </para>
		///<para>URL:</para>
		///<para>	https://api.weibo.com/2/users/show_rank.json</para>
		///<para>支持格式:</para>
		///<para>	JSON</para>
		///<para>HTTP请求方式:</para>
		///<para>	GET</para>
		///<para>是否需要登录:</para>
		///<para>	是  关于登录授权，参见 如何登录授权</para>
		///<para>访问授权限制:</para>
		///<para>	访问级别：普通接口  频次限制：是  关于频次限制，参见 接口访问权限说明</para>
		///<para>注意事项:</para>
		///<para>	无</para>
		///<para></para>
        /// </summary>
        public JsonResponse<Stream> RequestUsersShowRank(UsersShowRank.Request request)
        {
            return RequestUsersShowRankAsync(request).Result;
        }        
                
    }

}
