using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollTaxCodeDefaultDimensionEntityVocabulary : SimpleVocabulary
    {
        public PayrollTaxCodeDefaultDimensionEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollTaxCodeDefaultDimensionEntity";
            KeyPrefix = "commonDataModel.payrolltaxcodedefaultdimensionentity";
            KeySeparator = ".";
            Grouping = "/PayrollTaxCodeDefaultDimensionEntity";

            AddGroup("Common Data Model PayrollTaxCodeDefaultDimensionEntity Details", group =>
            {
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCodeCountryRegionId = group.Add(new VocabularyKey(nameof(TaxCodeCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorLegalEntityId = group.Add(new VocabularyKey(nameof(VendorLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCategoryLegalEntityId = group.Add(new VocabularyKey(nameof(ProjectCategoryLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaxCodeId { get; private set; }
public VocabularyKey TaxCodeCountryRegionId { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }
public VocabularyKey VendorLegalEntityId { get; private set; }
public VocabularyKey ProjectCategoryId { get; private set; }
public VocabularyKey ProjectCategoryLegalEntityId { get; private set; }


    }
}