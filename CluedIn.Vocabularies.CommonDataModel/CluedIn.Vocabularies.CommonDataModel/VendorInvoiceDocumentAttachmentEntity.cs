using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorInvoiceDocumentAttachmentEntityVocabulary : SimpleVocabulary
    {
        public VendorInvoiceDocumentAttachmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorInvoiceDocumentAttachmentEntity";
            KeyPrefix = "commonDataModel.vendorinvoicedocumentattachmententity";
            KeySeparator = ".";
            Grouping = "/VendorInvoiceDocumentAttachmentEntity";

            AddGroup("Common Data Model VendorInvoiceDocumentAttachmentEntity Details", group =>
            {
                DocumentId = group.Add(new VocabularyKey(nameof(DocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HeaderReference = group.Add(new VocabularyKey(nameof(HeaderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Restriction = group.Add(new VocabularyKey(nameof(Restriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FileContents = group.Add(new VocabularyKey(nameof(FileContents), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FileType = group.Add(new VocabularyKey(nameof(FileType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualCompanyId = group.Add(new VocabularyKey(nameof(ActualCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultAttachment = group.Add(new VocabularyKey(nameof(DefaultAttachment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DocumentId { get; private set; }
public VocabularyKey TypeId { get; private set; }
public VocabularyKey HeaderReference { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Notes { get; private set; }
public VocabularyKey Restriction { get; private set; }
public VocabularyKey FileContents { get; private set; }
public VocabularyKey FileName { get; private set; }
public VocabularyKey FileType { get; private set; }
public VocabularyKey ActualCompanyId { get; private set; }
public VocabularyKey DefaultAttachment { get; private set; }


    }
}