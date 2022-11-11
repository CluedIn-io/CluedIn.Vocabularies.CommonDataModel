using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductSizeGroupEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductSizeGroupEntityVocabulary()
        {
            VocabularyName = "EcoResProductSizeGroupEntity";
            KeyPrefix = "commonDataModel.ecoresproductsizegroupentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductSizeGroupEntity";

            AddGroup("EcoResProductSizeGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }


    }
}