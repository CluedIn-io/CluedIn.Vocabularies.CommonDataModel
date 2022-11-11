using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceRepairConditionEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceRepairConditionEntityVocabulary()
        {
            VocabularyName = "Common Data Model SMAServiceRepairConditionEntity";
            KeyPrefix = "commonDataModel.smaservicerepairconditionentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceRepairConditionEntity";

            AddGroup("Common Data Model SMAServiceRepairConditionEntity Details", group =>
            {
                ConditionId = group.Add(new VocabularyKey(nameof(ConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConditionDescription = group.Add(new VocabularyKey(nameof(ConditionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConditionId { get; private set; }
        public VocabularyKey ConditionDescription { get; private set; }


    }
}