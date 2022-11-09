using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BrazilianElectronicReportingParametersEntityVocabulary : SimpleVocabulary
    {
        public BrazilianElectronicReportingParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model BrazilianElectronicReportingParametersEntity";
            KeyPrefix = "commonDataModel.brazilianelectronicreportingparametersentity";
            KeySeparator = ".";
            Grouping = "/BrazilianElectronicReportingParametersEntity";

            AddGroup("Common Data Model BrazilianElectronicReportingParametersEntity Details", group =>
            {
                ReportType = group.Add(new VocabularyKey(nameof(ReportType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ERModelMappingTable = group.Add(new VocabularyKey(nameof(ERModelMappingTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ModelMappingName = group.Add(new VocabularyKey(nameof(ModelMappingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SolutionName = group.Add(new VocabularyKey(nameof(SolutionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorUrl = group.Add(new VocabularyKey(nameof(VendorUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReportType { get; private set; }
public VocabularyKey ERModelMappingTable { get; private set; }
public VocabularyKey ModelMappingName { get; private set; }
public VocabularyKey SolutionName { get; private set; }
public VocabularyKey VendorUrl { get; private set; }


    }
}