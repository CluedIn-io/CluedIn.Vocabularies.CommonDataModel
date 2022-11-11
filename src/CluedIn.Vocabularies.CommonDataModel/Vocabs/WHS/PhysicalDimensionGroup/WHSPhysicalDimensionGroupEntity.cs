using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSPhysicalDimensionGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSPhysicalDimensionGroupEntityVocabulary()
        {
            VocabularyName = "WHSPhysicalDimensionGroupEntity";
            KeyPrefix = "commonDataModel.whsphysicaldimensiongroupentity";
            KeySeparator = ".";
            Grouping = "/WHSPhysicalDimensionGroupEntity";

            AddGroup("WHSPhysicalDimensionGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }


    }
}