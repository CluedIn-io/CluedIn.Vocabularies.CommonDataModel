using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorInvoiceTotalToleranceEntityVocabulary : SimpleVocabulary
    {
        public VendorInvoiceTotalToleranceEntityVocabulary()
        {
            VocabularyName = "VendorInvoiceTotalToleranceEntity";
            KeyPrefix = "commonDataModel.vendorinvoicetotaltoleranceentity";
            KeySeparator = ".";
            Grouping = "/VendorInvoiceTotalToleranceEntity";

            AddGroup("VendorInvoiceTotalToleranceEntity Details", group =>
            {
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorName = group.Add(new VocabularyKey(nameof(VendorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceTotalsPercentage = group.Add(new VocabularyKey(nameof(InvoiceTotalsPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey VendorName { get; private set; }
        public VocabularyKey InvoiceTotalsPercentage { get; private set; }


    }
}