using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitCore
{
    public class AddressVocabulary : SimpleVocabulary
    {
        public AddressVocabulary()
        {
            VocabularyName = "Address";
            KeyPrefix = "commonDataModel.address.nonprofitcore";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Address;

            AddGroup("Address Details for NonProfitCore", group =>
            {
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsUspsValidated = group.Add(new VocabularyKey(nameof(IsUspsValidated), "USPS Validated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IsValidated = group.Add(new VocabularyKey(nameof(IsValidated), "Validated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Region = group.Add(new VocabularyKey(nameof(Region), "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalEndDay = group.Add(new VocabularyKey(nameof(SeasonalEndDay), "Seasonal End Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalEndMonth = group.Add(new VocabularyKey(nameof(SeasonalEndMonth), "Seasonal End Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalStartDay = group.Add(new VocabularyKey(nameof(SeasonalStartDay), "Seasonal Start Day", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SeasonalStartMonth = group.Add(new VocabularyKey(nameof(SeasonalStartMonth), "Seasonal Start Month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone1TypeCode = group.Add(new VocabularyKey(nameof(Telephone1TypeCode), "Telephone 1 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone2TypeCode = group.Add(new VocabularyKey(nameof(Telephone2TypeCode), "Telephone 2 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telephone3TypeCode = group.Add(new VocabularyKey(nameof(Telephone3TypeCode), "Telephone 3 Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ParentId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ParentId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ParentId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey IsUspsValidated { get; private set; }
        public VocabularyKey IsValidated { get; private set; }
        public VocabularyKey Region { get; private set; }
        public VocabularyKey SeasonalEndDay { get; private set; }
        public VocabularyKey SeasonalEndMonth { get; private set; }
        public VocabularyKey SeasonalStartDay { get; private set; }
        public VocabularyKey SeasonalStartMonth { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Telephone1TypeCode { get; private set; }
        public VocabularyKey Telephone2TypeCode { get; private set; }
        public VocabularyKey Telephone3TypeCode { get; private set; }
    }
}