using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCustomerRetentionTermEntityVocabulary : SimpleVocabulary
    {
        public ProjCustomerRetentionTermEntityVocabulary()
        {
            VocabularyName = "Proj Customer Retention Term Entity";
            KeyPrefix = "commonDataModel.projcustomerretentiontermentity";
            KeySeparator = ".";
            Grouping = "/ProjCustomerRetentionTermEntity";

            AddGroup("ProjCustomerRetentionTermEntity Details", group =>
            {
                BillingRule = group.Add(new VocabularyKey(nameof(BillingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetentionTerm = group.Add(new VocabularyKey(nameof(RetentionTerm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BillingRule { get; private set; }
        public VocabularyKey ProjectContractID { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey RetentionTerm { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
    }
}