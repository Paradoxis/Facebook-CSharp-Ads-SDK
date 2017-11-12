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
namespace FacebookAds.Object.Fields
{
    public class AdAccountFields : AbstractCrudObjectFields
    {
        public const string ACCOUNT_ID = "account_id";
        public const string ACCOUNT_STATUS = "account_status";
        public const string AGE = "age";
        public const string AGENCY_CLIENT_DECLARATION = "agency_client_declaration";
        public const string AMOUNT_SPENT = "amount_spent";
        public const string ATTRIBUTION_SPEC = "attribution_spec";
        public const string BALANCE = "balance";
        public const string BUSINESS = "business";
        public const string BUSINESS_CITY = "business_city";
        public const string BUSINESS_COUNTRY_CODE = "business_country_code";
        public const string BUSINESS_NAME = "business_name";
        public const string BUSINESS_STATE = "business_state";
        public const string BUSINESS_STREET = "business_street";
        public const string BUSINESS_STREET2 = "business_street2";
        public const string BUSINESS_ZIP = "business_zip";
        public const string CAPABILITIES = "capabilities";
        public const string CREATED_TIME = "created_time";
        public const string CURRENCY = "currency";
        public const string DISABLE_REASON = "disable_reason";
        public const string END_ADVERTISER = "end_advertiser";
        public const string END_ADVERTISER_NAME = "end_advertiser_name";
        public const string FAILED_DELIVERY_CHECKS = "failed_delivery_checks";
        public const string FUNDING_SOURCE = "funding_source";
        public const string FUNDING_SOURCE_DETAILS = "funding_source_details";
        public const string HAS_MIGRATED_PERMISSIONS = "has_migrated_permissions";
        public const string ID = "id";
        public const string IO_NUMBER = "io_number";
        public const string IS_ATTRIBUTION_SPEC_SYSTEM_DEFAULT = "is_attribution_spec_system_default";
        public const string IS_DIRECT_DEALS_ENABLED = "is_direct_deals_enabled";
        public const string IS_NOTIFICATIONS_ENABLED = "is_notifications_enabled";
        public const string IS_PERSONAL = "is_personal";
        public const string IS_PREPAY_ACCOUNT = "is_prepay_account";
        public const string IS_TAX_ID_REQUIRED = "is_tax_id_required";
        public const string LINE_NUMBERS = "line_numbers";
        public const string MEDIA_AGENCY = "media_agency";
        public const string MIN_CAMPAIGN_GROUP_SPEND_CAP = "min_campaign_group_spend_cap";
        public const string MIN_DAILY_BUDGET = "min_daily_budget";
        public const string NAME = "name";
        public const string NEXT_BILL_DATE = "next_bill_date";
        public const string OFFSITE_PIXELS_TOS_ACCEPTED = "offsite_pixels_tos_accepted";
        public const string OWNER = "owner";
        public const string PARTNER = "partner";
        public const string RF_SPEC = "rf_spec";
        public const string SALESFORCE_INVOICE_GROUP_ID = "salesforce_invoice_group_id";
        public const string SHOW_CHECKOUT_EXPERIENCE = "show_checkout_experience";
        public const string SPEND_CAP = "spend_cap";
        public const string TAX_ID = "tax_id";
        public const string TAX_ID_STATUS = "tax_id_status";
        public const string TAX_ID_TYPE = "tax_id_type";
        public const string TIMEZONE_ID = "timezone_id";
        public const string TIMEZONE_NAME = "timezone_name";
        public const string TIMEZONE_OFFSET_HOURS_UTC = "timezone_offset_hours_utc";
        public const string TOS_ACCEPTED = "tos_accepted";
        public const string USER_ROLE = "user_role";
        
    }
}


