using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AppointmentEMRReferralRequestVocabulary : SimpleVocabulary
    {
        public AppointmentEMRReferralRequestVocabulary()
        {
            VocabularyName = "Common Data Model AppointmentEMRReferralRequest";
            KeyPrefix = "commonDataModel.appointmentemrreferralrequest";
            KeySeparator = ".";
            Grouping = "/AppointmentEMRReferralRequest";

            AddGroup("Common Data Model AppointmentEMRReferralRequest Details", group =>
            {
                appointmentEMRReferralRequestId = group.Add(new VocabularyKey(nameof(appointmentEMRReferralRequestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey appointmentEMRReferralRequestId { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}