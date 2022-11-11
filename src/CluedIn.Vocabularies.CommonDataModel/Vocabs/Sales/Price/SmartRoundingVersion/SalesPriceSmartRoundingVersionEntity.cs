using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesPriceSmartRoundingVersionEntityVocabulary : SimpleVocabulary
    {
        public SalesPriceSmartRoundingVersionEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesPriceSmartRoundingVersionEntity";
            KeyPrefix = "commonDataModel.salespricesmartroundingversionentity";
            KeySeparator = ".";
            Grouping = "/SalesPriceSmartRoundingVersionEntity";

            AddGroup("Common Data Model SalesPriceSmartRoundingVersionEntity Details", group =>
            {
                RoundingVersionId = group.Add(new VocabularyKey(nameof(RoundingVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionName = group.Add(new VocabularyKey(nameof(VersionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RoundingVersionId { get; private set; }
        public VocabularyKey VersionName { get; private set; }


    }
}