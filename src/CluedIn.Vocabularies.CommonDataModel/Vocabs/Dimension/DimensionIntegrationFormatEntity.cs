using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionIntegrationFormatEntityVocabulary : SimpleVocabulary
    {
        public DimensionIntegrationFormatEntityVocabulary()
        {
            VocabularyName = "DimensionIntegrationFormatEntity";
            KeyPrefix = "commonDataModel.dimensionintegrationformatentity";
            KeySeparator = ".";
            Grouping = "/DimensionIntegrationFormatEntity";

            AddGroup("DimensionIntegrationFormatEntity Details", group =>
            {
                DimensionFormatName = group.Add(new VocabularyKey(nameof(DimensionFormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionFormatType = group.Add(new VocabularyKey(nameof(DimensionFormatType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialDimensionFormat = group.Add(new VocabularyKey(nameof(FinancialDimensionFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionHierarchy = group.Add(new VocabularyKey(nameof(DimensionHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionFormatName { get; private set; }
        public VocabularyKey DimensionFormatType { get; private set; }
        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey FinancialDimensionFormat { get; private set; }
        public VocabularyKey DimensionHierarchy { get; private set; }


    }
}