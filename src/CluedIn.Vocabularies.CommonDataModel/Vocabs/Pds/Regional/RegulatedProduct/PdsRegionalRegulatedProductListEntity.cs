using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsRegionalRegulatedProductListEntityVocabulary : SimpleVocabulary
    {
        public PdsRegionalRegulatedProductListEntityVocabulary()
        {
            VocabularyName = "Pds Regional Regulated Product List Entity";
            KeyPrefix = "commonDataModel.pdsregionalregulatedproductlistentity";
            KeySeparator = ".";
            Grouping = "/PdsRegionalRegulatedProductListEntity";

            AddGroup("PdsRegionalRegulatedProductListEntity Details", group =>
            {
                RegulatingCountryRegionId = group.Add(new VocabularyKey(nameof(RegulatingCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegulatingStateId = group.Add(new VocabularyKey(nameof(RegulatingStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReportingList = group.Add(new VocabularyKey(nameof(IsReportingList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingListId = group.Add(new VocabularyKey(nameof(ReportingListId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingListDescription = group.Add(new VocabularyKey(nameof(ReportingListDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RegulatingCountryRegionId { get; private set; }
        public VocabularyKey RegulatingStateId { get; private set; }
        public VocabularyKey IsReportingList { get; private set; }
        public VocabularyKey ReportingListId { get; private set; }
        public VocabularyKey ReportingListDescription { get; private set; }
    }
}