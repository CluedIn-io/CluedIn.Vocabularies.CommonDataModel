using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxGSTReportConfigurationEntityVocabulary : SimpleVocabulary
    {
        public TaxGSTReportConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxGSTReportConfigurationEntity";
            KeyPrefix = "commonDataModel.taxgstreportconfigurationentity";
            KeySeparator = ".";
            Grouping = "/TaxGSTReportConfigurationEntity";

            AddGroup("Common Data Model TaxGSTReportConfigurationEntity Details", group =>
            {
                ReportingCodesForGSTAmount = group.Add(new VocabularyKey(nameof(ReportingCodesForGSTAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportingCodesForTransactionAmount = group.Add(new VocabularyKey(nameof(ReportingCodesForTransactionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeOfTransaction = group.Add(new VocabularyKey(nameof(TypeOfTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportConfigurationName = group.Add(new VocabularyKey(nameof(ReportConfigurationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReportConfigurationDescription = group.Add(new VocabularyKey(nameof(ReportConfigurationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReportingCodesForGSTAmount { get; private set; }
public VocabularyKey ReportingCodesForTransactionAmount { get; private set; }
public VocabularyKey TypeOfTransaction { get; private set; }
public VocabularyKey ReportConfigurationName { get; private set; }
public VocabularyKey ReportConfigurationDescription { get; private set; }


    }
}