using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxServiceTaxRegistrationNumberEntityVocabulary : SimpleVocabulary
    {
        public TaxServiceTaxRegistrationNumberEntityVocabulary()
        {
            VocabularyName = "TaxServiceTaxRegistrationNumberEntity";
            KeyPrefix = "commonDataModel.taxservicetaxregistrationnumberentity";
            KeySeparator = ".";
            Grouping = "/TaxServiceTaxRegistrationNumberEntity";

            AddGroup("TaxServiceTaxRegistrationNumberEntity Details", group =>
            {
                Shared = group.Add(new VocabularyKey(nameof(Shared), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefCompanyId = group.Add(new VocabularyKey(nameof(RefCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumberType = group.Add(new VocabularyKey(nameof(RegistrationNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Shared { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RefCompanyId { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey RegistrationNumberType { get; private set; }
        public VocabularyKey TaxType { get; private set; }


    }
}