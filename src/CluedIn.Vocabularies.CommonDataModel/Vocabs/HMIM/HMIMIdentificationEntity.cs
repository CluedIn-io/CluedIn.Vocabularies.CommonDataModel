using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HMIMIdentificationEntityVocabulary : SimpleVocabulary
    {
        public HMIMIdentificationEntityVocabulary()
        {
            VocabularyName = "HMIM Identification Entity";
            KeyPrefix = "commonDataModel.hmimidentificationentity";
            KeySeparator = ".";
            Grouping = "/HMIMIdentificationEntity";

            AddGroup("HMIMIdentificationEntity Details", group =>
            {
                IdentificationCode = group.Add(new VocabularyKey(nameof(IdentificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictAir = group.Add(new VocabularyKey(nameof(RestrictAir), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RestrictSea = group.Add(new VocabularyKey(nameof(RestrictSea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IdentificationCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RestrictAir { get; private set; }
        public VocabularyKey RestrictSea { get; private set; }
    }
}