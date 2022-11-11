using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentTypesForVendorsEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentTypesForVendorsEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalDocumentTypesForVendorsEntity";
            KeyPrefix = "commonDataModel.fiscaldocumenttypesforvendorsentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentTypesForVendorsEntity";

            AddGroup("Common Data Model FiscalDocumentTypesForVendorsEntity Details", group =>
            {
                FiscalDocumentType_BR = group.Add(new VocabularyKey(nameof(FiscalDocumentType_BR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishment_BR = group.Add(new VocabularyKey(nameof(FiscalEstablishment_BR), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTypeId = group.Add(new VocabularyKey(nameof(FiscalDocumentTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FiscalDocumentType_BR { get; private set; }
        public VocabularyKey FiscalEstablishment_BR { get; private set; }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey FiscalDocumentTypeId { get; private set; }
        public VocabularyKey FiscalEstablishmentId { get; private set; }


    }
}