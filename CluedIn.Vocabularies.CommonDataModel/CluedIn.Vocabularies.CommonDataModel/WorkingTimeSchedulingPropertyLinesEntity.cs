using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkingTimeSchedulingPropertyLinesEntityVocabulary : SimpleVocabulary
    {
        public WorkingTimeSchedulingPropertyLinesEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkingTimeSchedulingPropertyLinesEntity";
            KeyPrefix = "commonDataModel.workingtimeschedulingpropertylinesentity";
            KeySeparator = ".";
            Grouping = "/WorkingTimeSchedulingPropertyLinesEntity";

            AddGroup("Common Data Model WorkingTimeSchedulingPropertyLinesEntity Details", group =>
            {
                WorkingTimeSchedulingPropertyId = group.Add(new VocabularyKey(nameof(WorkingTimeSchedulingPropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineName = group.Add(new VocabularyKey(nameof(LineName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineValue = group.Add(new VocabularyKey(nameof(LineValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WorkingTimeSchedulingPropertyId { get; private set; }
public VocabularyKey LineName { get; private set; }
public VocabularyKey LineValue { get; private set; }


    }
}