using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseRequisitionWorkerOperatingUnitAuthorizationEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseRequisitionWorkerOperatingUnitAuthorizationEntityVocabulary()
        {
            VocabularyName = "PurchPurchaseRequisitionWorkerOperatingUnitAuthorizationEntity";
            KeyPrefix = "commonDataModel.purchpurchaserequisitionworkeroperatingunitauthorizationentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseRequisitionWorkerOperatingUnitAuthorizationEntity";

            AddGroup("PurchPurchaseRequisitionWorkerOperatingUnitAuthorizationEntity Details", group =>
            {
                Requisitioner = group.Add(new VocabularyKey(nameof(Requisitioner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceivingOperatingUnit = group.Add(new VocabularyKey(nameof(ReceivingOperatingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequisitionerPersonnelNumber = group.Add(new VocabularyKey(nameof(RequisitionerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Requisitioner { get; private set; }
        public VocabularyKey ReceivingOperatingUnit { get; private set; }
        public VocabularyKey RequisitionerPersonnelNumber { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }


    }
}