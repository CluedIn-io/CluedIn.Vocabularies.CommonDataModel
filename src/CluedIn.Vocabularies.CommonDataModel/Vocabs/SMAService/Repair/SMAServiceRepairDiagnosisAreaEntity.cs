using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceRepairDiagnosisAreaEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceRepairDiagnosisAreaEntityVocabulary()
        {
            VocabularyName = "SMA Service Repair Diagnosis Area Entity";
            KeyPrefix = "commonDataModel.smaservicerepairdiagnosisareaentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceRepairDiagnosisAreaEntity";

            AddGroup("SMAServiceRepairDiagnosisAreaEntity Details", group =>
            {
                AreaCode = group.Add(new VocabularyKey(nameof(AreaCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreaDescription = group.Add(new VocabularyKey(nameof(AreaDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AreaCode { get; private set; }
        public VocabularyKey AreaDescription { get; private set; }
    }
}