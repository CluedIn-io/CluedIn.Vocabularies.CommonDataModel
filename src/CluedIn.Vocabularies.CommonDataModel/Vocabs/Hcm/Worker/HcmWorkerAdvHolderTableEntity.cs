using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmWorkerAdvHolderTableEntityVocabulary : SimpleVocabulary
    {
        public HcmWorkerAdvHolderTableEntityVocabulary()
        {
            VocabularyName = "Hcm Worker Adv Holder Table Entity";
            KeyPrefix = "commonDataModel.hcmworkeradvholdertableentity";
            KeySeparator = ".";
            Grouping = "/HcmWorkerAdvHolderTableEntity";

            AddGroup("HcmWorkerAdvHolderTableEntity Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeId = group.Add(new VocabularyKey(nameof(EmployeeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdvanceHolder = group.Add(new VocabularyKey(nameof(AdvanceHolder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HcmEmployment = group.Add(new VocabularyKey(nameof(HcmEmployment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkTypeId = group.Add(new VocabularyKey(nameof(WorkTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey EmployeeId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AdvanceHolder { get; private set; }
        public VocabularyKey HcmEmployment { get; private set; }
        public VocabularyKey WorkTypeId { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
    }
}