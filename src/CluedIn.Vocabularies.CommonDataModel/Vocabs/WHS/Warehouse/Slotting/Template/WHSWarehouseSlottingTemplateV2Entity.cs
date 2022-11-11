using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseSlottingTemplateV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseSlottingTemplateV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseSlottingTemplateV2Entity";
            KeyPrefix = "commonDataModel.whswarehouseslottingtemplatev2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseSlottingTemplateV2Entity";

            AddGroup("Common Data Model WHSWarehouseSlottingTemplateV2Entity Details", group =>
            {
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlottingStrategy = group.Add(new VocabularyKey(nameof(SlottingStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SlottingSource = group.Add(new VocabularyKey(nameof(SlottingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities = group.Add(new VocabularyKey(nameof(WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateQuery = group.Add(new VocabularyKey(nameof(TemplateQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey TemplateDescription { get; private set; }
        public VocabularyKey SlottingStrategy { get; private set; }
        public VocabularyKey SlottingSource { get; private set; }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey WillCreatedReplenishmentWorkAllowUsingUnreservedQuantities { get; private set; }
        public VocabularyKey TemplateQuery { get; private set; }


    }
}