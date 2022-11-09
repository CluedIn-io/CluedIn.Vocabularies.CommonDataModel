using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionAttributeEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionAttributeEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionAttributeEntity";
            KeyPrefix = "commonDataModel.retailtransactionattributeentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionAttributeEntity";

            AddGroup("Common Data Model RetailTransactionAttributeEntity Details", group =>
            {
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeName = group.Add(new VocabularyKey(nameof(AttributeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AttributeValue = group.Add(new VocabularyKey(nameof(AttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailChannelTableOMOperatingUnitId = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HeaderOrLineNum = group.Add(new VocabularyKey(nameof(HeaderOrLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Channel { get; private set; }
public VocabularyKey AttributeName { get; private set; }
public VocabularyKey Terminal { get; private set; }
public VocabularyKey AttributeValue { get; private set; }
public VocabularyKey TransactionNumber { get; private set; }
public VocabularyKey RetailChannelTableOMOperatingUnitId { get; private set; }
public VocabularyKey OperatingUnitNumber { get; private set; }
public VocabularyKey HeaderOrLineNum { get; private set; }


    }
}