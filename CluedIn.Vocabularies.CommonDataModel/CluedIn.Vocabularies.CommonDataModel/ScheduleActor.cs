using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ScheduleActorVocabulary : SimpleVocabulary
    {
        public ScheduleActorVocabulary()
        {
            VocabularyName = "Common Data Model ScheduleActor";
            KeyPrefix = "commonDataModel.scheduleactor";
            KeySeparator = ".";
            Grouping = "/ScheduleActor";

            AddGroup("Common Data Model ScheduleActor Details", group =>
            {
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
scheduleActorId = group.Add(new VocabularyKey(nameof(scheduleActorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey name { get; private set; }
public VocabularyKey scheduleActorId { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}