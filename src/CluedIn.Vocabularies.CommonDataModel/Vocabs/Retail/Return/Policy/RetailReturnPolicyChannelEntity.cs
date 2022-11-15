using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailReturnPolicyChannelEntityVocabulary : SimpleVocabulary
    {
        public RetailReturnPolicyChannelEntityVocabulary()
        {
            VocabularyName = "Retail Return Policy Channel Entity";
            KeyPrefix = "commonDataModel.retailreturnpolicychannelentity";
            KeySeparator = ".";
            Grouping = "/RetailReturnPolicyChannelEntity";

            AddGroup("RetailReturnPolicyChannelEntity Details", group =>
            {
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsManagerOverrideEnabled = group.Add(new VocabularyKey(nameof(IsManagerOverrideEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsManagerOverrideEnabled { get; private set; }
    }
}