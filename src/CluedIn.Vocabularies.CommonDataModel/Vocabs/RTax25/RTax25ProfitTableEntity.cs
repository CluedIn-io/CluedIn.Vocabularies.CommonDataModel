using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25ProfitTableEntityVocabulary : SimpleVocabulary
    {
        public RTax25ProfitTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTax25ProfitTableEntity";
            KeyPrefix = "commonDataModel.rtax25profittableentity";
            KeySeparator = ".";
            Grouping = "/RTax25ProfitTableEntity";

            AddGroup("Common Data Model RTax25ProfitTableEntity Details", group =>
            {
                Locked = group.Add(new VocabularyKey(nameof(Locked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Direct = group.Add(new VocabularyKey(nameof(Direct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseCode = group.Add(new VocabularyKey(nameof(ExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CodeType = group.Add(new VocabularyKey(nameof(CodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShortDescription = group.Add(new VocabularyKey(nameof(ShortDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentCode = group.Add(new VocabularyKey(nameof(ParentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Locked { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Direct { get; private set; }
public VocabularyKey ExpenseCode { get; private set; }
public VocabularyKey CodeType { get; private set; }
public VocabularyKey ShortDescription { get; private set; }
public VocabularyKey SalesTaxCode { get; private set; }
public VocabularyKey ParentCode { get; private set; }


    }
}