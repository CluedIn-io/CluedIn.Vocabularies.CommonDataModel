using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerEnrolledBenefitInquiryEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerEnrolledBenefitInquiryEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollWorkerEnrolledBenefitInquiryEntity";
            KeyPrefix = "commonDataModel.payrollworkerenrolledbenefitinquiryentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerEnrolledBenefitInquiryEntity";

            AddGroup("Common Data Model PayrollWorkerEnrolledBenefitInquiryEntity Details", group =>
            {
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitTypeId = group.Add(new VocabularyKey(nameof(BenefitTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayrollCategory = group.Add(new VocabularyKey(nameof(PayrollCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitPlanID = group.Add(new VocabularyKey(nameof(BenefitPlanID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitOptionID = group.Add(new VocabularyKey(nameof(BenefitOptionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionRateSource = group.Add(new VocabularyKey(nameof(DeductionRateSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionBasis = group.Add(new VocabularyKey(nameof(DeductionBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeductionAmountCur = group.Add(new VocabularyKey(nameof(DeductionAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionBasis = group.Add(new VocabularyKey(nameof(ContributionBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionRateSource = group.Add(new VocabularyKey(nameof(ContributionRateSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContributionAmountCur = group.Add(new VocabularyKey(nameof(ContributionAmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitId = group.Add(new VocabularyKey(nameof(BenefitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitPlanAndOption = group.Add(new VocabularyKey(nameof(BenefitPlanAndOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Worker { get; private set; }
        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BenefitTypeId { get; private set; }
        public VocabularyKey PayrollCategory { get; private set; }
        public VocabularyKey BenefitPlanID { get; private set; }
        public VocabularyKey BenefitOptionID { get; private set; }
        public VocabularyKey DeductionRateSource { get; private set; }
        public VocabularyKey DeductionBasis { get; private set; }
        public VocabularyKey DeductionAmountCur { get; private set; }
        public VocabularyKey ContributionBasis { get; private set; }
        public VocabularyKey ContributionRateSource { get; private set; }
        public VocabularyKey ContributionAmountCur { get; private set; }
        public VocabularyKey BenefitId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey BenefitPlanAndOption { get; private set; }


    }
}