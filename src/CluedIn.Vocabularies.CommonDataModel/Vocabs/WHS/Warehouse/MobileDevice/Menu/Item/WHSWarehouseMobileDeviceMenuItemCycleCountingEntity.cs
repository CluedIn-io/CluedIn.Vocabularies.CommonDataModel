using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseMobileDeviceMenuItemCycleCountingEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseMobileDeviceMenuItemCycleCountingEntityVocabulary()
        {
            VocabularyName = "WHSWarehouseMobileDeviceMenuItemCycleCountingEntity";
            KeyPrefix = "commonDataModel.whswarehousemobiledevicemenuitemcyclecountingentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseMobileDeviceMenuItemCycleCountingEntity";

            AddGroup("WHSWarehouseMobileDeviceMenuItemCycleCountingEntity Details", group =>
            {
                WarehouseMobileDeviceMenuItemId = group.Add(new VocabularyKey(nameof(WarehouseMobileDeviceMenuItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttemptsNumber = group.Add(new VocabularyKey(nameof(AttemptsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsItemNumberDisplayed = group.Add(new VocabularyKey(nameof(IsItemNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLicensePlateDisplayed = group.Add(new VocabularyKey(nameof(IsLicensePlateDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchNumberDisplayed = group.Add(new VocabularyKey(nameof(IsBatchNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSerialNumberDisplayed = group.Add(new VocabularyKey(nameof(IsSerialNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCountingReasonCode = group.Add(new VocabularyKey(nameof(DefaultCountingReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountingReasonCodeDisplayed = group.Add(new VocabularyKey(nameof(IsCountingReasonCodeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCountingReasonCodeEditable = group.Add(new VocabularyKey(nameof(IsCountingReasonCodeEditable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarehouseMobileDeviceMenuItemId { get; private set; }
        public VocabularyKey AttemptsNumber { get; private set; }
        public VocabularyKey IsItemNumberDisplayed { get; private set; }
        public VocabularyKey IsLicensePlateDisplayed { get; private set; }
        public VocabularyKey IsBatchNumberDisplayed { get; private set; }
        public VocabularyKey IsSerialNumberDisplayed { get; private set; }
        public VocabularyKey DefaultCountingReasonCode { get; private set; }
        public VocabularyKey IsCountingReasonCodeDisplayed { get; private set; }
        public VocabularyKey IsCountingReasonCodeEditable { get; private set; }


    }
}