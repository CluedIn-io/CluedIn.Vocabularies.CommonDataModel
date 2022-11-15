using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxRateTypeEntityVocabulary : SimpleVocabulary
    {
        public TaxRateTypeEntityVocabulary()
        {
            VocabularyName = "Tax Rate Type Entity";
            KeyPrefix = "commonDataModel.taxratetypeentity";
            KeySeparator = ".";
            Grouping = "/TaxRateTypeEntity";

            AddGroup("TaxRateTypeEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}