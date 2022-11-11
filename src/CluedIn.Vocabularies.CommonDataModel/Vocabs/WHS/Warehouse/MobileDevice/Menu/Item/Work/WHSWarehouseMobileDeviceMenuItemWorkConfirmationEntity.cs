using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuItemWorkConfirmationEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuItemWorkConfirmationEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseMobileDeviceMenuItemWorkConfirmationEntity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenuitemworkconfirmationentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuItemWorkConfirmationEntity";

            AddGroup("WHSWarehouseMobileDeviceMenuItemWorkConfirmationEntity Details", group =>
            {
                WarehouseMobileDeviceMenuItemId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceMenuItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkType = group.Add(new VocabularyKey(nameof(WorkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutoConfirmUsed = group.Add(new VocabularyKey(nameof(IsAutoConfirmUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseLocationConfirmationUsed = group.Add(new VocabularyKey(nameof(IsWarehouseLocationConfirmationUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuantityConfirmationUsed = group.Add(new VocabularyKey(nameof(IsQuantityConfirmationUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsProductConfirmationUsed = group.Add(new VocabularyKey(nameof(IsProductConfirmationUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPieceByPieceConfirmationUsed = group.Add(new VocabularyKey(nameof(IsPieceByPieceConfirmationUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumPieceConfirmation = group.Add(new VocabularyKey(nameof(MaximumPieceConfirmation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchConfirmationUsed = group.Add(new VocabularyKey(nameof(IsBatchConfirmationUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLicensePlateConfirmationUsed = group.Add(new VocabularyKey(nameof(IsLicensePlateConfirmationUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickDetailsConfirmationShown = group.Add(new VocabularyKey(nameof(IsPickDetailsConfirmationShown), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseMobileDeviceMenuItemId { get; private set; }
        public VocabularyKey WorkType { get; private set; }
        public VocabularyKey IsAutoConfirmUsed { get; private set; }
        public VocabularyKey IsWarehouseLocationConfirmationUsed { get; private set; }
        public VocabularyKey IsQuantityConfirmationUsed { get; private set; }
        public VocabularyKey IsProductConfirmationUsed { get; private set; }
        public VocabularyKey IsPieceByPieceConfirmationUsed { get; private set; }
        public VocabularyKey MaximumPieceConfirmation { get; private set; }
        public VocabularyKey IsBatchConfirmationUsed { get; private set; }
        public VocabularyKey IsLicensePlateConfirmationUsed { get; private set; }
        public VocabularyKey IsPickDetailsConfirmationShown { get; private set; }


    }
}