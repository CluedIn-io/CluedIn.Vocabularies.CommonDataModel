using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class MarketingListVocabulary : SimpleVocabulary
    {
        public MarketingListVocabulary()
        {
            VocabularyName = "Marketing List";
            KeyPrefix = "commonDataModel.marketinglist";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MarketingList;

            AddGroup("MarketingList Details for CrmCommon", group =>
            {
                ListId = group.Add(new VocabularyKey(nameof(ListId), "List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ListName = group.Add(new VocabularyKey(nameof(ListName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Cost = group.Add(new VocabularyKey(nameof(Cost), "Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                CostBase = group.Add(new VocabularyKey(nameof(CostBase), "Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedFromCode = group.Add(new VocabularyKey(nameof(CreatedFromCode), "Marketing List Member Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoNotSendOnOptOut = group.Add(new VocabularyKey(nameof(DoNotSendOnOptOut), "Exclude Members Who Opt Out", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IgnoreInactiveListMembers = group.Add(new VocabularyKey(nameof(IgnoreInactiveListMembers), "Ignore Inactive List Members", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                LastUsedOn = group.Add(new VocabularyKey(nameof(LastUsedOn), "Last Used On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LockStatus = group.Add(new VocabularyKey(nameof(LockStatus), "Locked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MemberCount = group.Add(new VocabularyKey(nameof(MemberCount), "Members Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MemberType = group.Add(new VocabularyKey(nameof(MemberType), "Member Type", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Query = group.Add(new VocabularyKey(nameof(Query), "Query", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Source = group.Add(new VocabularyKey(nameof(Source), "Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
            });
            AddGroup("MarketingList Details for Marketing", group =>
            {
                Issubscription = group.Add(new VocabularyKey(nameof(Issubscription), "Subscription", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="EntityId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="EntityId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="EntityId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="CreatedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ListId"/> to Vocab 'MarketingList.cdm.json/MarketingList' with Property 'ListId'
            ///Property <see cref="CreatedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="ListId"/> from Vocab 'CampaignActivityItem.cdm.json/CampaignActivityItem' with Property 'ItemId'
            ///Property <see cref="ListId"/> from Vocab 'MarketingListMember.cdm.json/MarketingListMember' with Property 'ListId'
            ///Property <see cref="ListId"/> from Vocab 'QuickCampaign.cdm.json/QuickCampaign' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey Cost { get; private set; }
        public VocabularyKey CostBase { get; private set; }
        public VocabularyKey CreatedFromCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DoNotSendOnOptOut { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey IgnoreInactiveListMembers { get; private set; }
        public VocabularyKey Issubscription { get; private set; }
        public VocabularyKey LastUsedOn { get; private set; }
        public VocabularyKey ListId { get; private set; }
        public VocabularyKey ListName { get; private set; }
        public VocabularyKey LockStatus { get; private set; }
        public VocabularyKey MemberCount { get; private set; }
        public VocabularyKey MemberType { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey Query { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}