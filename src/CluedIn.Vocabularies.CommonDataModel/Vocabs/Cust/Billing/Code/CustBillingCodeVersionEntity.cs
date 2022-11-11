using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustBillingCodeVersionEntityVocabulary : SimpleVocabulary
    {
        public CustBillingCodeVersionEntityVocabulary()
        {
            VocabularyName = "CustBillingCodeVersionEntity";
            KeyPrefix = "commonDataModel.custbillingcodeversionentity";
            KeySeparator = ".";
            Grouping = "/CustBillingCodeVersionEntity";

            AddGroup("CustBillingCodeVersionEntity Details", group =>
            {
                AllowChangeAmountOnInvoice = group.Add(new VocabularyKey(nameof(AllowChangeAmountOnInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowChangesToLedgerAccounts = group.Add(new VocabularyKey(nameof(AllowChangesToLedgerAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountDetails = group.Add(new VocabularyKey(nameof(AmountDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustBillingCode = group.Add(new VocabularyKey(nameof(CustBillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustInterest = group.Add(new VocabularyKey(nameof(CustInterest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowChangesToProjectCategory = group.Add(new VocabularyKey(nameof(AllowChangesToProjectCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategory = group.Add(new VocabularyKey(nameof(ProjectCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowChangesToProject = group.Add(new VocabularyKey(nameof(AllowChangesToProject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RateType = group.Add(new VocabularyKey(nameof(RateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseLineValuesForUnspecifiedDimensions = group.Add(new VocabularyKey(nameof(UseLineValuesForUnspecifiedDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInterestCodeFromBillingClassification = group.Add(new VocabularyKey(nameof(UseInterestCodeFromBillingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingCode = group.Add(new VocabularyKey(nameof(BillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingCodeDescription = group.Add(new VocabularyKey(nameof(BillingCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestCode = group.Add(new VocabularyKey(nameof(InterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AllowChangeAmountOnInvoice { get; private set; }
        public VocabularyKey AllowChangesToLedgerAccounts { get; private set; }
        public VocabularyKey AmountDetails { get; private set; }
        public VocabularyKey CustBillingCode { get; private set; }
        public VocabularyKey CustInterest { get; private set; }
        public VocabularyKey AllowChangesToProjectCategory { get; private set; }
        public VocabularyKey ProjectCategory { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey AllowChangesToProject { get; private set; }
        public VocabularyKey RateType { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey UseLineValuesForUnspecifiedDimensions { get; private set; }
        public VocabularyKey UseInterestCodeFromBillingClassification { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey BillingCode { get; private set; }
        public VocabularyKey BillingCodeDescription { get; private set; }
        public VocabularyKey InterestCode { get; private set; }


    }
}