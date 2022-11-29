using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class InvoiceProductVocabulary : SimpleVocabulary
    {
        public InvoiceProductVocabulary()
        {
            VocabularyName = "Invoice Product";
            KeyPrefix = "commonDataModel.invoiceproduct.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/InvoiceProduct";

            AddGroup("InvoiceProduct Details for ProjectServiceAutomation", group =>
            {
			    BillingMethod = group.Add(new VocabularyKey(nameof(BillingMethod), "Billing Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChargeableAmount = group.Add(new VocabularyKey(nameof(ChargeableAmount), "Chargeable Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ChargeableAmountBase = group.Add(new VocabularyKey(nameof(ChargeableAmountBase), "Chargeable Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ComplimentaryAmount = group.Add(new VocabularyKey(nameof(ComplimentaryAmount), "Complimentary Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ComplimentaryAmountBase = group.Add(new VocabularyKey(nameof(ComplimentaryAmountBase), "Complimentary Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), "(Deprecated) Project Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLineAmount = group.Add(new VocabularyKey(nameof(ContractLineAmount), "Contract Line Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ContractLineAmountBase = group.Add(new VocabularyKey(nameof(ContractLineAmountBase), "Contract Line Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoicedTillDate = group.Add(new VocabularyKey(nameof(InvoicedTillDate), "Amount Previously Invoiced", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    InvoicedTillDateBase = group.Add(new VocabularyKey(nameof(InvoicedTillDateBase), "Amount Previously Invoiced (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NonChargeableAmount = group.Add(new VocabularyKey(nameof(NonChargeableAmount), "Non Chargeable Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NonChargeableAmountBase = group.Add(new VocabularyKey(nameof(NonChargeableAmountBase), "Non Chargeable Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BillingMethod { get; private set; }
        public VocabularyKey ChargeableAmount { get; private set; }
        public VocabularyKey ChargeableAmountBase { get; private set; }
        public VocabularyKey ComplimentaryAmount { get; private set; }
        public VocabularyKey ComplimentaryAmountBase { get; private set; }
        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey ContractLineAmount { get; private set; }
        public VocabularyKey ContractLineAmountBase { get; private set; }
        public VocabularyKey InvoicedTillDate { get; private set; }
        public VocabularyKey InvoicedTillDateBase { get; private set; }
        public VocabularyKey NonChargeableAmount { get; private set; }
        public VocabularyKey NonChargeableAmountBase { get; private set; }
    }
}