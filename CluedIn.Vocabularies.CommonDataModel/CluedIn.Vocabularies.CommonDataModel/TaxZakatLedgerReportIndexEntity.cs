using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxZakatLedgerReportIndexEntityVocabulary : SimpleVocabulary
    {
        public TaxZakatLedgerReportIndexEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxZakatLedgerReportIndexEntity";
            KeyPrefix = "commonDataModel.taxzakatledgerreportindexentity";
            KeySeparator = ".";
            Grouping = "/TaxZakatLedgerReportIndexEntity";

            AddGroup("Common Data Model TaxZakatLedgerReportIndexEntity Details", group =>
            {
                ReportType = group.Add(new VocabularyKey(nameof(ReportType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportActive = group.Add(new VocabularyKey(nameof(ReportActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReportType { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ReportActive { get; private set; }


    }
}