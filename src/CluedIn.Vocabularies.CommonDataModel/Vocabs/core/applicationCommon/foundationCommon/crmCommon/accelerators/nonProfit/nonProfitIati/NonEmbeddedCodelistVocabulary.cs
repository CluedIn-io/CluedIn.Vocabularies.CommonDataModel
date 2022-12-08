using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitIati
{
    public class NonEmbeddedCodelistVocabularyVocabulary : SimpleVocabulary
    {
        public NonEmbeddedCodelistVocabularyVocabulary()
        {
            VocabularyName = "Non Embedded Codelist Vocabulary";
            KeyPrefix = "commonDataModel.nonembeddedcodelistvocabulary.nonprofitiati";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.NonEmbeddedCodelistVocabulary;

            AddGroup("NonEmbeddedCodelistVocabulary Details for NonProfitIati", group =>
            {
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodelistType = group.Add(new VocabularyKey(nameof(CodelistType), "Codelist Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NonEmbeddedCodelistVocabularyId = group.Add(new VocabularyKey(nameof(NonEmbeddedCodelistVocabularyId), "Non Embedded Codelist Vocabulary", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Uri = group.Add(new VocabularyKey(nameof(Uri), "URI", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
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
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="NonEmbeddedCodelistVocabularyId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'BudgetIdentifierVocabularyId'
            #endregion
        }

        public VocabularyKey Code { get; private set; }
        public VocabularyKey CodelistType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NonEmbeddedCodelistVocabularyId { get; private set; }
        public VocabularyKey Uri { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}