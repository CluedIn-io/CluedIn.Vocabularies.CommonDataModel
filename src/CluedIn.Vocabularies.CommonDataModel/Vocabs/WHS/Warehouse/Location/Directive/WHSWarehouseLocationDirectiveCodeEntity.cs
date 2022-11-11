using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseLocationDirectiveCodeEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseLocationDirectiveCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseLocationDirectiveCodeEntity";
            KeyPrefix = "commonDataModel.whswarehouselocationdirectivecodeentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseLocationDirectiveCodeEntity";

            AddGroup("Common Data Model WHSWarehouseLocationDirectiveCodeEntity Details", group =>
            {
                DirectiveCodeId = group.Add(new VocabularyKey(nameof(DirectiveCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirectiveCodeDescription = group.Add(new VocabularyKey(nameof(DirectiveCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DirectiveCodeId { get; private set; }
        public VocabularyKey DirectiveCodeDescription { get; private set; }


    }
}