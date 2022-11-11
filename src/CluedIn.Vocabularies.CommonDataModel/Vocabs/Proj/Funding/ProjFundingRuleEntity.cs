using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjFundingRuleEntityVocabulary : SimpleVocabulary
    {
        public ProjFundingRuleEntityVocabulary()
        {
            VocabularyName = "ProjFundingRuleEntity";
            KeyPrefix = "commonDataModel.projfundingruleentity";
            KeySeparator = ".";
            Grouping = "/ProjFundingRuleEntity";

            AddGroup("ProjFundingRuleEntity Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryGroupId = group.Add(new VocabularyKey(nameof(CategoryGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorityKey = group.Add(new VocabularyKey(nameof(PriorityKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocateRounding = group.Add(new VocabularyKey(nameof(AllocateRounding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllocationPercentage = group.Add(new VocabularyKey(nameof(AllocationPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingSource = group.Add(new VocabularyKey(nameof(FundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingSourceId = group.Add(new VocabularyKey(nameof(FundingSourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingSource_ContractId = group.Add(new VocabularyKey(nameof(FundingSource_ContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingRule = group.Add(new VocabularyKey(nameof(FundingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey CategoryGroupId { get; private set; }
        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey ProjectContractId { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey PriorityKey { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey AllocateRounding { get; private set; }
        public VocabularyKey AllocationPercentage { get; private set; }
        public VocabularyKey FundingSource { get; private set; }
        public VocabularyKey FundingSourceId { get; private set; }
        public VocabularyKey FundingSource_ContractId { get; private set; }
        public VocabularyKey FundingRule { get; private set; }


    }
}