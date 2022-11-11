using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkingTimeSchedulingPropertyEntityVocabulary : SimpleVocabulary
    {
        public WorkingTimeSchedulingPropertyEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkingTimeSchedulingPropertyEntity";
            KeyPrefix = "commonDataModel.workingtimeschedulingpropertyentity";
            KeySeparator = ".";
            Grouping = "/WorkingTimeSchedulingPropertyEntity";

            AddGroup("Common Data Model WorkingTimeSchedulingPropertyEntity Details", group =>
            {
                PropertyId = group.Add(new VocabularyKey(nameof(PropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropertyName = group.Add(new VocabularyKey(nameof(PropertyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PropertyId { get; private set; }
        public VocabularyKey PropertyName { get; private set; }


    }
}