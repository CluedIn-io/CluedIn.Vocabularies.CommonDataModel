using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitMeasurement
{
    public class IndicatorVocabulary : SimpleVocabulary
    {
        public IndicatorVocabulary()
        {
            VocabularyName = "Indicator";
            KeyPrefix = "commonDataModel.indicator.nonprofitmeasurement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Indicator;

            AddGroup("Indicator Details for NonProfitMeasurement", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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
            ///Property <see cref="ResultId"/> to Vocab 'Result.cdm.json/Result' with Property 'ResultId'
            ///Property <see cref="IndicatorId"/> to Vocab 'Indicator.cdm.json/Indicator' with Property 'IndicatorId'
            ///Property <see cref="ResultId"/> to Vocab 'Result.cdm.json/Result' with Property 'ResultId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="IndicatorId"/> from Vocab 'MeasurementItemUsage.cdm.json/MeasurementItemUsage' with Property 'IndicatorId'
            ///Property <see cref="IndicatorId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/IndicatorValue.cdm.json/IndicatorValue' with Property 'IndicatorId'
            ///Property <see cref="IndicatorId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/ProgramItemRelationship.cdm.json/ProgramItemRelationship' with Property 'IndicatorId'
            ///Property <see cref="IndicatorId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/TheoryOfChangeRelationship.cdm.json/TheoryOfChangeRelationship' with Property 'IndicatorId'
            #endregion
        }

        public VocabularyKey Name { get; private set; }
    }
}