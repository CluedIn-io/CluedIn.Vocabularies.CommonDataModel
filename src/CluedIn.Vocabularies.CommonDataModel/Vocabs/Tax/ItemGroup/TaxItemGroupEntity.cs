using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxItemGroupEntityVocabulary : SimpleVocabulary
    {
        public TaxItemGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxItemGroupEntity";
            KeyPrefix = "commonDataModel.taxitemgroupentity";
            KeySeparator = ".";
            Grouping = "/TaxItemGroupEntity";

            AddGroup("Common Data Model TaxItemGroupEntity Details", group =>
            {
                TaxItemGroupCode = group.Add(new VocabularyKey(nameof(TaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EUSalesListType = group.Add(new VocabularyKey(nameof(EUSalesListType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCode = group.Add(new VocabularyKey(nameof(TaxationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExemptTax = group.Add(new VocabularyKey(nameof(ExemptTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithoutTaxCredit = group.Add(new VocabularyKey(nameof(WithoutTaxCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationCodeTable = group.Add(new VocabularyKey(nameof(TaxationCodeTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptCode = group.Add(new VocabularyKey(nameof(TaxExemptCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxItemGroupCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EUSalesListType { get; private set; }
        public VocabularyKey TaxCodeId { get; private set; }
        public VocabularyKey TaxationCode { get; private set; }
        public VocabularyKey ExemptTax { get; private set; }
        public VocabularyKey WithoutTaxCredit { get; private set; }
        public VocabularyKey TaxationCodeTable { get; private set; }
        public VocabularyKey TaxExemptCode { get; private set; }


    }
}