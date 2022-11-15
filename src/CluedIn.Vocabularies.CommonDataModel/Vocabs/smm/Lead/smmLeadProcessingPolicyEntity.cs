using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmLeadProcessingPolicyEntityVocabulary : SimpleVocabulary
    {
        public SmmLeadProcessingPolicyEntityVocabulary()
        {
            VocabularyName = "Smm Lead Processing Policy Entity";
            KeyPrefix = "commonDataModel.smmleadprocessingpolicyentity";
            KeySeparator = ".";
            Grouping = "/SmmLeadProcessingPolicyEntity";

            AddGroup("SmmLeadProcessingPolicyEntity Details", group =>
            {
                WillLeadQualificationCreateOpportunity = group.Add(new VocabularyKey(nameof(WillLeadQualificationCreateOpportunity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillLeadQualificationCreateCustomer = group.Add(new VocabularyKey(nameof(WillLeadQualificationCreateCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WillLeadQualificationCreateOpportunity { get; private set; }
        public VocabularyKey WillLeadQualificationCreateCustomer { get; private set; }
    }
}