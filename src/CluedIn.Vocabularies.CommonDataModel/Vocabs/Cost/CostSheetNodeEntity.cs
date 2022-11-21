using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostSheetNodeEntityVocabulary : SimpleVocabulary
    {
        public CostSheetNodeEntityVocabulary()
        {
            VocabularyName = "Cost Sheet Node Entity";
            KeyPrefix = "commonDataModel.costsheetnodeentity";
            KeySeparator = ".";
            Grouping = "/CostSheetNodeEntity";

            AddGroup("CostSheetNodeEntity Details", group =>
            {
                IsCalculationFactorSpecifiedPerItem = group.Add(new VocabularyKey(nameof(IsCalculationFactorSpecifiedPerItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateNodeSubtype = group.Add(new VocabularyKey(nameof(RateNodeSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SurchargeNodeSubtype = group.Add(new VocabularyKey(nameof(SurchargeNodeSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitBasedNodeSubtype = group.Add(new VocabularyKey(nameof(UnitBasedNodeSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NodeName = group.Add(new VocabularyKey(nameof(NodeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostGroupId = group.Add(new VocabularyKey(nameof(CostGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimension = group.Add(new VocabularyKey(nameof(DefaultLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NodeDescription = group.Add(new VocabularyKey(nameof(NodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedIndirectAbsorptionMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedIndirectAbsorptionMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedIndirectAbsorptionOffsetMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedIndirectAbsorptionOffsetMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNodeShownAsHeader = group.Add(new VocabularyKey(nameof(IsNodeShownAsHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectAbsorptionMainAccountId = group.Add(new VocabularyKey(nameof(IndirectAbsorptionMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectAbsorptionOffsetMainAccountId = group.Add(new VocabularyKey(nameof(IndirectAbsorptionOffsetMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceNodeSubtype = group.Add(new VocabularyKey(nameof(PriceNodeSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsNodeShownAsTotalLine = group.Add(new VocabularyKey(nameof(IsNodeShownAsTotalLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NodeType = group.Add(new VocabularyKey(nameof(NodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedIndirectAbsorptionMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedIndirectAbsorptionMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedIndirectAbsorptionOffsetMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedIndirectAbsorptionOffsetMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectAbsorptionMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(IndirectAbsorptionMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndirectAbsorptionOffsetMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(IndirectAbsorptionOffsetMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentNodeName = group.Add(new VocabularyKey(nameof(ParentNodeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentNodeId = group.Add(new VocabularyKey(nameof(ParentNodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsorptionBasisNodeName = group.Add(new VocabularyKey(nameof(AbsorptionBasisNodeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SurchargeNodeAbsorptionBasisSubtype = group.Add(new VocabularyKey(nameof(SurchargeNodeAbsorptionBasisSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateNodeAbsorptionBasisSubtype = group.Add(new VocabularyKey(nameof(RateNodeAbsorptionBasisSubtype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsCalculationFactorSpecifiedPerItem { get; private set; }
        public VocabularyKey RateNodeSubtype { get; private set; }
        public VocabularyKey SurchargeNodeSubtype { get; private set; }
        public VocabularyKey UnitBasedNodeSubtype { get; private set; }
        public VocabularyKey NodeName { get; private set; }
        public VocabularyKey CostGroupId { get; private set; }
        public VocabularyKey DefaultLedgerDimension { get; private set; }
        public VocabularyKey NodeDescription { get; private set; }
        public VocabularyKey EstimatedIndirectAbsorptionMainAccountId { get; private set; }
        public VocabularyKey EstimatedIndirectAbsorptionOffsetMainAccountId { get; private set; }
        public VocabularyKey IsNodeShownAsHeader { get; private set; }
        public VocabularyKey IndirectAbsorptionMainAccountId { get; private set; }
        public VocabularyKey IndirectAbsorptionOffsetMainAccountId { get; private set; }
        public VocabularyKey PriceNodeSubtype { get; private set; }
        public VocabularyKey IsNodeShownAsTotalLine { get; private set; }
        public VocabularyKey NodeType { get; private set; }
        public VocabularyKey DefaultLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey EstimatedIndirectAbsorptionMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EstimatedIndirectAbsorptionOffsetMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey IndirectAbsorptionMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey IndirectAbsorptionOffsetMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey ParentNodeName { get; private set; }
        public VocabularyKey ParentNodeId { get; private set; }
        public VocabularyKey AbsorptionBasisNodeName { get; private set; }
        public VocabularyKey SurchargeNodeAbsorptionBasisSubtype { get; private set; }
        public VocabularyKey RateNodeAbsorptionBasisSubtype { get; private set; }
    }
}