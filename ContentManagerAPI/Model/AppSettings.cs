using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagerAPI.Model
{

    public class ConnectionStrings
    {
        public string TBSConnectionString { get; set; }
        public string TBSFeedAggregatorConnectionString { get; set; }
    }

    public class LogLevel
    {
        public string Default { get; set; }
    }

    public class Logging
    {
        public LogLevel LogLevel { get; set; }
    }

    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public string MarketingAdminEndPoint { get; set; }
        public string BetInterceptEndPoint { get; set; }
        public string ContactEndPoint { get; set; }
        public string ClientMicroServiceEndPoint { get; set; }
        public string BettingEndPoint { get; set; }
        public string SgmEndPoint { get; set; }
        public string ReferAFriendEndPoint { get; set; }
        public string RewardsEndPoint { get; set; }
        public string MarketingApiEndPoint { get; set; }
        public string RiskAdminApiEndPoint { get; set; }
        public string SportsRiskAdminApiEndPoint { get; set; }
        public string SumoCollectorUri { get; set; }
        public string SecurityMicroService { get; set; }
        public string CashOut { get; set; }
        public string HomepageFeatureEndPoint { get; set; }
        public string HomepageFeatureAdminEndPoint { get; set; }
        public string ExternalMicroServicesEndPoint { get; set; }
        public string ExternalAccountMicroServicesEndPoint { get; set; }
        public string FavouriteEndPoint { get; set; }
        public Logging Logging { get; set; }
        public string AllowedHosts { get; set; }
    }




    //public class AppSettings
    //{
    //    public string BettingEndPoint { get; set; }

    //    public string SecurityMicroService { get; set; }
    //    public ConnectionStrings ConnectionStrings { get; set; }
    //}

    //public class ConnectionStrings
    //{
    //    public string TBSConnectionString { get; set; }
    //    public string TBSFeedAggregatorConnectionString { get; set; }
    //}

}

