using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmTransactionLoggingPolicyEntityVocabulary : SimpleVocabulary
    {
        public SmmTransactionLoggingPolicyEntityVocabulary()
        {
            VocabularyName = "Smm Transaction Logging Policy Entity";
            KeyPrefix = "commonDataModel.smmtransactionloggingpolicyentity";
            KeySeparator = ".";
            Grouping = "/SmmTransactionLoggingPolicyEntity";

            AddGroup("SmmTransactionLoggingPolicyEntity Details", group =>
            {
                AreCustomerChangesLogged = group.Add(new VocabularyKey(nameof(AreCustomerChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreCustomerTransactionChangesLogged = group.Add(new VocabularyKey(nameof(AreCustomerTransactionChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreVendorChangesLogged = group.Add(new VocabularyKey(nameof(AreVendorChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreVendorTransactionChangesLogged = group.Add(new VocabularyKey(nameof(AreVendorTransactionChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreContactPersonChangesLogged = group.Add(new VocabularyKey(nameof(AreContactPersonChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesActivityChangesLogged = group.Add(new VocabularyKey(nameof(AreSalesActivityChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreDocumentReferenceChangesLogged = group.Add(new VocabularyKey(nameof(AreDocumentReferenceChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderChangesLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreQuotationChangesLogged = group.Add(new VocabularyKey(nameof(AreQuotationChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreMailingChangesLogged = group.Add(new VocabularyKey(nameof(AreMailingChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreProspectChangesLogged = group.Add(new VocabularyKey(nameof(AreProspectChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreTelemarketingCallListChangesLogged = group.Add(new VocabularyKey(nameof(AreTelemarketingCallListChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreCampaignChangesLogged = group.Add(new VocabularyKey(nameof(AreCampaignChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreOpportunityChangesLogged = group.Add(new VocabularyKey(nameof(AreOpportunityChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreLeadChangesLogged = group.Add(new VocabularyKey(nameof(AreLeadChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreCaseChangesLogged = group.Add(new VocabularyKey(nameof(AreCaseChangesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogAvailabilityDays = group.Add(new VocabularyKey(nameof(LogAvailabilityDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreCreatedTransactionsLogged = group.Add(new VocabularyKey(nameof(AreCreatedTransactionsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreDeletedTransactionsLogged = group.Add(new VocabularyKey(nameof(AreDeletedTransactionsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdatedTransactionsLoggingRule = group.Add(new VocabularyKey(nameof(UpdatedTransactionsLoggingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AreCustomerChangesLogged { get; private set; }
        public VocabularyKey AreCustomerTransactionChangesLogged { get; private set; }
        public VocabularyKey AreVendorChangesLogged { get; private set; }
        public VocabularyKey AreVendorTransactionChangesLogged { get; private set; }
        public VocabularyKey AreContactPersonChangesLogged { get; private set; }
        public VocabularyKey AreSalesActivityChangesLogged { get; private set; }
        public VocabularyKey AreDocumentReferenceChangesLogged { get; private set; }
        public VocabularyKey AreSalesOrderChangesLogged { get; private set; }
        public VocabularyKey AreQuotationChangesLogged { get; private set; }
        public VocabularyKey AreMailingChangesLogged { get; private set; }
        public VocabularyKey AreProspectChangesLogged { get; private set; }
        public VocabularyKey AreTelemarketingCallListChangesLogged { get; private set; }
        public VocabularyKey AreCampaignChangesLogged { get; private set; }
        public VocabularyKey AreOpportunityChangesLogged { get; private set; }
        public VocabularyKey AreLeadChangesLogged { get; private set; }
        public VocabularyKey AreCaseChangesLogged { get; private set; }
        public VocabularyKey LogAvailabilityDays { get; private set; }
        public VocabularyKey AreCreatedTransactionsLogged { get; private set; }
        public VocabularyKey AreDeletedTransactionsLogged { get; private set; }
        public VocabularyKey UpdatedTransactionsLoggingRule { get; private set; }
    }
}