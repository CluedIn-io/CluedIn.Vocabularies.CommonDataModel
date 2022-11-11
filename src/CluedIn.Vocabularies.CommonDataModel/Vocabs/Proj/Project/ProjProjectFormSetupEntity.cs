using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectFormSetupEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectFormSetupEntityVocabulary()
        {
            VocabularyName = "ProjProjectFormSetupEntity";
            KeyPrefix = "commonDataModel.projprojectformsetupentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectFormSetupEntity";

            AddGroup("ProjProjectFormSetupEntity Details", group =>
            {
                AssociatedPaymentAttachmentOnInvoice = group.Add(new VocabularyKey(nameof(AssociatedPaymentAttachmentOnInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackingSlip = group.Add(new VocabularyKey(nameof(PackingSlip), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumberInForms = group.Add(new VocabularyKey(nameof(ItemNumberInForms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintPackingSlipSpecificationsOnInvoice = group.Add(new VocabularyKey(nameof(PrintPackingSlipSpecificationsOnInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrePrintLevelInvoice = group.Add(new VocabularyKey(nameof(PrePrintLevelInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintEuroAmount = group.Add(new VocabularyKey(nameof(PrintEuroAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintTaxExemptNumberOnInvoice = group.Add(new VocabularyKey(nameof(PrintTaxExemptNumberOnInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecifyIndexCalculation = group.Add(new VocabularyKey(nameof(SpecifyIndexCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeparateTaxExemptBalanceInForms = group.Add(new VocabularyKey(nameof(SeparateTaxExemptBalanceInForms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxSpecification = group.Add(new VocabularyKey(nameof(SalesTaxSpecification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalsFirstLastPage = group.Add(new VocabularyKey(nameof(TotalsFirstLastPage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssociatedPaymentAttachmentOnInvoice { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey PackingSlip { get; private set; }
        public VocabularyKey ItemNumberInForms { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey PrintPackingSlipSpecificationsOnInvoice { get; private set; }
        public VocabularyKey PrePrintLevelInvoice { get; private set; }
        public VocabularyKey PrintEuroAmount { get; private set; }
        public VocabularyKey PrintTaxExemptNumberOnInvoice { get; private set; }
        public VocabularyKey SpecifyIndexCalculation { get; private set; }
        public VocabularyKey SeparateTaxExemptBalanceInForms { get; private set; }
        public VocabularyKey SalesTaxSpecification { get; private set; }
        public VocabularyKey TotalsFirstLastPage { get; private set; }


    }
}