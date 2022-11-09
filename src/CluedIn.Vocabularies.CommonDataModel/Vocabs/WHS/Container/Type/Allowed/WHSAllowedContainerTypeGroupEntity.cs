using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSAllowedContainerTypeGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSAllowedContainerTypeGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSAllowedContainerTypeGroupEntity";
            KeyPrefix = "commonDataModel.whsallowedcontainertypegroupentity";
            KeySeparator = ".";
            Grouping = "/WHSAllowedContainerTypeGroupEntity";

            AddGroup("Common Data Model WHSAllowedContainerTypeGroupEntity Details", group =>
            {
                AllowedContainerTypeGroupName = group.Add(new VocabularyKey(nameof(AllowedContainerTypeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AreUnspecifiedContainerTypesAllowed = group.Add(new VocabularyKey(nameof(AreUnspecifiedContainerTypesAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AllowedContainerTypeGroupName { get; private set; }
public VocabularyKey AreUnspecifiedContainerTypesAllowed { get; private set; }


    }
}