using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FinancialDimensionValueLegalEntityOverrideEntityVocabulary : SimpleVocabulary
    {
        public FinancialDimensionValueLegalEntityOverrideEntityVocabulary()
        {
            VocabularyName = "Financial Dimension Value Legal Entity Override Entity";
            KeyPrefix = "commonDataModel.financialdimensionvaluelegalentityoverrideentity";
            KeySeparator = ".";
            Grouping = "/FinancialDimensionValueLegalEntityOverrideEntity";

            AddGroup("FinancialDimensionValueLegalEntityOverrideEntity Details", group =>
            {
                FinancialDimension = group.Add(new VocabularyKey(nameof(FinancialDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityInstance = group.Add(new VocabularyKey(nameof(EntityInstance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue = group.Add(new VocabularyKey(nameof(DimensionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveFrom = group.Add(new VocabularyKey(nameof(ActiveFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveTo = group.Add(new VocabularyKey(nameof(ActiveTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSuspended = group.Add(new VocabularyKey(nameof(IsSuspended), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerRefRecId = group.Add(new VocabularyKey(nameof(OwnerRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Owner = group.Add(new VocabularyKey(nameof(Owner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FinancialDimension { get; private set; }
        public VocabularyKey EntityInstance { get; private set; }
        public VocabularyKey DimensionValue { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey ActiveFrom { get; private set; }
        public VocabularyKey ActiveTo { get; private set; }
        public VocabularyKey IsSuspended { get; private set; }
        public VocabularyKey OwnerRefRecId { get; private set; }
        public VocabularyKey Owner { get; private set; }
    }
}