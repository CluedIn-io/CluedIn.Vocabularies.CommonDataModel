using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailPackagePurchaseEntityVocabulary : SimpleVocabulary
    {
        public RetailPackagePurchaseEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailPackagePurchaseEntity";
            KeyPrefix = "commonDataModel.retailpackagepurchaseentity";
            KeySeparator = ".";
            Grouping = "/RetailPackagePurchaseEntity";

            AddGroup("Common Data Model RetailPackagePurchaseEntity Details", group =>
            {
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackageId = group.Add(new VocabularyKey(nameof(PackageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseId = group.Add(new VocabularyKey(nameof(PurchaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityReceived = group.Add(new VocabularyKey(nameof(QuantityReceived), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocatedCrossDockQty = group.Add(new VocabularyKey(nameof(AllocatedCrossDockQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey PackageId { get; private set; }
        public VocabularyKey PurchaseId { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey QuantityReceived { get; private set; }
        public VocabularyKey AllocatedCrossDockQty { get; private set; }


    }
}