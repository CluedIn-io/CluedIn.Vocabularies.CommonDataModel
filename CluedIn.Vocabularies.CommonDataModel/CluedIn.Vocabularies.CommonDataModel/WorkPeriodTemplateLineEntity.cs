using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkPeriodTemplateLineEntityVocabulary : SimpleVocabulary
    {
        public WorkPeriodTemplateLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkPeriodTemplateLineEntity";
            KeyPrefix = "commonDataModel.workperiodtemplatelineentity";
            KeySeparator = ".";
            Grouping = "/WorkPeriodTemplateLineEntity";

            AddGroup("Common Data Model WorkPeriodTemplateLineEntity Details", group =>
            {
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberOfPeriods = group.Add(new VocabularyKey(nameof(NumberOfPeriods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodDescription = group.Add(new VocabularyKey(nameof(PeriodDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodTemplateName = group.Add(new VocabularyKey(nameof(PeriodTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreMultiplePeriodsCreated = group.Add(new VocabularyKey(nameof(AreMultiplePeriodsCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LineNumber { get; private set; }
public VocabularyKey NumberOfPeriods { get; private set; }
public VocabularyKey PeriodName { get; private set; }
public VocabularyKey PeriodDescription { get; private set; }
public VocabularyKey PeriodTemplateName { get; private set; }
public VocabularyKey AreMultiplePeriodsCreated { get; private set; }


    }
}