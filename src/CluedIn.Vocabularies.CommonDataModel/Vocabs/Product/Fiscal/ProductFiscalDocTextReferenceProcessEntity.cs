using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductFiscalDocTextReferenceProcessEntityVocabulary : SimpleVocabulary
    {
        public ProductFiscalDocTextReferenceProcessEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProductFiscalDocTextReferenceProcessEntity";
            KeyPrefix = "commonDataModel.productfiscaldoctextreferenceprocessentity";
            KeySeparator = ".";
            Grouping = "/ProductFiscalDocTextReferenceProcessEntity";

            AddGroup("Common Data Model ProductFiscalDocTextReferenceProcessEntity Details", group =>
            {
                Item = group.Add(new VocabularyKey(nameof(Item), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentText = group.Add(new VocabularyKey(nameof(FiscalDocumentText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Agency = group.Add(new VocabularyKey(nameof(Agency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcessNumber = group.Add(new VocabularyKey(nameof(ProcessNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocuRefExt_BR = group.Add(new VocabularyKey(nameof(DocuRefExt_BR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocuRef = group.Add(new VocabularyKey(nameof(DocuRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefCompanyId = group.Add(new VocabularyKey(nameof(RefCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Item { get; private set; }
public VocabularyKey FiscalDocumentText { get; private set; }
public VocabularyKey Agency { get; private set; }
public VocabularyKey ProcessNumber { get; private set; }
public VocabularyKey DocuRefExt_BR { get; private set; }
public VocabularyKey DocuRef { get; private set; }
public VocabularyKey RefRecId { get; private set; }
public VocabularyKey RefTableId { get; private set; }
public VocabularyKey RefCompanyId { get; private set; }


    }
}