using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmEmploymentContractorEntity_InternalVocabulary : SimpleVocabulary
    {
        public HcmEmploymentContractorEntity_InternalVocabulary()
        {
            VocabularyName = "HcmEmploymentContractorEntity_Internal";
            KeyPrefix = "commonDataModel.hcmemploymentcontractorentity_internal";
            KeySeparator = ".";
            Grouping = "/HcmEmploymentContractorEntity_Internal";

            AddGroup("HcmEmploymentContractorEntity_Internal Details", group =>
            {
                Employment = group.Add(new VocabularyKey(nameof(Employment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchReqTable = group.Add(new VocabularyKey(nameof(PurchReqTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorDataAreaID = group.Add(new VocabularyKey(nameof(VendorDataAreaID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorID = group.Add(new VocabularyKey(nameof(VendorID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchReqId = group.Add(new VocabularyKey(nameof(PurchReqId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorDataArea = group.Add(new VocabularyKey(nameof(VendorDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Employment { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey PurchReqTable { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey VendorDataAreaID { get; private set; }
        public VocabularyKey VendorID { get; private set; }
        public VocabularyKey PurchReqId { get; private set; }
        public VocabularyKey VendorDataArea { get; private set; }


    }
}