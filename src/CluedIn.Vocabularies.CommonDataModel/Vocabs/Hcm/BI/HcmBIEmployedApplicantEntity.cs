using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmBIEmployedApplicantEntityVocabulary : SimpleVocabulary
    {
        public HcmBIEmployedApplicantEntityVocabulary()
        {
            VocabularyName = "HcmBIEmployedApplicantEntity";
            KeyPrefix = "commonDataModel.hcmbiemployedapplicantentity";
            KeySeparator = ".";
            Grouping = "/HcmBIEmployedApplicantEntity";

            AddGroup("HcmBIEmployedApplicantEntity Details", group =>
            {
                Application = group.Add(new VocabularyKey(nameof(Application), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Applicant = group.Add(new VocabularyKey(nameof(Applicant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrespondenceAction = group.Add(new VocabularyKey(nameof(CorrespondenceAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfReceipt = group.Add(new VocabularyKey(nameof(DateOfReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpiryDate = group.Add(new VocabularyKey(nameof(ExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HiringManager = group.Add(new VocabularyKey(nameof(HiringManager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Media = group.Add(new VocabularyKey(nameof(Media), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecruitmentProject = group.Add(new VocabularyKey(nameof(RecruitmentProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LodgingCost = group.Add(new VocabularyKey(nameof(LodgingCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OtherCost = group.Add(new VocabularyKey(nameof(OtherCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TravelCost = group.Add(new VocabularyKey(nameof(TravelCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EducationLevel = group.Add(new VocabularyKey(nameof(EducationLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rating = group.Add(new VocabularyKey(nameof(Rating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplicationStatus = group.Add(new VocabularyKey(nameof(ApplicationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedSource = group.Add(new VocabularyKey(nameof(CreatedSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Job = group.Add(new VocabularyKey(nameof(Job), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Department = group.Add(new VocabularyKey(nameof(Department), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Employment = group.Add(new VocabularyKey(nameof(Employment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Performance = group.Add(new VocabularyKey(nameof(Performance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Demographics = group.Add(new VocabularyKey(nameof(Demographics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeographicLocation = group.Add(new VocabularyKey(nameof(GeographicLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplicantType = group.Add(new VocabularyKey(nameof(ApplicantType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidFrom = group.Add(new VocabularyKey(nameof(PersonDetailsValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidTo = group.Add(new VocabularyKey(nameof(PersonDetailsValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalAddressValidFrom = group.Add(new VocabularyKey(nameof(PostalAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalAddressValidTo = group.Add(new VocabularyKey(nameof(PostalAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidFrom = group.Add(new VocabularyKey(nameof(JobDetailValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidTo = group.Add(new VocabularyKey(nameof(JobDetailValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidFrom = group.Add(new VocabularyKey(nameof(EmploymentDetailValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidTo = group.Add(new VocabularyKey(nameof(EmploymentDetailValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentValidTo = group.Add(new VocabularyKey(nameof(EmploymentValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentValidFrom = group.Add(new VocabularyKey(nameof(EmploymentValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTitleValidFrom = group.Add(new VocabularyKey(nameof(WorkerTitleValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTitleValidTo = group.Add(new VocabularyKey(nameof(WorkerTitleValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidFromPrivate = group.Add(new VocabularyKey(nameof(PersonDetailsValidFromPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonDetailsValidToPrivate = group.Add(new VocabularyKey(nameof(PersonDetailsValidToPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidFromPrivate = group.Add(new VocabularyKey(nameof(JobDetailValidFromPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobDetailValidToPrivate = group.Add(new VocabularyKey(nameof(JobDetailValidToPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidFromPrivate = group.Add(new VocabularyKey(nameof(EmploymentDetailValidFromPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentDetailValidToPrivate = group.Add(new VocabularyKey(nameof(EmploymentDetailValidToPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Application { get; private set; }
        public VocabularyKey Applicant { get; private set; }
        public VocabularyKey CorrespondenceAction { get; private set; }
        public VocabularyKey DateOfReceipt { get; private set; }
        public VocabularyKey ExpiryDate { get; private set; }
        public VocabularyKey HiringManager { get; private set; }
        public VocabularyKey Media { get; private set; }
        public VocabularyKey RecruitmentProject { get; private set; }
        public VocabularyKey LodgingCost { get; private set; }
        public VocabularyKey OtherCost { get; private set; }
        public VocabularyKey TravelCost { get; private set; }
        public VocabularyKey EducationLevel { get; private set; }
        public VocabularyKey Rating { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ApplicationStatus { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey CreatedSource { get; private set; }
        public VocabularyKey Job { get; private set; }
        public VocabularyKey Department { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Employment { get; private set; }
        public VocabularyKey Performance { get; private set; }
        public VocabularyKey Demographics { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey GeographicLocation { get; private set; }
        public VocabularyKey ApplicantType { get; private set; }
        public VocabularyKey PersonDetailsValidFrom { get; private set; }
        public VocabularyKey PersonDetailsValidTo { get; private set; }
        public VocabularyKey PostalAddressValidFrom { get; private set; }
        public VocabularyKey PostalAddressValidTo { get; private set; }
        public VocabularyKey JobDetailValidFrom { get; private set; }
        public VocabularyKey JobDetailValidTo { get; private set; }
        public VocabularyKey EmploymentDetailValidFrom { get; private set; }
        public VocabularyKey EmploymentDetailValidTo { get; private set; }
        public VocabularyKey EmploymentValidTo { get; private set; }
        public VocabularyKey EmploymentValidFrom { get; private set; }
        public VocabularyKey WorkerTitleValidFrom { get; private set; }
        public VocabularyKey WorkerTitleValidTo { get; private set; }
        public VocabularyKey PersonDetailsValidFromPrivate { get; private set; }
        public VocabularyKey PersonDetailsValidToPrivate { get; private set; }
        public VocabularyKey JobDetailValidFromPrivate { get; private set; }
        public VocabularyKey JobDetailValidToPrivate { get; private set; }
        public VocabularyKey EmploymentDetailValidFromPrivate { get; private set; }
        public VocabularyKey EmploymentDetailValidToPrivate { get; private set; }


    }
}