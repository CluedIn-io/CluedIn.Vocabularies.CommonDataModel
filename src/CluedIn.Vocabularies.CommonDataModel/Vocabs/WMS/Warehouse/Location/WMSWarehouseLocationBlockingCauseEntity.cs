using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WMSWarehouseLocationBlockingCauseEntityVocabulary : SimpleVocabulary
    {
        public WMSWarehouseLocationBlockingCauseEntityVocabulary()
        {
            VocabularyName = "Common Data Model WMSWarehouseLocationBlockingCauseEntity";
            KeyPrefix = "commonDataModel.wmswarehouselocationblockingcauseentity";
            KeySeparator = ".";
            Grouping = "/WMSWarehouseLocationBlockingCauseEntity";

            AddGroup("Common Data Model WMSWarehouseLocationBlockingCauseEntity Details", group =>
            {
                CauseId = group.Add(new VocabularyKey(nameof(CauseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CauseDescription = group.Add(new VocabularyKey(nameof(CauseDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CauseId { get; private set; }
public VocabularyKey CauseDescription { get; private set; }


    }
}