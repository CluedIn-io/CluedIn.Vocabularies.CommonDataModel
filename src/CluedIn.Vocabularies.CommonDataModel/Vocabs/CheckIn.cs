using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CheckInVocabulary : SimpleVocabulary
    {
        public CheckInVocabulary()
        {
            VocabularyName = "Common Data Model CheckIn";
            KeyPrefix = "commonDataModel.checkin";
            KeySeparator = ".";
            Grouping = "/CheckIn";

            AddGroup("Common Data Model CheckIn Details", group =>
            {
                audienceType = group.Add(new VocabularyKey(nameof(audienceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
checkInId = group.Add(new VocabularyKey(nameof(checkInId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
checkInTime = group.Add(new VocabularyKey(nameof(checkInTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
checkInType = group.Add(new VocabularyKey(nameof(checkInType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
checkOutTime = group.Add(new VocabularyKey(nameof(checkOutTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberOfQuestionsAsked = group.Add(new VocabularyKey(nameof(numberOfQuestionsAsked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
registrationidfromqr = group.Add(new VocabularyKey(nameof(registrationidfromqr), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sessionCode = group.Add(new VocabularyKey(nameof(sessionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sessionType = group.Add(new VocabularyKey(nameof(sessionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
viewingDurationInMins = group.Add(new VocabularyKey(nameof(viewingDurationInMins), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey audienceType { get; private set; }
public VocabularyKey checkInId { get; private set; }
public VocabularyKey checkInTime { get; private set; }
public VocabularyKey checkInType { get; private set; }
public VocabularyKey checkOutTime { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey numberOfQuestionsAsked { get; private set; }
public VocabularyKey registrationidfromqr { get; private set; }
public VocabularyKey sessionCode { get; private set; }
public VocabularyKey sessionType { get; private set; }
public VocabularyKey viewingDurationInMins { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}