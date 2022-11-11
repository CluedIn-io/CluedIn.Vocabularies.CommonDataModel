using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorPaymentJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public VendorPaymentJournalHeaderEntityVocabulary()
        {
            VocabularyName = "VendorPaymentJournalHeaderEntity";
            KeyPrefix = "commonDataModel.vendorpaymentjournalheaderentity";
            KeySeparator = ".";
            Grouping = "/VendorPaymentJournalHeaderEntity";

            AddGroup("VendorPaymentJournalHeaderEntity Details", group =>
            {
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocalInstrument = group.Add(new VocabularyKey(nameof(LocalInstrument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeBearer = group.Add(new VocabularyKey(nameof(ChargeBearer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryPurpose = group.Add(new VocabularyKey(nameof(CategoryPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLevel = group.Add(new VocabularyKey(nameof(ServiceLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey IsPosted { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LocalInstrument { get; private set; }
        public VocabularyKey ChargeBearer { get; private set; }
        public VocabularyKey CategoryPurpose { get; private set; }
        public VocabularyKey ServiceLevel { get; private set; }


    }
}