using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentSourceTextEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentSourceTextEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalDocumentSourceTextEntity";
            KeyPrefix = "commonDataModel.fiscaldocumentsourcetextentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentSourceTextEntity";

            AddGroup("Common Data Model FiscalDocumentSourceTextEntity Details", group =>
            {
                FiscalInformation = group.Add(new VocabularyKey(nameof(FiscalInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Text = group.Add(new VocabularyKey(nameof(Text), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Restriction = group.Add(new VocabularyKey(nameof(Restriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentText = group.Add(new VocabularyKey(nameof(FiscalDocumentText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FiscalInformation { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey Text { get; private set; }
public VocabularyKey Restriction { get; private set; }
public VocabularyKey FiscalDocumentText { get; private set; }


    }
}