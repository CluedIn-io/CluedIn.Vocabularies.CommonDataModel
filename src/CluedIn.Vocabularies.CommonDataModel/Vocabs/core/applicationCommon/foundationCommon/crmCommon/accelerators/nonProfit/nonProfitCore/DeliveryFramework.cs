using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitCore
{
    public class DeliveryFrameworkVocabulary : SimpleVocabulary
    {
        public DeliveryFrameworkVocabulary()
        {
            VocabularyName = "Delivery Framework";
            KeyPrefix = "commonDataModel.deliveryframework.nonprofitcore";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeliveryFramework;

            AddGroup("DeliveryFramework Details for NonProfitCore", group =>
            {
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    DeliveryFrameworkId = group.Add(new VocabularyKey(nameof(DeliveryFrameworkId), "Delivery Framework", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeliveryFrameworkType = group.Add(new VocabularyKey(nameof(DeliveryFrameworkType), "Delivery Framework Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Goal = group.Add(new VocabularyKey(nameof(Goal), "Goal", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedEndDate = group.Add(new VocabularyKey(nameof(PlannedEndDate), "Planned End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlannedStartDate = group.Add(new VocabularyKey(nameof(PlannedStartDate), "Planned Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Region = group.Add(new VocabularyKey(nameof(Region), "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Scope = group.Add(new VocabularyKey(nameof(Scope), "Scope", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="DonorId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="DonorId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
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
            ///Property <see cref="ObjectiveId"/> to Vocab 'Objective.cdm.json/Objective' with Property 'ObjectiveId'
            ///Property <see cref="ParentDeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="ReviewerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ObjectiveId"/> to Vocab 'Objective.cdm.json/Objective' with Property 'ObjectiveId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Budget.cdm.json/Budget' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'ParentDeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'DisbursementDistribution.cdm.json/DisbursementDistribution' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'ProgramItemRelationship.cdm.json/ProgramItemRelationship' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Result.cdm.json/Result' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'TheoryOfChangeRelationship.cdm.json/TheoryOfChangeRelationship' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'WorkItem.cdm.json/WorkItem' with Property 'RelatedDeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Project.cdm.json/Project' with Property 'DeliveryFrameworkId'
            #endregion
        }

        public VocabularyKey Country { get; private set; }
        public VocabularyKey DeliveryFrameworkId { get; private set; }
        public VocabularyKey DeliveryFrameworkType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Goal { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PlannedEndDate { get; private set; }
        public VocabularyKey PlannedStartDate { get; private set; }
        public VocabularyKey Region { get; private set; }
        public VocabularyKey Scope { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}