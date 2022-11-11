using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjGrantTypeFrequencyEntityVocabulary : SimpleVocabulary
    {
        public ProjGrantTypeFrequencyEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjGrantTypeFrequencyEntity";
            KeyPrefix = "commonDataModel.projgranttypefrequencyentity";
            KeySeparator = ".";
            Grouping = "/ProjGrantTypeFrequencyEntity";

            AddGroup("Common Data Model ProjGrantTypeFrequencyEntity Details", group =>
            {
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Frequency = group.Add(new VocabularyKey(nameof(Frequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrantType = group.Add(new VocabularyKey(nameof(ProjGrantType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjGrantType_GrantType = group.Add(new VocabularyKey(nameof(ProjGrantType_GrantType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Comments { get; private set; }
        public VocabularyKey Frequency { get; private set; }
        public VocabularyKey ProjGrantType { get; private set; }
        public VocabularyKey ProjGrantType_GrantType { get; private set; }


    }
}