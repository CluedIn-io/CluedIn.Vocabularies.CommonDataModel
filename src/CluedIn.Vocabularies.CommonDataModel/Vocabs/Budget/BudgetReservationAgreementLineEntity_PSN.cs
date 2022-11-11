using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetReservationAgreementLineEntity_PSNVocabulary : SimpleVocabulary
    {
        public BudgetReservationAgreementLineEntity_PSNVocabulary()
        {
            VocabularyName = "Common Data Model BudgetReservationAgreementLineEntity_PSN";
            KeyPrefix = "commonDataModel.budgetreservationagreementlineentity_psn";
            KeySeparator = ".";
            Grouping = "/BudgetReservationAgreementLineEntity_PSN";

            AddGroup("Common Data Model BudgetReservationAgreementLineEntity_PSN Details", group =>
            {
                BudgetReservationDocumentNumber = group.Add(new VocabularyKey(nameof(BudgetReservationDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationLineNumber = group.Add(new VocabularyKey(nameof(BudgetReservationLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementLineNumber = group.Add(new VocabularyKey(nameof(AgreementLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseNumberSequence = group.Add(new VocabularyKey(nameof(PurchaseNumberSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgreementLineRecId = group.Add(new VocabularyKey(nameof(AgreementLineRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetReservationLineRecId = group.Add(new VocabularyKey(nameof(BudgetReservationLineRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyingLegalEntityRecId = group.Add(new VocabularyKey(nameof(BuyingLegalEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyingLegalEntityId = group.Add(new VocabularyKey(nameof(BuyingLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BudgetReservationDocumentNumber { get; private set; }
        public VocabularyKey BudgetReservationLineNumber { get; private set; }
        public VocabularyKey AgreementLineNumber { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey PurchaseNumberSequence { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey AgreementLineRecId { get; private set; }
        public VocabularyKey BudgetReservationLineRecId { get; private set; }
        public VocabularyKey BuyingLegalEntityRecId { get; private set; }
        public VocabularyKey BuyingLegalEntityId { get; private set; }


    }
}