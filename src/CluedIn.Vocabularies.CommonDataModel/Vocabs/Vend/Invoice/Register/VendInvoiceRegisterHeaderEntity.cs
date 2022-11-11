using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendInvoiceRegisterHeaderEntityVocabulary : SimpleVocabulary
    {
        public VendInvoiceRegisterHeaderEntityVocabulary()
        {
            VocabularyName = "VendInvoiceRegisterHeaderEntity";
            KeyPrefix = "commonDataModel.vendinvoiceregisterheaderentity";
            KeySeparator = ".";
            Grouping = "/VendInvoiceRegisterHeaderEntity";

            AddGroup("VendInvoiceRegisterHeaderEntity Details", group =>
            {
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxIncluded = group.Add(new VocabularyKey(nameof(SalesTaxIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey JournalName { get; private set; }
        public VocabularyKey JournalBatchNumber { get; private set; }
        public VocabularyKey SalesTaxIncluded { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Posted { get; private set; }


    }
}