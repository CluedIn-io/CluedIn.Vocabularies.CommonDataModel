using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.FoundationCommon
{
    public class RatingValueVocabulary : SimpleVocabulary
    {
        public RatingValueVocabulary()
        {
            VocabularyName = "Rating Value";
            KeyPrefix = "commonDataModel.ratingvalue.foundationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RatingValue;

            AddGroup("RatingValue Details for FoundationCommon", group =>
            {
			    RatingValueId = group.Add(new VocabularyKey(nameof(RatingValueId), "Rating Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="RatingModel"/> to Vocab 'RatingModel.cdm.json/RatingModel' with Property 'RatingModelId'
            ///Property <see cref="RatingModel"/> to Vocab 'RatingModel.cdm.json/RatingModel' with Property 'RatingModelId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="RatingValueId"/> from Vocab 'BookableResourceCharacteristic.cdm.json/BookableResourceCharacteristic' with Property 'RatingValue'
            #endregion
        }

        public VocabularyKey RatingValueId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}