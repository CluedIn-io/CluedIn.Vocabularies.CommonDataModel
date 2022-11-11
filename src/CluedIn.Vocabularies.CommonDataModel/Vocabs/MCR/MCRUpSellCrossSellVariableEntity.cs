using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRUpSellCrossSellVariableEntityVocabulary : SimpleVocabulary
    {
        public MCRUpSellCrossSellVariableEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRUpSellCrossSellVariableEntity";
            KeyPrefix = "commonDataModel.mcrupsellcrosssellvariableentity";
            KeySeparator = ".";
            Grouping = "/MCRUpSellCrossSellVariableEntity";

            AddGroup("Common Data Model MCRUpSellCrossSellVariableEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Field = group.Add(new VocabularyKey(nameof(Field), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariableName = group.Add(new VocabularyKey(nameof(VariableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VariableTable = group.Add(new VocabularyKey(nameof(VariableTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Field { get; private set; }
        public VocabularyKey VariableName { get; private set; }
        public VocabularyKey VariableTable { get; private set; }


    }
}