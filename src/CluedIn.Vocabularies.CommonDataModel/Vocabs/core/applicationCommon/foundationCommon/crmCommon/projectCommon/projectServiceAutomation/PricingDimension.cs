using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class PricingDimensionVocabulary : SimpleVocabulary
    {
        public PricingDimensionVocabulary()
        {
            VocabularyName = "Pricing Dimension";
            KeyPrefix = "commonDataModel.pricingdimension.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/PricingDimension";

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
        }

        public VocabularyKey DimensionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ApplicableToCost { get; private set; }
        public VocabularyKey ApplicableToPurchase { get; private set; }
        public VocabularyKey ApplicableToSales { get; private set; }
        public VocabularyKey CostPriority { get; private set; }
        public VocabularyKey PurchasePriority { get; private set; }
        public VocabularyKey SalesPriority { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}