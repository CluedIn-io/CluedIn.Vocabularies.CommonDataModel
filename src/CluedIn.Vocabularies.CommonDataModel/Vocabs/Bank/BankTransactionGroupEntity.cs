using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankTransactionGroupEntityVocabulary : SimpleVocabulary
    {
        public BankTransactionGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankTransactionGroupEntity";
            KeyPrefix = "commonDataModel.banktransactiongroupentity";
            KeySeparator = ".";
            Grouping = "/BankTransactionGroupEntity";

            AddGroup("Common Data Model BankTransactionGroupEntity Details", group =>
            {
                TransactionGroupId = group.Add(new VocabularyKey(nameof(TransactionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionTypeId = group.Add(new VocabularyKey(nameof(TransactionTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TransactionGroupId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey TransactionTypeId { get; private set; }


    }
}