using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvCreditCardCodeEntityVocabulary : SimpleVocabulary
    {
        public TrvCreditCardCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvCreditCardCodeEntity";
            KeyPrefix = "commonDataModel.trvcreditcardcodeentity";
            KeySeparator = ".";
            Grouping = "/TrvCreditCardCodeEntity";

            AddGroup("Common Data Model TrvCreditCardCodeEntity Details", group =>
            {
                CardType = group.Add(new VocabularyKey(nameof(CardType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseCategory = group.Add(new VocabularyKey(nameof(ExpenseCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CardType { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ExpenseCategory { get; private set; }


    }
}