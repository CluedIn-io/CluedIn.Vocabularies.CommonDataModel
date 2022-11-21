using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdAuthoritiesEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdAuthoritiesEntityVocabulary()
        {
            VocabularyName = "Tax Withhold Authorities Entity";
            KeyPrefix = "commonDataModel.taxwithholdauthoritiesentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdAuthoritiesEntity";

            AddGroup("TaxWithholdAuthoritiesEntity Details", group =>
            {
                WithholdingTaxAuthority = group.Add(new VocabularyKey(nameof(WithholdingTaxAuthority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendAccount = group.Add(new VocabularyKey(nameof(VendAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WithholdingTaxAuthority { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey VendAccount { get; private set; }
    }
}