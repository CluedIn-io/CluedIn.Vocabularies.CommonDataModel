using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollAccrualBasisEarningCodeEntityVocabulary : SimpleVocabulary
    {
        public PayrollAccrualBasisEarningCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollAccrualBasisEarningCodeEntity";
            KeyPrefix = "commonDataModel.payrollaccrualbasisearningcodeentity";
            KeySeparator = ".";
            Grouping = "/PayrollAccrualBasisEarningCodeEntity";

            AddGroup("Common Data Model PayrollAccrualBasisEarningCodeEntity Details", group =>
            {
                Accrual = group.Add(new VocabularyKey(nameof(Accrual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccrualRate = group.Add(new VocabularyKey(nameof(AccrualRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccrualType = group.Add(new VocabularyKey(nameof(AccrualType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningCodeGroup = group.Add(new VocabularyKey(nameof(EarningCodeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccrualId = group.Add(new VocabularyKey(nameof(AccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningCodeGroupId = group.Add(new VocabularyKey(nameof(EarningCodeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Accrual { get; private set; }
public VocabularyKey AccrualRate { get; private set; }
public VocabularyKey AccrualType { get; private set; }
public VocabularyKey EarningCode { get; private set; }
public VocabularyKey EarningCodeGroup { get; private set; }
public VocabularyKey AccrualId { get; private set; }
public VocabularyKey EarningCodeId { get; private set; }
public VocabularyKey EarningCodeGroupId { get; private set; }


    }
}