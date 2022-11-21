using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResAttributeGroupEntityVocabulary : SimpleVocabulary
    {
        public EcoResAttributeGroupEntityVocabulary()
        {
            VocabularyName = "Eco Res Attribute Group Entity";
            KeyPrefix = "commonDataModel.ecoresattributegroupentity";
            KeySeparator = ".";
            Grouping = "/EcoResAttributeGroupEntity";

            AddGroup("EcoResAttributeGroupEntity Details", group =>
            {
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupName { get; private set; }
    }
}