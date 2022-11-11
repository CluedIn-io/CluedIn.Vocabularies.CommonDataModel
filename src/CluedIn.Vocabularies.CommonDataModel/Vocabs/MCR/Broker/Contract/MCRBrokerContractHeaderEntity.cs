using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRBrokerContractHeaderEntityVocabulary : SimpleVocabulary
    {
        public MCRBrokerContractHeaderEntityVocabulary()
        {
            VocabularyName = "MCRBrokerContractHeaderEntity";
            KeyPrefix = "commonDataModel.mcrbrokercontractheaderentity";
            KeySeparator = ".";
            Grouping = "/MCRBrokerContractHeaderEntity";

            AddGroup("MCRBrokerContractHeaderEntity Details", group =>
            {
                BrokerVendorAccountNumber = group.Add(new VocabularyKey(nameof(BrokerVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractId = group.Add(new VocabularyKey(nameof(ContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerFeeCurrencyCode = group.Add(new VocabularyKey(nameof(BrokerFeeCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractDescription = group.Add(new VocabularyKey(nameof(ContractDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerSalesChargeCode = group.Add(new VocabularyKey(nameof(BrokerSalesChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractStatus = group.Add(new VocabularyKey(nameof(ContractStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueType = group.Add(new VocabularyKey(nameof(ValueType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerFeeAmountPerProductUnitSold = group.Add(new VocabularyKey(nameof(BrokerFeeAmountPerProductUnitSold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedBrokerFeeAmount = group.Add(new VocabularyKey(nameof(FixedBrokerFeeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrokerFeePercentage = group.Add(new VocabularyKey(nameof(BrokerFeePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BrokerVendorAccountNumber { get; private set; }
        public VocabularyKey ContractId { get; private set; }
        public VocabularyKey BrokerFeeCurrencyCode { get; private set; }
        public VocabularyKey ContractDescription { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey BrokerSalesChargeCode { get; private set; }
        public VocabularyKey ContractStatus { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey ValueType { get; private set; }
        public VocabularyKey BrokerFeeAmountPerProductUnitSold { get; private set; }
        public VocabularyKey FixedBrokerFeeAmount { get; private set; }
        public VocabularyKey BrokerFeePercentage { get; private set; }


    }
}