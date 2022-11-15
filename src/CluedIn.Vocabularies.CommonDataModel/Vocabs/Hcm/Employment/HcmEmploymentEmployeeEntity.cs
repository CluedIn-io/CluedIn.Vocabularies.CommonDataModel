using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmEmploymentEmployeeEntityVocabulary : SimpleVocabulary
    {
        public HcmEmploymentEmployeeEntityVocabulary()
        {
            VocabularyName = "Hcm Employment Employee Entity";
            KeyPrefix = "commonDataModel.hcmemploymentemployeeentity";
            KeySeparator = ".";
            Grouping = "/HcmEmploymentEmployeeEntity";

            AddGroup("HcmEmploymentEmployeeEntity Details", group =>
            {
                ProbationPeriod = group.Add(new VocabularyKey(nameof(ProbationPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentStartDate = group.Add(new VocabularyKey(nameof(EmploymentStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentEndDate = group.Add(new VocabularyKey(nameof(EmploymentEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProbationPeriod { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey EmploymentStartDate { get; private set; }
        public VocabularyKey EmploymentEndDate { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
    }
}