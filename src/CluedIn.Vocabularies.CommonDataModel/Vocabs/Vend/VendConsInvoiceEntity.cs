using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendConsInvoiceEntityVocabulary : SimpleVocabulary
    {
        public VendConsInvoiceEntityVocabulary()
        {
            VocabularyName = "VendConsInvoiceEntity";
            KeyPrefix = "commonDataModel.vendconsinvoiceentity";
            KeySeparator = ".";
            Grouping = "/VendConsInvoiceEntity";

            AddGroup("VendConsInvoiceEntity Details", group =>
            {
                AdjustmentAmount = group.Add(new VocabularyKey(nameof(AdjustmentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationDate = group.Add(new VocabularyKey(nameof(ConsolidationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConsolidationId = group.Add(new VocabularyKey(nameof(ConsolidationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExecutionDate = group.Add(new VocabularyKey(nameof(ExecutionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAmountDuringConsolidationPeriod = group.Add(new VocabularyKey(nameof(InvoiceAmountDuringConsolidationPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreviouslyPaidAmount = group.Add(new VocabularyKey(nameof(PreviouslyPaidAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreviousInvoiceAmount = group.Add(new VocabularyKey(nameof(PreviousInvoiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTax = group.Add(new VocabularyKey(nameof(SalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceConsolidationId = group.Add(new VocabularyKey(nameof(ReferenceConsolidationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AdjustmentAmount { get; private set; }
        public VocabularyKey ConsolidationDate { get; private set; }
        public VocabularyKey ConsolidationId { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey ExecutionDate { get; private set; }
        public VocabularyKey InvoiceAmountDuringConsolidationPeriod { get; private set; }
        public VocabularyKey PreviouslyPaidAmount { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey PreviousInvoiceAmount { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SalesTax { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey ReferenceConsolidationId { get; private set; }


    }
}