using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjHourCostPriceV2EntityVocabulary : SimpleVocabulary
    {
        public ProjHourCostPriceV2EntityVocabulary()
        {
            VocabularyName = "ProjHourCostPriceV2Entity";
            KeyPrefix = "commonDataModel.projhourcostpricev2entity";
            KeySeparator = ".";
            Grouping = "/ProjHourCostPriceV2Entity";

            AddGroup("ProjHourCostPriceV2Entity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveLaborRate = group.Add(new VocabularyKey(nameof(EffectiveLaborRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsResourceRate = group.Add(new VocabularyKey(nameof(IsResourceRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceGroupId = group.Add(new VocabularyKey(nameof(PriceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractId = group.Add(new VocabularyKey(nameof(ProjectContractId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategory = group.Add(new VocabularyKey(nameof(ResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceId = group.Add(new VocabularyKey(nameof(ResourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategoryId = group.Add(new VocabularyKey(nameof(ResourceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCompanyId = group.Add(new VocabularyKey(nameof(ResourceCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey EffectiveLaborRate { get; private set; }
        public VocabularyKey IsResourceRate { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey PriceGroupId { get; private set; }
        public VocabularyKey ProjectContractId { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey ResourceCategory { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey ResourceId { get; private set; }
        public VocabularyKey ResourceCategoryId { get; private set; }
        public VocabularyKey ResourceCompanyId { get; private set; }


    }
}