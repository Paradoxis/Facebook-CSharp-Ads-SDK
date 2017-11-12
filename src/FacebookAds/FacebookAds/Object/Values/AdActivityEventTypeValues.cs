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
/// Copyright (c) 2017 - Luke Paris (Paradoxis) | Searchresult Performancemarketing
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
/// <date>2017-11-12 14:56:48</date>
/// <author>Luke Paris (Paradoxis) | luke@paradoxis.nl</author>
///
/// <remarks>
/// This file was automatically generated using the Facebook Ads
/// PHP SDK to C# converter found in this library under '/src/SdkConverter/'
/// For more information please refer to the official documentation
/// </remarks>
namespace FacebookAds.Object.Values
{
    public class AdActivityEventTypeValues : AbstractCrudObjectFields
    {
        public const string AD_ACCOUNT_UPDATE_SPEND_LIMIT = "ad_account_update_spend_limit";
        public const string AD_ACCOUNT_RESET_SPEND_LIMIT = "ad_account_reset_spend_limit";
        public const string AD_ACCOUNT_REMOVE_SPEND_LIMIT = "ad_account_remove_spend_limit";
        public const string AD_ACCOUNT_SET_BUSINESS_INFORMATION = "ad_account_set_business_information";
        public const string AD_ACCOUNT_UPDATE_STATUS = "ad_account_update_status";
        public const string AD_ACCOUNT_ADD_USER_TO_ROLE = "ad_account_add_user_to_role";
        public const string AD_ACCOUNT_REMOVE_USER_FROM_ROLE = "ad_account_remove_user_from_role";
        public const string ADD_IMAGES = "add_images";
        public const string EDIT_IMAGES = "edit_images";
        public const string DELETE_IMAGES = "delete_images";
        public const string AD_ACCOUNT_BILLING_CHARGE = "ad_account_billing_charge";
        public const string AD_ACCOUNT_BILLING_CHARGE_FAILED = "ad_account_billing_charge_failed";
        public const string AD_ACCOUNT_BILLING_CHARGEBACK = "ad_account_billing_chargeback";
        public const string AD_ACCOUNT_BILLING_CHARGEBACK_REVERSAL = "ad_account_billing_chargeback_reversal";
        public const string AD_ACCOUNT_BILLING_DECLINE = "ad_account_billing_decline";
        public const string AD_ACCOUNT_BILLING_REFUND = "ad_account_billing_refund";
        public const string BILLING_EVENT = "billing_event";
        public const string ADD_FUNDING_SOURCE = "add_funding_source";
        public const string REMOVE_FUNDING_SOURCE = "remove_funding_source";
        public const string CREATE_CAMPAIGN_GROUP = "create_campaign_group";
        public const string UPDATE_CAMPAIGN_NAME = "update_campaign_name";
        public const string UPDATE_CAMPAIGN_RUN_STATUS = "update_campaign_run_status";
        public const string UPDATE_CAMPAIGN_GROUP_SPEND_CAP = "update_campaign_group_spend_cap";
        public const string CAMPAIGN_ENDED = "campaign_ended";
        public const string CREATE_CAMPAIGN = "create_campaign";
        public const string CREATE_CAMPAIGN_LEGACY = "create_campaign_legacy";
        public const string UPDATE_CAMPAIGN_BUDGET = "update_campaign_budget";
        public const string UPDATE_CAMPAIGN_DURATION = "update_campaign_duration";
        public const string CREATE_AD_SET = "create_ad_set";
        public const string UPDATE_AD_SET_BIDDING = "update_ad_set_bidding";
        public const string UPDATE_AD_SET_BUDGET = "update_ad_set_budget";
        public const string UPDATE_AD_SET_DURATION = "update_ad_set_duration";
        public const string UPDATE_AD_SET_RUN_STATUS = "update_ad_set_run_status";
        public const string UPDATE_AD_SET_NAME = "update_ad_set_name";
        public const string CREATE_AD = "create_ad";
        public const string UPDATE_AD_CREATIVE = "update_ad_creative";
        public const string EDIT_AND_UPDATE_AD_CREATIVE = "edit_and_update_ad_creative";
        public const string UPDATE_AD_BID_INFO = "update_ad_bid_info";
        public const string UPDATE_AD_BID_TYPE = "update_ad_bid_type";
        public const string UPDATE_AD_RUN_STATUS = "update_ad_run_status";
        public const string UPDATE_AD_FRIENDLY_NAME = "update_ad_friendly_name";
        public const string UPDATE_AD_TARGETS_SPEC = "update_ad_targets_spec";
        public const string UPDATE_ADGROUP_STOP_DELIVERY = "update_adgroup_stop_delivery";
        public const string UPDATE_AD_SET_TARGET_SPEC = "update_ad_set_target_spec";
        public const string AD_REVIEW_APPROVED = "ad_review_approved";
        public const string AD_REVIEW_DECLINED = "ad_review_declined";
        public const string FIRST_DELIVERY_EVENT = "first_delivery_event";
        public const string CREATE_AUDIENCE = "create_audience";
        public const string UPDATE_AUDIENCE = "update_audience";
        public const string DELETE_AUDIENCE = "delete_audience";
        public const string SHARE_AUDIENCE = "share_audience";
        public const string RECEIVE_AUDIENCE = "receive_audience";
        public const string UNSHARE_AUDIENCE = "unshare_audience";
        public const string REMOVE_SHARED_AUDIENCE = "remove_shared_audience";
        public const string UNKNOWN = "unknown";
        public const string ACCOUNT_SPENDING_LIMIT_REACHED = "account_spending_limit_reached";
        public const string CAMPAIGN_SPENDING_LIMIT_REACHED = "campaign_spending_limit_reached";
        public const string LIFETIME_BUDGET_SPENT = "lifetime_budget_spent";
        public const string FUNDING_EVENT_INITIATED = "funding_event_initiated";
        public const string FUNDING_EVENT_SUCCESSFUL = "funding_event_successful";
        public const string UPDATE_AD_LABELS = "update_ad_labels";
        
    }
}


