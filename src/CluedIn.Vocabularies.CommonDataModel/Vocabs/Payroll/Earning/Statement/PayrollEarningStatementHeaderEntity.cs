using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEarningStatementHeaderEntityVocabulary : SimpleVocabulary
    {
        public PayrollEarningStatementHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollEarningStatementHeaderEntity";
            KeyPrefix = "commonDataModel.payrollearningstatementheaderentity";
            KeySeparator = ".";
            Grouping = "/PayrollEarningStatementHeaderEntity";

            AddGroup("Common Data Model PayrollEarningStatementHeaderEntity Details", group =>
            {
                EarningsStatementNumber = group.Add(new VocabularyKey(nameof(EarningsStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayPeriod = group.Add(new VocabularyKey(nameof(PayPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayCycle = group.Add(new VocabularyKey(nameof(PayCycle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayPeriodEndDate = group.Add(new VocabularyKey(nameof(PayPeriodEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PayCycleId = group.Add(new VocabularyKey(nameof(PayCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey EarningsStatementNumber { get; private set; }
public VocabularyKey Note { get; private set; }
public VocabularyKey PayPeriod { get; private set; }
public VocabularyKey Worker { get; private set; }
public VocabularyKey PayCycle { get; private set; }
public VocabularyKey PayPeriodEndDate { get; private set; }
public VocabularyKey PayCycleId { get; private set; }
public VocabularyKey PersonnelNumber { get; private set; }
public VocabularyKey Company { get; private set; }


    }
}