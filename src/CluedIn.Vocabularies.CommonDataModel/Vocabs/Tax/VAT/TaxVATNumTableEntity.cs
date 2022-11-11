using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxVATNumTableEntityVocabulary : SimpleVocabulary
    {
        public TaxVATNumTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxVATNumTableEntity";
            KeyPrefix = "commonDataModel.taxvatnumtableentity";
            KeySeparator = ".";
            Grouping = "/TaxVATNumTableEntity";

            AddGroup("Common Data Model TaxVATNumTableEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATNum = group.Add(new VocabularyKey(nameof(VATNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey VATNum { get; private set; }


    }
}