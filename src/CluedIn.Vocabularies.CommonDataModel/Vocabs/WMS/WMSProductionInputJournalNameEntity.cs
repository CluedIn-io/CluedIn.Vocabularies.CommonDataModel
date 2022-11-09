using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WMSProductionInputJournalNameEntityVocabulary : SimpleVocabulary
    {
        public WMSProductionInputJournalNameEntityVocabulary()
        {
            VocabularyName = "Common Data Model WMSProductionInputJournalNameEntity";
            KeyPrefix = "commonDataModel.wmsproductioninputjournalnameentity";
            KeySeparator = ".";
            Grouping = "/WMSProductionInputJournalNameEntity";

            AddGroup("Common Data Model WMSProductionInputJournalNameEntity Details", group =>
            {
                DefaultPrivateUserGroupId = group.Add(new VocabularyKey(nameof(DefaultPrivateUserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPickingWarehouseLocationCheckedByDefault = group.Add(new VocabularyKey(nameof(IsPickingWarehouseLocationCheckedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillPostingDeleteLinesByDefault = group.Add(new VocabularyKey(nameof(WillPostingDeleteLinesByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultJournalDescription = group.Add(new VocabularyKey(nameof(DefaultJournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DefaultPrivateUserGroupId { get; private set; }
public VocabularyKey IsPickingWarehouseLocationCheckedByDefault { get; private set; }
public VocabularyKey WillPostingDeleteLinesByDefault { get; private set; }
public VocabularyKey DefaultJournalDescription { get; private set; }
public VocabularyKey JournalNameId { get; private set; }


    }
}