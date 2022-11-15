using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceRepairConditionEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceRepairConditionEntityVocabulary()
        {
            VocabularyName = "SMA Service Repair Condition Entity";
            KeyPrefix = "commonDataModel.smaservicerepairconditionentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceRepairConditionEntity";

            AddGroup("SMAServiceRepairConditionEntity Details", group =>
            {
                ConditionId = group.Add(new VocabularyKey(nameof(ConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConditionDescription = group.Add(new VocabularyKey(nameof(ConditionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConditionId { get; private set; }
        public VocabularyKey ConditionDescription { get; private set; }
    }
}