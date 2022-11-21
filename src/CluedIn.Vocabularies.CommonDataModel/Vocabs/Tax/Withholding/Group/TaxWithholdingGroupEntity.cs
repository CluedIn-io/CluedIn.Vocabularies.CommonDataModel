using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdingGroupEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdingGroupEntityVocabulary()
        {
            VocabularyName = "Tax Withholding Group Entity";
            KeyPrefix = "commonDataModel.taxwithholdinggroupentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdingGroupEntity";

            AddGroup("TaxWithholdingGroupEntity Details", group =>
            {
                WithholdingTaxGroupCode = group.Add(new VocabularyKey(nameof(WithholdingTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcludeCharges = group.Add(new VocabularyKey(nameof(ExcludeCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Transporter = group.Add(new VocabularyKey(nameof(Transporter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplicableTaxRates = group.Add(new VocabularyKey(nameof(ApplicableTaxRates), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WithholdingTaxGroupCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExcludeCharges { get; private set; }
        public VocabularyKey Transporter { get; private set; }
        public VocabularyKey ApplicableTaxRates { get; private set; }
        public VocabularyKey TaxType { get; private set; }
    }
}