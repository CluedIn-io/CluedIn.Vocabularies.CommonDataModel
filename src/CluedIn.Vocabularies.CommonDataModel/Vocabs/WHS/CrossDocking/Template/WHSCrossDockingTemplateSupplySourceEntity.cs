using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCrossDockingTemplateSupplySourceEntityVocabulary : SimpleVocabulary
    {
        public WHSCrossDockingTemplateSupplySourceEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSCrossDockingTemplateSupplySourceEntity";
            KeyPrefix = "commonDataModel.whscrossdockingtemplatesupplysourceentity";
            KeySeparator = ".";
            Grouping = "/WHSCrossDockingTemplateSupplySourceEntity";

            AddGroup("Common Data Model WHSCrossDockingTemplateSupplySourceEntity Details", group =>
            {
                CrossDockingTemplateId = group.Add(new VocabularyKey(nameof(CrossDockingTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SupplySource = group.Add(new VocabularyKey(nameof(SupplySource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SupplyQuery = group.Add(new VocabularyKey(nameof(SupplyQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CrossDockingTemplateId { get; private set; }
        public VocabularyKey SupplySource { get; private set; }
        public VocabularyKey SupplyQuery { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }


    }
}