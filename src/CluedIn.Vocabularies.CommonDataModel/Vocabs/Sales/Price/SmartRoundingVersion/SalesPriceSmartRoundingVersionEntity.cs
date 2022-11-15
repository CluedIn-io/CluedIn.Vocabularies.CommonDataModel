using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesPriceSmartRoundingVersionEntityVocabulary : SimpleVocabulary
    {
        public SalesPriceSmartRoundingVersionEntityVocabulary()
        {
            VocabularyName = "Sales Price Smart Rounding Version Entity";
            KeyPrefix = "commonDataModel.salespricesmartroundingversionentity";
            KeySeparator = ".";
            Grouping = "/SalesPriceSmartRoundingVersionEntity";

            AddGroup("SalesPriceSmartRoundingVersionEntity Details", group =>
            {
                RoundingVersionId = group.Add(new VocabularyKey(nameof(RoundingVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionName = group.Add(new VocabularyKey(nameof(VersionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RoundingVersionId { get; private set; }
        public VocabularyKey VersionName { get; private set; }
    }
}