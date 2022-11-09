using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxGroupDataEntityVocabulary : SimpleVocabulary
    {
        public TaxGroupDataEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxGroupDataEntity";
            KeyPrefix = "commonDataModel.taxgroupdataentity";
            KeySeparator = ".";
            Grouping = "/TaxGroupDataEntity";

            AddGroup("Common Data Model TaxGroupDataEntity Details", group =>
            {
                TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxExemptCodeId = group.Add(new VocabularyKey(nameof(TaxExemptCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExemptTax = group.Add(new VocabularyKey(nameof(ExemptTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UseTax = group.Add(new VocabularyKey(nameof(UseTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrazilianTaxationCode = group.Add(new VocabularyKey(nameof(BrazilianTaxationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BrazilianTaxationCodeId = group.Add(new VocabularyKey(nameof(BrazilianTaxationCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReverseCharge = group.Add(new VocabularyKey(nameof(ReverseCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaxGroupId { get; private set; }
public VocabularyKey TaxCodeId { get; private set; }
public VocabularyKey TaxExemptCodeId { get; private set; }
public VocabularyKey ExemptTax { get; private set; }
public VocabularyKey UseTax { get; private set; }
public VocabularyKey BrazilianTaxationCode { get; private set; }
public VocabularyKey BrazilianTaxationCodeId { get; private set; }
public VocabularyKey ReverseCharge { get; private set; }


    }
}