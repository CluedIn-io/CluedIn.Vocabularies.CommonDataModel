using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationEquipmentEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationEquipmentEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationEquipmentEntity";
            KeyPrefix = "commonDataModel.tmstransportationequipmententity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationEquipmentEntity";

            AddGroup("Common Data Model TMSTransportationEquipmentEntity Details", group =>
            {
                EquipmentUsageDurationMinutes = group.Add(new VocabularyKey(nameof(EquipmentUsageDurationMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquipmentCode = group.Add(new VocabularyKey(nameof(EquipmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquipmentHeight = group.Add(new VocabularyKey(nameof(EquipmentHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquipmentLength = group.Add(new VocabularyKey(nameof(EquipmentLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAllowedLoadVolume = group.Add(new VocabularyKey(nameof(MaximumAllowedLoadVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAllowedLoadWeight = group.Add(new VocabularyKey(nameof(MaximumAllowedLoadWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquipmentName = group.Add(new VocabularyKey(nameof(EquipmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRoundTripRequired = group.Add(new VocabularyKey(nameof(IsRoundTripRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquipmentTareWeight = group.Add(new VocabularyKey(nameof(EquipmentTareWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EquipmentWidth = group.Add(new VocabularyKey(nameof(EquipmentWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EquipmentUsageDurationMinutes { get; private set; }
        public VocabularyKey EquipmentCode { get; private set; }
        public VocabularyKey EquipmentHeight { get; private set; }
        public VocabularyKey EquipmentLength { get; private set; }
        public VocabularyKey MaximumAllowedLoadVolume { get; private set; }
        public VocabularyKey MaximumAllowedLoadWeight { get; private set; }
        public VocabularyKey EquipmentName { get; private set; }
        public VocabularyKey IsRoundTripRequired { get; private set; }
        public VocabularyKey EquipmentTareWeight { get; private set; }
        public VocabularyKey EquipmentWidth { get; private set; }


    }
}