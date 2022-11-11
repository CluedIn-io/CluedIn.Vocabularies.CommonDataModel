using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxIntervatConfigurationEntityVocabulary : SimpleVocabulary
    {
        public TaxIntervatConfigurationEntityVocabulary()
        {
            VocabularyName = "TaxIntervatConfigurationEntity";
            KeyPrefix = "commonDataModel.taxintervatconfigurationentity";
            KeySeparator = ".";
            Grouping = "/TaxIntervatConfigurationEntity";

            AddGroup("TaxIntervatConfigurationEntity Details", group =>
            {
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Language { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}