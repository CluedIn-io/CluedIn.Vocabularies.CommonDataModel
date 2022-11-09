using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxFiscalClassificationCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxFiscalClassificationCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxFiscalClassificationCodeEntity";
            KeyPrefix = "commonDataModel.taxfiscalclassificationcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxFiscalClassificationCodeEntity";

            AddGroup("Common Data Model TaxFiscalClassificationCodeEntity Details", group =>
            {
                FiscalClassificationCode = group.Add(new VocabularyKey(nameof(FiscalClassificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalClassificationName = group.Add(new VocabularyKey(nameof(FiscalClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ApproximateTaxRateForNationalProducts = group.Add(new VocabularyKey(nameof(ApproximateTaxRateForNationalProducts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ApproximateTaxRateForImportedProducts = group.Add(new VocabularyKey(nameof(ApproximateTaxRateForImportedProducts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FiscalClassificationCode { get; private set; }
public VocabularyKey FiscalClassificationName { get; private set; }
public VocabularyKey ApproximateTaxRateForNationalProducts { get; private set; }
public VocabularyKey ApproximateTaxRateForImportedProducts { get; private set; }


    }
}