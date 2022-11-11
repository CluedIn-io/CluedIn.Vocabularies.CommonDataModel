using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MainAccountTotalAccountIntervalEntityVocabulary : SimpleVocabulary
    {
        public MainAccountTotalAccountIntervalEntityVocabulary()
        {
            VocabularyName = "Common Data Model MainAccountTotalAccountIntervalEntity";
            KeyPrefix = "commonDataModel.mainaccounttotalaccountintervalentity";
            KeySeparator = ".";
            Grouping = "/MainAccountTotalAccountIntervalEntity";

            AddGroup("Common Data Model MainAccountTotalAccountIntervalEntity Details", group =>
            {
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromValue = group.Add(new VocabularyKey(nameof(FromValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToValue = group.Add(new VocabularyKey(nameof(ToValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvertTotalSign = group.Add(new VocabularyKey(nameof(InvertTotalSign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey FromValue { get; private set; }
        public VocabularyKey ToValue { get; private set; }
        public VocabularyKey InvertTotalSign { get; private set; }


    }
}