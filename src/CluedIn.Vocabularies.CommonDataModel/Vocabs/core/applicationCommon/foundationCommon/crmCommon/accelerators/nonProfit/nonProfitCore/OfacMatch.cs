using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class OfacMatchVocabulary : SimpleVocabulary
    {
        public OfacMatchVocabulary()
        {
            VocabularyName = "Ofac Match";
            KeyPrefix = "commonDataModel.ofacmatch";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.OfacMatch;

            AddGroup("OfacMatch Details for NonProfitCore", group =>
            {
			    MatchType = group.Add(new VocabularyKey(nameof(MatchType), "Match Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OfacMatchId = group.Add(new VocabularyKey(nameof(OfacMatchId), "OFAC Match", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReportDate = group.Add(new VocabularyKey(nameof(ReportDate), "Report Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SDNName = group.Add(new VocabularyKey(nameof(SDNName), "SDN Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SDNNumber = group.Add(new VocabularyKey(nameof(SDNNumber), "SDN Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("OfacMatch Details for NonProfitForSales", group =>
            {

            });
            
            #region Incoming Relationships
            ///Property <see cref="OfacMatchCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OfacMatchCustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="OfacMatchCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="OfacMatchCustomerId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="RequestId"/> to Vocab 'Request.cdm.json/Request' with Property 'RequestId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey MatchType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OfacMatchId { get; private set; }
        public VocabularyKey ReportDate { get; private set; }
        public VocabularyKey SDNName { get; private set; }
        public VocabularyKey SDNNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Title { get; private set; }
    }
}