using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitMeasurement
{
    public class ResultVocabulary : SimpleVocabulary
    {
        public ResultVocabulary()
        {
            VocabularyName = "Result";
            KeyPrefix = "commonDataModel.result.nonprofitmeasurement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Result;

            AddGroup("Result Details for NonProfitMeasurement", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="DeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
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
            ///Property <see cref="ParentResultId"/> to Vocab 'Result.cdm.json/Result' with Property 'ResultId'
            ///Property <see cref="ParentResultId"/> to Vocab 'Result.cdm.json/Result' with Property 'ResultId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ResultId"/> from Vocab 'Indicator.cdm.json/Indicator' with Property 'ResultId'
            ///Property <see cref="ResultId"/> from Vocab 'MeasurementItemUsage.cdm.json/MeasurementItemUsage' with Property 'ResultId'
            ///Property <see cref="ResultId"/> from Vocab 'Result.cdm.json/Result' with Property 'ParentResultId'
            ///Property <see cref="ResultId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Indicator.cdm.json/Indicator' with Property 'ResultId'
            ///Property <see cref="ResultId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/ProgramItemRelationship.cdm.json/ProgramItemRelationship' with Property 'ResultId'
            ///Property <see cref="ResultId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Result.cdm.json/Result' with Property 'ParentResultId'
            ///Property <see cref="ResultId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/TheoryOfChangeRelationship.cdm.json/TheoryOfChangeRelationship' with Property 'ResultId'
            #endregion
        }

        public VocabularyKey Name { get; private set; }
    }
}