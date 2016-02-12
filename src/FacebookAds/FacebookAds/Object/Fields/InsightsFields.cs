using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Facebook;
using FacebookAds.Interfaces;

/// <summary>
/// The MIT License (MIT)
///
/// Copyright (c) 2016 - Luke Paris (Paradoxis) | Searchresult Performancemarketing
///
/// Permission is hereby granted, free of charge, to any person obtaining a copy
/// of this software and associated documentation files (the "Software"), to deal
/// in the Software without restriction, including without limitation the rights
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
/// copies of the Software, and to permit persons to whom the Software is
/// furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included in all
/// copies or substantial portions of the Software.
///
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
/// SOFTWARE.
/// </summary>
/// <date>2016-02-12 11:11:08</date>
/// <author>Luke Paris (Paradoxis) | luke@paradoxis.nl</author>
///
/// <remarks>
/// This file was automatically generated using the Facebook Ads
/// PHP SDK to C# converter found in this library under '/src/SdkConverter/'
/// For more information please refer to the official documentation
/// </remarks>
namespace FacebookAds.Object.Fields
{
    public class InsightsFields : AbstractCrudObjectFields
    {
        public const string ACCOUNT_ID = "account_id";
        public const string ACCOUNT_NAME = "account_name";
        public const string ACTION_VALUES = "action_values";
        public const string ACTIONS = "actions";
        public const string ACTIONS_PER_IMPRESSION = "actions_per_impression";
        public const string AD_ID = "ad_id";
        public const string AD_NAME = "ad_name";
        public const string ADSET_ID = "adset_id";
        public const string ADSET_NAME = "adset_name";
        public const string AGE = "age";
        public const string APP_STORE_CLICKS = "app_store_clicks";
        public const string BUYING_TYPE = "buying_type";
        public const string CALL_TO_ACTION_CLICKS = "call_to_action_clicks";
        public const string CAMPAIGN_ID = "campaign_id";
        public const string CAMPAIGN_NAME = "campaign_name";
        public const string COST_PER_10_SEC_VIDEO_VIEW = "cost_per_10_esc_video_view";
        public const string COST_PER_ACTION_TYPE = "cost_per_action_type";
        public const string COST_PER_ESTIMAED_AD_RECALLERS = "cost_per_estimated_ad_recallers";
        public const string COST_PER_INLINE_LINK_CLICK = "cost_per_inline_link_click";
        public const string COST_PER_INLINE_POST_ENGAGEMENT = "cost_per_inline_post_engagement";
        public const string COST_PER_TOTAL_ACTION = "cost_per_total_action";
        public const string COST_PER_UNIQUE_CLICK = "cost_per_unique_click";
        public const string COST_PER_UNIQUE_ACTION_TYPE = "cost_per_unique_action_type";
        public const string COUNTRY = "country";
        public const string CPM = "cpm";
        public const string CPP = "cpp";
        public const string CTR = "ctr";
        public const string DATE_START = "date_start";
        public const string DATE_STOP = "date_stop";
        public const string DEEPLINK_CLICKS = "deeplink_clicks";
        public const string ESTIMATED_AD_RECALLERS = "estimated_ad_recallers";
        public const string ESTIMATED_AD_RECALLERS_LOWER_BOUND = "estimated_ad_recallers_lower_bound";
        public const string ESTIMATED_AD_RECALLERS_UPPER_BOUND = "estimated_ad_recallers_upper_bound";
        public const string ESTIMATED_AD_RECALL_RATE = "estimated_ad_recall_rate";
        public const string ESTIMATED_AD_RECALL_RATE_LOWER_BOUND = "estimated_ad_recall_rate_lower_bound";
        public const string ESTIMATED_AD_RECALL_RATE_UPPPER_BOUND = "estimated_ad_recall_rate_upper_bound";
        public const string FREQUENCY = "frequency";
        public const string FREQUENCY_VALUE = "frequency_value";
        public const string GENDER = "gender";
        public const string HOURLY_STATS_AGGREGATED_BY_ADVERTISER_TIME_ZONE = "hourly_stats_aggregated_by_advertiser_time_zone";
        public const string HOURLY_STATS_AGGREGATED_BY_AUDIENCE_TIME_ZONE = "hourly_stats_aggregated_by_audience_time_zone";
        public const string IMPRESSIONS = "impressions";
        public const string IMPRESSION_DEVICE = "impression_device";
        public const string INLINE_LINK_CLICKS = "inline_link_clicks";
        public const string INLINE_POST_ENGAGEMENT = "inline_post_engagement";
        public const string NEWSFEED_AVG_POSITION = "newsfeed_avg_position";
        public const string NEWSFEED_CLICKS = "newsfeed_clicks";
        public const string NEWSFEED_IMPRESSIONS = "newsfeed_impresions";
        public const string PLACEMENT = "placement";
        public const string PRODUCT_ID = "product_id";
        public const string REACH = "reach";
        public const string REGION = "region";
        public const string RELEVANCE_SCORE = "relevance_score";
        public const string SOCIAL_CLICKS = "social_clicks";
        public const string SOCIAL_IMPRESSIONS = "social_impressions";
        public const string SOCIAL_REACH = "social_reach";
        public const string SOCIAL_SPEND = "social_spend";
        public const string SPEND = "spend";
        public const string TOTAL_ACTION_VALUE = "total_action_value";
        public const string TOTAL_ACTIONS = "total_actions";
        public const string TOTAL_UNIQUE_ACTIONS = "total_unique_actions";
        public const string UNIQUE_ACTIONS = "unique_actions";
        public const string UNIQUE_CLICKS = "unique_clicks";
        public const string UNIQUE_CTR = "unique_ctr";
        public const string UNIQUE_IMPRESSIONS = "unique_impressions";
        public const string UNIQUE_LINK_CLICKS_CTR = "unique_link_clicks_ctr";
        public const string UNIQUE_SOCIAL_CLICKS = "unique_social_clicks";
        public const string UNIQUE_SOCIAL_IMPRESSIONS = "unique_social_impressions";
        public const string VIDEO_10_SEC_WATCHED_ACTIONS = "video_10_sec_watched_actions";
        public const string VIDEO_15_SEC_WATCHED_ACTIONS = "video_15_sec_watched_actions";
        public const string VIDEO_30_SEC_WATCHED_ACTIONS = "video_30_sec_watched_actions";
        public const string VIDEO_AVG_PCT_WATCHED_ACTIONS = "video_avg_pct_watched_actions";
        public const string VIDEO_AVG_SEC_WATCHED_ACTIONS = "video_avg_sec_watched_actions";
        public const string VIDEO_COMPLETE_WATCHED_ACTIONS = "video_complete_watched_actions";
        public const string VIDEO_P100_WATCHED_ACTIONS = "video_p100_watched_actions";
        public const string VIDEO_P25_WATCHED_ACTIONS = "video_p25_watched_actions";
        public const string VIDEO_P50_WATCHED_ACTIONS = "video_p50_watched_actions";
        public const string VIDEO_P75_WATCHED_ACTIONS = "video_p75_watched_actions";
        public const string VIDEO_P95_WATCHED_ACTIONS = "video_p95_watched_actions";
        public const string WEBSITE_CLICKS = "website_clicks";
        public const string WEBSITE_CTR = "website_ctr";
        
    }
}


