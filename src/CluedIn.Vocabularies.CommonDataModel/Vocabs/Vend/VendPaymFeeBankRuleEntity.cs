using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymFeeBankRuleEntityVocabulary : SimpleVocabulary
    {
        public VendPaymFeeBankRuleEntityVocabulary()
        {
            VocabularyName = "Vend Paym Fee Bank Rule Entity";
            KeyPrefix = "commonDataModel.vendpaymfeebankruleentity";
            KeySeparator = ".";
            Grouping = "/VendPaymFeeBankRuleEntity";

            AddGroup("VendPaymFeeBankRuleEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyBankGroup = group.Add(new VocabularyKey(nameof(CompanyBankGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThirdPartyBankGroup = group.Add(new VocabularyKey(nameof(ThirdPartyBankGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Relation = group.Add(new VocabularyKey(nameof(Relation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyFieldId = group.Add(new VocabularyKey(nameof(CompanyFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyTableId = group.Add(new VocabularyKey(nameof(CompanyTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustVendFieldId = group.Add(new VocabularyKey(nameof(CustVendFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustVendTableId = group.Add(new VocabularyKey(nameof(CustVendTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey LineId { get; private set; }
        public VocabularyKey CompanyBankGroup { get; private set; }
        public VocabularyKey ThirdPartyBankGroup { get; private set; }
        public VocabularyKey Relation { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey CompanyFieldId { get; private set; }
        public VocabularyKey CompanyTableId { get; private set; }
        public VocabularyKey CustVendFieldId { get; private set; }
        public VocabularyKey CustVendTableId { get; private set; }
    }
}