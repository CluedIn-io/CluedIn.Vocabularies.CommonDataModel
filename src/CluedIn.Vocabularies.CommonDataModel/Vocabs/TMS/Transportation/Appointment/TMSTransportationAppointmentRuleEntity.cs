using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationAppointmentRuleEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationAppointmentRuleEntityVocabulary()
        {
            VocabularyName = "TMSTransportationAppointmentRuleEntity";
            KeyPrefix = "commonDataModel.tmstransportationappointmentruleentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationAppointmentRuleEntity";

            AddGroup("TMSTransportationAppointmentRuleEntity Details", group =>
            {
                ItemMovementDirectionRule = group.Add(new VocabularyKey(nameof(ItemMovementDirectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumAppointmentsAllowed = group.Add(new VocabularyKey(nameof(MaximumAppointmentsAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentRuleId = group.Add(new VocabularyKey(nameof(AppointmentRuleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDriverCheckInRequired = group.Add(new VocabularyKey(nameof(IsDriverCheckInRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultAppointmentDurationMinutes = group.Add(new VocabularyKey(nameof(DefaultAppointmentDurationMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentWarehouseId = group.Add(new VocabularyKey(nameof(AppointmentWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentSiteId = group.Add(new VocabularyKey(nameof(AppointmentSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AppointmentCheckInCheckOutWarehouseLocationProfileId = group.Add(new VocabularyKey(nameof(AppointmentCheckInCheckOutWarehouseLocationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ItemMovementDirectionRule { get; private set; }
        public VocabularyKey MaximumAppointmentsAllowed { get; private set; }
        public VocabularyKey AppointmentRuleId { get; private set; }
        public VocabularyKey IsDriverCheckInRequired { get; private set; }
        public VocabularyKey DefaultAppointmentDurationMinutes { get; private set; }
        public VocabularyKey AppointmentWarehouseId { get; private set; }
        public VocabularyKey AppointmentSiteId { get; private set; }
        public VocabularyKey AppointmentCheckInCheckOutWarehouseLocationProfileId { get; private set; }


    }
}