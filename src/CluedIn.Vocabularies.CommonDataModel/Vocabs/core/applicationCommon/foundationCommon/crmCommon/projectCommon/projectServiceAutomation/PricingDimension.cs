using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PricingDimensionVocabulary : SimpleVocabulary
    {
        public PricingDimensionVocabulary()
        {
            VocabularyName = "Pricing Dimension";
            KeyPrefix = "commonDataModel.pricingdimension";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PricingDimension;

            AddGroup("PricingDimension Details for ProjectServiceAutomation", group =>
            {
			    DimensionId = group.Add(new VocabularyKey(nameof(DimensionId), "Pricing Dimension", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Dimension Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApplicableToCost = group.Add(new VocabularyKey(nameof(ApplicableToCost), "Applicable To Cost", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ApplicableToPurchase = group.Add(new VocabularyKey(nameof(ApplicableToPurchase), "Applicable To Purchase", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ApplicableToSales = group.Add(new VocabularyKey(nameof(ApplicableToSales), "Applicable To Sales", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CostPriority = group.Add(new VocabularyKey(nameof(CostPriority), "Cost Priority", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PurchasePriority = group.Add(new VocabularyKey(nameof(PurchasePriority), "Purchase Priority", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SalesPriority = group.Add(new VocabularyKey(nameof(SalesPriority), "Sales Priority", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
            ///Property <see cref="DimensionId"/> to Vocab 'PricingDimension.cdm.json/PricingDimension' with Property 'DimensionId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DimensionId"/> from Vocab 'PricingDimensionFieldName.cdm.json/PricingDimensionFieldName' with Property 'DimensionId'
            #endregion
        }

        public VocabularyKey ApplicableToCost { get; private set; }
        public VocabularyKey ApplicableToPurchase { get; private set; }
        public VocabularyKey ApplicableToSales { get; private set; }
        public VocabularyKey CostPriority { get; private set; }
        public VocabularyKey DimensionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PurchasePriority { get; private set; }
        public VocabularyKey SalesPriority { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}