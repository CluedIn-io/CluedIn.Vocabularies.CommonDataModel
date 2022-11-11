using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesShipmentReportFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SalesShipmentReportFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "SalesShipmentReportFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.salesshipmentreportformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SalesShipmentReportFormPrintingConfigurationEntity";

            AddGroup("SalesShipmentReportFormPrintingConfigurationEntity Details", group =>
            {
                ReportLayout = group.Add(new VocabularyKey(nameof(ReportLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReportLayout { get; private set; }


    }
}