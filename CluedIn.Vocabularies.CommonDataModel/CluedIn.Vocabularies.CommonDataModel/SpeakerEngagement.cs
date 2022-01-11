using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SpeakerEngagementVocabulary : SimpleVocabulary
    {
        public SpeakerEngagementVocabulary()
        {
            VocabularyName = "Common Data Model SpeakerEngagement";
            KeyPrefix = "commonDataModel.speakerengagement";
            KeySeparator = ".";
            Grouping = "/SpeakerEngagement";

            AddGroup("Common Data Model SpeakerEngagement Details", group =>
            {
                entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
endTime = group.Add(new VocabularyKey(nameof(endTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
speakerCost = group.Add(new VocabularyKey(nameof(speakerCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
speakerCostBase = group.Add(new VocabularyKey(nameof(speakerCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
speakerEngagementId = group.Add(new VocabularyKey(nameof(speakerEngagementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
startTime = group.Add(new VocabularyKey(nameof(startTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey entityImage { get; private set; }
public VocabularyKey exchangeRate { get; private set; }
public VocabularyKey description { get; private set; }
public VocabularyKey endTime { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey speakerCost { get; private set; }
public VocabularyKey speakerCostBase { get; private set; }
public VocabularyKey speakerEngagementId { get; private set; }
public VocabularyKey startTime { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}