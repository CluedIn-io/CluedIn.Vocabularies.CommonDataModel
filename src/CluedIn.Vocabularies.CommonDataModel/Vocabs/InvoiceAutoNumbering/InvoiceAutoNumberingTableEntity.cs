using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InvoiceAutoNumberingTableEntityVocabulary : SimpleVocabulary
    {
        public InvoiceAutoNumberingTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model InvoiceAutoNumberingTableEntity";
            KeyPrefix = "commonDataModel.invoiceautonumberingtableentity";
            KeySeparator = ".";
            Grouping = "/InvoiceAutoNumberingTableEntity";

            AddGroup("Common Data Model InvoiceAutoNumberingTableEntity Details", group =>
            {
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Retail = group.Add(new VocabularyKey(nameof(Retail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LastDate = group.Add(new VocabularyKey(nameof(LastDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Numbering = group.Add(new VocabularyKey(nameof(Numbering), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Module = group.Add(new VocabularyKey(nameof(Module), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Continue = group.Add(new VocabularyKey(nameof(Continue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Type { get; private set; }
public VocabularyKey Retail { get; private set; }
public VocabularyKey AccountCode { get; private set; }
public VocabularyKey Code { get; private set; }
public VocabularyKey LastDate { get; private set; }
public VocabularyKey Numbering { get; private set; }
public VocabularyKey NumberSequenceCode { get; private set; }
public VocabularyKey Module { get; private set; }
public VocabularyKey Continue { get; private set; }


    }
}