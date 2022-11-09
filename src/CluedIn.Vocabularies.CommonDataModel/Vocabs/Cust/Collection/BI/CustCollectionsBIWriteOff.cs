using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBIWriteOffVocabulary : SimpleVocabulary
    {
        public CustCollectionsBIWriteOffVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBIWriteOff";
            KeyPrefix = "commonDataModel.custcollectionsbiwriteoff";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBIWriteOff";

            AddGroup("Common Data Model CustCollectionsBIWriteOff Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Reason = group.Add(new VocabularyKey(nameof(Reason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonComment = group.Add(new VocabularyKey(nameof(ReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SystemCurrencyAmount = group.Add(new VocabularyKey(nameof(SystemCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WriteOffDimension = group.Add(new VocabularyKey(nameof(WriteOffDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountNum { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Reason { get; private set; }
public VocabularyKey ReasonComment { get; private set; }
public VocabularyKey SystemCurrencyAmount { get; private set; }
public VocabularyKey WriteOffDimension { get; private set; }
public VocabularyKey TransDate { get; private set; }


    }
}