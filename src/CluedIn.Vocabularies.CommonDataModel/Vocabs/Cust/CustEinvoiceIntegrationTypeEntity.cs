using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustEinvoiceIntegrationTypeEntityVocabulary : SimpleVocabulary
    {
        public CustEinvoiceIntegrationTypeEntityVocabulary()
        {
            VocabularyName = "Cust Einvoice Integration Type Entity";
            KeyPrefix = "commonDataModel.custeinvoiceintegrationtypeentity";
            KeySeparator = ".";
            Grouping = "/CustEinvoiceIntegrationTypeEntity";

            AddGroup("CustEinvoiceIntegrationTypeEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TypeId { get; private set; }
    }
}