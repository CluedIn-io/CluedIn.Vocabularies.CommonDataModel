using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBenefitExternalReportingEntityVocabulary : SimpleVocabulary
    {
        public PayrollBenefitExternalReportingEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollBenefitExternalReportingEntity";
            KeyPrefix = "commonDataModel.payrollbenefitexternalreportingentity";
            KeySeparator = ".";
            Grouping = "/PayrollBenefitExternalReportingEntity";

            AddGroup("Common Data Model PayrollBenefitExternalReportingEntity Details", group =>
            {
                BenefitPlan = group.Add(new VocabularyKey(nameof(BenefitPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxLabel = group.Add(new VocabularyKey(nameof(W2BoxLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxLabelContribution = group.Add(new VocabularyKey(nameof(W2BoxLabelContribution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxNumber = group.Add(new VocabularyKey(nameof(W2BoxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxNumberContribution = group.Add(new VocabularyKey(nameof(W2BoxNumberContribution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitPlanID = group.Add(new VocabularyKey(nameof(BenefitPlanID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BenefitPlan { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey W2BoxLabel { get; private set; }
        public VocabularyKey W2BoxLabelContribution { get; private set; }
        public VocabularyKey W2BoxNumber { get; private set; }
        public VocabularyKey W2BoxNumberContribution { get; private set; }
        public VocabularyKey BenefitPlanID { get; private set; }


    }
}