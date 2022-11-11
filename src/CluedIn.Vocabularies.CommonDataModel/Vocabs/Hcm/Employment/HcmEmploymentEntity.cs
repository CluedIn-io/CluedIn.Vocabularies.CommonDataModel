using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmEmploymentEntityVocabulary : SimpleVocabulary
    {
        public HcmEmploymentEntityVocabulary()
        {
            VocabularyName = "HcmEmploymentEntity";
            KeyPrefix = "commonDataModel.hcmemploymententity";
            KeySeparator = ".";
            Grouping = "/HcmEmploymentEntity";

            AddGroup("HcmEmploymentEntity Details", group =>
            {
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegulatoryEstablishment = group.Add(new VocabularyKey(nameof(RegulatoryEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegulatoryEstablishmentId = group.Add(new VocabularyKey(nameof(RegulatoryEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerType = group.Add(new VocabularyKey(nameof(WorkerType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentStartDate = group.Add(new VocabularyKey(nameof(EmploymentStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentEndDate = group.Add(new VocabularyKey(nameof(EmploymentEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarLegalEntityId = group.Add(new VocabularyKey(nameof(CalendarLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey RegulatoryEstablishment { get; private set; }
        public VocabularyKey RegulatoryEstablishmentId { get; private set; }
        public VocabularyKey WorkerType { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey EmploymentStartDate { get; private set; }
        public VocabularyKey EmploymentEndDate { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey CalendarLegalEntityId { get; private set; }


    }
}