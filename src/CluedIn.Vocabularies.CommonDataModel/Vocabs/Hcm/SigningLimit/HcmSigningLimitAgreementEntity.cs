using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmSigningLimitAgreementEntityVocabulary : SimpleVocabulary
    {
        public HcmSigningLimitAgreementEntityVocabulary()
        {
            VocabularyName = "HcmSigningLimitAgreementEntity";
            KeyPrefix = "commonDataModel.hcmsigninglimitagreemententity";
            KeySeparator = ".";
            Grouping = "/HcmSigningLimitAgreementEntity";

            AddGroup("HcmSigningLimitAgreementEntity Details", group =>
            {
                AgreementName = group.Add(new VocabularyKey(nameof(AgreementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttestationPeriod = group.Add(new VocabularyKey(nameof(AttestationPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                URL = group.Add(new VocabularyKey(nameof(URL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AgreementName { get; private set; }
        public VocabularyKey AttestationPeriod { get; private set; }
        public VocabularyKey URL { get; private set; }


    }
}