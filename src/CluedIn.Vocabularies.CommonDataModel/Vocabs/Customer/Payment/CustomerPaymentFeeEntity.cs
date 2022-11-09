using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerPaymentFeeEntityVocabulary : SimpleVocabulary
    {
        public CustomerPaymentFeeEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustomerPaymentFeeEntity";
            KeyPrefix = "commonDataModel.customerpaymentfeeentity";
            KeySeparator = ".";
            Grouping = "/CustomerPaymentFeeEntity";

            AddGroup("Common Data Model CustomerPaymentFeeEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeType = group.Add(new VocabularyKey(nameof(ChargeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionText = group.Add(new VocabularyKey(nameof(TransactionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ChargeType { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey JournalType { get; private set; }
public VocabularyKey TransactionText { get; private set; }
public VocabularyKey MainAccountIdDisplayValue { get; private set; }


    }
}