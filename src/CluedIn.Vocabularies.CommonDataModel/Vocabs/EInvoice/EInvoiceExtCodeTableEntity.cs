using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EInvoiceExtCodeTableEntityVocabulary : SimpleVocabulary
    {
        public EInvoiceExtCodeTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model EInvoiceExtCodeTableEntity";
            KeyPrefix = "commonDataModel.einvoiceextcodetableentity";
            KeySeparator = ".";
            Grouping = "/EInvoiceExtCodeTableEntity";

            AddGroup("Common Data Model EInvoiceExtCodeTableEntity Details", group =>
            {
                CodeId = group.Add(new VocabularyKey(nameof(CodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CodeType = group.Add(new VocabularyKey(nameof(CodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Version = group.Add(new VocabularyKey(nameof(Version), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CodeId { get; private set; }
public VocabularyKey CodeType { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey Version { get; private set; }


    }
}