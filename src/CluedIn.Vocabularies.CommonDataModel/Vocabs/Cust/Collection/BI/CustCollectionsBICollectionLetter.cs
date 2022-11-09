using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCollectionsBICollectionLetterVocabulary : SimpleVocabulary
    {
        public CustCollectionsBICollectionLetterVocabulary()
        {
            VocabularyName = "Common Data Model CustCollectionsBICollectionLetter";
            KeyPrefix = "commonDataModel.custcollectionsbicollectionletter";
            KeySeparator = ".";
            Grouping = "/CustCollectionsBICollectionLetter";

            AddGroup("Common Data Model CustCollectionsBICollectionLetter Details", group =>
            {
                CollectionLetterNum = group.Add(new VocabularyKey(nameof(CollectionLetterNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionLetterCode = group.Add(new VocabularyKey(nameof(CollectionLetterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CollectionLetterDate = group.Add(new VocabularyKey(nameof(CollectionLetterDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintDate = group.Add(new VocabularyKey(nameof(PrintDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CollectionLetterNum { get; private set; }
public VocabularyKey AccountNum { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey CollectionLetterCode { get; private set; }
public VocabularyKey CollectionLetterDate { get; private set; }
public VocabularyKey PrintDate { get; private set; }


    }
}