using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesRebateParametersEntityVocabulary : SimpleVocabulary
    {
        public SalesRebateParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesRebateParametersEntity";
            KeyPrefix = "commonDataModel.salesrebateparametersentity";
            KeySeparator = ".";
            Grouping = "/SalesRebateParametersEntity";

            AddGroup("Common Data Model SalesRebateParametersEntity Details", group =>
            {
                WillInvoicingCreateRebateClaim = group.Add(new VocabularyKey(nameof(WillInvoicingCreateRebateClaim), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateWeekStartingDay = group.Add(new VocabularyKey(nameof(RebateWeekStartingDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerCreditNoteRebateProcessingJournalNameId = group.Add(new VocabularyKey(nameof(CustomerCreditNoteRebateProcessingJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceRegistrationRebateProcessingJournalNameId = group.Add(new VocabularyKey(nameof(VendorInvoiceRegistrationRebateProcessingJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceRegistrationPaymentTermsName = group.Add(new VocabularyKey(nameof(VendorInvoiceRegistrationPaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAccrualProcessingJournalNameId = group.Add(new VocabularyKey(nameof(RebateAccrualProcessingJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeSpendingRebateProcessingJournalNameId = group.Add(new VocabularyKey(nameof(TradeSpendingRebateProcessingJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightRebateProcessingJournalNameId = group.Add(new VocabularyKey(nameof(FreightRebateProcessingJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WillInvoicingCreateRebateClaim { get; private set; }
        public VocabularyKey RebateWeekStartingDay { get; private set; }
        public VocabularyKey CustomerCreditNoteRebateProcessingJournalNameId { get; private set; }
        public VocabularyKey VendorInvoiceRegistrationRebateProcessingJournalNameId { get; private set; }
        public VocabularyKey VendorInvoiceRegistrationPaymentTermsName { get; private set; }
        public VocabularyKey RebateAccrualProcessingJournalNameId { get; private set; }
        public VocabularyKey TradeSpendingRebateProcessingJournalNameId { get; private set; }
        public VocabularyKey FreightRebateProcessingJournalNameId { get; private set; }


    }
}