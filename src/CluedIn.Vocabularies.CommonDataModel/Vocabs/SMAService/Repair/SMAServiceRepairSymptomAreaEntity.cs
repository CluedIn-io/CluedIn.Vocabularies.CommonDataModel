using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceRepairSymptomAreaEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceRepairSymptomAreaEntityVocabulary()
        {
            VocabularyName = "SMA Service Repair Symptom Area Entity";
            KeyPrefix = "commonDataModel.smaservicerepairsymptomareaentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceRepairSymptomAreaEntity";

            AddGroup("SMAServiceRepairSymptomAreaEntity Details", group =>
            {
                AreaDescription = group.Add(new VocabularyKey(nameof(AreaDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreaId = group.Add(new VocabularyKey(nameof(AreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AreaDescription { get; private set; }
        public VocabularyKey AreaId { get; private set; }
    }
}