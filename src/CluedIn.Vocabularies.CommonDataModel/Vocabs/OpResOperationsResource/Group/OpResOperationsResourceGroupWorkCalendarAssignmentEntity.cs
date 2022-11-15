using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OpResOperationsResourceGroupWorkCalendarAssignmentEntityVocabulary : SimpleVocabulary
    {
        public OpResOperationsResourceGroupWorkCalendarAssignmentEntityVocabulary()
        {
            VocabularyName = "Op Res Operations Resource Group Work Calendar Assignment Entity";
            KeyPrefix = "commonDataModel.opresoperationsresourcegroupworkcalendarassignmententity";
            KeySeparator = ".";
            Grouping = "/OpResOperationsResourceGroupWorkCalendarAssignmentEntity";

            AddGroup("OpResOperationsResourceGroupWorkCalendarAssignmentEntity Details", group =>
            {
                OperationsResourceGroupId = group.Add(new VocabularyKey(nameof(OperationsResourceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkCalendarId = group.Add(new VocabularyKey(nameof(WorkCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey OperationsResourceGroupId { get; private set; }
        public VocabularyKey WorkCalendarId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
    }
}