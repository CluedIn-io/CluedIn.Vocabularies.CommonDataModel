using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerFiscalDocumentTextEntityVocabulary : SimpleVocabulary
    {
        public CustomerFiscalDocumentTextEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustomerFiscalDocumentTextEntity";
            KeyPrefix = "commonDataModel.customerfiscaldocumenttextentity";
            KeySeparator = ".";
            Grouping = "/CustomerFiscalDocumentTextEntity";

            AddGroup("Common Data Model CustomerFiscalDocumentTextEntity Details", group =>
            {
                Customer = group.Add(new VocabularyKey(nameof(Customer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentText = group.Add(new VocabularyKey(nameof(FiscalDocumentText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Restriction = group.Add(new VocabularyKey(nameof(Restriction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalInformation = group.Add(new VocabularyKey(nameof(FiscalInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocuRef = group.Add(new VocabularyKey(nameof(DocuRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefRecId = group.Add(new VocabularyKey(nameof(RefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RefCompanyId = group.Add(new VocabularyKey(nameof(RefCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Customer { get; private set; }
public VocabularyKey FiscalDocumentText { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Type { get; private set; }
public VocabularyKey Notes { get; private set; }
public VocabularyKey Restriction { get; private set; }
public VocabularyKey FiscalInformation { get; private set; }
public VocabularyKey DocuRef { get; private set; }
public VocabularyKey RefRecId { get; private set; }
public VocabularyKey RefTableId { get; private set; }
public VocabularyKey RefCompanyId { get; private set; }


    }
}