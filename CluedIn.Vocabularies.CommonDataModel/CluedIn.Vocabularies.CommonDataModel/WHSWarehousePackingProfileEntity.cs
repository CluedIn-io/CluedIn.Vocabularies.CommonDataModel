using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehousePackingProfileEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehousePackingProfileEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehousePackingProfileEntity";
            KeyPrefix = "commonDataModel.whswarehousepackingprofileentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehousePackingProfileEntity";

            AddGroup("Common Data Model WHSWarehousePackingProfileEntity Details", group =>
            {
                WillContainerClosingCreateNewContainer = group.Add(new VocabularyKey(nameof(WillContainerClosingCreateNewContainer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerClosingProfileId = group.Add(new VocabularyKey(nameof(ContainerClosingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerTypeId = group.Add(new VocabularyKey(nameof(ContainerTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingProfileDescription = group.Add(new VocabularyKey(nameof(PackingProfileDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContainerIdAssigmentMode = group.Add(new VocabularyKey(nameof(ContainerIdAssigmentMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PackingProfileId = group.Add(new VocabularyKey(nameof(PackingProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WillContainerClosingCreateNewContainer { get; private set; }
public VocabularyKey ContainerClosingProfileId { get; private set; }
public VocabularyKey ContainerTypeId { get; private set; }
public VocabularyKey PackingProfileDescription { get; private set; }
public VocabularyKey ContainerIdAssigmentMode { get; private set; }
public VocabularyKey PackingProfileId { get; private set; }


    }
}