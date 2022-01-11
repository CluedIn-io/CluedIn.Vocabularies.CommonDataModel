using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationAppointmentDriverLogEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationAppointmentDriverLogEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationAppointmentDriverLogEntity";
            KeyPrefix = "commonDataModel.tmstransportationappointmentdriverlogentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationAppointmentDriverLogEntity";

            AddGroup("Common Data Model TMSTransportationAppointmentDriverLogEntity Details", group =>
            {
                ActualAppointmentEndDateTime = group.Add(new VocabularyKey(nameof(ActualAppointmentEndDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActualAppointmentStartDateTime = group.Add(new VocabularyKey(nameof(ActualAppointmentStartDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AppointmentId = group.Add(new VocabularyKey(nameof(AppointmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DriverLicense = group.Add(new VocabularyKey(nameof(DriverLicense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DriverName = group.Add(new VocabularyKey(nameof(DriverName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDropTrailerAllowed = group.Add(new VocabularyKey(nameof(IsDropTrailerAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShippingCarrierVendorAccountNumber = group.Add(new VocabularyKey(nameof(ShippingCarrierVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationAppointmentAlertRule = group.Add(new VocabularyKey(nameof(TransportationAppointmentAlertRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ActualAppointmentEndDateTime { get; private set; }
public VocabularyKey ActualAppointmentStartDateTime { get; private set; }
public VocabularyKey AppointmentId { get; private set; }
public VocabularyKey DriverLicense { get; private set; }
public VocabularyKey DriverName { get; private set; }
public VocabularyKey IsDropTrailerAllowed { get; private set; }
public VocabularyKey ShippingCarrierVendorAccountNumber { get; private set; }
public VocabularyKey TransportationAppointmentAlertRule { get; private set; }


    }
}