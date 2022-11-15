using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public VendVendorGroupEntityVocabulary()
        {
            VocabularyName = "Vend Vendor Group Entity";
            KeyPrefix = "commonDataModel.vendvendorgroupentity";
            KeySeparator = ".";
            Grouping = "/VendVendorGroupEntity";

            AddGroup("VendVendorGroupEntity Details", group =>
            {
                VendorGroupId = group.Add(new VocabularyKey(nameof(VendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPaymentTermName = group.Add(new VocabularyKey(nameof(DefaultPaymentTermName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClearingPeriodPaymentTermName = group.Add(new VocabularyKey(nameof(ClearingPeriodPaymentTermName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTaxGroupCode = group.Add(new VocabularyKey(nameof(DefaultTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExcludedFromSearchResults = group.Add(new VocabularyKey(nameof(IsExcludedFromSearchResults), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendAccountNumSeq = group.Add(new VocabularyKey(nameof(VendAccountNumSeq), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumberSequence = group.Add(new VocabularyKey(nameof(VendorAccountNumberSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey VendorGroupId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DefaultPaymentTermName { get; private set; }
        public VocabularyKey ClearingPeriodPaymentTermName { get; private set; }
        public VocabularyKey DefaultTaxGroupCode { get; private set; }
        public VocabularyKey IsExcludedFromSearchResults { get; private set; }
        public VocabularyKey VendAccountNumSeq { get; private set; }
        public VocabularyKey VendorAccountNumberSequence { get; private set; }
    }
}