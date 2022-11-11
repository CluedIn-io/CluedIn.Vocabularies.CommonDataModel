using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseAgreementLineFulfillmentEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseAgreementLineFulfillmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseAgreementLineFulfillmentEntity";
            KeyPrefix = "commonDataModel.purchpurchaseagreementlinefulfillmententity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseAgreementLineFulfillmentEntity";

            AddGroup("Common Data Model PurchPurchaseAgreementLineFulfillmentEntity Details", group =>
            {
                PurchaseAgreementLegalEntityId = group.Add(new VocabularyKey(nameof(PurchaseAgreementLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseAgreementId = group.Add(new VocabularyKey(nameof(PurchaseAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommittedQuantity = group.Add(new VocabularyKey(nameof(CommittedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingQuantity = group.Add(new VocabularyKey(nameof(RemainingQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleasedQuantity = group.Add(new VocabularyKey(nameof(ReleasedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivedQuantity = group.Add(new VocabularyKey(nameof(ReceivedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicedQuantity = group.Add(new VocabularyKey(nameof(InvoicedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSymbol = group.Add(new VocabularyKey(nameof(UnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommittedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(CommittedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RemainingCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleasedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReleasedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(ReceivedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(InvoicedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CommittedAmount = group.Add(new VocabularyKey(nameof(CommittedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemainingAmount = group.Add(new VocabularyKey(nameof(RemainingAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReleasedAmount = group.Add(new VocabularyKey(nameof(ReleasedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivedAmount = group.Add(new VocabularyKey(nameof(ReceivedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicedAmount = group.Add(new VocabularyKey(nameof(InvoicedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurchaseAgreementLegalEntityId { get; private set; }
        public VocabularyKey PurchaseAgreementId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey CommittedQuantity { get; private set; }
        public VocabularyKey RemainingQuantity { get; private set; }
        public VocabularyKey ReleasedQuantity { get; private set; }
        public VocabularyKey ReceivedQuantity { get; private set; }
        public VocabularyKey InvoicedQuantity { get; private set; }
        public VocabularyKey UnitSymbol { get; private set; }
        public VocabularyKey CommittedCatchWeightQuantity { get; private set; }
        public VocabularyKey RemainingCatchWeightQuantity { get; private set; }
        public VocabularyKey ReleasedCatchWeightQuantity { get; private set; }
        public VocabularyKey ReceivedCatchWeightQuantity { get; private set; }
        public VocabularyKey InvoicedCatchWeightQuantity { get; private set; }
        public VocabularyKey CommittedAmount { get; private set; }
        public VocabularyKey RemainingAmount { get; private set; }
        public VocabularyKey ReleasedAmount { get; private set; }
        public VocabularyKey ReceivedAmount { get; private set; }
        public VocabularyKey InvoicedAmount { get; private set; }


    }
}