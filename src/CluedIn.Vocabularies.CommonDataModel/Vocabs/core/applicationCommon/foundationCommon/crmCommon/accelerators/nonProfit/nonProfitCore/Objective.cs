using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitCore
{
    public class ObjectiveVocabulary : SimpleVocabulary
    {
        public ObjectiveVocabulary()
        {
            VocabularyName = "Objective";
            KeyPrefix = "commonDataModel.objective.nonprofitcore";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Objective;

            AddGroup("Objective Details for NonProfitCore", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObjectiveId = group.Add(new VocabularyKey(nameof(ObjectiveId), "Objective", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObjectiveType = group.Add(new VocabularyKey(nameof(ObjectiveType), "Objective Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ObjectiveAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
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
            ///Property <see cref="ParentObjectiveId"/> to Vocab 'Objective.cdm.json/Objective' with Property 'ObjectiveId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="ObjectiveId"/> from Vocab 'Budget.cdm.json/Budget' with Property 'ObjectiveId'
            ///Property <see cref="ObjectiveId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'ObjectiveId'
            ///Property <see cref="ObjectiveId"/> from Vocab 'Objective.cdm.json/Objective' with Property 'ParentObjectiveId'
            ///Property <see cref="ObjectiveId"/> from Vocab 'ProgramItemRelationship.cdm.json/ProgramItemRelationship' with Property 'ObjectiveId'
            ///Property <see cref="ObjectiveId"/> from Vocab 'TheoryOfChangeRelationship.cdm.json/TheoryOfChangeRelationship' with Property 'ObjectiveId'
            ///Property <see cref="ObjectiveId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitMeasurement/DeliveryFramework.cdm.json/DeliveryFramework' with Property 'ObjectiveId'
            ///Property <see cref="ObjectiveId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitMeasurement/MeasurementItemUsage.cdm.json/MeasurementItemUsage' with Property 'ObjectiveId'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObjectiveId { get; private set; }
        public VocabularyKey ObjectiveType { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}