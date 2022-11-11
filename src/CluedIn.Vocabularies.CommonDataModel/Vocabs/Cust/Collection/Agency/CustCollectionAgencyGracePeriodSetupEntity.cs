using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionAgencyGracePeriodSetupEntityVocabulary : SimpleVocabulary
    {
        public CustCollectionAgencyGracePeriodSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionAgencyGracePeriodSetupEntity";
            KeyPrefix = "commonDataModel.custcollectionagencygraceperiodsetupentity";
            KeySeparator = ".";
            Grouping = "/CustCollectionAgencyGracePeriodSetupEntity";

            AddGroup("Common Data Model CustCollectionAgencyGracePeriodSetupEntity Details", group =>
            {
                AccountOrGroupNumber = group.Add(new VocabularyKey(nameof(AccountOrGroupNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GracePeriodInDaysAfterTransactionDate = group.Add(new VocabularyKey(nameof(GracePeriodInDaysAfterTransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountOrGroupNumber { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey GracePeriodInDaysAfterTransactionDate { get; private set; }


    }
}