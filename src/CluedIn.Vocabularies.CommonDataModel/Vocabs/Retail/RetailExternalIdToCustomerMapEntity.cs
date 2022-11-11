using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailExternalIdToCustomerMapEntityVocabulary : SimpleVocabulary
    {
        public RetailExternalIdToCustomerMapEntityVocabulary()
        {
            VocabularyName = "RetailExternalIdToCustomerMapEntity";
            KeyPrefix = "commonDataModel.retailexternalidtocustomermapentity";
            KeySeparator = ".";
            Grouping = "/RetailExternalIdToCustomerMapEntity";

            AddGroup("RetailExternalIdToCustomerMapEntity Details", group =>
            {
                ExternalIdentityId = group.Add(new VocabularyKey(nameof(ExternalIdentityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProviderId = group.Add(new VocabularyKey(nameof(ProviderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActivated = group.Add(new VocabularyKey(nameof(IsActivated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ExternalIdentityId { get; private set; }
        public new VocabularyKey ProviderId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey IsActivated { get; private set; }


    }
}