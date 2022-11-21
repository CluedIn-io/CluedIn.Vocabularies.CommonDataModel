using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead";
            KeySeparator = ".";
            Grouping = "/Lead";

            AddGroup("Lead Details", group =>
            {
                LeadSourceCode = group.Add(new VocabularyKey(nameof(LeadSourceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanySize = group.Add(new VocabularyKey(nameof(CompanySize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Degree = group.Add(new VocabularyKey(nameof(Degree), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldOfStudy = group.Add(new VocabularyKey(nameof(FieldOfStudy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GraduationDate = group.Add(new VocabularyKey(nameof(GraduationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Industry = group.Add(new VocabularyKey(nameof(Industry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobFunction = group.Add(new VocabularyKey(nameof(JobFunction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Latestsubmissiondate = group.Add(new VocabularyKey(nameof(Latestsubmissiondate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Linkedinsubmissioncount = group.Add(new VocabularyKey(nameof(Linkedinsubmissioncount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                School = group.Add(new VocabularyKey(nameof(School), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Seniority = group.Add(new VocabularyKey(nameof(Seniority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LeadSourceCode { get; private set; }
        public VocabularyKey CompanySize { get; private set; }
        public VocabularyKey Degree { get; private set; }
        public VocabularyKey FieldOfStudy { get; private set; }
        public VocabularyKey GraduationDate { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey JobFunction { get; private set; }
        public VocabularyKey Latestsubmissiondate { get; private set; }
        public VocabularyKey Linkedinsubmissioncount { get; private set; }
        public VocabularyKey School { get; private set; }
        public VocabularyKey Seniority { get; private set; }
        public VocabularyKey StartDate { get; private set; }
    }
}