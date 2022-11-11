using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendanceManualPremiumRegistrationEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendanceManualPremiumRegistrationEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgTimeAndAttendanceManualPremiumRegistrationEntity";
            KeyPrefix = "commonDataModel.jmgtimeandattendancemanualpremiumregistrationentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendanceManualPremiumRegistrationEntity";

            AddGroup("Common Data Model JmgTimeAndAttendanceManualPremiumRegistrationEntity Details", group =>
            {
                TimeProfileDate = group.Add(new VocabularyKey(nameof(TimeProfileDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeAndAttendanceManualPremiumId = group.Add(new VocabularyKey(nameof(TimeAndAttendanceManualPremiumId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitQuantity = group.Add(new VocabularyKey(nameof(UnitQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityRegistrationTransactionId = group.Add(new VocabularyKey(nameof(ActivityRegistrationTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualPremiumRegistrationEntryNumber = group.Add(new VocabularyKey(nameof(ManualPremiumRegistrationEntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(WorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TimeProfileDate { get; private set; }
        public VocabularyKey TimeAndAttendanceManualPremiumId { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey UnitQuantity { get; private set; }
        public VocabularyKey ActivityRegistrationTransactionId { get; private set; }
        public VocabularyKey ManualPremiumRegistrationEntryNumber { get; private set; }
        public VocabularyKey WorkerPersonnelNumber { get; private set; }


    }
}