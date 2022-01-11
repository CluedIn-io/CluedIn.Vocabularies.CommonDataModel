using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSPhysicalDimensionGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSPhysicalDimensionGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSPhysicalDimensionGroupEntity";
            KeyPrefix = "commonDataModel.whsphysicaldimensiongroupentity";
            KeySeparator = ".";
            Grouping = "/WHSPhysicalDimensionGroupEntity";

            AddGroup("Common Data Model WHSPhysicalDimensionGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupDescription { get; private set; }
public VocabularyKey GroupId { get; private set; }


    }
}