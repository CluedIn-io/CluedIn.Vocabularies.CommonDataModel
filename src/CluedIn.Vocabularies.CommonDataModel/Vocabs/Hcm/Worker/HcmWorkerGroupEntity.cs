using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmWorkerGroupEntityVocabulary : SimpleVocabulary
    {
        public HcmWorkerGroupEntityVocabulary()
        {
            VocabularyName = "Hcm Worker Group Entity";
            KeyPrefix = "commonDataModel.hcmworkergroupentity";
            KeySeparator = ".";
            Grouping = "/HcmWorkerGroupEntity";

            AddGroup("HcmWorkerGroupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployeeGroupId = group.Add(new VocabularyKey(nameof(EmployeeGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EmployeeGroupId { get; private set; }
    }
}