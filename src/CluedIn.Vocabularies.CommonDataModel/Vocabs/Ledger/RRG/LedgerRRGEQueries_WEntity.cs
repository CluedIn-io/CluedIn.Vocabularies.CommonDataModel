using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerRRGEQueries_WEntityVocabulary : SimpleVocabulary
    {
        public LedgerRRGEQueries_WEntityVocabulary()
        {
            VocabularyName = "LedgerRRGEQueries_WEntity";
            KeyPrefix = "commonDataModel.ledgerrrgequeries_wentity";
            KeySeparator = ".";
            Grouping = "/LedgerRRGEQueries_WEntity";

            AddGroup("LedgerRRGEQueries_WEntity Details", group =>
            {
                CurrencyForCalc = group.Add(new VocabularyKey(nameof(CurrencyForCalc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataType = group.Add(new VocabularyKey(nameof(DataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstOnly = group.Add(new VocabularyKey(nameof(FirstOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelNum = group.Add(new VocabularyKey(nameof(ModelNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Period = group.Add(new VocabularyKey(nameof(Period), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PointSignNum = group.Add(new VocabularyKey(nameof(PointSignNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QueryId = group.Add(new VocabularyKey(nameof(QueryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scale = group.Add(new VocabularyKey(nameof(Scale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeByCorrect = group.Add(new VocabularyKey(nameof(TypeByCorrect), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionHierarchyHashKey = group.Add(new VocabularyKey(nameof(DimensionHierarchyHashKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CurrencyForCalc { get; private set; }
        public VocabularyKey DataType { get; private set; }
        public VocabularyKey FirstOnly { get; private set; }
        public VocabularyKey ModelNum { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Period { get; private set; }
        public VocabularyKey PointSignNum { get; private set; }
        public VocabularyKey QueryId { get; private set; }
        public VocabularyKey Scale { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey TypeByCorrect { get; private set; }
        public VocabularyKey DimensionHierarchyHashKey { get; private set; }


    }
}