using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocSourceTextReferenceProcessEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocSourceTextReferenceProcessEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalDocSourceTextReferenceProcessEntity";
            KeyPrefix = "commonDataModel.fiscaldocsourcetextreferenceprocessentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocSourceTextReferenceProcessEntity";

            AddGroup("Common Data Model FiscalDocSourceTextReferenceProcessEntity Details", group =>
            {
                FiscalDocumentText = group.Add(new VocabularyKey(nameof(FiscalDocumentText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Agency = group.Add(new VocabularyKey(nameof(Agency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReferenceProcessNumber = group.Add(new VocabularyKey(nameof(ReferenceProcessNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReferenceFiscalDocumentSourceText = group.Add(new VocabularyKey(nameof(ReferenceFiscalDocumentSourceText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FiscalDocumentText { get; private set; }
public VocabularyKey Agency { get; private set; }
public VocabularyKey ReferenceProcessNumber { get; private set; }
public VocabularyKey ReferenceFiscalDocumentSourceText { get; private set; }


    }
}