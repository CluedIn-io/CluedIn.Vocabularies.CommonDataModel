using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInventItemLabelReportSetupEntityVocabulary : SimpleVocabulary
    {
        public RetailInventItemLabelReportSetupEntityVocabulary()
        {
            VocabularyName = "RetailInventItemLabelReportSetupEntity";
            KeyPrefix = "commonDataModel.retailinventitemlabelreportsetupentity";
            KeySeparator = ".";
            Grouping = "/RetailInventItemLabelReportSetupEntity";

            AddGroup("RetailInventItemLabelReportSetupEntity Details", group =>
            {
                ReportName = group.Add(new VocabularyKey(nameof(ReportName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReportName { get; private set; }
        public VocabularyKey Type { get; private set; }


    }
}