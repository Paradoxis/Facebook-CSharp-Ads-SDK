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
    public class AdAccountTargetingUnifiedLimitTypeValues : AbstractCrudObjectFields
    {
        public const string ADGROUP_ID = "adgroup_id";
        public const string GENDERS = "genders";
        public const string AGE_MIN = "age_min";
        public const string AGE_MAX = "age_max";
        public const string COUNTRY_GROUPS = "country_groups";
        public const string COUNTRIES = "countries";
        public const string COUNTRY = "country";
        public const string CITIES = "cities";
        public const string RADIUS = "radius";
        public const string REGIONS = "regions";
        public const string ZIPS = "zips";
        public const string INTERESTS = "interests";
        public const string KEYWORDS = "keywords";
        public const string EDUCATION_SCHOOLS = "education_schools";
        public const string EDUCATION_MAJORS = "education_majors";
        public const string WORK_POSITIONS = "work_positions";
        public const string WORK_EMPLOYERS = "work_employers";
        public const string RELATIONSHIP_STATUSES = "relationship_statuses";
        public const string INTERESTED_IN = "interested_in";
        public const string LOCALES = "locales";
        public const string USER_ADCLUSTERS = "user_adclusters";
        public const string EXCLUDED_USER_ADCLUSTERS = "excluded_user_adclusters";
        public const string CONJUNCTIVE_USER_ADCLUSTERS = "conjunctive_user_adclusters";
        public const string CUSTOM_AUDIENCES = "custom_audiences";
        public const string EXCLUDED_CUSTOM_AUDIENCES = "excluded_custom_audiences";
        public const string COLLEGE_YEARS = "college_years";
        public const string EDUCATION_STATUSES = "education_statuses";
        public const string CONNECTIONS = "connections";
        public const string EXCLUDED_CONNECTIONS = "excluded_connections";
        public const string FRIENDS_OF_CONNECTIONS = "friends_of_connections";
        public const string USER_EVENT = "user_event";
        public const string DYNAMIC_AUDIENCE_IDS = "dynamic_audience_ids";
        public const string EXCLUDED_DYNAMIC_AUDIENCE_IDS = "excluded_dynamic_audience_ids";
        public const string RTB_FLAG = "rtb_flag";
        public const string SITE_CATEGORY = "site_category";
        public const string GEO_LOCATIONS = "geo_locations";
        public const string EXCLUDED_GEO_LOCATIONS = "excluded_geo_locations";
        public const string TIMEZONES = "timezones";
        public const string PLACE_PAGE_SET_IDS = "place_page_set_ids";
        public const string PAGE_TYPES = "page_types";
        public const string PUBLISHER_PLATFORMS = "publisher_platforms";
        public const string EFFECTIVE_PUBLISHER_PLATFORMS = "effective_publisher_platforms";
        public const string FACEBOOK_POSITIONS = "facebook_positions";
        public const string EFFECTIVE_FACEBOOK_POSITIONS = "effective_facebook_positions";
        public const string INSTAGRAM_POSITIONS = "instagram_positions";
        public const string EFFECTIVE_INSTAGRAM_POSITIONS = "effective_instagram_positions";
        public const string MESSENGER_POSITIONS = "messenger_positions";
        public const string EFFECTIVE_MESSENGER_POSITIONS = "effective_messenger_positions";
        public const string DEVICE_PLATFORMS = "device_platforms";
        public const string EFFECTIVE_DEVICE_PLATFORMS = "effective_device_platforms";
        public const string AUDIENCE_NETWORK_POSITIONS = "audience_network_positions";
        public const string EFFECTIVE_AUDIENCE_NETWORK_POSITIONS = "effective_audience_network_positions";
        public const string EXCLUDED_PUBLISHER_CATEGORIES = "excluded_publisher_categories";
        public const string EXCLUDED_PUBLISHER_LIST_IDS = "excluded_publisher_list_ids";
        public const string PUBLISHER_VISIBILITY_CATEGORIES = "publisher_visibility_categories";
        public const string USER_DEVICE = "user_device";
        public const string MOBILE_DEVICE_MODEL = "mobile_device_model";
        public const string EXCLUDED_USER_DEVICE = "excluded_user_device";
        public const string EXCLUDED_MOBILE_DEVICE_MODEL = "excluded_mobile_device_model";
        public const string USER_OS = "user_os";
        public const string WIRELESS_CARRIER = "wireless_carrier";
        public const string FAMILY_STATUSES = "family_statuses";
        public const string INDUSTRIES = "industries";
        public const string LIFE_EVENTS = "life_events";
        public const string POLITICAL_VIEWS = "political_views";
        public const string POLITICS = "politics";
        public const string BEHAVIORS = "behaviors";
        public const string INCOME = "income";
        public const string NET_WORTH = "net_worth";
        public const string HOME_TYPE = "home_type";
        public const string HOME_OWNERSHIP = "home_ownership";
        public const string HOME_VALUE = "home_value";
        public const string ETHNIC_AFFINITY = "ethnic_affinity";
        public const string GENERATION = "generation";
        public const string HOUSEHOLD_COMPOSITION = "household_composition";
        public const string MOMS = "moms";
        public const string OFFICE_TYPE = "office_type";
        public const string TARGETING_OPTIMIZATION = "targeting_optimization";
        public const string DIRECT_INSTALL_DEVICES = "direct_install_devices";
        public const string ENGAGEMENT_SPECS = "engagement_specs";
        public const string EXCLUDED_ENGAGEMENT_SPECS = "excluded_engagement_specs";
        public const string PRODUCT_AUDIENCE_SPECS = "product_audience_specs";
        public const string EXCLUDED_PRODUCT_AUDIENCE_SPECS = "excluded_product_audience_specs";
        public const string EXCLUSIONS = "exclusions";
        public const string FLEXIBLE_SPEC = "flexible_spec";
        public const string EXCLUDE_REACHED_SINCE = "exclude_reached_since";
        public const string EXCLUDE_PREVIOUS_DAYS = "exclude_previous_days";
        public const string APP_INSTALL_STATE = "app_install_state";
        public const string FB_DEAL_ID = "fb_deal_id";
        public const string INTEREST_DEFAULTS_SOURCE = "interest_defaults_source";
        public const string ALTERNATE_AUTO_TARGETING_OPTION = "alternate_auto_targeting_option";
        public const string CONTEXTUAL_TARGETING_CATEGORIES = "contextual_targeting_categories";
        public const string TOPIC = "topic";
        public const string FORMAT = "format";
        public const string TRENDING = "trending";
        public const string GATEKEEPERS = "gatekeepers";
        public const string FOLLOW_PROFILES = "follow_profiles";
        public const string FOLLOW_PROFILES_NEGATIVE = "follow_profiles_negative";
        public const string LOCATION_CATEGORIES = "location_categories";
        public const string USER_PAGE_THREADS = "user_page_threads";
        public const string USER_PAGE_THREADS_EXCLUDED = "user_page_threads_excluded";
        
    }
}


