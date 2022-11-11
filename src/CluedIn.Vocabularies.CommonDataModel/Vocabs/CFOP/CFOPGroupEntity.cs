using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFOPGroupEntityVocabulary : SimpleVocabulary
    {
        public CFOPGroupEntityVocabulary()
        {
            VocabularyName = "CFOPGroupEntity";
            KeyPrefix = "commonDataModel.cfopgroupentity";
            KeySeparator = ".";
            Grouping = "/CFOPGroupEntity";

            AddGroup("CFOPGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}