using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PropertyInstanceVocabulary : SimpleVocabulary
    {
        public PropertyInstanceVocabulary()
        {
            VocabularyName = "Property Instance";
            KeyPrefix = "commonDataModel.propertyinstance";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PropertyInstance;

            AddGroup("PropertyInstance Details for FoundationCommon", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValueInteger = group.Add(new VocabularyKey(nameof(ValueInteger), "Integer Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ValueDecimal = group.Add(new VocabularyKey(nameof(ValueDecimal), "Decimal Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueDouble = group.Add(new VocabularyKey(nameof(ValueDouble), "Double Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ValueString = group.Add(new VocabularyKey(nameof(ValueString), "String Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsValid = group.Add(new VocabularyKey(nameof(IsValid), "Is Valid", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("PropertyInstance Details for Sales", group =>
            {

            });
            
            #region Incoming Relationships
            ///Property <see cref="DynamicPropertyId"/> to Vocab 'Property.cdm.json/Property' with Property 'DynamicPropertyId'
            ///Property <see cref="DynamicPropertyId"/> to Vocab 'Property.cdm.json/Property' with Property 'DynamicPropertyId'
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
            ///Property <see cref="DynamicPropertyInstanceid"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="DynamicPropertyInstanceid"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey IsValid { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey ValueDecimal { get; private set; }
        public VocabularyKey ValueDouble { get; private set; }
        public VocabularyKey ValueInteger { get; private set; }
        public VocabularyKey ValueString { get; private set; }
    }
}