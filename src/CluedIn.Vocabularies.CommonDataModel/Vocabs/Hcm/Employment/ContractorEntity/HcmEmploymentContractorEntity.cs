using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmEmploymentContractorEntityVocabulary : SimpleVocabulary
    {
        public HcmEmploymentContractorEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmEmploymentContractorEntity";
            KeyPrefix = "commonDataModel.hcmemploymentcontractorentity";
            KeySeparator = ".";
            Grouping = "/HcmEmploymentContractorEntity";

            AddGroup("Common Data Model HcmEmploymentContractorEntity Details", group =>
            {
                Employment = group.Add(new VocabularyKey(nameof(Employment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchReqTable = group.Add(new VocabularyKey(nameof(PurchReqTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorLegalEntityId = group.Add(new VocabularyKey(nameof(VendorLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentLegalEntity = group.Add(new VocabularyKey(nameof(EmploymentLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentStartDate = group.Add(new VocabularyKey(nameof(EmploymentStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentEndDate = group.Add(new VocabularyKey(nameof(EmploymentEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisitionId = group.Add(new VocabularyKey(nameof(PurchaseRequisitionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmploymentLegalEntityId = group.Add(new VocabularyKey(nameof(EmploymentLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Employment { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey PurchReqTable { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey VendorLegalEntityId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey EmploymentLegalEntity { get; private set; }
        public VocabularyKey EmploymentStartDate { get; private set; }
        public VocabularyKey EmploymentEndDate { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey PurchaseRequisitionId { get; private set; }
        public VocabularyKey EmploymentLegalEntityId { get; private set; }


    }
}