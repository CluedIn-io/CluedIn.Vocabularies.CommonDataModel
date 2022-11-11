using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxSalesTaxFormTypesEntityVocabulary : SimpleVocabulary
    {
        public TaxSalesTaxFormTypesEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxSalesTaxFormTypesEntity";
            KeyPrefix = "commonDataModel.taxsalestaxformtypesentity";
            KeySeparator = ".";
            Grouping = "/TaxSalesTaxFormTypesEntity";

            AddGroup("Common Data Model TaxSalesTaxFormTypesEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormType = group.Add(new VocabularyKey(nameof(FormType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey FormType { get; private set; }
        public VocabularyKey TaxType { get; private set; }


    }
}