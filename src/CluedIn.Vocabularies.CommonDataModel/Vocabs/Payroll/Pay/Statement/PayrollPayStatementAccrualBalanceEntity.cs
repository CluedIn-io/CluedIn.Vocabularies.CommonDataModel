using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPayStatementAccrualBalanceEntityVocabulary : SimpleVocabulary
    {
        public PayrollPayStatementAccrualBalanceEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollPayStatementAccrualBalanceEntity";
            KeyPrefix = "commonDataModel.payrollpaystatementaccrualbalanceentity";
            KeySeparator = ".";
            Grouping = "/PayrollPayStatementAccrualBalanceEntity";

            AddGroup("Common Data Model PayrollPayStatementAccrualBalanceEntity Details", group =>
            {
                Accrual = group.Add(new VocabularyKey(nameof(Accrual), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccruedHours = group.Add(new VocabularyKey(nameof(AccruedHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayStatement = group.Add(new VocabularyKey(nameof(PayStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalAccruedHours = group.Add(new VocabularyKey(nameof(TotalAccruedHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalAvailableHours = group.Add(new VocabularyKey(nameof(TotalAvailableHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalUsedHours = group.Add(new VocabularyKey(nameof(TotalUsedHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UsedHours = group.Add(new VocabularyKey(nameof(UsedHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccrualId = group.Add(new VocabularyKey(nameof(AccrualId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Accrual { get; private set; }
public VocabularyKey AccruedHours { get; private set; }
public VocabularyKey PayStatement { get; private set; }
public VocabularyKey TotalAccruedHours { get; private set; }
public VocabularyKey TotalAvailableHours { get; private set; }
public VocabularyKey TotalUsedHours { get; private set; }
public VocabularyKey UsedHours { get; private set; }
public VocabularyKey AccrualId { get; private set; }
public VocabularyKey PayStatementNumber { get; private set; }


    }
}