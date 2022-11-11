using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmBICurrentWorkerEntityVocabulary : SimpleVocabulary
    {
        public HcmBICurrentWorkerEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmBICurrentWorkerEntity";
            KeyPrefix = "commonDataModel.hcmbicurrentworkerentity";
            KeySeparator = ".";
            Grouping = "/HcmBICurrentWorkerEntity";

            AddGroup("Common Data Model HcmBICurrentWorkerEntity Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Compensation = group.Add(new VocabularyKey(nameof(Compensation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Benefit = group.Add(new VocabularyKey(nameof(Benefit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Performance = group.Add(new VocabularyKey(nameof(Performance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonSkill = group.Add(new VocabularyKey(nameof(PersonSkill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Demographics = group.Add(new VocabularyKey(nameof(Demographics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Employment = group.Add(new VocabularyKey(nameof(Employment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeographicLocation = group.Add(new VocabularyKey(nameof(GeographicLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportsTo = group.Add(new VocabularyKey(nameof(ReportsTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Age = group.Add(new VocabularyKey(nameof(Age), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearsOfService = group.Add(new VocabularyKey(nameof(YearsOfService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionAssignmentStartDate = group.Add(new VocabularyKey(nameof(PositionAssignmentStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionAssignmentEndDate = group.Add(new VocabularyKey(nameof(PositionAssignmentEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentValidFrom = group.Add(new VocabularyKey(nameof(EmploymentValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentValidTo = group.Add(new VocabularyKey(nameof(EmploymentValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidTo = group.Add(new VocabularyKey(nameof(EmploymentDetailValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidFrom = group.Add(new VocabularyKey(nameof(EmploymentDetailValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedCompensationValidTo = group.Add(new VocabularyKey(nameof(FixedCompensationValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedCompensationValidFrom = group.Add(new VocabularyKey(nameof(FixedCompensationValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionDetailValidFrom = group.Add(new VocabularyKey(nameof(PositionDetailValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionDetailValidTo = group.Add(new VocabularyKey(nameof(PositionDetailValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidFrom = group.Add(new VocabularyKey(nameof(JobDetailValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidTo = group.Add(new VocabularyKey(nameof(JobDetailValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionHierarchyValidTo = group.Add(new VocabularyKey(nameof(PositionHierarchyValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionHierarchyValidFrom = group.Add(new VocabularyKey(nameof(PositionHierarchyValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportsToWorkerPositionAssignmentValidFrom = group.Add(new VocabularyKey(nameof(ReportsToWorkerPositionAssignmentValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportsToWorkerPositionAssignmentValidTo = group.Add(new VocabularyKey(nameof(ReportsToWorkerPositionAssignmentValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalAddressValidFrom = group.Add(new VocabularyKey(nameof(PostalAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalAddressValidTo = group.Add(new VocabularyKey(nameof(PostalAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidFrom = group.Add(new VocabularyKey(nameof(PersonDetailsValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidTo = group.Add(new VocabularyKey(nameof(PersonDetailsValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTitleValidFrom = group.Add(new VocabularyKey(nameof(WorkerTitleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTitleValidTo = group.Add(new VocabularyKey(nameof(WorkerTitleValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerEnrolledBenefitValidFrom = group.Add(new VocabularyKey(nameof(WorkerEnrolledBenefitValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerEnrolledBenefitValidTo = group.Add(new VocabularyKey(nameof(WorkerEnrolledBenefitValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidToPrivate = group.Add(new VocabularyKey(nameof(PersonDetailsValidToPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidFromPrivate = group.Add(new VocabularyKey(nameof(PersonDetailsValidFromPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionDetailValidFromPrivate = group.Add(new VocabularyKey(nameof(PositionDetailValidFromPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionDetailValidToPrivate = group.Add(new VocabularyKey(nameof(PositionDetailValidToPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidFromPrivate = group.Add(new VocabularyKey(nameof(JobDetailValidFromPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidToPrivate = group.Add(new VocabularyKey(nameof(JobDetailValidToPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidToPrivate = group.Add(new VocabularyKey(nameof(EmploymentDetailValidToPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidFromPrivate = group.Add(new VocabularyKey(nameof(EmploymentDetailValidFromPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Company { get; private set; }
        public VocabularyKey Compensation { get; private set; }
        public VocabularyKey Benefit { get; private set; }
        public VocabularyKey Performance { get; private set; }
        public VocabularyKey PersonSkill { get; private set; }
        public VocabularyKey Demographics { get; private set; }
        public VocabularyKey Employment { get; private set; }
        public VocabularyKey GeographicLocation { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey Job { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey ReportsTo { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Age { get; private set; }
        public VocabularyKey YearsOfService { get; private set; }
        public VocabularyKey PositionAssignmentStartDate { get; private set; }
        public VocabularyKey PositionAssignmentEndDate { get; private set; }
        public VocabularyKey EmploymentValidFrom { get; private set; }
        public VocabularyKey EmploymentValidTo { get; private set; }
        public VocabularyKey EmploymentDetailValidTo { get; private set; }
        public VocabularyKey EmploymentDetailValidFrom { get; private set; }
        public VocabularyKey FixedCompensationValidTo { get; private set; }
        public VocabularyKey FixedCompensationValidFrom { get; private set; }
        public VocabularyKey PositionDetailValidFrom { get; private set; }
        public VocabularyKey PositionDetailValidTo { get; private set; }
        public VocabularyKey JobDetailValidFrom { get; private set; }
        public VocabularyKey JobDetailValidTo { get; private set; }
        public VocabularyKey PositionHierarchyValidTo { get; private set; }
        public VocabularyKey PositionHierarchyValidFrom { get; private set; }
        public VocabularyKey ReportsToWorkerPositionAssignmentValidFrom { get; private set; }
        public VocabularyKey ReportsToWorkerPositionAssignmentValidTo { get; private set; }
        public VocabularyKey PostalAddressValidFrom { get; private set; }
        public VocabularyKey PostalAddressValidTo { get; private set; }
        public VocabularyKey PersonDetailsValidFrom { get; private set; }
        public VocabularyKey PersonDetailsValidTo { get; private set; }
        public VocabularyKey WorkerTitleValidFrom { get; private set; }
        public VocabularyKey WorkerTitleValidTo { get; private set; }
        public VocabularyKey WorkerEnrolledBenefitValidFrom { get; private set; }
        public VocabularyKey WorkerEnrolledBenefitValidTo { get; private set; }
        public VocabularyKey PersonDetailsValidToPrivate { get; private set; }
        public VocabularyKey PersonDetailsValidFromPrivate { get; private set; }
        public VocabularyKey PositionDetailValidFromPrivate { get; private set; }
        public VocabularyKey PositionDetailValidToPrivate { get; private set; }
        public VocabularyKey JobDetailValidFromPrivate { get; private set; }
        public VocabularyKey JobDetailValidToPrivate { get; private set; }
        public VocabularyKey EmploymentDetailValidToPrivate { get; private set; }
        public VocabularyKey EmploymentDetailValidFromPrivate { get; private set; }


    }
}