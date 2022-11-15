using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductColorGroupEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductColorGroupEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Color Group Entity";
            KeyPrefix = "commonDataModel.ecoresproductcolorgroupentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductColorGroupEntity";

            AddGroup("EcoResProductColorGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
    }
}