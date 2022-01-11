using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25StdExpressionTableEntityVocabulary : SimpleVocabulary
    {
        public RTax25StdExpressionTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTax25StdExpressionTableEntity";
            KeyPrefix = "commonDataModel.rtax25stdexpressiontableentity";
            KeySeparator = ".";
            Grouping = "/RTax25StdExpressionTableEntity";

            AddGroup("Common Data Model RTax25StdExpressionTableEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseCode = group.Add(new VocabularyKey(nameof(ExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ModuleType = group.Add(new VocabularyKey(nameof(ModuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Sequence { get; private set; }
public VocabularyKey ExpenseCode { get; private set; }
public VocabularyKey ModuleType { get; private set; }


    }
}