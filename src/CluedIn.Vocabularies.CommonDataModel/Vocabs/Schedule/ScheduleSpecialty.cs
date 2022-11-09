using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ScheduleSpecialtyVocabulary : SimpleVocabulary
    {
        public ScheduleSpecialtyVocabulary()
        {
            VocabularyName = "Common Data Model ScheduleSpecialty";
            KeyPrefix = "commonDataModel.schedulespecialty";
            KeySeparator = ".";
            Grouping = "/ScheduleSpecialty";

            AddGroup("Common Data Model ScheduleSpecialty Details", group =>
            {
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
scheduleSpecialtyId = group.Add(new VocabularyKey(nameof(scheduleSpecialtyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey name { get; private set; }
public VocabularyKey scheduleSpecialtyId { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}