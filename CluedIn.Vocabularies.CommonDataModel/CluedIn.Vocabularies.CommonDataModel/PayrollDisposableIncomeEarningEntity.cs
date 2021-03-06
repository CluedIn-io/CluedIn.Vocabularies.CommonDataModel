using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollDisposableIncomeEarningEntityVocabulary : SimpleVocabulary
    {
        public PayrollDisposableIncomeEarningEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollDisposableIncomeEarningEntity";
            KeyPrefix = "commonDataModel.payrolldisposableincomeearningentity";
            KeySeparator = ".";
            Grouping = "/PayrollDisposableIncomeEarningEntity";

            AddGroup("Common Data Model PayrollDisposableIncomeEarningEntity Details", group =>
            {
                DisposableIncome = group.Add(new VocabularyKey(nameof(DisposableIncome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningCode = group.Add(new VocabularyKey(nameof(EarningCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EarningCodeId = group.Add(new VocabularyKey(nameof(EarningCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DisposableIncome { get; private set; }
public VocabularyKey EarningCode { get; private set; }
public VocabularyKey EarningCodeId { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}