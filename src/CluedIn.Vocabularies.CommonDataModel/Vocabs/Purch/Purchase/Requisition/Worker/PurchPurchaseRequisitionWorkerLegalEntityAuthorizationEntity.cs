using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionWorkerLegalEntityAuthorizationEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionWorkerLegalEntityAuthorizationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseRequisitionWorkerLegalEntityAuthorizationEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionworkerlegalentityauthorizationentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionWorkerLegalEntityAuthorizationEntity";

            AddGroup("Common Data Model PurchPurchaseRequisitionWorkerLegalEntityAuthorizationEntity Details", group =>
            {
                Requisitioner = group.Add(new VocabularyKey(nameof(Requisitioner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionerPersonnelNumber = group.Add(new VocabularyKey(nameof(RequisitionerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Requisitioner { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey RequisitionerPersonnelNumber { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }


    }
}