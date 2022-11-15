using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmPersonProjectRoleEntityVocabulary : SimpleVocabulary
    {
        public HcmPersonProjectRoleEntityVocabulary()
        {
            VocabularyName = "Hcm Person Project Role Entity";
            KeyPrefix = "commonDataModel.hcmpersonprojectroleentity";
            KeySeparator = ".";
            Grouping = "/HcmPersonProjectRoleEntity";

            AddGroup("HcmPersonProjectRoleEntity Details", group =>
            {
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataArea = group.Add(new VocabularyKey(nameof(DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NullableDataArea = group.Add(new VocabularyKey(nameof(NullableDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Person = group.Add(new VocabularyKey(nameof(Person), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectName = group.Add(new VocabularyKey(nameof(ProjectName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey DataArea { get; private set; }
        public VocabularyKey NullableDataArea { get; private set; }
        public VocabularyKey Person { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectName { get; private set; }
        public VocabularyKey Role { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey StartDate { get; private set; }
    }
}