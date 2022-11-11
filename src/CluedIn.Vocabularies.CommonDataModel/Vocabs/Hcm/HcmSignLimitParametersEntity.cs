using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmSignLimitParametersEntityVocabulary : SimpleVocabulary
    {
        public HcmSignLimitParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmSignLimitParametersEntity";
            KeyPrefix = "commonDataModel.hcmsignlimitparametersentity";
            KeySeparator = ".";
            Grouping = "/HcmSignLimitParametersEntity";

            AddGroup("Common Data Model HcmSignLimitParametersEntity Details", group =>
            {
                SigningLimitsForEmployeesOnly = group.Add(new VocabularyKey(nameof(SigningLimitsForEmployeesOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireExplicitSigningLimitRequest = group.Add(new VocabularyKey(nameof(RequireExplicitSigningLimitRequest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitBasis = group.Add(new VocabularyKey(nameof(LimitBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SigningLimitsForEmployeesOnly { get; private set; }
        public VocabularyKey RequireExplicitSigningLimitRequest { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey LimitBasis { get; private set; }


    }
}