using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendCorrectionNoteEntityVocabulary : SimpleVocabulary
    {
        public VendCorrectionNoteEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendCorrectionNoteEntity";
            KeyPrefix = "commonDataModel.vendcorrectionnoteentity";
            KeySeparator = ".";
            Grouping = "/VendCorrectionNoteEntity";

            AddGroup("Common Data Model VendCorrectionNoteEntity Details", group =>
            {
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CorrectionNote = group.Add(new VocabularyKey(nameof(CorrectionNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginalText = group.Add(new VocabularyKey(nameof(OriginalText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CorrectedText = group.Add(new VocabularyKey(nameof(CorrectedText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Invoice { get; private set; }
public VocabularyKey InvoiceAccount { get; private set; }
public VocabularyKey Date { get; private set; }
public VocabularyKey CorrectionNote { get; private set; }
public VocabularyKey DocumentDate { get; private set; }
public VocabularyKey OriginalText { get; private set; }
public VocabularyKey CorrectedText { get; private set; }
public VocabularyKey Posted { get; private set; }


    }
}