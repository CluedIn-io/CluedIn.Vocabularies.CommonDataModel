using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsRegionalRegulatedProductEntityVocabulary : SimpleVocabulary
    {
        public PdsRegionalRegulatedProductEntityVocabulary()
        {
            VocabularyName = "Common Data Model PdsRegionalRegulatedProductEntity";
            KeyPrefix = "commonDataModel.pdsregionalregulatedproductentity";
            KeySeparator = ".";
            Grouping = "/PdsRegionalRegulatedProductEntity";

            AddGroup("Common Data Model PdsRegionalRegulatedProductEntity Details", group =>
            {
                RegionalRegulatedProductListRegulatingCountryRegionId = group.Add(new VocabularyKey(nameof(RegionalRegulatedProductListRegulatingCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegionalRegulatedProductListRegulatingStateId = group.Add(new VocabularyKey(nameof(RegionalRegulatedProductListRegulatingStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRegionalRegulatedProductListReportingList = group.Add(new VocabularyKey(nameof(IsRegionalRegulatedProductListReportingList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegionalRegulatedProductListReportingListId = group.Add(new VocabularyKey(nameof(RegionalRegulatedProductListReportingListId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegulatedItemNumber = group.Add(new VocabularyKey(nameof(RegulatedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RegionalRegulatedProductListRegulatingCountryRegionId { get; private set; }
        public VocabularyKey RegionalRegulatedProductListRegulatingStateId { get; private set; }
        public VocabularyKey IsRegionalRegulatedProductListReportingList { get; private set; }
        public VocabularyKey RegionalRegulatedProductListReportingListId { get; private set; }
        public VocabularyKey RegulatedItemNumber { get; private set; }


    }
}