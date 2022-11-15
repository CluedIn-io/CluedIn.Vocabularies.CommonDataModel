using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdingTaxCodeValueEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdingTaxCodeValueEntityVocabulary()
        {
            VocabularyName = "Tax Withholding Tax Code Value Entity";
            KeyPrefix = "commonDataModel.taxwithholdingtaxcodevalueentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdingTaxCodeValueEntity";

            AddGroup("TaxWithholdingTaxCodeValueEntity Details", group =>
            {
                TaxWithholdCodeId = group.Add(new VocabularyKey(nameof(TaxWithholdCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludePercentage = group.Add(new VocabularyKey(nameof(ExcludePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumLimit = group.Add(new VocabularyKey(nameof(MaximumLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumLimit = group.Add(new VocabularyKey(nameof(MinimumLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TaxWithholdCodeId { get; private set; }
        public VocabularyKey ExcludePercentage { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey MaximumLimit { get; private set; }
        public VocabularyKey MinimumLimit { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey Value { get; private set; }
    }
}