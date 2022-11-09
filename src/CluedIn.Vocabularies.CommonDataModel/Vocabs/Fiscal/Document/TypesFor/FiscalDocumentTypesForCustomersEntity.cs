using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentTypesForCustomersEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentTypesForCustomersEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalDocumentTypesForCustomersEntity";
            KeyPrefix = "commonDataModel.fiscaldocumenttypesforcustomersentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentTypesForCustomersEntity";

            AddGroup("Common Data Model FiscalDocumentTypesForCustomersEntity Details", group =>
            {
                FiscalDocumentType_BR = group.Add(new VocabularyKey(nameof(FiscalDocumentType_BR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishment_BR = group.Add(new VocabularyKey(nameof(FiscalEstablishment_BR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemType = group.Add(new VocabularyKey(nameof(ItemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalDocumentTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FiscalDocumentType_BR { get; private set; }
public VocabularyKey FiscalEstablishment_BR { get; private set; }
public VocabularyKey AccountCode { get; private set; }
public VocabularyKey AccountRelation { get; private set; }
public VocabularyKey ItemType { get; private set; }
public VocabularyKey FiscalEstablishmentId { get; private set; }
public VocabularyKey FiscalDocumentTypeId { get; private set; }


    }
}