using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchProductApprovedVendorEntityVocabulary : SimpleVocabulary
    {
        public PurchProductApprovedVendorEntityVocabulary()
        {
            VocabularyName = "Purch Product Approved Vendor Entity";
            KeyPrefix = "commonDataModel.purchproductapprovedvendorentity";
            KeySeparator = ".";
            Grouping = "/PurchProductApprovedVendorEntity";

            AddGroup("PurchProductApprovedVendorEntity Details", group =>
            {
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApprovedVendorAccountNumber = group.Add(new VocabularyKey(nameof(ApprovedVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ApprovedVendorAccountNumber { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
    }
}