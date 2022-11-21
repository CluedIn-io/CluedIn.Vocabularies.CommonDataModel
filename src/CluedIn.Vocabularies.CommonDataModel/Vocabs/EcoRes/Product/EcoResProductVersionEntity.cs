using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductVersionEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductVersionEntityVocabulary()
        {
            VocabularyName = "Eco Res Product Version Entity";
            KeyPrefix = "commonDataModel.ecoresproductversionentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductVersionEntity";

            AddGroup("EcoResProductVersionEntity Details", group =>
            {
                VersionId = group.Add(new VocabularyKey(nameof(VersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey VersionId { get; private set; }
    }
}