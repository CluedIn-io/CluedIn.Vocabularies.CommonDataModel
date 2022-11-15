using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public CustCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Cust Customer Group Entity";
            KeyPrefix = "commonDataModel.custcustomergroupentity";
            KeySeparator = ".";
            Grouping = "/CustCustomerGroupEntity";

            AddGroup("CustCustomerGroupEntity Details", group =>
            {
                CustomerGroupId = group.Add(new VocabularyKey(nameof(CustomerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesTaxIncludedInPrice = group.Add(new VocabularyKey(nameof(IsSalesTaxIncludedInPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroupId = group.Add(new VocabularyKey(nameof(TaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermId = group.Add(new VocabularyKey(nameof(PaymentTermId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffReason = group.Add(new VocabularyKey(nameof(WriteOffReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WriteOffCompany = group.Add(new VocabularyKey(nameof(WriteOffCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClearingPeriodPaymentTermName = group.Add(new VocabularyKey(nameof(ClearingPeriodPaymentTermName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccountNumSeq = group.Add(new VocabularyKey(nameof(CustAccountNumSeq), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumberSequence = group.Add(new VocabularyKey(nameof(CustomerAccountNumberSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerGroupId { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsSalesTaxIncludedInPrice { get; private set; }
        public VocabularyKey TaxGroupId { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey PaymentTermId { get; private set; }
        public VocabularyKey WriteOffReason { get; private set; }
        public VocabularyKey WriteOffCompany { get; private set; }
        public VocabularyKey ClearingPeriodPaymentTermName { get; private set; }
        public VocabularyKey CustAccountNumSeq { get; private set; }
        public VocabularyKey CustomerAccountNumberSequence { get; private set; }
    }
}