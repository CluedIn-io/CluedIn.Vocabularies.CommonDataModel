using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.NonProfitMeasurement
{
    public class DeliveryFrameworkVocabulary : SimpleVocabulary
    {
        public DeliveryFrameworkVocabulary()
        {
            VocabularyName = "Delivery Framework";
            KeyPrefix = "commonDataModel.deliveryframework.nonprofitmeasurement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeliveryFramework;

            AddGroup("DeliveryFramework Details for NonProfitMeasurement", group =>
            {
			    Country = group.Add(new VocabularyKey(nameof(Country), "Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible)); 
			    LogframeStatus = group.Add(new VocabularyKey(nameof(LogframeStatus), "Logframe Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Region = group.Add(new VocabularyKey(nameof(Region), "Region", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
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
            ///Property <see cref="AccountId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ObjectiveId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Objective.cdm.json/Objective' with Property 'ObjectiveId'
            ///Property <see cref="ParentDeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DonorId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ReviewerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ParentDeliveryFrameworkId"/> to Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'DeliveryFrameworkId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'DeliveryFramework.cdm.json/DeliveryFramework' with Property 'ParentDeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Budget.cdm.json/Budget' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DeliveryFramework.cdm.json/DeliveryFramework' with Property 'ParentDeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/DisbursementDistribution.cdm.json/DisbursementDistribution' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/ProgramItemRelationship.cdm.json/ProgramItemRelationship' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/Result.cdm.json/Result' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/TheoryOfChangeRelationship.cdm.json/TheoryOfChangeRelationship' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitCore/WorkItem.cdm.json/WorkItem' with Property 'RelatedDeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitForSales/Lead.cdm.json/Lead' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Project.cdm.json/Project' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'MeasurementItemUsage.cdm.json/MeasurementItemUsage' with Property 'DeliveryFrameworkId'
            ///Property <see cref="DeliveryFrameworkId"/> from Vocab 'Result.cdm.json/Result' with Property 'DeliveryFrameworkId'
            #endregion
        }

        public VocabularyKey Country { get; private set; }
        public VocabularyKey LogframeStatus { get; private set; }
        public VocabularyKey Region { get; private set; }
    }
}