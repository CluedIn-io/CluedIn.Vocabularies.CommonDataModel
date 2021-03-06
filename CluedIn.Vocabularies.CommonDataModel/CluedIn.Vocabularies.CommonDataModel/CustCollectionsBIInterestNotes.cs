using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBIInterestNotesVocabulary : SimpleVocabulary
    {
        public CustCollectionsBIInterestNotesVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBIInterestNotes";
            KeyPrefix = "commonDataModel.custcollectionsbiinterestnotes";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBIInterestNotes";

            AddGroup("Common Data Model CustCollectionsBIInterestNotes Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InterestNote = group.Add(new VocabularyKey(nameof(InterestNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountNum { get; private set; }
public VocabularyKey InterestNote { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey FromDate { get; private set; }
public VocabularyKey ToDate { get; private set; }


    }
}