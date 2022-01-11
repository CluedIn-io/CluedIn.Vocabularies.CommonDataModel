using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailPosSeedDataEntityVocabulary : SimpleVocabulary
    {
        public RetailPosSeedDataEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailPosSeedDataEntity";
            KeyPrefix = "commonDataModel.retailposseeddataentity";
            KeySeparator = ".";
            Grouping = "/RetailPosSeedDataEntity";

            AddGroup("Common Data Model RetailPosSeedDataEntity Details", group =>
            {
                DataType = group.Add(new VocabularyKey(nameof(DataType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DataValue = group.Add(new VocabularyKey(nameof(DataValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TerminalID = group.Add(new VocabularyKey(nameof(TerminalID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DataType { get; private set; }
public VocabularyKey DataValue { get; private set; }
public VocabularyKey StoreNumber { get; private set; }
public VocabularyKey TerminalID { get; private set; }


    }
}