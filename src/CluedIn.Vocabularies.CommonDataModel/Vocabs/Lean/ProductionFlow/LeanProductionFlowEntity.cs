using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeanProductionFlowEntityVocabulary : SimpleVocabulary
    {
        public LeanProductionFlowEntityVocabulary()
        {
            VocabularyName = "LeanProductionFlowEntity";
            KeyPrefix = "commonDataModel.leanproductionflowentity";
            KeySeparator = ".";
            Grouping = "/LeanProductionFlowEntity";

            AddGroup("LeanProductionFlowEntity Details", group =>
            {
                ControllingOrganization = group.Add(new VocabularyKey(nameof(ControllingOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueStreamNumber = group.Add(new VocabularyKey(nameof(ValueStreamNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlowName = group.Add(new VocabularyKey(nameof(FlowName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlowDescription = group.Add(new VocabularyKey(nameof(FlowDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionGroupId = group.Add(new VocabularyKey(nameof(ProductionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ControllingOrganization { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey ValueStreamNumber { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey FlowName { get; private set; }
        public VocabularyKey FlowDescription { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey ProductionGroupId { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }


    }
}