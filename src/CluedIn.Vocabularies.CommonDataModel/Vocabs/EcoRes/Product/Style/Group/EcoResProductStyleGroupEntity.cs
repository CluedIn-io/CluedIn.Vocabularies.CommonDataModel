using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductStyleGroupEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductStyleGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductStyleGroupEntity";
            KeyPrefix = "commonDataModel.ecoresproductstylegroupentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductStyleGroupEntity";

            AddGroup("Common Data Model EcoResProductStyleGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }


    }
}