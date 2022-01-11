using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesExternalSalesAgreementClassificationEntityVocabulary : SimpleVocabulary
    {
        public SalesExternalSalesAgreementClassificationEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesExternalSalesAgreementClassificationEntity";
            KeyPrefix = "commonDataModel.salesexternalsalesagreementclassificationentity";
            KeySeparator = ".";
            Grouping = "/SalesExternalSalesAgreementClassificationEntity";

            AddGroup("Common Data Model SalesExternalSalesAgreementClassificationEntity Details", group =>
            {
                ExternalAgreementClassificationName = group.Add(new VocabularyKey(nameof(ExternalAgreementClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesAgreementClassificationName = group.Add(new VocabularyKey(nameof(SalesAgreementClassificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalAgreementClassificationCodeId = group.Add(new VocabularyKey(nameof(ExternalAgreementClassificationCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ExternalAgreementClassificationName { get; private set; }
public VocabularyKey SalesAgreementClassificationName { get; private set; }
public VocabularyKey ExternalAgreementClassificationCodeId { get; private set; }


    }
}