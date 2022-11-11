using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerMatrixDimensionReportSetupEntityVocabulary : SimpleVocabulary
    {
        public LedgerMatrixDimensionReportSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerMatrixDimensionReportSetupEntity";
            KeyPrefix = "commonDataModel.ledgermatrixdimensionreportsetupentity";
            KeySeparator = ".";
            Grouping = "/LedgerMatrixDimensionReportSetupEntity";

            AddGroup("Common Data Model LedgerMatrixDimensionReportSetupEntity Details", group =>
            {
                Format = group.Add(new VocabularyKey(nameof(Format), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionMatrix = group.Add(new VocabularyKey(nameof(DimensionMatrix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttribute = group.Add(new VocabularyKey(nameof(DimensionAttribute), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionName = group.Add(new VocabularyKey(nameof(DimensionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValue = group.Add(new VocabularyKey(nameof(DimensionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Format { get; private set; }
        public VocabularyKey DimensionMatrix { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DimensionAttribute { get; private set; }
        public VocabularyKey DimensionName { get; private set; }
        public VocabularyKey DimensionValue { get; private set; }


    }
}