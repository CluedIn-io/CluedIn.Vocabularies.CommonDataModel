using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxExciseTaxRegistrationNumberEntityVocabulary : SimpleVocabulary
    {
        public TaxExciseTaxRegistrationNumberEntityVocabulary()
        {
            VocabularyName = "Tax Excise Tax Registration Number Entity";
            KeyPrefix = "commonDataModel.taxexcisetaxregistrationnumberentity";
            KeySeparator = ".";
            Grouping = "/TaxExciseTaxRegistrationNumberEntity";

            AddGroup("TaxExciseTaxRegistrationNumberEntity Details", group =>
            {
                Shared = group.Add(new VocabularyKey(nameof(Shared), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefCompanyId = group.Add(new VocabularyKey(nameof(RefCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumberType = group.Add(new VocabularyKey(nameof(RegistrationNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceTable = group.Add(new VocabularyKey(nameof(NumberSequenceTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegistrationNumberTable = group.Add(new VocabularyKey(nameof(TaxRegistrationNumberTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Shared { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RefCompanyId { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey RegistrationNumberType { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey NumberSequenceTable { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey NumberSequenceCode { get; private set; }
        public VocabularyKey TaxRegistrationNumberTable { get; private set; }
    }
}