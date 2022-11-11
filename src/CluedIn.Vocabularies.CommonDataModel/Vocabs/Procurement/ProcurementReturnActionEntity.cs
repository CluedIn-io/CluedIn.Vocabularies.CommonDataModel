using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcurementReturnActionEntityVocabulary : SimpleVocabulary
    {
        public ProcurementReturnActionEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProcurementReturnActionEntity";
            KeyPrefix = "commonDataModel.procurementreturnactionentity";
            KeySeparator = ".";
            Grouping = "/ProcurementReturnActionEntity";

            AddGroup("Common Data Model ProcurementReturnActionEntity Details", group =>
            {
                ActionId = group.Add(new VocabularyKey(nameof(ActionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionDescription = group.Add(new VocabularyKey(nameof(ActionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActionId { get; private set; }
        public VocabularyKey ActionDescription { get; private set; }


    }
}