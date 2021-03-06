using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustEinvoiceIntegrationTypeEntityVocabulary : SimpleVocabulary
    {
        public CustEinvoiceIntegrationTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustEinvoiceIntegrationTypeEntity";
            KeyPrefix = "commonDataModel.custeinvoiceintegrationtypeentity";
            KeySeparator = ".";
            Grouping = "/CustEinvoiceIntegrationTypeEntity";

            AddGroup("Common Data Model CustEinvoiceIntegrationTypeEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey TypeId { get; private set; }


    }
}