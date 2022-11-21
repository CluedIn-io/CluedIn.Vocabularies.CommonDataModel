using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FICardVocabulary : SimpleVocabulary
    {
        public FICardVocabulary()
        {
            VocabularyName = "FI Card";
            KeyPrefix = "commonDataModel.ficard";
            KeySeparator = ".";
            Grouping = "/FICard";

            AddGroup("FICard Details", group =>
            {
                Fi_CardId = group.Add(new VocabularyKey(nameof(Fi_CardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivationDate = group.Add(new VocabularyKey(nameof(ActivationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardNetwork = group.Add(new VocabularyKey(nameof(CardNetwork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Cardnumber = group.Add(new VocabularyKey(nameof(Cardnumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardType = group.Add(new VocabularyKey(nameof(CardType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dateoflastcashwithdrawal = group.Add(new VocabularyKey(nameof(Dateoflastcashwithdrawal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dateoflasttransaction = group.Add(new VocabularyKey(nameof(Dateoflasttransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmbossingName = group.Add(new VocabularyKey(nameof(EmbossingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpiryDate = group.Add(new VocabularyKey(nameof(ExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Financialinstrumenttype = group.Add(new VocabularyKey(nameof(Financialinstrumenttype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IssueDate = group.Add(new VocabularyKey(nameof(IssueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Numberofcashwithdrawal = group.Add(new VocabularyKey(nameof(Numberofcashwithdrawal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Numberoftransactions = group.Add(new VocabularyKey(nameof(Numberoftransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingLimit = group.Add(new VocabularyKey(nameof(PurchasingLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purchasinglimit_Base = group.Add(new VocabularyKey(nameof(Purchasinglimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Purchasinglimit_default = group.Add(new VocabularyKey(nameof(Purchasinglimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithdrawalLimit = group.Add(new VocabularyKey(nameof(WithdrawalLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Withdrawallimit_Base = group.Add(new VocabularyKey(nameof(Withdrawallimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Withdrawallimit_default = group.Add(new VocabularyKey(nameof(Withdrawallimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Fi_CardId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ActivationDate { get; private set; }
        public VocabularyKey CardNetwork { get; private set; }
        public VocabularyKey Cardnumber { get; private set; }
        public VocabularyKey CardType { get; private set; }
        public VocabularyKey Dateoflastcashwithdrawal { get; private set; }
        public VocabularyKey Dateoflasttransaction { get; private set; }
        public VocabularyKey EmbossingName { get; private set; }
        public VocabularyKey ExpiryDate { get; private set; }
        public VocabularyKey Financialinstrumenttype { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
        public VocabularyKey IssueDate { get; private set; }
        public VocabularyKey Numberofcashwithdrawal { get; private set; }
        public VocabularyKey Numberoftransactions { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey PurchasingLimit { get; private set; }
        public VocabularyKey Purchasinglimit_Base { get; private set; }
        public VocabularyKey Purchasinglimit_default { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey WithdrawalLimit { get; private set; }
        public VocabularyKey Withdrawallimit_Base { get; private set; }
        public VocabularyKey Withdrawallimit_default { get; private set; }
    }
}