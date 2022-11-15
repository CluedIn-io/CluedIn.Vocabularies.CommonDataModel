using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgElectronicTimecardActivityRegistrationHeaderEntityVocabulary : SimpleVocabulary
    {
        public JmgElectronicTimecardActivityRegistrationHeaderEntityVocabulary()
        {
            VocabularyName = "Jmg Electronic Timecard Activity Registration Header Entity";
            KeyPrefix = "commonDataModel.jmgelectronictimecardactivityregistrationheaderentity";
            KeySeparator = ".";
            Grouping = "/JmgElectronicTimecardActivityRegistrationHeaderEntity";

            AddGroup("JmgElectronicTimecardActivityRegistrationHeaderEntity Details", group =>
            {
                TimeProfileDate = group.Add(new VocabularyKey(nameof(TimeProfileDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeProfileId = group.Add(new VocabularyKey(nameof(TimeProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTransferred = group.Add(new VocabularyKey(nameof(IsTransferred), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TimeProfileDate { get; private set; }
        public VocabularyKey TimeProfileId { get; private set; }
        public VocabularyKey IsTransferred { get; private set; }
        public VocabularyKey WorkerPersonnelNumber { get; private set; }
    }
}