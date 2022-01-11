using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerTaxCodeV2EntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerTaxCodeV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollWorkerTaxCodeV2Entity";
            KeyPrefix = "commonDataModel.payrollworkertaxcodev2entity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerTaxCodeV2Entity";

            AddGroup("Common Data Model PayrollWorkerTaxCodeV2Entity Details", group =>
            {
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaxCode { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey TaxCodeId { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }


    }
}