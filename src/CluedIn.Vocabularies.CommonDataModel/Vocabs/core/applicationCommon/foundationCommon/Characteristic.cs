using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CharacteristicVocabulary : SimpleVocabulary
    {
        public CharacteristicVocabulary()
        {
            VocabularyName = "Characteristic";
            KeyPrefix = "commonDataModel.characteristic";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Characteristic;

            AddGroup("Characteristic Details for FoundationCommon", group =>
            {
                CharacteristicId = group.Add(new VocabularyKey(nameof(CharacteristicId), "Characteristic", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CharacteristicType = group.Add(new VocabularyKey(nameof(CharacteristicType), "Characteristic Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Characteristic Details for ProjectServiceAutomation", group =>
            {
                RequireApproval = group.Add(new VocabularyKey(nameof(RequireApproval), "Require Approval", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="Resource"/> to Vocab 'BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
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
            ///Property <see cref="Characteristic"/> to Vocab 'Characteristic.cdm.json/Characteristic' with Property 'CharacteristicId'
            ///Property <see cref="RatingValue"/> to Vocab 'RatingValue.cdm.json/RatingValue' with Property 'RatingValueId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
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
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="CharacteristicId"/> from Vocab 'BookableResourceCharacteristic.cdm.json/BookableResourceCharacteristic' with Property 'Characteristic'
            #endregion
        }

        public VocabularyKey CharacteristicId { get; private set; }
        public VocabularyKey CharacteristicType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequireApproval { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}