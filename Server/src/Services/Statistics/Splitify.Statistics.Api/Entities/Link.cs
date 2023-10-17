﻿namespace Splitify.Statistics.Api.Entities
{
    public class Link
    {
        public string? Id { get; set; }

        public int UniqueVisitors { get; set; }

        public int Visitors { get; set; }

        public string CampaignId { get; set; }

        public Link(string id, int uniqueVisitors, int visitors, string campaignId)
        {
            Id = id;
            UniqueVisitors = uniqueVisitors;
            Visitors = visitors;
            CampaignId = campaignId;
        }
    }
}
