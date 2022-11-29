using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CrmCommon
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.crmcommon";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details for CrmCommon", group =>
            {
			    OpenDeals = group.Add(new VocabularyKey(nameof(OpenDeals), "Open Deals", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OpenDealsDate = group.Add(new VocabularyKey(nameof(OpenDealsDate), "Open Deals (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpenDealsState = group.Add(new VocabularyKey(nameof(OpenDealsState), "Open Deals (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OpenRevenue = group.Add(new VocabularyKey(nameof(OpenRevenue), "Open Revenue", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OpenRevenueBase = group.Add(new VocabularyKey(nameof(OpenRevenueBase), "Open Revenue (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpenRevenueDate = group.Add(new VocabularyKey(nameof(OpenRevenueDate), "Open Revenue (Last Updated On)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpenRevenueState = group.Add(new VocabularyKey(nameof(OpenRevenueState), "Open Revenue (State)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey OpenDeals { get; private set; }
        public VocabularyKey OpenDealsDate { get; private set; }
        public VocabularyKey OpenDealsState { get; private set; }
        public VocabularyKey OpenRevenue { get; private set; }
        public VocabularyKey OpenRevenueBase { get; private set; }
        public VocabularyKey OpenRevenueDate { get; private set; }
        public VocabularyKey OpenRevenueState { get; private set; }
    }
}