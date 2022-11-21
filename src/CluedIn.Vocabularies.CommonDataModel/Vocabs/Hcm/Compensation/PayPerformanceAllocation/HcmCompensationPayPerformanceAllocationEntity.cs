using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmCompensationPayPerformanceAllocationEntityVocabulary : SimpleVocabulary
    {
        public HcmCompensationPayPerformanceAllocationEntityVocabulary()
        {
            VocabularyName = "Hcm Compensation Pay Performance Allocation Entity";
            KeyPrefix = "commonDataModel.hcmcompensationpayperformanceallocationentity";
            KeySeparator = ".";
            Grouping = "/HcmCompensationPayPerformanceAllocationEntity";

            AddGroup("HcmCompensationPayPerformanceAllocationEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Allocation = group.Add(new VocabularyKey(nameof(Allocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Department = group.Add(new VocabularyKey(nameof(Department), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DepartmentNumber = group.Add(new VocabularyKey(nameof(DepartmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Plan = group.Add(new VocabularyKey(nameof(Plan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Effective = group.Add(new VocabularyKey(nameof(Effective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Expiration = group.Add(new VocabularyKey(nameof(Expiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Allocation { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey DepartmentNumber { get; private set; }
        public VocabularyKey Plan { get; private set; }
        public VocabularyKey Effective { get; private set; }
        public VocabularyKey Expiration { get; private set; }
    }
}