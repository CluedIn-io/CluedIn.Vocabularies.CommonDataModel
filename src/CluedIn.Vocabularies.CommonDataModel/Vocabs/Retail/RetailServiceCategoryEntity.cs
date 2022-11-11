using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailServiceCategoryEntityVocabulary : SimpleVocabulary
    {
        public RetailServiceCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailServiceCategoryEntity";
            KeyPrefix = "commonDataModel.retailservicecategoryentity";
            KeySeparator = ".";
            Grouping = "/RetailServiceCategoryEntity";

            AddGroup("Common Data Model RetailServiceCategoryEntity Details", group =>
            {
                SalesDate = group.Add(new VocabularyKey(nameof(SalesDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Calendar = group.Add(new VocabularyKey(nameof(Calendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CrossDockingWarehouse = group.Add(new VocabularyKey(nameof(CrossDockingWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocalDeliveryDate = group.Add(new VocabularyKey(nameof(LocalDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentWarehouse = group.Add(new VocabularyKey(nameof(ReplenishmentWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentRule = group.Add(new VocabularyKey(nameof(ReplenishmentRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceCategory = group.Add(new VocabularyKey(nameof(ServiceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalesDate { get; private set; }
        public VocabularyKey Calendar { get; private set; }
        public VocabularyKey CrossDockingWarehouse { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LocalDeliveryDate { get; private set; }
        public VocabularyKey ReplenishmentWarehouse { get; private set; }
        public VocabularyKey ReplenishmentRule { get; private set; }
        public VocabularyKey ServiceCategory { get; private set; }


    }
}