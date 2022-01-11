using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SessionTrackVocabulary : SimpleVocabulary
    {
        public SessionTrackVocabulary()
        {
            VocabularyName = "Common Data Model SessionTrack";
            KeyPrefix = "commonDataModel.sessiontrack";
            KeySeparator = ".";
            Grouping = "/SessionTrack";

            AddGroup("Common Data Model SessionTrack Details", group =>
            {
                audienceType = group.Add(new VocabularyKey(nameof(audienceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
industryType = group.Add(new VocabularyKey(nameof(industryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
keywords = group.Add(new VocabularyKey(nameof(keywords), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
numberOfRegistrations = group.Add(new VocabularyKey(nameof(numberOfRegistrations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
publishStatus = group.Add(new VocabularyKey(nameof(publishStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sessionsInTrack = group.Add(new VocabularyKey(nameof(sessionsInTrack), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
sessionTrackId = group.Add(new VocabularyKey(nameof(sessionTrackId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
targetNumberOfSessions = group.Add(new VocabularyKey(nameof(targetNumberOfSessions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
trackCode = group.Add(new VocabularyKey(nameof(trackCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
trackGoal = group.Add(new VocabularyKey(nameof(trackGoal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
trackType = group.Add(new VocabularyKey(nameof(trackType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey audienceType { get; private set; }
public VocabularyKey description { get; private set; }
public VocabularyKey industryType { get; private set; }
public VocabularyKey keywords { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey numberOfRegistrations { get; private set; }
public VocabularyKey publishStatus { get; private set; }
public VocabularyKey sessionsInTrack { get; private set; }
public VocabularyKey sessionTrackId { get; private set; }
public VocabularyKey targetNumberOfSessions { get; private set; }
public VocabularyKey trackCode { get; private set; }
public VocabularyKey trackGoal { get; private set; }
public VocabularyKey trackType { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}