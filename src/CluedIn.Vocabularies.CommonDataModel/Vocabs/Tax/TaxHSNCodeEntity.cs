using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxHSNCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxHSNCodeEntityVocabulary()
        {
            VocabularyName = "TaxHSNCodeEntity";
            KeyPrefix = "commonDataModel.taxhsncodeentity";
            KeySeparator = ".";
            Grouping = "/TaxHSNCodeEntity";

            AddGroup("TaxHSNCodeEntity Details", group =>
            {
                Chapter = group.Add(new VocabularyKey(nameof(Chapter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryExtension = group.Add(new VocabularyKey(nameof(CountryExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Heading = group.Add(new VocabularyKey(nameof(Heading), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatisticalSuffix = group.Add(new VocabularyKey(nameof(StatisticalSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Subheading = group.Add(new VocabularyKey(nameof(Subheading), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Chapter { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey CountryExtension { get; private set; }
        public VocabularyKey Heading { get; private set; }
        public VocabularyKey StatisticalSuffix { get; private set; }
        public VocabularyKey Subheading { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}