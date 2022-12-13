using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SocialProfileVocabulary : SimpleVocabulary
    {
        public SocialProfileVocabulary()
        {
            VocabularyName = "Social Profile";
            KeyPrefix = "commonDataModel.socialprofile";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SocialProfile;

            AddGroup("SocialProfile Details for ApplicationCommon", group =>
            {
                SocialProfileId = group.Add(new VocabularyKey(nameof(SocialProfileId), "Social Profile ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileName = group.Add(new VocabularyKey(nameof(ProfileName), "Profile Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileFullName = group.Add(new VocabularyKey(nameof(ProfileFullName), "Full Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Blocked = group.Add(new VocabularyKey(nameof(Blocked), "Blocked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Community = group.Add(new VocabularyKey(nameof(Community), "Social Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfluenceScore = group.Add(new VocabularyKey(nameof(InfluenceScore), "Influence Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ProfileLink = group.Add(new VocabularyKey(nameof(ProfileLink), "Profile Link", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                UniqueProfileID = group.Add(new VocabularyKey(nameof(UniqueProfileID), "Unique Profile ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="CustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="SocialProfileId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="SocialProfileId"/> from Vocab 'Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="SocialProfileId"/> from Vocab 'SocialActivity.cdm.json/SocialActivity' with Property 'PostFromProfileId'
            ///Property <see cref="SocialProfileId"/> from Vocab 'foundationCommon/crmCommon/SocialActivity.cdm.json/SocialActivity' with Property 'PostFromProfileId'
            ///Property <see cref="SocialProfileId"/> from Vocab 'foundationCommon/crmCommon/service/Case.cdm.json/Case' with Property 'SocialProfileId'
            ///Property <see cref="SocialProfileId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record2Id'
            ///Property <see cref="SocialProfileId"/> from Vocab 'foundationCommon/crmCommon/solutions/marketing/Connection.cdm.json/Connection' with Property 'Record1Id'
            ///Property <see cref="SocialProfileId"/> from Vocab 'foundationCommon/crmCommon/solutions/portals/Case.cdm.json/Case' with Property 'SocialProfileId'
            #endregion
        }

        public VocabularyKey Blocked { get; private set; }
        public VocabularyKey Community { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey InfluenceScore { get; private set; }
        public VocabularyKey ProfileFullName { get; private set; }
        public VocabularyKey ProfileLink { get; private set; }
        public VocabularyKey ProfileName { get; private set; }
        public VocabularyKey SocialProfileId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey UniqueProfileID { get; private set; }
    }
}