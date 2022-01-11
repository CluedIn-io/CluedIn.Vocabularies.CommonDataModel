using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmQuotationDocumentTitleEntityVocabulary : SimpleVocabulary
    {
        public smmQuotationDocumentTitleEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmQuotationDocumentTitleEntity";
            KeyPrefix = "commonDataModel.smmquotationdocumenttitleentity";
            KeySeparator = ".";
            Grouping = "/smmQuotationDocumentTitleEntity";

            AddGroup("Common Data Model smmQuotationDocumentTitleEntity Details", group =>
            {
                DocumentTitle = group.Add(new VocabularyKey(nameof(DocumentTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DocumentTitle { get; private set; }


    }
}