using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmCampaignTypeEntityVocabulary : SimpleVocabulary
    {
        public smmCampaignTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmCampaignTypeEntity";
            KeyPrefix = "commonDataModel.smmcampaigntypeentity";
            KeySeparator = ".";
            Grouping = "/smmCampaignTypeEntity";

            AddGroup("Common Data Model smmCampaignTypeEntity Details", group =>
            {
                TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TypeDescription { get; private set; }
public VocabularyKey TypeId { get; private set; }


    }
}