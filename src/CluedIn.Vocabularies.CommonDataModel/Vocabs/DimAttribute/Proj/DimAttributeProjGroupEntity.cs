using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeProjGroupEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeProjGroupEntityVocabulary()
        {
            VocabularyName = "DimAttributeProjGroupEntity";
            KeyPrefix = "commonDataModel.dimattributeprojgroupentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeProjGroupEntity";

            AddGroup("DimAttributeProjGroupEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}