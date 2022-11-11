using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionParametersEntityVocabulary : SimpleVocabulary
    {
        public DimensionParametersEntityVocabulary()
        {
            VocabularyName = "DimensionParametersEntity";
            KeyPrefix = "commonDataModel.dimensionparametersentity";
            KeySeparator = ".";
            Grouping = "/DimensionParametersEntity";

            AddGroup("DimensionParametersEntity Details", group =>
            {
                DimensionSegmentDelimiter = group.Add(new VocabularyKey(nameof(DimensionSegmentDelimiter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionSegmentDelimiter { get; private set; }
        public VocabularyKey Key { get; private set; }


    }
}