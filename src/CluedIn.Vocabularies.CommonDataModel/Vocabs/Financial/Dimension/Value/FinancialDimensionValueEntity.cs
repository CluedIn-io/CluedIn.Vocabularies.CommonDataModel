using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FinancialDimensionValueEntityVocabulary : SimpleVocabulary
    {
        public FinancialDimensionValueEntityVocabulary()
        {
            VocabularyName = "FinancialDimensionValueEntity";
            KeyPrefix = "commonDataModel.financialdimensionvalueentity";
            KeySeparator = ".";
            Grouping = "/FinancialDimensionValueEntity";

            AddGroup("FinancialDimensionValueEntity Details", group =>
            {
                FinancialDimension = group.Add(new VocabularyKey(nameof(FinancialDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue = group.Add(new VocabularyKey(nameof(DimensionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveFrom = group.Add(new VocabularyKey(nameof(ActiveFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveTo = group.Add(new VocabularyKey(nameof(ActiveTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSuspended = group.Add(new VocabularyKey(nameof(IsSuspended), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTotal = group.Add(new VocabularyKey(nameof(IsTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBlockedForManualEntry = group.Add(new VocabularyKey(nameof(IsBlockedForManualEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDimension = group.Add(new VocabularyKey(nameof(GroupDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBalancing_PSN = group.Add(new VocabularyKey(nameof(IsBalancing_PSN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerRefRecId = group.Add(new VocabularyKey(nameof(OwnerRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Owner = group.Add(new VocabularyKey(nameof(Owner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FinancialDimension { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey DimensionValue { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ActiveFrom { get; private set; }
        public VocabularyKey ActiveTo { get; private set; }
        public VocabularyKey IsSuspended { get; private set; }
        public VocabularyKey IsTotal { get; private set; }
        public VocabularyKey IsBlockedForManualEntry { get; private set; }
        public VocabularyKey GroupDimension { get; private set; }
        public VocabularyKey IsBalancing_PSN { get; private set; }
        public VocabularyKey OwnerRefRecId { get; private set; }
        public VocabularyKey Owner { get; private set; }


    }
}