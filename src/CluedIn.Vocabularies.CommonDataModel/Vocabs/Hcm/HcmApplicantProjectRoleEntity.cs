using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmApplicantProjectRoleEntityVocabulary : SimpleVocabulary
    {
        public HcmApplicantProjectRoleEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmApplicantProjectRoleEntity";
            KeyPrefix = "commonDataModel.hcmapplicantprojectroleentity";
            KeySeparator = ".";
            Grouping = "/HcmApplicantProjectRoleEntity";

            AddGroup("Common Data Model HcmApplicantProjectRoleEntity Details", group =>
            {
                ApplicantId = group.Add(new VocabularyKey(nameof(ApplicantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DataArea = group.Add(new VocabularyKey(nameof(DataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectName = group.Add(new VocabularyKey(nameof(ProjectName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ApplicantId { get; private set; }
        public VocabularyKey DataArea { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectName { get; private set; }
        public VocabularyKey Role { get; private set; }
        public VocabularyKey StartDate { get; private set; }


    }
}