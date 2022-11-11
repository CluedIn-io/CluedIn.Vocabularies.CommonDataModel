using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBIAgedBalancesVocabulary : SimpleVocabulary
    {
        public CustCollectionsBIAgedBalancesVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBIAgedBalances";
            KeyPrefix = "commonDataModel.custcollectionsbiagedbalances";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBIAgedBalances";

            AddGroup("Common Data Model CustCollectionsBIAgedBalances Details", group =>
            {
                AmountDueMst = group.Add(new VocabularyKey(nameof(AmountDueMst), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Heading = group.Add(new VocabularyKey(nameof(Heading), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpenBalanceMst = group.Add(new VocabularyKey(nameof(OpenBalanceMst), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AgingName = group.Add(new VocabularyKey(nameof(AgingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemCurrencyBalance = group.Add(new VocabularyKey(nameof(SystemCurrencyBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AmountDueMst { get; private set; }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey Heading { get; private set; }
        public VocabularyKey OpenBalanceMst { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AgingName { get; private set; }
        public VocabularyKey SystemCurrencyBalance { get; private set; }


    }
}