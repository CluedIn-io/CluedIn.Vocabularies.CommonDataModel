using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesShipmentReportFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SalesShipmentReportFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesShipmentReportFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.salesshipmentreportformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SalesShipmentReportFormPrintingConfigurationEntity";

            AddGroup("Common Data Model SalesShipmentReportFormPrintingConfigurationEntity Details", group =>
            {
                ReportLayout = group.Add(new VocabularyKey(nameof(ReportLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReportLayout { get; private set; }


    }
}