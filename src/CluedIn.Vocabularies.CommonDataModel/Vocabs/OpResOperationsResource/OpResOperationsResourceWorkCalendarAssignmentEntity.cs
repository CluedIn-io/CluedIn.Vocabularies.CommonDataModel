using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OpResOperationsResourceWorkCalendarAssignmentEntityVocabulary : SimpleVocabulary
    {
        public OpResOperationsResourceWorkCalendarAssignmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model OpResOperationsResourceWorkCalendarAssignmentEntity";
            KeyPrefix = "commonDataModel.opresoperationsresourceworkcalendarassignmententity";
            KeySeparator = ".";
            Grouping = "/OpResOperationsResourceWorkCalendarAssignmentEntity";

            AddGroup("Common Data Model OpResOperationsResourceWorkCalendarAssignmentEntity Details", group =>
            {
                OperationsResourceId = group.Add(new VocabularyKey(nameof(OperationsResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkCalendarId = group.Add(new VocabularyKey(nameof(WorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey OperationsResourceId { get; private set; }
public VocabularyKey WorkCalendarId { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }


    }
}