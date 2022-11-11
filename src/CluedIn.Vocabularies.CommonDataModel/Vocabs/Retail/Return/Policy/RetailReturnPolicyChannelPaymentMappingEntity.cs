using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailReturnPolicyChannelPaymentMappingEntityVocabulary : SimpleVocabulary
    {
        public RetailReturnPolicyChannelPaymentMappingEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailReturnPolicyChannelPaymentMappingEntity";
            KeyPrefix = "commonDataModel.retailreturnpolicychannelpaymentmappingentity";
            KeySeparator = ".";
            Grouping = "/RetailReturnPolicyChannelPaymentMappingEntity";

            AddGroup("Common Data Model RetailReturnPolicyChannelPaymentMappingEntity Details", group =>
            {
                RetailReturnPolicyChannel = group.Add(new VocabularyKey(nameof(RetailReturnPolicyChannel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalTenderTypeId = group.Add(new VocabularyKey(nameof(OriginalTenderTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailReturnPolicyChannel_PolicyName = group.Add(new VocabularyKey(nameof(RetailReturnPolicyChannel_PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowedReturnTenderTypeId = group.Add(new VocabularyKey(nameof(AllowedReturnTenderTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RetailReturnPolicyChannel { get; private set; }
        public VocabularyKey OriginalTenderTypeId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey RetailReturnPolicyChannel_PolicyName { get; private set; }
        public VocabularyKey AllowedReturnTenderTypeId { get; private set; }


    }
}