using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReport347ValidationEntityVocabulary : SimpleVocabulary
    {
        public TaxReport347ValidationEntityVocabulary()
        {
            VocabularyName = "Tax Report 347 Validation Entity";
            KeyPrefix = "commonDataModel.taxreport347validationentity";
            KeySeparator = ".";
            Grouping = "/TaxReport347ValidationEntity";

            AddGroup("TaxReport347ValidationEntity Details", group =>
            {
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SalesTaxGroup { get; private set; }
    }
}