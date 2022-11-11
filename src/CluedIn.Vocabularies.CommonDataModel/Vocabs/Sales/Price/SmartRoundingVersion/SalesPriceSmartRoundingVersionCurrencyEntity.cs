using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesPriceSmartRoundingVersionCurrencyEntityVocabulary : SimpleVocabulary
    {
        public SalesPriceSmartRoundingVersionCurrencyEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesPriceSmartRoundingVersionCurrencyEntity";
            KeyPrefix = "commonDataModel.salespricesmartroundingversioncurrencyentity";
            KeySeparator = ".";
            Grouping = "/SalesPriceSmartRoundingVersionCurrencyEntity";

            AddGroup("Common Data Model SalesPriceSmartRoundingVersionCurrencyEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPriceSmartRoundingVersionId = group.Add(new VocabularyKey(nameof(SalesPriceSmartRoundingVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionRecId = group.Add(new VocabularyKey(nameof(VersionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey SalesPriceSmartRoundingVersionId { get; private set; }
        public VocabularyKey VersionRecId { get; private set; }


    }
}