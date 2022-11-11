using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerGarnishmentDetailEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerGarnishmentDetailEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollWorkerGarnishmentDetailEntity";
            KeyPrefix = "commonDataModel.payrollworkergarnishmentdetailentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerGarnishmentDetailEntity";

            AddGroup("Common Data Model PayrollWorkerGarnishmentDetailEntity Details", group =>
            {
                AdministrativeFee = group.Add(new VocabularyKey(nameof(AdministrativeFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CaseNumber = group.Add(new VocabularyKey(nameof(CaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GarnishmentTaxLevyType = group.Add(new VocabularyKey(nameof(GarnishmentTaxLevyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerEnrolledBenefit = group.Add(new VocabularyKey(nameof(WorkerEnrolledBenefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnrollmentStart = group.Add(new VocabularyKey(nameof(EnrollmentStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnrollmentEnd = group.Add(new VocabularyKey(nameof(EnrollmentEnd), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BenefitID = group.Add(new VocabularyKey(nameof(BenefitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AdministrativeFee { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey CaseNumber { get; private set; }
        public VocabularyKey GarnishmentTaxLevyType { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey WorkerEnrolledBenefit { get; private set; }
        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey EnrollmentStart { get; private set; }
        public VocabularyKey EnrollmentEnd { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey BenefitID { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }


    }
}