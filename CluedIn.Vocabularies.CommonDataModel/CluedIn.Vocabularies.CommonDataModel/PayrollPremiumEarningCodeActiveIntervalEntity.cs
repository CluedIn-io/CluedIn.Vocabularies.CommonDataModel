using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPremiumEarningCodeActiveIntervalEntityVocabulary : SimpleVocabulary
    {
        public PayrollPremiumEarningCodeActiveIntervalEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollPremiumEarningCodeActiveIntervalEntity";
            KeyPrefix = "commonDataModel.payrollpremiumearningcodeactiveintervalentity";
            KeySeparator = ".";
            Grouping = "/PayrollPremiumEarningCodeActiveIntervalEntity";

            AddGroup("Common Data Model PayrollPremiumEarningCodeActiveIntervalEntity Details", group =>
            {
                PremiumEarningCode = group.Add(new VocabularyKey(nameof(PremiumEarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PremiumEarningCodeId = group.Add(new VocabularyKey(nameof(PremiumEarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PremiumEarningCode { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey PremiumEarningCodeId { get; private set; }


    }
}