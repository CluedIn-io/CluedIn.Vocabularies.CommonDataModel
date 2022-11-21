using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DlvDeliveryModeEntityVocabulary : SimpleVocabulary
    {
        public DlvDeliveryModeEntityVocabulary()
        {
            VocabularyName = "Dlv Delivery Mode Entity";
            KeyPrefix = "commonDataModel.dlvdeliverymodeentity";
            KeySeparator = ".";
            Grouping = "/DlvDeliveryModeEntity";

            AddGroup("DlvDeliveryModeEntity Details", group =>
            {
                ModeCode = group.Add(new VocabularyKey(nameof(ModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeDeliveryGroupId = group.Add(new VocabularyKey(nameof(ChargeDeliveryGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultExpediteCode = group.Add(new VocabularyKey(nameof(DefaultExpediteCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModeDescription = group.Add(new VocabularyKey(nameof(ModeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatTransportModeCode = group.Add(new VocabularyKey(nameof(IntrastatTransportModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ModeCode { get; private set; }
        public VocabularyKey ChargeDeliveryGroupId { get; private set; }
        public VocabularyKey DefaultExpediteCode { get; private set; }
        public VocabularyKey ModeDescription { get; private set; }
        public VocabularyKey IntrastatTransportModeCode { get; private set; }
    }
}