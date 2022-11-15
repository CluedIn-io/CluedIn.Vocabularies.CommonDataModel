using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeTrvTravelTxtEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeTrvTravelTxtEntityVocabulary()
        {
            VocabularyName = "Dim Attribute Trv Travel Txt Entity";
            KeyPrefix = "commonDataModel.dimattributetrvtraveltxtentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeTrvTravelTxtEntity";

            AddGroup("DimAttributeTrvTravelTxtEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}