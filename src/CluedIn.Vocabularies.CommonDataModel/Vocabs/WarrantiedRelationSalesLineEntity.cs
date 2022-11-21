using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WarrantiedRelationSalesLineEntityVocabulary : SimpleVocabulary
    {
        public WarrantiedRelationSalesLineEntityVocabulary()
        {
            VocabularyName = "Warrantied Relation Sales Line Entity";
            KeyPrefix = "commonDataModel.warrantiedrelationsaleslineentity";
            KeySeparator = ".";
            Grouping = "/WarrantiedRelationSalesLineEntity";

            AddGroup("WarrantiedRelationSalesLineEntity Details", group =>
            {
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantiedOrderType = group.Add(new VocabularyKey(nameof(WarrantiedOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantiedSalesId = group.Add(new VocabularyKey(nameof(WarrantiedSalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantiedItemId = group.Add(new VocabularyKey(nameof(WarrantiedItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantiedSalesLineNumber = group.Add(new VocabularyKey(nameof(WarrantiedSalesLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantiedInventoryLotId = group.Add(new VocabularyKey(nameof(WarrantiedInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantiedSerialNumber = group.Add(new VocabularyKey(nameof(WarrantiedSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyOrderType = group.Add(new VocabularyKey(nameof(WarrantyOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantySalesId = group.Add(new VocabularyKey(nameof(WarrantySalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyItemId = group.Add(new VocabularyKey(nameof(WarrantyItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantySalesLineNumber = group.Add(new VocabularyKey(nameof(WarrantySalesLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyInventoryLotId = group.Add(new VocabularyKey(nameof(WarrantyInventoryLotId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Relation = group.Add(new VocabularyKey(nameof(Relation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey WarrantiedOrderType { get; private set; }
        public VocabularyKey WarrantiedSalesId { get; private set; }
        public VocabularyKey WarrantiedItemId { get; private set; }
        public VocabularyKey WarrantiedSalesLineNumber { get; private set; }
        public VocabularyKey WarrantiedInventoryLotId { get; private set; }
        public VocabularyKey WarrantiedSerialNumber { get; private set; }
        public VocabularyKey WarrantyOrderType { get; private set; }
        public VocabularyKey WarrantySalesId { get; private set; }
        public VocabularyKey WarrantyItemId { get; private set; }
        public VocabularyKey WarrantySalesLineNumber { get; private set; }
        public VocabularyKey WarrantyInventoryLotId { get; private set; }
        public VocabularyKey Relation { get; private set; }
    }
}