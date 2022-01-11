using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailExternalIdToCustomerMapEntityVocabulary : SimpleVocabulary
    {
        public RetailExternalIdToCustomerMapEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailExternalIdToCustomerMapEntity";
            KeyPrefix = "commonDataModel.retailexternalidtocustomermapentity";
            KeySeparator = ".";
            Grouping = "/RetailExternalIdToCustomerMapEntity";

            AddGroup("Common Data Model RetailExternalIdToCustomerMapEntity Details", group =>
            {
                ExternalIdentityId = group.Add(new VocabularyKey(nameof(ExternalIdentityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProviderId = group.Add(new VocabularyKey(nameof(ProviderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActivated = group.Add(new VocabularyKey(nameof(IsActivated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ExternalIdentityId { get; private set; }
public VocabularyKey ProviderId { get; private set; }
public VocabularyKey CustomerAccountNumber { get; private set; }
public VocabularyKey IsActivated { get; private set; }


    }
}