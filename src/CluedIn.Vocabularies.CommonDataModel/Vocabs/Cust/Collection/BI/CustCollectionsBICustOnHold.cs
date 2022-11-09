using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBICustOnHoldVocabulary : SimpleVocabulary
    {
        public CustCollectionsBICustOnHoldVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBICustOnHold";
            KeyPrefix = "commonDataModel.custcollectionsbicustonhold";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBICustOnHold";

            AddGroup("Common Data Model CustCollectionsBICustOnHold Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Blocked = group.Add(new VocabularyKey(nameof(Blocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BlockStatus = group.Add(new VocabularyKey(nameof(BlockStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountNum { get; private set; }
public VocabularyKey Blocked { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey BlockStatus { get; private set; }


    }
}