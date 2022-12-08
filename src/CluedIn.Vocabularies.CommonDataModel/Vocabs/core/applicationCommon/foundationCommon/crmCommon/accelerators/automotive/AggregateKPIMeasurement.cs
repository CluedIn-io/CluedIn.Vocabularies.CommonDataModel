using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Automotive
{
    public class AggregateKPIMeasurementVocabulary : SimpleVocabulary
    {
        public AggregateKPIMeasurementVocabulary()
        {
            VocabularyName = "Aggregate KPI Measurement";
            KeyPrefix = "commonDataModel.aggregatekpimeasurement.automotive";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.AggregateKPIMeasurement;

            AddGroup("AggregateKPIMeasurement Details for Automotive", group =>
            {
			    AggregateId = group.Add(new VocabularyKey(nameof(AggregateId), "Aggregate KPI Measurement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Count = group.Add(new VocabularyKey(nameof(Count), "Count", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Max = group.Add(new VocabularyKey(nameof(Max), "Max", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Mean = group.Add(new VocabularyKey(nameof(Mean), "Mean", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    MeasuredOn = group.Add(new VocabularyKey(nameof(MeasuredOn), "Measured On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Min = group.Add(new VocabularyKey(nameof(Min), "Min", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StdDev = group.Add(new VocabularyKey(nameof(StdDev), "StdDev", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    TargetValue = group.Add(new VocabularyKey(nameof(TargetValue), "Target Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
            ///Property <see cref="AggregateKPIContextId"/> to Vocab 'AggregateKPIContext.cdm.json/AggregateKPIContext' with Property 'AggregateKPIContextId'
            ///Property <see cref="MeasuredById"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="UnitId"/> to Vocab 'Unit.cdm.json/Unit' with Property 'UnitId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AggregateId { get; private set; }
        public VocabularyKey Count { get; private set; }
        public VocabularyKey Max { get; private set; }
        public VocabularyKey Mean { get; private set; }
        public VocabularyKey MeasuredOn { get; private set; }
        public VocabularyKey Min { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StdDev { get; private set; }
        public VocabularyKey TargetValue { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}