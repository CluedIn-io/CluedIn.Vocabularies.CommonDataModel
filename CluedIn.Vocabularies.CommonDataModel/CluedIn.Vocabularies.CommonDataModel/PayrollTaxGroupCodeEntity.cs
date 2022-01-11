using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollTaxGroupCodeEntityVocabulary : SimpleVocabulary
    {
        public PayrollTaxGroupCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollTaxGroupCodeEntity";
            KeyPrefix = "commonDataModel.payrolltaxgroupcodeentity";
            KeySeparator = ".";
            Grouping = "/PayrollTaxGroupCodeEntity";

            AddGroup("Common Data Model PayrollTaxGroupCodeEntity Details", group =>
            {
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCodeCountryRegionId = group.Add(new VocabularyKey(nameof(TaxCodeCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaxCode { get; private set; }
public VocabularyKey TaxGroup { get; private set; }
public VocabularyKey TaxCodeId { get; private set; }
public VocabularyKey TaxCodeCountryRegionId { get; private set; }
public VocabularyKey TaxGroupId { get; private set; }


    }
}