using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxBusinessVerticalsEntityVocabulary : SimpleVocabulary
    {
        public TaxBusinessVerticalsEntityVocabulary()
        {
            VocabularyName = "TaxBusinessVerticalsEntity";
            KeyPrefix = "commonDataModel.taxbusinessverticalsentity";
            KeySeparator = ".";
            Grouping = "/TaxBusinessVerticalsEntity";

            AddGroup("TaxBusinessVerticalsEntity Details", group =>
            {
                BusinessVerticals = group.Add(new VocabularyKey(nameof(BusinessVerticals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityCode = group.Add(new VocabularyKey(nameof(EntityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BusinessVerticals { get; private set; }
        public VocabularyKey EntityCode { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}