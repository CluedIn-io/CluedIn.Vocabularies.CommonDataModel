using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class CharacteristicVocabulary : SimpleVocabulary
    {
        public CharacteristicVocabulary()
        {
            VocabularyName = "Characteristic";
            KeyPrefix = "commonDataModel.characteristic.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Characteristic;

            AddGroup("Characteristic Details for ProjectServiceAutomation", group =>
            {
			    RequireApproval = group.Add(new VocabularyKey(nameof(RequireApproval), "Require Approval", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Characteristic"/> to Vocab 'Characteristic.cdm.json/Characteristic' with Property 'CharacteristicId'
            ///Property <see cref="RatingValue"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/RatingValue.cdm.json/RatingValue' with Property 'RatingValueId'
            ///Property <see cref="Resource"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SupportingRecord"/> to Vocab 'BookableResourceCharacteristic.cdm.json/BookableResourceCharacteristic' with Property 'BookableResourceCharacteristicId'
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
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="Characteristic"/> to Vocab 'Characteristic.cdm.json/Characteristic' with Property 'CharacteristicId'
            ///Property <see cref="Characteristic"/> to Vocab 'Characteristic.cdm.json/Characteristic' with Property 'CharacteristicId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="CharacteristicId"/> from Vocab 'BookableResourceCharacteristic.cdm.json/BookableResourceCharacteristic' with Property 'Characteristic'
            ///Property <see cref="BookableResourceCharacteristicId"/> from Vocab 'BookableResourceCharacteristic.cdm.json/BookableResourceCharacteristic' with Property 'SupportingRecord'
            ///Property <see cref="BookableResourceCharacteristicId"/> from Vocab 'ProjectServiceApproval.cdm.json/ProjectServiceApproval' with Property 'Characteristic'
            ///Property <see cref="CharacteristicId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceCharacteristic.cdm.json/BookableResourceCharacteristic' with Property 'Characteristic'
            ///Property <see cref="CharacteristicId"/> from Vocab 'RoleCompetencyRequirement.cdm.json/RoleCompetencyRequirement' with Property 'Characteristic'
            ///Property <see cref="CharacteristicId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/RequirementCharacteristic.cdm.json/RequirementCharacteristic' with Property 'Characteristic'
            #endregion
        }

        public VocabularyKey RequireApproval { get; private set; }
    }
}