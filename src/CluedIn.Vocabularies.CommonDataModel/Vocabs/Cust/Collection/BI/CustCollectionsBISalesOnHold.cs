using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBISalesOnHoldVocabulary : SimpleVocabulary
    {
        public CustCollectionsBISalesOnHoldVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBISalesOnHold";
            KeyPrefix = "commonDataModel.custcollectionsbisalesonhold";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBISalesOnHold";

            AddGroup("Common Data Model CustCollectionsBISalesOnHold Details", group =>
            {
                SalesId = group.Add(new VocabularyKey(nameof(SalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MCRReasonCode = group.Add(new VocabularyKey(nameof(MCRReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesName = group.Add(new VocabularyKey(nameof(SalesName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesId { get; private set; }
        public VocabularyKey MCRReasonCode { get; private set; }
        public VocabularyKey SalesName { get; private set; }
        public VocabularyKey CustAccount { get; private set; }


    }
}