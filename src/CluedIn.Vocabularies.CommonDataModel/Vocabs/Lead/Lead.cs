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
                leadSourceCode = group.Add(new VocabularyKey(nameof(leadSourceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                companySize = group.Add(new VocabularyKey(nameof(companySize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                degree = group.Add(new VocabularyKey(nameof(degree), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fieldOfStudy = group.Add(new VocabularyKey(nameof(fieldOfStudy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                graduationDate = group.Add(new VocabularyKey(nameof(graduationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                industry = group.Add(new VocabularyKey(nameof(industry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                jobFunction = group.Add(new VocabularyKey(nameof(jobFunction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                latestsubmissiondate = group.Add(new VocabularyKey(nameof(latestsubmissiondate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                linkedinsubmissioncount = group.Add(new VocabularyKey(nameof(linkedinsubmissioncount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                school = group.Add(new VocabularyKey(nameof(school), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                seniority = group.Add(new VocabularyKey(nameof(seniority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                startDate = group.Add(new VocabularyKey(nameof(startDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey leadSourceCode { get; private set; }
        public VocabularyKey companySize { get; private set; }
        public VocabularyKey degree { get; private set; }
        public VocabularyKey fieldOfStudy { get; private set; }
        public VocabularyKey graduationDate { get; private set; }
        public VocabularyKey industry { get; private set; }
        public VocabularyKey jobFunction { get; private set; }
        public VocabularyKey latestsubmissiondate { get; private set; }
        public VocabularyKey linkedinsubmissioncount { get; private set; }
        public VocabularyKey school { get; private set; }
        public VocabularyKey seniority { get; private set; }
        public VocabularyKey startDate { get; private set; }


    }
}