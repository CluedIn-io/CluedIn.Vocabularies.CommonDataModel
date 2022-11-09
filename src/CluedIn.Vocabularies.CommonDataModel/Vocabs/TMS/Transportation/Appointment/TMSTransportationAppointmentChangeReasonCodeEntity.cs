using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationAppointmentChangeReasonCodeEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationAppointmentChangeReasonCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationAppointmentChangeReasonCodeEntity";
            KeyPrefix = "commonDataModel.tmstransportationappointmentchangereasoncodeentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationAppointmentChangeReasonCodeEntity";

            AddGroup("Common Data Model TMSTransportationAppointmentChangeReasonCodeEntity Details", group =>
            {
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReasonDescription { get; private set; }
public VocabularyKey ReasonCode { get; private set; }


    }
}