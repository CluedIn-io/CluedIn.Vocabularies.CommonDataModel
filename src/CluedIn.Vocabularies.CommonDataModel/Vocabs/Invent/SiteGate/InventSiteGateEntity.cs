using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventSiteGateEntityVocabulary : SimpleVocabulary
    {
        public InventSiteGateEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventSiteGateEntity";
            KeyPrefix = "commonDataModel.inventsitegateentity";
            KeySeparator = ".";
            Grouping = "/InventSiteGateEntity";

            AddGroup("Common Data Model InventSiteGateEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GateId = group.Add(new VocabularyKey(nameof(GateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SiteId = group.Add(new VocabularyKey(nameof(SiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey GateId { get; private set; }
public VocabularyKey SiteId { get; private set; }
public VocabularyKey Type { get; private set; }


    }
}