using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmCampaignGroupEntityVocabulary : SimpleVocabulary
    {
        public smmCampaignGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmCampaignGroupEntity";
            KeyPrefix = "commonDataModel.smmcampaigngroupentity";
            KeySeparator = ".";
            Grouping = "/smmCampaignGroupEntity";

            AddGroup("Common Data Model smmCampaignGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupDescription { get; private set; }
public VocabularyKey GroupId { get; private set; }


    }
}