using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkCycleEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkCycleEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollWorkCycleEntity";
            KeyPrefix = "commonDataModel.payrollworkcycleentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkCycleEntity";

            AddGroup("Common Data Model PayrollWorkCycleEntity Details", group =>
            {
                DaysPerPeriod = group.Add(new VocabularyKey(nameof(DaysPerPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkCycleId = group.Add(new VocabularyKey(nameof(WorkCycleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DaysPerPeriod { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey WorkCycleId { get; private set; }


    }
}