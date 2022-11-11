using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdingTaxCodeLimitEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdingTaxCodeLimitEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdingTaxCodeLimitEntity";
            KeyPrefix = "commonDataModel.taxwithholdingtaxcodelimitentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdingTaxCodeLimitEntity";

            AddGroup("Common Data Model TaxWithholdingTaxCodeLimitEntity Details", group =>
            {
                MaximumWithholdingTax = group.Add(new VocabularyKey(nameof(MaximumWithholdingTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumWithholdingTax = group.Add(new VocabularyKey(nameof(MinimumWithholdingTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxCodeId = group.Add(new VocabularyKey(nameof(WithholdingTaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MaximumWithholdingTax { get; private set; }
        public VocabularyKey MinimumWithholdingTax { get; private set; }
        public VocabularyKey WithholdingTaxCodeId { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }


    }
}