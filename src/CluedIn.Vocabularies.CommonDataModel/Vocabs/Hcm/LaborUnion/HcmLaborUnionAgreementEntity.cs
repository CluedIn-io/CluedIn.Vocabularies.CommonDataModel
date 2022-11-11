using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmLaborUnionAgreementEntityVocabulary : SimpleVocabulary
    {
        public HcmLaborUnionAgreementEntityVocabulary()
        {
            VocabularyName = "HcmLaborUnionAgreementEntity";
            KeyPrefix = "commonDataModel.hcmlaborunionagreemententity";
            KeySeparator = ".";
            Grouping = "/HcmLaborUnionAgreementEntity";

            AddGroup("HcmLaborUnionAgreementEntity Details", group =>
            {
                AgreementName = group.Add(new VocabularyKey(nameof(AgreementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LaborUnion = group.Add(new VocabularyKey(nameof(LaborUnion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnionId = group.Add(new VocabularyKey(nameof(UnionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AgreementName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LaborUnion { get; private set; }
        public VocabularyKey UnionId { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }


    }
}