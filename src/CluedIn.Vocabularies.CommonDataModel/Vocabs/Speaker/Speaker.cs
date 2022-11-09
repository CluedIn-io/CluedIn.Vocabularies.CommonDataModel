using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SpeakerVocabulary : SimpleVocabulary
    {
        public SpeakerVocabulary()
        {
            VocabularyName = "Common Data Model Speaker";
            KeyPrefix = "commonDataModel.speaker";
            KeySeparator = ".";
            Grouping = "/Speaker";

            AddGroup("Common Data Model Speaker Details", group =>
            {
                entityImage = group.Add(new VocabularyKey(nameof(entityImage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
about = group.Add(new VocabularyKey(nameof(about), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
accomplishments = group.Add(new VocabularyKey(nameof(accomplishments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
blog = group.Add(new VocabularyKey(nameof(blog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
email = group.Add(new VocabularyKey(nameof(email), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
linkedIn = group.Add(new VocabularyKey(nameof(linkedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
publications = group.Add(new VocabularyKey(nameof(publications), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
speakerCost = group.Add(new VocabularyKey(nameof(speakerCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
speakerCostBase = group.Add(new VocabularyKey(nameof(speakerCostBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
speakerId = group.Add(new VocabularyKey(nameof(speakerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
title = group.Add(new VocabularyKey(nameof(title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
twitter = group.Add(new VocabularyKey(nameof(twitter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
website = group.Add(new VocabularyKey(nameof(website), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
processID = group.Add(new VocabularyKey(nameof(processID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stageID = group.Add(new VocabularyKey(nameof(stageID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
traversedPath = group.Add(new VocabularyKey(nameof(traversedPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey entityImage { get; private set; }
public VocabularyKey exchangeRate { get; private set; }
public VocabularyKey about { get; private set; }
public VocabularyKey accomplishments { get; private set; }
public VocabularyKey blog { get; private set; }
public VocabularyKey email { get; private set; }
public VocabularyKey linkedIn { get; private set; }
public VocabularyKey name { get; private set; }
public VocabularyKey publications { get; private set; }
public VocabularyKey speakerCost { get; private set; }
public VocabularyKey speakerCostBase { get; private set; }
public VocabularyKey speakerId { get; private set; }
public VocabularyKey title { get; private set; }
public VocabularyKey twitter { get; private set; }
public VocabularyKey type { get; private set; }
public VocabularyKey website { get; private set; }
public VocabularyKey processID { get; private set; }
public VocabularyKey stageID { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }
public VocabularyKey traversedPath { get; private set; }


    }
}