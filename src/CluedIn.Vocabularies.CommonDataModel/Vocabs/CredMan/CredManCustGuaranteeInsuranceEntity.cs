using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCustGuaranteeInsuranceEntityVocabulary : SimpleVocabulary
    {
        public CredManCustGuaranteeInsuranceEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManCustGuaranteeInsuranceEntity";
            KeyPrefix = "commonDataModel.credmancustguaranteeinsuranceentity";
            KeySeparator = ".";
            Grouping = "/CredManCustGuaranteeInsuranceEntity";

            AddGroup("Common Data Model CredManCustGuaranteeInsuranceEntity Details", group =>
            {
                CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GuaranteeInsurance = group.Add(new VocabularyKey(nameof(GuaranteeInsurance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GuaranteeInsuranceType = group.Add(new VocabularyKey(nameof(GuaranteeInsuranceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GuarantorInsurer = group.Add(new VocabularyKey(nameof(GuarantorInsurer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InsuranceCoverageType = group.Add(new VocabularyKey(nameof(InsuranceCoverageType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GuaranteeNumber = group.Add(new VocabularyKey(nameof(GuaranteeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncreaseCreditLimitPercent = group.Add(new VocabularyKey(nameof(IncreaseCreditLimitPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeInExposure = group.Add(new VocabularyKey(nameof(IncludeInExposure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CustAccount { get; private set; }
public VocabularyKey GuaranteeInsurance { get; private set; }
public VocabularyKey GuaranteeInsuranceType { get; private set; }
public VocabularyKey GuarantorInsurer { get; private set; }
public VocabularyKey InsuranceCoverageType { get; private set; }
public VocabularyKey GuaranteeNumber { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey Value { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey IncreaseCreditLimitPercent { get; private set; }
public VocabularyKey IncludeInExposure { get; private set; }


    }
}