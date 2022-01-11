using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmTotalCompStatementSectionTaxEntityVocabulary : SimpleVocabulary
    {
        public HcmTotalCompStatementSectionTaxEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmTotalCompStatementSectionTaxEntity";
            KeyPrefix = "commonDataModel.hcmtotalcompstatementsectiontaxentity";
            KeySeparator = ".";
            Grouping = "/HcmTotalCompStatementSectionTaxEntity";

            AddGroup("Common Data Model HcmTotalCompStatementSectionTaxEntity Details", group =>
            {
                TotalCompensationStatementSection = group.Add(new VocabularyKey(nameof(TotalCompensationStatementSection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCodeGroupType = group.Add(new VocabularyKey(nameof(TaxCodeGroupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StatementSectionId = group.Add(new VocabularyKey(nameof(StatementSectionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NullableTaxCodeId = group.Add(new VocabularyKey(nameof(NullableTaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NullableCountryRegionId = group.Add(new VocabularyKey(nameof(NullableCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NullableTaxGroupId = group.Add(new VocabularyKey(nameof(NullableTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TotalCompensationStatementSection { get; private set; }
public VocabularyKey TaxCode { get; private set; }
public VocabularyKey TaxCodeGroupType { get; private set; }
public VocabularyKey TaxGroup { get; private set; }
public VocabularyKey StatementSectionId { get; private set; }
public VocabularyKey TaxCodeId { get; private set; }
public VocabularyKey NullableTaxCodeId { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey NullableCountryRegionId { get; private set; }
public VocabularyKey TaxGroupId { get; private set; }
public VocabularyKey NullableTaxGroupId { get; private set; }


    }
}